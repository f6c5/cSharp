namespace Sube2
{
    partial class Numaralandirici
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
            this.lstDeneme = new System.Windows.Forms.ListBox();
            this.btnMevsim = new System.Windows.Forms.Button();
            this.btnPlaka = new System.Windows.Forms.Button();
            this.btnAylar = new System.Windows.Forms.Button();
            this.lblDeger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDeneme
            // 
            this.lstDeneme.FormattingEnabled = true;
            this.lstDeneme.ItemHeight = 16;
            this.lstDeneme.Location = new System.Drawing.Point(43, 25);
            this.lstDeneme.Name = "lstDeneme";
            this.lstDeneme.Size = new System.Drawing.Size(120, 196);
            this.lstDeneme.TabIndex = 0;
            this.lstDeneme.SelectedIndexChanged += new System.EventHandler(this.lstDeneme_SelectedIndexChanged);
            // 
            // btnMevsim
            // 
            this.btnMevsim.Location = new System.Drawing.Point(219, 36);
            this.btnMevsim.Name = "btnMevsim";
            this.btnMevsim.Size = new System.Drawing.Size(75, 23);
            this.btnMevsim.TabIndex = 1;
            this.btnMevsim.Text = "Mevsim";
            this.btnMevsim.UseVisualStyleBackColor = true;
            this.btnMevsim.Click += new System.EventHandler(this.btnMevsim_Click);
            // 
            // btnPlaka
            // 
            this.btnPlaka.Location = new System.Drawing.Point(219, 97);
            this.btnPlaka.Name = "btnPlaka";
            this.btnPlaka.Size = new System.Drawing.Size(75, 23);
            this.btnPlaka.TabIndex = 2;
            this.btnPlaka.Text = "Plakalar";
            this.btnPlaka.UseVisualStyleBackColor = true;
            this.btnPlaka.Click += new System.EventHandler(this.btnPlaka_Click);
            // 
            // btnAylar
            // 
            this.btnAylar.Location = new System.Drawing.Point(219, 158);
            this.btnAylar.Name = "btnAylar";
            this.btnAylar.Size = new System.Drawing.Size(75, 23);
            this.btnAylar.TabIndex = 3;
            this.btnAylar.Text = "Aylar";
            this.btnAylar.UseVisualStyleBackColor = true;
            this.btnAylar.Click += new System.EventHandler(this.btnAylar_Click);
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(81, 239);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(46, 17);
            this.lblDeger.TabIndex = 4;
            this.lblDeger.Text = "label1";
            // 
            // Numaralandirici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 297);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.btnAylar);
            this.Controls.Add(this.btnPlaka);
            this.Controls.Add(this.btnMevsim);
            this.Controls.Add(this.lstDeneme);
            this.Name = "Numaralandirici";
            this.Text = "Numaralandirici";
            this.Load += new System.EventHandler(this.Numaralandirici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeneme;
        private System.Windows.Forms.Button btnMevsim;
        private System.Windows.Forms.Button btnPlaka;
        private System.Windows.Forms.Button btnAylar;
        private System.Windows.Forms.Label lblDeger;
    }
}