using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_Sammlung
{
	public partial class NeueCD : Form
	{
		public CD NeuErstellteCD;
		public NeueCD()
		{
			InitializeComponent();
		}

		private void btnAbbrechen_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnHinzufügen_Click(object sender, EventArgs e)
		{
			try
			{
				NeuErstellteCD = new CD(txtAlbum.Text, txtKünstler.Text);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void NeueCD_Load(object sender, EventArgs e)
		{

		}
	}
}
