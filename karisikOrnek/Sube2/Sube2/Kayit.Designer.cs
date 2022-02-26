namespace Sube2
{
    partial class Kayit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyaAd = new System.Windows.Forms.TextBox();
            this.tctTel = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSoyAd = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SoyAd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "T.C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tel:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(98, 13);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "Ad";
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAd_KeyDown);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtSoyaAd
            // 
            this.txtSoyaAd.HideSelection = false;
            this.txtSoyaAd.Location = new System.Drawing.Point(98, 41);
            this.txtSoyaAd.Name = "txtSoyaAd";
            this.txtSoyaAd.Size = new System.Drawing.Size(100, 22);
            this.txtSoyaAd.TabIndex = 1;
            this.txtSoyaAd.TextChanged += new System.EventHandler(this.txtSoyaAd_TextChanged);
            this.txtSoyaAd.Leave += new System.EventHandler(this.txtSoyaAd_Leave);
            // 
            // tctTel
            // 
            this.tctTel.Location = new System.Drawing.Point(98, 129);
            this.tctTel.Name = "tctTel";
            this.tctTel.Size = new System.Drawing.Size(100, 22);
            this.tctTel.TabIndex = 4;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(98, 101);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 3;
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(98, 70);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(100, 22);
            this.txtCinsiyet.TabIndex = 2;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(72, 169);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(235, 17);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(46, 17);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "label6";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(235, 106);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(46, 17);
            this.lblTC.TabIndex = 7;
            this.lblTC.Text = "label7";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(235, 73);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(46, 17);
            this.lblCinsiyet.TabIndex = 8;
            this.lblCinsiyet.Text = "label8";
            // 
            // lblSoyAd
            // 
            this.lblSoyAd.AutoSize = true;
            this.lblSoyAd.Location = new System.Drawing.Point(235, 46);
            this.lblSoyAd.Name = "lblSoyAd";
            this.lblSoyAd.Size = new System.Drawing.Size(46, 17);
            this.lblSoyAd.TabIndex = 9;
            this.lblSoyAd.Text = "label9";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(260, 169);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAnaSayfa.TabIndex = 10;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // Kayit
            // 
            this.AcceptButton = this.btnKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 204);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.lblSoyAd);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.tctTel);
            this.Controls.Add(this.txtSoyaAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.Load += new System.EventHandler(this.Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyaAd;
        private System.Windows.Forms.TextBox tctTel;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSoyAd;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}