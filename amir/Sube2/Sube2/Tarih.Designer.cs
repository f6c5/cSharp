namespace Sube2
{
    partial class Tarih
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
            this.btnTarih = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.txtOrnek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTarih
            // 
            this.btnTarih.Location = new System.Drawing.Point(56, 127);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(75, 23);
            this.btnTarih.TabIndex = 0;
            this.btnTarih.Text = "Göster";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(329, 28);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 17);
            this.lblsonuc.TabIndex = 1;
            this.lblsonuc.Visible = false;
            // 
            // txtOrnek
            // 
            this.txtOrnek.Location = new System.Drawing.Point(99, 23);
            this.txtOrnek.Name = "txtOrnek";
            this.txtOrnek.Size = new System.Drawing.Size(100, 22);
            this.txtOrnek.TabIndex = 2;
            // 
            // Tarih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 253);
            this.Controls.Add(this.txtOrnek);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnTarih);
            this.Name = "Tarih";
            this.Text = "Tarih";
            this.Load += new System.EventHandler(this.Tarih_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.TextBox txtOrnek;
    }
}