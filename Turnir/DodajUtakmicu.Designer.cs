namespace Turnir
{
    partial class DodajUtakmicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajUtakmicu));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.cmbGost = new System.Windows.Forms.ComboBox();
            this.cmbDomacin = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domacin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrijeme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gost";
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Location = new System.Drawing.Point(102, 15);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(121, 20);
            this.txtVrijeme.TabIndex = 4;
            // 
            // cmbGost
            // 
            this.cmbGost.FormattingEnabled = true;
            this.cmbGost.Location = new System.Drawing.Point(103, 135);
            this.cmbGost.Name = "cmbGost";
            this.cmbGost.Size = new System.Drawing.Size(121, 21);
            this.cmbGost.TabIndex = 5;
            // 
            // cmbDomacin
            // 
            this.cmbDomacin.FormattingEnabled = true;
            this.cmbDomacin.Location = new System.Drawing.Point(103, 95);
            this.cmbDomacin.Name = "cmbDomacin";
            this.cmbDomacin.Size = new System.Drawing.Size(121, 21);
            this.cmbDomacin.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Lime;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(113, 183);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(95, 28);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grupa";
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(102, 55);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupa.TabIndex = 10;
            // 
            // DodajUtakmicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 235);
            this.Controls.Add(this.cmbGrupa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbDomacin);
            this.Controls.Add(this.cmbGost);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajUtakmicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj utakmicu";
            this.Load += new System.EventHandler(this.DodajUtakmicu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.ComboBox cmbGost;
        private System.Windows.Forms.ComboBox cmbDomacin;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupa;
    }
}