namespace Sube2
{
    partial class Class2
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
            this.txtMarkasi = new System.Windows.Forms.TextBox();
            this.txtNumarasi = new System.Windows.Forms.TextBox();
            this.txtMalzemesi = new System.Windows.Forms.TextBox();
            this.txtTipi = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lstSiparish = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMarkasi
            // 
            this.txtMarkasi.Location = new System.Drawing.Point(157, 40);
            this.txtMarkasi.Name = "txtMarkasi";
            this.txtMarkasi.Size = new System.Drawing.Size(100, 22);
            this.txtMarkasi.TabIndex = 1;
            // 
            // txtNumarasi
            // 
            this.txtNumarasi.Location = new System.Drawing.Point(157, 184);
            this.txtNumarasi.Name = "txtNumarasi";
            this.txtNumarasi.Size = new System.Drawing.Size(100, 22);
            this.txtNumarasi.TabIndex = 4;
            // 
            // txtMalzemesi
            // 
            this.txtMalzemesi.Location = new System.Drawing.Point(157, 135);
            this.txtMalzemesi.Name = "txtMalzemesi";
            this.txtMalzemesi.Size = new System.Drawing.Size(100, 22);
            this.txtMalzemesi.TabIndex = 3;
            // 
            // txtTipi
            // 
            this.txtTipi.Location = new System.Drawing.Point(157, 85);
            this.txtTipi.Name = "txtTipi";
            this.txtTipi.Size = new System.Drawing.Size(100, 22);
            this.txtTipi.TabIndex = 2;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(157, 234);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 22);
            this.txtRenk.TabIndex = 5;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(294, 184);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 7;
            this.btnOnayla.Text = "Onay";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(166, 284);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Bagicikli mi?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lstSiparish
            // 
            this.lstSiparish.FormattingEnabled = true;
            this.lstSiparish.ItemHeight = 16;
            this.lstSiparish.Location = new System.Drawing.Point(451, 13);
            this.lstSiparish.Name = "lstSiparish";
            this.lstSiparish.Size = new System.Drawing.Size(378, 308);
            this.lstSiparish.TabIndex = 9;
            // 
            // Class2
            // 
            this.AcceptButton = this.btnOnayla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 336);
            this.Controls.Add(this.lstSiparish);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtTipi);
            this.Controls.Add(this.txtMalzemesi);
            this.Controls.Add(this.txtNumarasi);
            this.Controls.Add(this.txtMarkasi);
            this.Name = "Class2";
            this.Text = "Class2";
            this.Load += new System.EventHandler(this.Class2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarkasi;
        private System.Windows.Forms.TextBox txtNumarasi;
        private System.Windows.Forms.TextBox txtMalzemesi;
        private System.Windows.Forms.TextBox txtTipi;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lstSiparish;
    }
}