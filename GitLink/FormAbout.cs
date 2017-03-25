using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitLink
{
	public partial class FormAbout : Form
	{
		public FormAbout()
		{
			InitializeComponent();
		}

		private void buttonLicense_Click(object sender, EventArgs e)
		{
			using (FormLicense frm = new FormLicense())
			{
				frm.ShowDialog();
			}
		}

		private void FormAbout_Load(object sender, EventArgs e)
		{
			string firstLine = "";
			firstLine += "GetLink - Copyright © 2017 NetCreek.com - Version " + Application.ProductVersion + " - Contact enos@netcreek.com";
			richTextBoxAbout.Text = firstLine + richTextBoxAbout.Text;
		}
	}
}
