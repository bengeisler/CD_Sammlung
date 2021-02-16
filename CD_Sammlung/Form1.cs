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
	public partial class Form1 : Form
	{
		private List<CD> CdSammlung = new List<CD>();
		public Form1()
		{
			InitializeComponent();
		}

		private void btnHinzufügen_Click(object sender, EventArgs e)
		{
			CdSammlung.Add(new CD("Queen", "A Night At The Opera"));
			CdSammlung.Add(new CD("Queen", "A Day At The Races"));
			CdSammlung.Add(new CD("The Offspring", "Smash"));
			CdSammlung.Add(new CD("Earth, Wind And Fire", "Best Of"));
			CdSammlung.Add(new CD("Adele", "21"));

			MessageBox.Show("Die Liste enthält nun " + CdSammlung.Count + " CDs");
		}

		private void btnEnthaltenPrüfen_Click(object sender, EventArgs e)
		{
			if (CdSammlung.Contains(new CD("Queen", "A Night At The Opera"))) MessageBox.Show("CD ist enthalten");
			else MessageBox.Show("CD ist nicht enthalten");
		}

		private void btnCdsAnzeigen_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Unsortierte Ausgabe");
			foreach (var cd in CdSammlung)
			{
				Console.WriteLine(cd);
			}
		}

		private void btnSortiertAusgeben_Click(object sender, EventArgs e)
		{
			CdSammlung.Sort();
			Console.WriteLine("Sortierte Ausgabe");
			foreach (var cd in CdSammlung)
			{
				Console.WriteLine(cd);
			}
		}

		private void btnNeueCD_Click(object sender, EventArgs e)
		{
			var frm = new NeueCD();
			var result = frm.ShowDialog();
			if (result == DialogResult.OK) CdSammlung.Add(frm.NeuErstellteCD);
		}
	}
}
