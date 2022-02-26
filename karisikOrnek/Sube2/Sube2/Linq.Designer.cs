namespace Sube2
{
    partial class Linq
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
            this.txtOrnek = new System.Windows.Forms.TextBox();
            this.btnOrnek = new System.Windows.Forms.Button();
            this.lblornek = new System.Windows.Forms.Label();
            this.btnIslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrnek
            // 
            this.lstOrnek.FormattingEnabled = true;
            this.lstOrnek.ItemHeight = 16;
            this.lstOrnek.Location = new System.Drawing.Point(466, 46);
            this.lstOrnek.Name = "lstOrnek";
            this.lstOrnek.Size = new System.Drawing.Size(120, 84);
            this.lstOrnek.TabIndex = 0;
            // 
            // txtOrnek
            // 
            this.txtOrnek.Location = new System.Drawing.Point(57, 46);
            this.txtOrnek.Name = "txtOrnek";
            this.txtOrnek.Size = new System.Drawing.Size(100, 22);
            this.txtOrnek.TabIndex = 1;
            // 
            // btnOrnek
            // 
            this.btnOrnek.Location = new System.Drawing.Point(72, 107);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(75, 23);
            this.btnOrnek.TabIndex = 2;
            this.btnOrnek.Text = "ara";
            this.btnOrnek.UseVisualStyleBackColor = true;
            this.btnOrnek.Click += new System.EventHandler(this.btnOrnek_Click);
            // 
            // lblornek
            // 
            this.lblornek.AutoSize = true;
            this.lblornek.Location = new System.Drawing.Point(69, 157);
            this.lblornek.Name = "lblornek";
            this.lblornek.Size = new System.Drawing.Size(0, 17);
            this.lblornek.TabIndex = 3;
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(189, 106);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(75, 23);
            this.btnIslem.TabIndex = 4;
            this.btnIslem.Text = "işlem";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // Linq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 392);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.lblornek);
            this.Controls.Add(this.btnOrnek);
            this.Controls.Add(this.txtOrnek);
            this.Controls.Add(this.lstOrnek);
            this.Name = "Linq";
            this.Text = "Linq";
            this.Load += new System.EventHandler(this.Linq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrnek;
        private System.Windows.Forms.TextBox txtOrnek;
        private System.Windows.Forms.Button btnOrnek;
        private System.Windows.Forms.Label lblornek;
        private System.Windows.Forms.Button btnIslem;
    }
}