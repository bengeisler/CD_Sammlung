
namespace CD_Sammlung
{
	partial class NeueCD
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAlbum = new System.Windows.Forms.TextBox();
			this.txtKünstler = new System.Windows.Forms.TextBox();
			this.btnHinzufügen = new System.Windows.Forms.Button();
			this.btnAbbrechen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Album:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Künstler:";
			// 
			// txtAlbum
			// 
			this.txtAlbum.Location = new System.Drawing.Point(72, 16);
			this.txtAlbum.Name = "txtAlbum";
			this.txtAlbum.Size = new System.Drawing.Size(203, 20);
			this.txtAlbum.TabIndex = 2;
			// 
			// txtKünstler
			// 
			this.txtKünstler.Location = new System.Drawing.Point(72, 41);
			this.txtKünstler.Name = "txtKünstler";
			this.txtKünstler.Size = new System.Drawing.Size(203, 20);
			this.txtKünstler.TabIndex = 3;
			// 
			// btnHinzufügen
			// 
			this.btnHinzufügen.Location = new System.Drawing.Point(72, 83);
			this.btnHinzufügen.Name = "btnHinzufügen";
			this.btnHinzufügen.Size = new System.Drawing.Size(75, 23);
			this.btnHinzufügen.TabIndex = 4;
			this.btnHinzufügen.Text = "Hinzufügen";
			this.btnHinzufügen.UseVisualStyleBackColor = true;
			this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
			// 
			// btnAbbrechen
			// 
			this.btnAbbrechen.Location = new System.Drawing.Point(200, 83);
			this.btnAbbrechen.Name = "btnAbbrechen";
			this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
			this.btnAbbrechen.TabIndex = 5;
			this.btnAbbrechen.Text = "Abbrechen";
			this.btnAbbrechen.UseVisualStyleBackColor = true;
			this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
			// 
			// NeueCD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 120);
			this.Controls.Add(this.btnAbbrechen);
			this.Controls.Add(this.btnHinzufügen);
			this.Controls.Add(this.txtKünstler);
			this.Controls.Add(this.txtAlbum);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "NeueCD";
			this.Text = "NeueCD";
			this.Load += new System.EventHandler(this.NeueCD_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAlbum;
		private System.Windows.Forms.TextBox txtKünstler;
		private System.Windows.Forms.Button btnHinzufügen;
		private System.Windows.Forms.Button btnAbbrechen;
	}
}