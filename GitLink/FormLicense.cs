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
	public partial class FormLicense : Form
	{
		public FormLicense()
		{
			InitializeComponent();
		}

		private void FormLicense_Load(object sender, EventArgs e)
		{
			//
			// The length you can enter in a RichTextBox at design is limited by the Visual Studio Tool. So, the workaround used consist
			// to enter the text at design in two RichTextBox, and to concatenate the two RichTextBox into only one RichTextBox at run time
			// ====================================================================================================================
			//
			richTextBoxLicense.Text = richTextBox1.Text + richTextBox2.Text;
			richTextBox1.Visible = false;
			richTextBox2.Visible = false;
		}
	}
}
