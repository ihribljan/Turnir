namespace Turnir
{
    partial class Tablica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablica));
            this.dgvStrijelci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAGrupa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBGrupa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCGrupa = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDGrupa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrijelci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAGrupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBGrupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCGrupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDGrupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStrijelci
            // 
            this.dgvStrijelci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrijelci.Location = new System.Drawing.Point(187, 377);
            this.dgvStrijelci.Name = "dgvStrijelci";
            this.dgvStrijelci.Size = new System.Drawing.Size(476, 137);
            this.dgvStrijelci.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista strijelaca";
            // 
            // dgvAGrupa
            // 
            this.dgvAGrupa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAGrupa.Location = new System.Drawing.Point(10, 42);
            this.dgvAGrupa.Name = "dgvAGrupa";
            this.dgvAGrupa.Size = new System.Drawing.Size(383, 89);
            this.dgvAGrupa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A grupa";
            // 
            // dgvBGrupa
            // 
            this.dgvBGrupa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBGrupa.Location = new System.Drawing.Point(415, 42);
            this.dgvBGrupa.Name = "dgvBGrupa";
            this.dgvBGrupa.Size = new System.Drawing.Size(383, 111);
            this.dgvBGrupa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "B grupa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "C grupa";
            // 
            // dgvCGrupa
            // 
            this.dgvCGrupa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCGrupa.Location = new System.Drawing.Point(10, 195);
            this.dgvCGrupa.Name = "dgvCGrupa";
            this.dgvCGrupa.Size = new System.Drawing.Size(383, 111);
            this.dgvCGrupa.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "D grupa";
            // 
            // dgvDGrupa
            // 
            this.dgvDGrupa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDGrupa.Location = new System.Drawing.Point(415, 195);
            this.dgvDGrupa.Name = "dgvDGrupa";
            this.dgvDGrupa.Size = new System.Drawing.Size(383, 111);
            this.dgvDGrupa.TabIndex = 8;
            // 
            // Tablica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 526);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDGrupa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCGrupa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBGrupa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAGrupa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStrijelci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tablica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablica";
            this.Load += new System.EventHandler(this.Tablica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrijelci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAGrupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBGrupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCGrupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDGrupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStrijelci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAGrupa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBGrupa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCGrupa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDGrupa;
    }
}