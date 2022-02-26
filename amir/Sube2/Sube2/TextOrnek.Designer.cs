namespace Sube2
{
    partial class TextOrnek
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
            this.txtOrnek1 = new System.Windows.Forms.TextBox();
            this.txtOrnek2 = new System.Windows.Forms.TextBox();
            this.btnOlaylar = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnOrnek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOrnek1
            // 
            this.txtOrnek1.HideSelection = false;
            this.txtOrnek1.Location = new System.Drawing.Point(12, 12);
            this.txtOrnek1.Multiline = true;
            this.txtOrnek1.Name = "txtOrnek1";
            this.txtOrnek1.Size = new System.Drawing.Size(100, 75);
            this.txtOrnek1.TabIndex = 0;
            // 
            // txtOrnek2
            // 
            this.txtOrnek2.HideSelection = false;
            this.txtOrnek2.Location = new System.Drawing.Point(12, 129);
            this.txtOrnek2.Multiline = true;
            this.txtOrnek2.Name = "txtOrnek2";
            this.txtOrnek2.Size = new System.Drawing.Size(100, 112);
            this.txtOrnek2.TabIndex = 1;
            // 
            // btnOlaylar
            // 
            this.btnOlaylar.Location = new System.Drawing.Point(162, 48);
            this.btnOlaylar.Name = "btnOlaylar";
            this.btnOlaylar.Size = new System.Drawing.Size(75, 23);
            this.btnOlaylar.TabIndex = 2;
            this.btnOlaylar.Text = "SelectALL";
            this.btnOlaylar.UseVisualStyleBackColor = true;
            this.btnOlaylar.Click += new System.EventHandler(this.btnOlaylar_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(162, 164);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(75, 23);
            this.btnOrnek2.TabIndex = 3;
            this.btnOrnek2.Text = "Select";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(162, 92);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(162, 129);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(75, 23);
            this.btnYapistir.TabIndex = 5;
            this.btnYapistir.Text = "Yapiştir";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(162, 194);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnOrnek
            // 
            this.btnOrnek.Location = new System.Drawing.Point(343, 63);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(75, 23);
            this.btnOrnek.TabIndex = 7;
            this.btnOrnek.Text = "Aktar";
            this.btnOrnek.UseVisualStyleBackColor = true;
            this.btnOrnek.Click += new System.EventHandler(this.btnOrnek_Click);
            // 
            // TextOrnek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 253);
            this.Controls.Add(this.btnOrnek);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOlaylar);
            this.Controls.Add(this.txtOrnek2);
            this.Controls.Add(this.txtOrnek1);
            this.Name = "TextOrnek";
            this.Text = "TextOrnek";
            this.Load += new System.EventHandler(this.TextOrnek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrnek1;
        private System.Windows.Forms.TextBox txtOrnek2;
        private System.Windows.Forms.Button btnOlaylar;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnYapistir;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnOrnek;
    }
}