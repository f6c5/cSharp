namespace Sube2
{
    partial class Class
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
            this.components = new System.ComponentModel.Container();
            this.lblOrnek = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnOlay = new System.Windows.Forms.Button();
            this.btnOlayB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrnek
            // 
            this.lblOrnek.AutoSize = true;
            this.lblOrnek.Location = new System.Drawing.Point(157, 59);
            this.lblOrnek.Name = "lblOrnek";
            this.lblOrnek.Size = new System.Drawing.Size(0, 17);
            this.lblOrnek.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(108, 79);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(108, 119);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnOlay
            // 
            this.btnOlay.Location = new System.Drawing.Point(108, 203);
            this.btnOlay.Name = "btnOlay";
            this.btnOlay.Size = new System.Drawing.Size(111, 23);
            this.btnOlay.TabIndex = 4;
            this.btnOlay.Text = "Hesapla A";
            this.btnOlay.UseVisualStyleBackColor = true;
            this.btnOlay.Click += new System.EventHandler(this.btnOlay_Click);
            // 
            // btnOlayB
            // 
            this.btnOlayB.Location = new System.Drawing.Point(255, 203);
            this.btnOlayB.Name = "btnOlayB";
            this.btnOlayB.Size = new System.Drawing.Size(111, 23);
            this.btnOlayB.TabIndex = 5;
            this.btnOlayB.Text = "Hesapla B";
            this.btnOlayB.UseVisualStyleBackColor = true;
            this.btnOlayB.Click += new System.EventHandler(this.btnOlayB_Click);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 331);
            this.Controls.Add(this.btnOlayB);
            this.Controls.Add(this.btnOlay);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblOrnek);
            this.Name = "Class";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Class_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrnek;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnOlay;
        private System.Windows.Forms.Button btnOlayB;
    }
}