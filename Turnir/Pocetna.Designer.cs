namespace Turnir
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.btnTablica = new System.Windows.Forms.Button();
            this.btnRaspored = new System.Windows.Forms.Button();
            this.pnlPocetna = new System.Windows.Forms.Panel();
            this.btnEkipe = new System.Windows.Forms.Button();
            this.pbGrb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.pnlPocetna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.GridColor = System.Drawing.Color.DarkGray;
            this.dgvRaspored.Location = new System.Drawing.Point(218, 12);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.Size = new System.Drawing.Size(503, 380);
            this.dgvRaspored.TabIndex = 0;
            // 
            // btnTablica
            // 
            this.btnTablica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnTablica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablica.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnTablica.ForeColor = System.Drawing.Color.White;
            this.btnTablica.Location = new System.Drawing.Point(41, 206);
            this.btnTablica.Name = "btnTablica";
            this.btnTablica.Padding = new System.Windows.Forms.Padding(2);
            this.btnTablica.Size = new System.Drawing.Size(117, 42);
            this.btnTablica.TabIndex = 2;
            this.btnTablica.Text = "Tablica";
            this.btnTablica.UseVisualStyleBackColor = false;
            this.btnTablica.Click += new System.EventHandler(this.btnTablica_Click);
            // 
            // btnRaspored
            // 
            this.btnRaspored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnRaspored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaspored.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaspored.ForeColor = System.Drawing.Color.White;
            this.btnRaspored.Location = new System.Drawing.Point(41, 290);
            this.btnRaspored.Name = "btnRaspored";
            this.btnRaspored.Size = new System.Drawing.Size(117, 42);
            this.btnRaspored.TabIndex = 3;
            this.btnRaspored.Text = "Utakmice";
            this.btnRaspored.UseVisualStyleBackColor = false;
            this.btnRaspored.Click += new System.EventHandler(this.btnRaspored_Click);
            // 
            // pnlPocetna
            // 
            this.pnlPocetna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlPocetna.Controls.Add(this.btnEkipe);
            this.pnlPocetna.Controls.Add(this.pbGrb);
            this.pnlPocetna.Controls.Add(this.btnTablica);
            this.pnlPocetna.Controls.Add(this.btnRaspored);
            this.pnlPocetna.Location = new System.Drawing.Point(12, 12);
            this.pnlPocetna.Name = "pnlPocetna";
            this.pnlPocetna.Size = new System.Drawing.Size(200, 380);
            this.pnlPocetna.TabIndex = 4;
            // 
            // btnEkipe
            // 
            this.btnEkipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnEkipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkipe.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnEkipe.ForeColor = System.Drawing.Color.White;
            this.btnEkipe.Location = new System.Drawing.Point(41, 127);
            this.btnEkipe.Name = "btnEkipe";
            this.btnEkipe.Padding = new System.Windows.Forms.Padding(2);
            this.btnEkipe.Size = new System.Drawing.Size(117, 42);
            this.btnEkipe.TabIndex = 5;
            this.btnEkipe.Text = "Ekipe";
            this.btnEkipe.UseVisualStyleBackColor = false;
            this.btnEkipe.Click += new System.EventHandler(this.btnEkipe_Click_1);
            // 
            // pbGrb
            // 
            this.pbGrb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbGrb.Image = global::Turnir.Properties.Resources.output_onlinepngtools2;
            this.pbGrb.Location = new System.Drawing.Point(0, 0);
            this.pbGrb.Name = "pbGrb";
            this.pbGrb.Padding = new System.Windows.Forms.Padding(3);
            this.pbGrb.Size = new System.Drawing.Size(200, 81);
            this.pbGrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrb.TabIndex = 4;
            this.pbGrb.TabStop = false;
            this.pbGrb.WaitOnLoad = true;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 411);
            this.Controls.Add(this.pnlPocetna);
            this.Controls.Add(this.dgvRaspored);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.Pocetna_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.pnlPocetna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Button btnTablica;
        private System.Windows.Forms.Button btnRaspored;
        private System.Windows.Forms.Panel pnlPocetna;
        private System.Windows.Forms.PictureBox pbGrb;
        private System.Windows.Forms.Button btnEkipe;
    }
}

