namespace Turnir
{
    partial class FormaEkipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaEkipe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.dgvEkipe = new System.Windows.Forms.DataGridView();
            this.txtUnosEkipe = new System.Windows.Forms.TextBox();
            this.btnUnosEkipe = new System.Windows.Forms.Button();
            this.btnBrisiEkipu = new System.Windows.Forms.Button();
            this.btnDodajIgraca = new System.Windows.Forms.Button();
            this.btnBrisiIgraca = new System.Windows.Forms.Button();
            this.txtPrezimeIgraca = new System.Windows.Forms.TextBox();
            this.txtImeIgraca = new System.Windows.Forms.TextBox();
            this.pnlPocetna = new System.Windows.Forms.Panel();
            this.cmbGrupe = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkipe)).BeginInit();
            this.pnlPocetna.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Igrači";
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Location = new System.Drawing.Point(241, 25);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.Size = new System.Drawing.Size(244, 291);
            this.dgvIgraci.TabIndex = 2;
            this.dgvIgraci.SelectionChanged += new System.EventHandler(this.dgvIgraci_SelectionChanged);
            // 
            // dgvEkipe
            // 
            this.dgvEkipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEkipe.Location = new System.Drawing.Point(12, 25);
            this.dgvEkipe.Name = "dgvEkipe";
            this.dgvEkipe.Size = new System.Drawing.Size(223, 291);
            this.dgvEkipe.TabIndex = 3;
            this.dgvEkipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEkipe_CellClick);
            this.dgvEkipe.SelectionChanged += new System.EventHandler(this.dgvEkipe_SelectionChanged);
            // 
            // txtUnosEkipe
            // 
            this.txtUnosEkipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtUnosEkipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnosEkipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnosEkipe.ForeColor = System.Drawing.Color.White;
            this.txtUnosEkipe.Location = new System.Drawing.Point(13, 27);
            this.txtUnosEkipe.Margin = new System.Windows.Forms.Padding(0);
            this.txtUnosEkipe.Name = "txtUnosEkipe";
            this.txtUnosEkipe.Size = new System.Drawing.Size(110, 15);
            this.txtUnosEkipe.TabIndex = 4;
            this.txtUnosEkipe.Text = "Naziv ekipe";
            this.txtUnosEkipe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUnosEkipe_MouseClick);
            // 
            // btnUnosEkipe
            // 
            this.btnUnosEkipe.BackColor = System.Drawing.Color.White;
            this.btnUnosEkipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosEkipe.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosEkipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUnosEkipe.Location = new System.Drawing.Point(13, 64);
            this.btnUnosEkipe.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnosEkipe.Name = "btnUnosEkipe";
            this.btnUnosEkipe.Size = new System.Drawing.Size(110, 35);
            this.btnUnosEkipe.TabIndex = 5;
            this.btnUnosEkipe.Text = "Dodaj ekipu";
            this.btnUnosEkipe.UseVisualStyleBackColor = false;
            this.btnUnosEkipe.Click += new System.EventHandler(this.btnUnosEkipe_Click);
            // 
            // btnBrisiEkipu
            // 
            this.btnBrisiEkipu.BackColor = System.Drawing.Color.White;
            this.btnBrisiEkipu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisiEkipu.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiEkipu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnBrisiEkipu.Location = new System.Drawing.Point(144, 64);
            this.btnBrisiEkipu.Name = "btnBrisiEkipu";
            this.btnBrisiEkipu.Size = new System.Drawing.Size(110, 35);
            this.btnBrisiEkipu.TabIndex = 6;
            this.btnBrisiEkipu.Text = "Obriši ekipu";
            this.btnBrisiEkipu.UseVisualStyleBackColor = false;
            this.btnBrisiEkipu.Click += new System.EventHandler(this.btnBrisiEkipu_Click);
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.BackColor = System.Drawing.Color.White;
            this.btnDodajIgraca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajIgraca.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajIgraca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajIgraca.Location = new System.Drawing.Point(13, 242);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(110, 35);
            this.btnDodajIgraca.TabIndex = 9;
            this.btnDodajIgraca.Text = "Dodaj igrača";
            this.btnDodajIgraca.UseVisualStyleBackColor = false;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // btnBrisiIgraca
            // 
            this.btnBrisiIgraca.BackColor = System.Drawing.Color.White;
            this.btnBrisiIgraca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisiIgraca.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiIgraca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnBrisiIgraca.Location = new System.Drawing.Point(144, 242);
            this.btnBrisiIgraca.Name = "btnBrisiIgraca";
            this.btnBrisiIgraca.Size = new System.Drawing.Size(110, 35);
            this.btnBrisiIgraca.TabIndex = 10;
            this.btnBrisiIgraca.Text = "Obriši igrača";
            this.btnBrisiIgraca.UseVisualStyleBackColor = false;
            this.btnBrisiIgraca.Click += new System.EventHandler(this.btnBrisiIgraca_Click);
            // 
            // txtPrezimeIgraca
            // 
            this.txtPrezimeIgraca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtPrezimeIgraca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezimeIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrezimeIgraca.ForeColor = System.Drawing.Color.White;
            this.txtPrezimeIgraca.Location = new System.Drawing.Point(144, 214);
            this.txtPrezimeIgraca.Name = "txtPrezimeIgraca";
            this.txtPrezimeIgraca.Size = new System.Drawing.Size(110, 15);
            this.txtPrezimeIgraca.TabIndex = 11;
            this.txtPrezimeIgraca.Text = "Prezime";
            this.txtPrezimeIgraca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrezimeIgraca_MouseClick);
            this.txtPrezimeIgraca.MouseLeave += new System.EventHandler(this.txtPrezimeIgraca_MouseLeave);
            // 
            // txtImeIgraca
            // 
            this.txtImeIgraca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtImeIgraca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImeIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeIgraca.ForeColor = System.Drawing.Color.White;
            this.txtImeIgraca.Location = new System.Drawing.Point(13, 214);
            this.txtImeIgraca.Name = "txtImeIgraca";
            this.txtImeIgraca.Size = new System.Drawing.Size(110, 15);
            this.txtImeIgraca.TabIndex = 12;
            this.txtImeIgraca.Text = "Ime";
            this.txtImeIgraca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtImeIgraca_MouseClick);
            this.txtImeIgraca.MouseLeave += new System.EventHandler(this.txtImeIgraca_MouseLeave);
            // 
            // pnlPocetna
            // 
            this.pnlPocetna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlPocetna.Controls.Add(this.cmbGrupe);
            this.pnlPocetna.Controls.Add(this.panel4);
            this.pnlPocetna.Controls.Add(this.panel3);
            this.pnlPocetna.Controls.Add(this.panel2);
            this.pnlPocetna.Controls.Add(this.panel1);
            this.pnlPocetna.Controls.Add(this.btnUnosEkipe);
            this.pnlPocetna.Controls.Add(this.txtImeIgraca);
            this.pnlPocetna.Controls.Add(this.txtPrezimeIgraca);
            this.pnlPocetna.Controls.Add(this.txtUnosEkipe);
            this.pnlPocetna.Controls.Add(this.btnBrisiIgraca);
            this.pnlPocetna.Controls.Add(this.btnBrisiEkipu);
            this.pnlPocetna.Controls.Add(this.btnDodajIgraca);
            this.pnlPocetna.Location = new System.Drawing.Point(510, 25);
            this.pnlPocetna.Name = "pnlPocetna";
            this.pnlPocetna.Size = new System.Drawing.Size(278, 291);
            this.pnlPocetna.TabIndex = 14;
            // 
            // cmbGrupe
            // 
            this.cmbGrupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrupe.ForeColor = System.Drawing.Color.White;
            this.cmbGrupe.FormattingEnabled = true;
            this.cmbGrupe.Location = new System.Drawing.Point(144, 21);
            this.cmbGrupe.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGrupe.Name = "cmbGrupe";
            this.cmbGrupe.Size = new System.Drawing.Size(120, 21);
            this.cmbGrupe.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(144, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 2);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 2);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(144, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 2);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 2);
            this.panel1.TabIndex = 14;
            // 
            // FormaEkipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.pnlPocetna);
            this.Controls.Add(this.dgvEkipe);
            this.Controls.Add(this.dgvIgraci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaEkipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekipe";
            this.Load += new System.EventHandler(this.FormaEkipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkipe)).EndInit();
            this.pnlPocetna.ResumeLayout(false);
            this.pnlPocetna.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.DataGridView dgvEkipe;
        private System.Windows.Forms.TextBox txtUnosEkipe;
        private System.Windows.Forms.Button btnUnosEkipe;
        private System.Windows.Forms.Button btnBrisiEkipu;
        private System.Windows.Forms.Button btnDodajIgraca;
        private System.Windows.Forms.Button btnBrisiIgraca;
        private System.Windows.Forms.TextBox txtPrezimeIgraca;
        private System.Windows.Forms.TextBox txtImeIgraca;
        private System.Windows.Forms.Panel pnlPocetna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbGrupe;
        private System.Windows.Forms.Panel panel4;
    }
}