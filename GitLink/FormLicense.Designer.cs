namespace GitLink
{
	partial class FormLicense
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicense));
			this.richTextBoxLicense = new System.Windows.Forms.RichTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// richTextBoxLicense
			// 
			this.richTextBoxLicense.Location = new System.Drawing.Point(13, 13);
			this.richTextBoxLicense.Name = "richTextBoxLicense";
			this.richTextBoxLicense.ReadOnly = true;
			this.richTextBoxLicense.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBoxLicense.Size = new System.Drawing.Size(599, 416);
			this.richTextBoxLicense.TabIndex = 0;
			this.richTextBoxLicense.Text = "";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(148, 296);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(100, 96);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(360, 296);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(100, 96);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
			// 
			// FormLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.richTextBoxLicense);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLicense";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GNU GENERAL PUBLIC LICENSE Version 3";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormLicense_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBoxLicense;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
	}
}