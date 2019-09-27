namespace Turnir
{
    partial class Raspored
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raspored));
            this.dgvFormaRaspored = new System.Windows.Forms.DataGridView();
            this.txtDomacin = new System.Windows.Forms.TextBox();
            this.txtGoloviDomacin = new System.Windows.Forms.TextBox();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.txtGost = new System.Windows.Forms.TextBox();
            this.Domacin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrupa = new System.Windows.Forms.TextBox();
            this.Strijelac = new System.Windows.Forms.Label();
            this.cmbStrijelci = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGoloviGost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUtakmicaBroj = new System.Windows.Forms.TextBox();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnPocetakUtakmice = new System.Windows.Forms.Button();
            this.btnKrajUtakmice = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFormaRaspored
            // 
            this.dgvFormaRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaRaspored.Location = new System.Drawing.Point(12, 12);
            this.dgvFormaRaspored.Name = "dgvFormaRaspored";
            this.dgvFormaRaspored.Size = new System.Drawing.Size(722, 301);
            this.dgvFormaRaspored.TabIndex = 0;
            this.dgvFormaRaspored.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormaRaspored_CellClick);
            this.dgvFormaRaspored.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFormaRaspored_CellFormatting);
            // 
            // txtDomacin
            // 
            this.txtDomacin.Location = new System.Drawing.Point(229, 349);
            this.txtDomacin.Name = "txtDomacin";
            this.txtDomacin.Size = new System.Drawing.Size(100, 20);
            this.txtDomacin.TabIndex = 1;
            // 
            // txtGoloviDomacin
            // 
            this.txtGoloviDomacin.Location = new System.Drawing.Point(441, 349);
            this.txtGoloviDomacin.Name = "txtGoloviDomacin";
            this.txtGoloviDomacin.Size = new System.Drawing.Size(79, 20);
            this.txtGoloviDomacin.TabIndex = 2;
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Location = new System.Drawing.Point(89, 349);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(69, 20);
            this.txtVrijeme.TabIndex = 3;
            // 
            // txtGost
            // 
            this.txtGost.Location = new System.Drawing.Point(335, 349);
            this.txtGost.Name = "txtGost";
            this.txtGost.Size = new System.Drawing.Size(100, 20);
            this.txtGost.TabIndex = 4;
            // 
            // Domacin
            // 
            this.Domacin.AutoSize = true;
            this.Domacin.Location = new System.Drawing.Point(226, 333);
            this.Domacin.Name = "Domacin";
            this.Domacin.Size = new System.Drawing.Size(49, 13);
            this.Domacin.TabIndex = 5;
            this.Domacin.Text = "Domacin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Golovi domacin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vrijeme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gost";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Green;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(16, 383);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 35);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(229, 383);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(130, 35);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj utakmicu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Grupa";
            // 
            // txtGrupa
            // 
            this.txtGrupa.Location = new System.Drawing.Point(164, 349);
            this.txtGrupa.Name = "txtGrupa";
            this.txtGrupa.Size = new System.Drawing.Size(59, 20);
            this.txtGrupa.TabIndex = 13;
            // 
            // Strijelac
            // 
            this.Strijelac.AutoSize = true;
            this.Strijelac.Location = new System.Drawing.Point(589, 333);
            this.Strijelac.Name = "Strijelac";
            this.Strijelac.Size = new System.Drawing.Size(44, 13);
            this.Strijelac.TabIndex = 14;
            this.Strijelac.Text = "Strijelac";
            // 
            // cmbStrijelci
            // 
            this.cmbStrijelci.FormattingEnabled = true;
            this.cmbStrijelci.Location = new System.Drawing.Point(592, 349);
            this.cmbStrijelci.Name = "cmbStrijelci";
            this.cmbStrijelci.Size = new System.Drawing.Size(165, 21);
            this.cmbStrijelci.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Golovi gost";
            // 
            // txtGoloviGost
            // 
            this.txtGoloviGost.Location = new System.Drawing.Point(526, 349);
            this.txtGoloviGost.Name = "txtGoloviGost";
            this.txtGoloviGost.Size = new System.Drawing.Size(57, 20);
            this.txtGoloviGost.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Utakmica br.";
            // 
            // txtUtakmicaBroj
            // 
            this.txtUtakmicaBroj.Location = new System.Drawing.Point(16, 349);
            this.txtUtakmicaBroj.Name = "txtUtakmicaBroj";
            this.txtUtakmicaBroj.Size = new System.Drawing.Size(62, 20);
            this.txtUtakmicaBroj.TabIndex = 19;
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.Red;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrisi.ForeColor = System.Drawing.Color.White;
            this.btnBrisi.Location = new System.Drawing.Point(123, 383);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(100, 35);
            this.btnBrisi.TabIndex = 20;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPocetakUtakmice
            // 
            this.btnPocetakUtakmice.BackColor = System.Drawing.Color.Green;
            this.btnPocetakUtakmice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetakUtakmice.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.btnPocetakUtakmice.ForeColor = System.Drawing.Color.White;
            this.btnPocetakUtakmice.Location = new System.Drawing.Point(783, 12);
            this.btnPocetakUtakmice.Name = "btnPocetakUtakmice";
            this.btnPocetakUtakmice.Size = new System.Drawing.Size(100, 45);
            this.btnPocetakUtakmice.TabIndex = 22;
            this.btnPocetakUtakmice.Text = "Početak utakmice";
            this.btnPocetakUtakmice.UseVisualStyleBackColor = false;
            this.btnPocetakUtakmice.Click += new System.EventHandler(this.btnPocetakUtakmice_Click);
            // 
            // btnKrajUtakmice
            // 
            this.btnKrajUtakmice.BackColor = System.Drawing.Color.Red;
            this.btnKrajUtakmice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKrajUtakmice.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.btnKrajUtakmice.ForeColor = System.Drawing.Color.White;
            this.btnKrajUtakmice.Location = new System.Drawing.Point(783, 63);
            this.btnKrajUtakmice.Name = "btnKrajUtakmice";
            this.btnKrajUtakmice.Size = new System.Drawing.Size(100, 45);
            this.btnKrajUtakmice.TabIndex = 23;
            this.btnKrajUtakmice.Text = "Kraj  utakmice";
            this.btnKrajUtakmice.UseVisualStyleBackColor = false;
            this.btnKrajUtakmice.Click += new System.EventHandler(this.btnKrajUtakmice_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.Orange;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.btnAzuriraj.ForeColor = System.Drawing.Color.White;
            this.btnAzuriraj.Location = new System.Drawing.Point(783, 268);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(100, 45);
            this.btnAzuriraj.TabIndex = 25;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // Raspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 431);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnKrajUtakmice);
            this.Controls.Add(this.btnPocetakUtakmice);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.txtUtakmicaBroj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGoloviGost);
            this.Controls.Add(this.cmbStrijelci);
            this.Controls.Add(this.Strijelac);
            this.Controls.Add(this.txtGrupa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Domacin);
            this.Controls.Add(this.txtGost);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.txtGoloviDomacin);
            this.Controls.Add(this.txtDomacin);
            this.Controls.Add(this.dgvFormaRaspored);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raspored";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raspored";
            this.Load += new System.EventHandler(this.FormaRaspored_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaRaspored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormaRaspored;
        private System.Windows.Forms.TextBox txtDomacin;
        private System.Windows.Forms.TextBox txtGoloviDomacin;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.TextBox txtGost;
        private System.Windows.Forms.Label Domacin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupa;
        private System.Windows.Forms.Label Strijelac;
        private System.Windows.Forms.ComboBox cmbStrijelci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGoloviGost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUtakmicaBroj;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnPocetakUtakmice;
        private System.Windows.Forms.Button btnKrajUtakmice;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}