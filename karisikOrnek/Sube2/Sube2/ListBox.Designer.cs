namespace Sube2
{
    partial class ListBox
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
            this.lstOrnek = new System.Windows.Forms.ListBox();
            this.btnOrnek = new System.Windows.Forms.Button();
            this.lblOrnek = new System.Windows.Forms.Label();
            this.txtOrnek = new System.Windows.Forms.TextBox();
            this.btnSiralama = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstDersler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrnek
            // 
            this.lstOrnek.FormattingEnabled = true;
            this.lstOrnek.ItemHeight = 16;
            this.lstOrnek.Items.AddRange(new object[] {
            "Görsel",
            "işletim sistemleri"});
            this.lstOrnek.Location = new System.Drawing.Point(58, 94);
            this.lstOrnek.Name = "lstOrnek";
            this.lstOrnek.Size = new System.Drawing.Size(251, 84);
            this.lstOrnek.TabIndex = 0;
            this.lstOrnek.SelectedIndexChanged += new System.EventHandler(this.lstOrnek_SelectedIndexChanged);
            // 
            // btnOrnek
            // 
            this.btnOrnek.Location = new System.Drawing.Point(48, 262);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(75, 23);
            this.btnOrnek.TabIndex = 1;
            this.btnOrnek.Text = "Ekle";
            this.btnOrnek.UseVisualStyleBackColor = true;
            this.btnOrnek.Click += new System.EventHandler(this.btnOrnek_Click);
            // 
            // lblOrnek
            // 
            this.lblOrnek.AutoSize = true;
            this.lblOrnek.Location = new System.Drawing.Point(328, 49);
            this.lblOrnek.Name = "lblOrnek";
            this.lblOrnek.Size = new System.Drawing.Size(0, 17);
            this.lblOrnek.TabIndex = 2;
            // 
            // txtOrnek
            // 
            this.txtOrnek.Location = new System.Drawing.Point(58, 44);
            this.txtOrnek.Name = "txtOrnek";
            this.txtOrnek.Size = new System.Drawing.Size(100, 22);
            this.txtOrnek.TabIndex = 3;
            // 
            // btnSiralama
            // 
            this.btnSiralama.Location = new System.Drawing.Point(253, 262);
            this.btnSiralama.Name = "btnSiralama";
            this.btnSiralama.Size = new System.Drawing.Size(75, 23);
            this.btnSiralama.TabIndex = 4;
            this.btnSiralama.Text = "Sıralama";
            this.btnSiralama.UseVisualStyleBackColor = true;
            this.btnSiralama.Click += new System.EventHandler(this.btnSiralama_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(151, 262);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstDersler
            // 
            this.lstDersler.FormattingEnabled = true;
            this.lstDersler.ItemHeight = 16;
            this.lstDersler.Location = new System.Drawing.Point(402, 94);
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.Size = new System.Drawing.Size(251, 84);
            this.lstDersler.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDersler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSiralama);
            this.Controls.Add(this.txtOrnek);
            this.Controls.Add(this.lblOrnek);
            this.Controls.Add(this.btnOrnek);
            this.Controls.Add(this.lstOrnek);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrnek;
        private System.Windows.Forms.Button btnOrnek;
        private System.Windows.Forms.Label lblOrnek;
        private System.Windows.Forms.TextBox txtOrnek;
        private System.Windows.Forms.Button btnSiralama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstDersler;
        private System.Windows.Forms.Button button1;
    }
}