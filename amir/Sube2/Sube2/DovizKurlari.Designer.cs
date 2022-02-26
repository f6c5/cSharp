namespace Sube2
{
    partial class DovizKurlari
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
            this.lstdoviz = new System.Windows.Forms.ListBox();
            this.lblAlis = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstdoviz
            // 
            this.lstdoviz.FormattingEnabled = true;
            this.lstdoviz.ItemHeight = 16;
            this.lstdoviz.Location = new System.Drawing.Point(29, 28);
            this.lstdoviz.Name = "lstdoviz";
            this.lstdoviz.Size = new System.Drawing.Size(233, 292);
            this.lstdoviz.TabIndex = 0;
            this.lstdoviz.SelectedIndexChanged += new System.EventHandler(this.lstdoviz_SelectedIndexChanged);
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.ForeColor = System.Drawing.Color.Lime;
            this.lblAlis.Location = new System.Drawing.Point(377, 56);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(0, 17);
            this.lblAlis.TabIndex = 1;
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.ForeColor = System.Drawing.Color.Red;
            this.lblSatis.Location = new System.Drawing.Point(377, 118);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(0, 17);
            this.lblSatis.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(465, 55);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(46, 17);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "label1";
            // 
            // DovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 339);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.lstdoviz);
            this.Name = "DovizKurlari";
            this.Text = "DovizKurlari";
            this.Load += new System.EventHandler(this.DovizKurlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstdoviz;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.Label lblAd;
    }
}