namespace GitLink
{
	partial class FormGitLink
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGitLink));
			this.listBoxMessages = new System.Windows.Forms.ListBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemForce = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.textBoxSource = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxTarget = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxExclude = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonSource = new System.Windows.Forms.Button();
			this.buttonTarget = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.forceTheReplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxMessages
			// 
			this.listBoxMessages.FormattingEnabled = true;
			this.listBoxMessages.HorizontalScrollbar = true;
			this.listBoxMessages.Location = new System.Drawing.Point(10, 165);
			this.listBoxMessages.Name = "listBoxMessages";
			this.listBoxMessages.Size = new System.Drawing.Size(986, 264);
			this.listBoxMessages.TabIndex = 0;
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "GitLink";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConfig,
            this.toolStripMenuItemForce,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(183, 76);
			// 
			// toolStripMenuItemConfig
			// 
			this.toolStripMenuItemConfig.Name = "toolStripMenuItemConfig";
			this.toolStripMenuItemConfig.Size = new System.Drawing.Size(182, 22);
			this.toolStripMenuItemConfig.Text = "Configure...";
			this.toolStripMenuItemConfig.Click += new System.EventHandler(this.toolStripMenuItemConfig_Click);
			// 
			// toolStripMenuItemForce
			// 
			this.toolStripMenuItemForce.Name = "toolStripMenuItemForce";
			this.toolStripMenuItemForce.Size = new System.Drawing.Size(182, 22);
			this.toolStripMenuItemForce.Text = "Force the replication";
			this.toolStripMenuItemForce.Click += new System.EventHandler(this.toolStripMenuItemForce_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(182, 22);
			this.toolStripMenuItemExit.Text = "Exit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
			// 
			// textBoxSource
			// 
			this.textBoxSource.Location = new System.Drawing.Point(10, 45);
			this.textBoxSource.Name = "textBoxSource";
			this.textBoxSource.ReadOnly = true;
			this.textBoxSource.Size = new System.Drawing.Size(905, 20);
			this.textBoxSource.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Source directory to replicate";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Target directory to replicate";
			// 
			// textBoxTarget
			// 
			this.textBoxTarget.Location = new System.Drawing.Point(10, 85);
			this.textBoxTarget.Name = "textBoxTarget";
			this.textBoxTarget.ReadOnly = true;
			this.textBoxTarget.Size = new System.Drawing.Size(905, 20);
			this.textBoxTarget.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Directories or files to be exclude";
			// 
			// textBoxExclude
			// 
			this.textBoxExclude.Location = new System.Drawing.Point(10, 125);
			this.textBoxExclude.Name = "textBoxExclude";
			this.textBoxExclude.Size = new System.Drawing.Size(905, 20);
			this.textBoxExclude.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Last 1000 Events List";
			// 
			// buttonSource
			// 
			this.buttonSource.Location = new System.Drawing.Point(921, 45);
			this.buttonSource.Name = "buttonSource";
			this.buttonSource.Size = new System.Drawing.Size(75, 20);
			this.buttonSource.TabIndex = 9;
			this.buttonSource.Text = "Browse";
			this.buttonSource.UseVisualStyleBackColor = true;
			this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
			// 
			// buttonTarget
			// 
			this.buttonTarget.Location = new System.Drawing.Point(921, 85);
			this.buttonTarget.Name = "buttonTarget";
			this.buttonTarget.Size = new System.Drawing.Size(75, 20);
			this.buttonTarget.TabIndex = 10;
			this.buttonTarget.Text = "Browse";
			this.buttonTarget.UseVisualStyleBackColor = true;
			this.buttonTarget.Click += new System.EventHandler(this.buttonTarget_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(921, 125);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 20);
			this.buttonApply.TabIndex = 11;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.toolStripMenuItem2});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip.TabIndex = 12;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceTheReplicationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fichierToolStripMenuItem.Text = "File";
			// 
			// forceTheReplicationToolStripMenuItem
			// 
			this.forceTheReplicationToolStripMenuItem.Name = "forceTheReplicationToolStripMenuItem";
			this.forceTheReplicationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.forceTheReplicationToolStripMenuItem.Text = "Force the replication";
			this.forceTheReplicationToolStripMenuItem.Click += new System.EventHandler(this.forceTheReplicationToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem2.Text = "?";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// FormGitLink
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 441);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonTarget);
			this.Controls.Add(this.buttonSource);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxExclude);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxTarget);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxSource);
			this.Controls.Add(this.listBoxMessages);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "FormGitLink";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GitLink";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMirror_FormClosing);
			this.Load += new System.EventHandler(this.FormDirectoryReplication_Load);
			this.Resize += new System.EventHandler(this.FormDirectoryReplication_Resize);
			this.contextMenuStrip.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxMessages;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConfig;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForce;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.TextBox textBoxSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxTarget;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxExclude;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonSource;
		private System.Windows.Forms.Button buttonTarget;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem forceTheReplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

