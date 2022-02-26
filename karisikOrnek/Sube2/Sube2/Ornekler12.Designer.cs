namespace Sube2
{
    partial class Ornekler12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ornekler12));
            this.lblOrnek = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKuallnici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblHata = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrnek
            // 
            this.lblOrnek.AutoSize = true;
            this.lblOrnek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.lblOrnek.Location = new System.Drawing.Point(275, 18);
            this.lblOrnek.Name = "lblOrnek";
            this.lblOrnek.Size = new System.Drawing.Size(125, 25);
            this.lblOrnek.TabIndex = 0;
            this.lblOrnek.Text = "Kullanıcı Adı:";
            this.lblOrnek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrnek.Click += new System.EventHandler(this.lblOrnek_Click);
            this.lblOrnek.MouseHover += new System.EventHandler(this.lblOrnek_MouseHover);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(275, 52);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtKuallnici
            // 
            this.txtKuallnici.Location = new System.Drawing.Point(444, 21);
            this.txtKuallnici.MaxLength = 11;
            this.txtKuallnici.Name = "txtKuallnici";
            this.txtKuallnici.Size = new System.Drawing.Size(141, 22);
            this.txtKuallnici.TabIndex = 0;
            this.txtKuallnici.Text = "Kullanıcı Adınız giriniz....";
            this.txtKuallnici.Leave += new System.EventHandler(this.txtKuallnici_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(444, 54);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(141, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(601, 91);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(74, 71);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(277, 161);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 17);
            this.lblHata.TabIndex = 3;
            this.lblHata.Visible = false;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(291, 161);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(138, 17);
            this.lblMesaj.TabIndex = 4;
            this.lblMesaj.Text = "Hatalı giriş yaptınız...";
            this.lblMesaj.Visible = false;
            // 
            // Ornekler12
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 266);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKuallnici);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblOrnek);
            this.Name = "Ornekler12";
            this.Text = "Ornekler12";
            this.Load += new System.EventHandler(this.Ornekler12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrnek;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKuallnici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label lblMesaj;
    }
}