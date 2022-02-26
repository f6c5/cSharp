namespace Vize
{
    partial class Soforler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOnay = new System.Windows.Forms.Button();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.btnOnay);
            this.groupBox1.Controls.Add(this.txtTell);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.lblSoyAd);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Şoförler Bilgileri:";
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(164, 178);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 23);
            this.btnOnay.TabIndex = 4;
            this.btnOnay.Text = "Tamamla";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(164, 140);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(100, 22);
            this.txtTell.TabIndex = 3;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(25, 143);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(124, 17);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Telefon Numarası:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(164, 95);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // lblSoyAd
            // 
            this.lblSoyAd.AutoSize = true;
            this.lblSoyAd.Location = new System.Drawing.Point(25, 100);
            this.lblSoyAd.Name = "lblSoyAd";
            this.lblSoyAd.Size = new System.Drawing.Size(53, 17);
            this.lblSoyAd.TabIndex = 2;
            this.lblSoyAd.Text = "SoyAd:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(164, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(25, 59);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 17);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(289, 237);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(6, 219);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(107, 219);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Soforler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 272);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Soforler";
            this.Text = "Soforler";
            this.Load += new System.EventHandler(this.Soforler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
    }
}