namespace Sube2
{
    partial class Klasor
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
            this.btnOluştur = new System.Windows.Forms.Button();
            this.btnMOve = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnDrcInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOluştur
            // 
            this.btnOluştur.Location = new System.Drawing.Point(24, 23);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(129, 23);
            this.btnOluştur.TabIndex = 0;
            this.btnOluştur.Text = "Klasör oluştur";
            this.btnOluştur.UseVisualStyleBackColor = true;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // btnMOve
            // 
            this.btnMOve.Location = new System.Drawing.Point(24, 53);
            this.btnMOve.Name = "btnMOve";
            this.btnMOve.Size = new System.Drawing.Size(129, 23);
            this.btnMOve.TabIndex = 1;
            this.btnMOve.Text = "Taşıma";
            this.btnMOve.UseVisualStyleBackColor = true;
            this.btnMOve.Click += new System.EventHandler(this.btnMOve_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(24, 83);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(24, 113);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(129, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Get Directory";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(173, 22);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 4;
            this.btnPath.Text = "Yol";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnDrcInfo
            // 
            this.btnDrcInfo.Location = new System.Drawing.Point(173, 154);
            this.btnDrcInfo.Name = "btnDrcInfo";
            this.btnDrcInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDrcInfo.TabIndex = 5;
            this.btnDrcInfo.Text = "DirectoryInfo";
            this.btnDrcInfo.UseVisualStyleBackColor = true;
            this.btnDrcInfo.Click += new System.EventHandler(this.btnDrcInfo_Click);
            // 
            // Klasor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnDrcInfo);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnMOve);
            this.Controls.Add(this.btnOluştur);
            this.Name = "Klasor";
            this.Text = "Klasor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.Button btnMOve;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnDrcInfo;
    }
}