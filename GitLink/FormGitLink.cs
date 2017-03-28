using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GitLink
{
	public partial class FormGitLink : Form
	{
		private string source;
		private string target;
		private string exclude;
		private string[] excludes;

		public FormGitLink()
		{
			InitializeComponent();
		}

		#region Initialization

		/// <summary>
		/// Initialization
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormDirectoryReplication_Load(object sender, EventArgs e)
		{
			this.Text = "GitLink " + Application.ProductVersion;
			//
			// Get application parameters
			// ==========================
			//
			textBoxSource.Text = source = Properties.Settings.Default.Source;
			textBoxTarget.Text =  target = Properties.Settings.Default.Target;
			textBoxExclude.Text = exclude = ".git|" + Properties.Settings.Default.Exclude;		// Exclusion of .git is hard coded
			excludes = exclude.Split('|');
			//
			// Initialize the File System Watcher
			// ==================================
			//
			if (!Directory.Exists(source)) Directory.CreateDirectory(source);
			FileSystemWatcher watcher = new FileSystemWatcher(source, "*.*");
			watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
			watcher.IncludeSubdirectories = true;
			watcher.Created += new FileSystemEventHandler(OnChanged);
			watcher.Changed += new FileSystemEventHandler(OnChanged);
			watcher.Deleted += new FileSystemEventHandler(OnChanged);
			watcher.Renamed += new RenamedEventHandler(OnRenamed);
			watcher.EnableRaisingEvents = true;
			//
			// Force the replication in case of file modification since last run
			// =================================================================
			//
			ForceReplication();
		}
		#endregion

		#region File System Watcher

		/// <summary>
		/// Manage "Created", "Changed", and "Deleted" events on files and directories
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void OnChanged(object source, FileSystemEventArgs e)
		{
			try
			{
				//
				// Search for excluded files or directories
				// ========================================
				//
				bool found = false;
				foreach (string item in excludes) if (e.FullPath.EndsWith(@"\" + item) || e.FullPath.Contains(@"\" + item + @"\")) found = true;
				//
				// Process non excluded files or directories
				// =========================================
				//
				if (!found)
				{
					if (Directory.Exists(e.FullPath) || Directory.Exists(Path.Combine(target, e.Name)))
					{
						//
						// Manage "Created" and "Deleted" events on directories
						// ====================================================
						//
						this.BeginInvoke(new EventHandler(delegate { PushNewMessage("Directory " + e.FullPath + " " + e.ChangeType); }));
						if (e.ChangeType.ToString() == "Created") Directory.CreateDirectory(Path.Combine(target, e.Name));
						if (e.ChangeType.ToString() == "Deleted") Directory.Delete(Path.Combine(target, e.Name), true);
					}
					else
					{
						//
						// Manage "Created/Changed", and "Deleted" events on files
						// =======================================================
						//
						this.BeginInvoke(new EventHandler(delegate { PushNewMessage("File " + e.FullPath + " " + e.ChangeType); }));
						if (e.ChangeType.ToString() == "Changed") File.Copy(e.FullPath, Path.Combine(target, e.Name), true);
						if (e.ChangeType.ToString() == "Deleted") File.Delete(Path.Combine(target, e.Name));
					}
				}
			}
			catch(Exception ex)
			{
				//
				// Display the error in a task bar notification
				// ============================================
				//
				notifyIcon.Icon = Properties.Resources.GitLink_Red;
				Application.DoEvents();
				notifyIcon.BalloonTipTitle = "GitLink report";
				notifyIcon.BalloonTipText = ex.Message;
				notifyIcon.BalloonTipIcon = ToolTipIcon.Error;
				notifyIcon.ShowBalloonTip(15000);
			}
		}

		/// <summary>
		/// Manage "Renamed" events on files and directories
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void OnRenamed(object source, RenamedEventArgs e)
		{
			try
			{
				//
				// Search for excluded files or directories
				// ========================================
				//
				bool found = false;
				foreach (string item in excludes) if (e.FullPath.EndsWith(@"\" + item) || e.FullPath.Contains(@"\" + item + @"\")) found = true;
				//
				// Process non excluded files or directories
				// =========================================
				//
				if (!found)
				{
					if (Directory.Exists(e.FullPath))
					{
						//
						// Event on directory
						// ==================
						//
						this.BeginInvoke(new EventHandler(delegate { PushNewMessage("Directory " + e.OldFullPath + " renamed to " + e.FullPath); }));
						Directory.Move(Path.Combine(target, e.OldName), Path.Combine(target, e.Name));
					}
					else
					{
						//
						// Event on file
						// =============
						//
						this.BeginInvoke(new EventHandler(delegate { PushNewMessage("File " + e.OldFullPath + " renamed to " + e.FullPath); }));
						File.Move(Path.Combine(target, e.OldName), Path.Combine(target, e.Name));
					}
				}
			}
			catch(Exception ex)
			{
				//
				// Display the error in a task bar notification
				// ============================================
				//
				notifyIcon.Icon = Properties.Resources.GitLink_Red;
				Application.DoEvents();
				notifyIcon.BalloonTipTitle = "GitLink report";
				notifyIcon.BalloonTipText = ex.Message;
				notifyIcon.BalloonTipIcon = ToolTipIcon.Error;
				notifyIcon.ShowBalloonTip(15000);
			}
		}

		/// <summary>
		/// Display the last 100 events in a listbox
		/// </summary>
		/// <param name="message"></param>
		private void PushNewMessage(string message)
		{
			listBoxMessages.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + message);
			if (listBoxMessages.Items.Count > 1000) listBoxMessages.Items.RemoveAt(0);
			listBoxMessages.SelectedIndex = listBoxMessages.Items.Count - 1;
		}
		#endregion

		#region Force Replication

		/// <summary>
		/// Force the replication from the context menu associated to the notification icon
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void forceTheReplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ForceReplication();
		}

		/// <summary>
		/// Force the replication in case of file modification since last run or replication error signaled
		/// </summary>
		private void ForceReplication()
		{
			try
			{
				notifyIcon.Icon = Properties.Resources.GitLink_Yellow;
				Application.DoEvents();
				System.Threading.Thread.Sleep(1000);
				//
				// Recursive processing of each file in directory and subdirectories
				// =================================================================
				//
				DirSearch(source);
				//
				// Display the result in a task bar notification
				// =============================================
				//
				notifyIcon.Icon = Properties.Resources.GitLink_Green;
				Application.DoEvents();
				notifyIcon.BalloonTipTitle = "GitLink report";
				notifyIcon.BalloonTipText = "Replication is up to date";
				notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
				notifyIcon.ShowBalloonTip(15000);
			}
			catch (Exception ex)
			{
				//
				// Display the error in a task bar notification
				// ============================================
				//
				notifyIcon.Icon = Properties.Resources.GitLink_Red;
				Application.DoEvents();
				notifyIcon.BalloonTipTitle = "GitLink report";
				notifyIcon.BalloonTipText = ex.Message;
				notifyIcon.BalloonTipIcon = ToolTipIcon.Error;
				notifyIcon.ShowBalloonTip(15000);
			}
		}

		/// <summary>
		/// Recursive processing of each file in directory and subdirectories
		/// </summary>
		/// <param name="directory"></param>
		private void DirSearch(string directory)
		{
			//
			// Search for excluded directory
			// =============================
			//
			bool found = false;
			foreach (string item in excludes) if (directory.EndsWith(@"\" + item)) found = true;
			//
			// Process non excluded directories
			// ================================
			//
			if (!found)
			{
				PushNewMessage("Forced replication of directory: " + directory);
				//
				// Build the target fullpath by replacing source path by target path, conserving the directory name
				// ================================================================================================
				//
				string newDir = directory.Replace(source, "");
				if (newDir.StartsWith("\\")) newDir = newDir.Substring(1, newDir.Length - 1);
				string targetDir = Path.Combine(target, newDir);
				//
				// Create the target directory if not exits
				// ========================================
				//
				if (!Directory.Exists(targetDir)) Directory.CreateDirectory(targetDir);
				//
				// Process each file in the directory
				// ==================================
				//
				foreach (string file in Directory.GetFiles(directory))
				{
					//
					// Search for excluded files
					// =========================
					//
					found = false;
					foreach (string item in excludes) if (file.EndsWith(@"\" + item)) found = true;
					//
					// Process non excluded files
					// ==========================
					//
					if (!found)
					{
						PushNewMessage("Forced replication of File: " + file);
						//
						// Build the target fullpath by replacing source path by target path, conserving the file name
						// ===========================================================================================
						//
						string newFile = file.Replace(source, "");
						if (newFile.StartsWith("\\")) newFile = newFile.Substring(1, newFile.Length - 1);
						string targetFile = Path.Combine(target, newFile);
						//
						// Copy the file to the target directory
						// =====================================
						//
						File.Copy(file, targetFile, true);
					}
				}
				//
				// Recursive process for each subdirectory
				// =======================================
				//
				foreach (string subDirectory in Directory.GetDirectories(directory))
				{
					this.DirSearch(subDirectory);
				}
			}
		}
		#endregion

		#region Systray Management

		/// <summary>
		/// Hide the form when minimized and show the notify icon
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormDirectoryReplication_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				notifyIcon.Visible = true;
				this.Hide();
			}

			else if (this.WindowState == FormWindowState.Normal)
			{
				notifyIcon.Visible = false;
			}
		}
		
		/// <summary>
		/// Hide the form instead of closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormMirror_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)   // to allow closing the form programmaticaly
			{
				notifyIcon.Visible = true;
				Hide();
				e.Cancel = true;
			}
		}

		/// <summary>
		/// Call the configuration form by a double clic on the notify icon
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon.Visible = false;
		}

		/// <summary>
		/// Display the configuration form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItemConfig_Click(object sender, EventArgs e)
		{
			Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon.Visible = false;
		}

		/// <summary>
		/// Force the replication
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItemForce_Click(object sender, EventArgs e)
		{
			ForceReplication();
		}

		/// <summary>
		/// Exit the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			notifyIcon.Visible = false;
			Application.Exit();
		}
		#endregion

		#region Form Management
		/// <summary>
		/// Select the source directory
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSource_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderDlg = new FolderBrowserDialog();
			folderDlg.ShowNewFolderButton = true;
			folderDlg.SelectedPath = source;
			DialogResult result = folderDlg.ShowDialog();
			if (result == DialogResult.OK)
			{
				//
				// Update source and save the parameter
				// ====================================
				//
				textBoxSource.Text = source = folderDlg.SelectedPath;
				Properties.Settings.Default.Source = source;
				Properties.Settings.Default.Save();
			}
		}

		/// <summary>
		/// Select the target directory
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonTarget_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderDlg = new FolderBrowserDialog();
			folderDlg.ShowNewFolderButton = true;
			folderDlg.SelectedPath = target;
			DialogResult result = folderDlg.ShowDialog();
			if (result == DialogResult.OK)
			{
				//
				// Search for whole disks or system directories to exclude
				// =======================================================
				//
				bool invalid = false;
				if (folderDlg.SelectedPath.Length == 3)
				{
					invalid = true;
				}
				if (folderDlg.SelectedPath.EndsWith(@"C:\Windows"))
				{
					invalid = true;
				}
				if (folderDlg.SelectedPath.StartsWith(@"C:\Program"))
				{
					invalid = true;
				}
				if (folderDlg.SelectedPath.EndsWith(@"\.git"))
				{
					invalid = true;
				}
				if (invalid)
				{
					MessageBox.Show("Invalid or dangerous target directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					//
					// Update target and save the parameter
					// ====================================
					//
					textBoxSource.Text = target = folderDlg.SelectedPath;
					Properties.Settings.Default.Target = target;
					Properties.Settings.Default.Save();
				}
			}
		}

		/// <summary>
		/// Save exclude list of files and directories
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonApply_Click(object sender, EventArgs e)
		{
			exclude = textBoxExclude.Text;
			excludes = exclude.Split('|');
			Properties.Settings.Default.Save();
		}

		/// <summary>
		/// Exit the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			notifyIcon.Visible = false;
			Application.Exit();
		}

		/// <summary>
		/// About form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormAbout frm = new FormAbout())
			{
				frm.ShowDialog();
			}
		}
		#endregion
	}
}
