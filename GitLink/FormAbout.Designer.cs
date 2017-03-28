namespace GitLink
{
	partial class FormAbout
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.buttonLicense = new System.Windows.Forms.Button();
			this.richTextBoxAbout = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// buttonLicense
			// 
			this.buttonLicense.Location = new System.Drawing.Point(274, 406);
			this.buttonLicense.Name = "buttonLicense";
			this.buttonLicense.Size = new System.Drawing.Size(75, 23);
			this.buttonLicense.TabIndex = 0;
			this.buttonLicense.Text = "License";
			this.buttonLicense.UseVisualStyleBackColor = true;
			this.buttonLicense.Click += new System.EventHandler(this.buttonLicense_Click);
			// 
			// richTextBoxAbout
			// 
			this.richTextBoxAbout.Location = new System.Drawing.Point(13, 12);
			this.richTextBoxAbout.Name = "richTextBoxAbout";
			this.richTextBoxAbout.ReadOnly = true;
			this.richTextBoxAbout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBoxAbout.Size = new System.Drawing.Size(599, 380);
			this.richTextBoxAbout.TabIndex = 1;
			this.richTextBoxAbout.Text = resources.GetString("richTextBoxAbout.Text");
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.richTextBoxAbout);
			this.Controls.Add(this.buttonLicense);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About...";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormAbout_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLicense;
		private System.Windows.Forms.RichTextBox richTextBoxAbout;
	}
}