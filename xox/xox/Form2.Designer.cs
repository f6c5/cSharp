
namespace xox
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnl_mod = new System.Windows.Forms.Panel();
            this.mod_h = new System.Windows.Forms.RadioButton();
            this.mod_e = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pvm = new System.Windows.Forms.Button();
            this.pvp = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_mod.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_mod
            // 
            this.pnl_mod.Controls.Add(this.mod_h);
            this.pnl_mod.Controls.Add(this.mod_e);
            this.pnl_mod.Location = new System.Drawing.Point(285, 265);
            this.pnl_mod.Name = "pnl_mod";
            this.pnl_mod.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_mod.Size = new System.Drawing.Size(183, 109);
            this.pnl_mod.TabIndex = 26;
            this.pnl_mod.Visible = false;
            // 
            // mod_h
            // 
            this.mod_h.AutoSize = true;
            this.mod_h.Dock = System.Windows.Forms.DockStyle.Top;
            this.mod_h.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mod_h.ForeColor = System.Drawing.Color.White;
            this.mod_h.Location = new System.Drawing.Point(10, 51);
            this.mod_h.Name = "mod_h";
            this.mod_h.Size = new System.Drawing.Size(163, 41);
            this.mod_h.TabIndex = 2;
            this.mod_h.TabStop = true;
            this.mod_h.Text = "zor";
            this.mod_h.UseVisualStyleBackColor = true;
            this.mod_h.CheckedChanged += new System.EventHandler(this.mod_h_CheckedChanged);
            // 
            // mod_e
            // 
            this.mod_e.AutoSize = true;
            this.mod_e.Dock = System.Windows.Forms.DockStyle.Top;
            this.mod_e.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mod_e.ForeColor = System.Drawing.Color.White;
            this.mod_e.Location = new System.Drawing.Point(10, 10);
            this.mod_e.Name = "mod_e";
            this.mod_e.Size = new System.Drawing.Size(163, 41);
            this.mod_e.TabIndex = 0;
            this.mod_e.TabStop = true;
            this.mod_e.Text = "kolay";
            this.mod_e.UseVisualStyleBackColor = true;
            this.mod_e.CheckedChanged += new System.EventHandler(this.mod_e_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 47);
            this.label1.TabIndex = 25;
            this.label1.Text = "oyun modu:";
            // 
            // pvm
            // 
            this.pvm.BackColor = System.Drawing.Color.White;
            this.pvm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pvm.ForeColor = System.Drawing.Color.Black;
            this.pvm.Location = new System.Drawing.Point(46, 265);
            this.pvm.Name = "pvm";
            this.pvm.Size = new System.Drawing.Size(200, 50);
            this.pvm.TabIndex = 24;
            this.pvm.Text = "bilgisayar";
            this.pvm.UseVisualStyleBackColor = false;
            this.pvm.Click += new System.EventHandler(this.pvm_Click);
            // 
            // pvp
            // 
            this.pvp.BackColor = System.Drawing.Color.White;
            this.pvp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pvp.ForeColor = System.Drawing.Color.Black;
            this.pvp.Location = new System.Drawing.Point(46, 192);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(200, 50);
            this.pvp.TabIndex = 23;
            this.pvp.Text = "oyuncu";
            this.pvp.UseVisualStyleBackColor = false;
            this.pvp.Click += new System.EventHandler(this.pvp_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(5, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(525, 10);
            this.panel4.TabIndex = 22;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(285, 30);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(225, 55);
            this.txt_p2.TabIndex = 21;
            this.txt_p2.Text = "oyuncu2";
            this.txt_p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(31, 30);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(225, 55);
            this.txt_p1.TabIndex = 20;
            this.txt_p1.Text = "oyuncu1";
            this.txt_p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(285, 430);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(200, 50);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "iptal";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(46, 430);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 50);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "kaydet";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.pnl_mod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pvm);
            this.Controls.Add(this.pvp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ayarlar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_mod.ResumeLayout(false);
            this.pnl_mod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_mod;
        private System.Windows.Forms.RadioButton mod_h;
        private System.Windows.Forms.RadioButton mod_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pvm;
        private System.Windows.Forms.Button pvp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_p2;
        private System.Windows.Forms.TextBox txt_p1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}