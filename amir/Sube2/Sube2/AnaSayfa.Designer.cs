namespace Sube2
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnOrnek = new System.Windows.Forms.Button();
            this.btnRenk1 = new System.Windows.Forms.Button();
            this.btnRenk2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnGiris.Location = new System.Drawing.Point(57, 187);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "&Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnOrnek
            // 
            this.btnOrnek.Location = new System.Drawing.Point(204, 187);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(75, 23);
            this.btnOrnek.TabIndex = 3;
            this.btnOrnek.Text = "&Örnek";
            this.btnOrnek.UseVisualStyleBackColor = true;
            this.btnOrnek.Click += new System.EventHandler(this.btnOrnek_Click);
            this.btnOrnek.MouseLeave += new System.EventHandler(this.btnOrnek_MouseLeave);
            this.btnOrnek.MouseHover += new System.EventHandler(this.btnOrnek_MouseHover);
            // 
            // btnRenk1
            // 
            this.btnRenk1.BackColor = System.Drawing.Color.Red;
            this.btnRenk1.ForeColor = System.Drawing.Color.Red;
            this.btnRenk1.Location = new System.Drawing.Point(0, 0);
            this.btnRenk1.Name = "btnRenk1";
            this.btnRenk1.Size = new System.Drawing.Size(75, 56);
            this.btnRenk1.TabIndex = 4;
            this.btnRenk1.Text = "Kırmızı";
            this.btnRenk1.UseVisualStyleBackColor = false;
            this.btnRenk1.Click += new System.EventHandler(this.btnRenk1_Click);
            // 
            // btnRenk2
            // 
            this.btnRenk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRenk2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRenk2.Location = new System.Drawing.Point(81, 0);
            this.btnRenk2.Name = "btnRenk2";
            this.btnRenk2.Size = new System.Drawing.Size(75, 56);
            this.btnRenk2.TabIndex = 5;
            this.btnRenk2.Text = "Yeşil";
            this.btnRenk2.UseVisualStyleBackColor = false;
            this.btnRenk2.Click += new System.EventHandler(this.btnRenk2_Click);
            // 
            // AnaSayfa
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.btnRenk2);
            this.Controls.Add(this.btnRenk1);
            this.Controls.Add(this.btnOrnek);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.DoubleClick += new System.EventHandler(this.AnaSayfa_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaSayfa_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnaSayfa_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnOrnek;
        private System.Windows.Forms.Button btnRenk1;
        private System.Windows.Forms.Button btnRenk2;
    }
}