namespace alif_bishara
{
    partial class FormNew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnianitalmidim = new System.Windows.Forms.Button();
            this.panelmerkazi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAnianitalmidim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(893, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 666);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "בית הספר לספורט";
            // 
            // btnAnianitalmidim
            // 
            this.btnAnianitalmidim.BackColor = System.Drawing.Color.LightPink;
            this.btnAnianitalmidim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnianitalmidim.Location = new System.Drawing.Point(3, 68);
            this.btnAnianitalmidim.Name = "btnAnianitalmidim";
            this.btnAnianitalmidim.Size = new System.Drawing.Size(127, 78);
            this.btnAnianitalmidim.TabIndex = 1;
            this.btnAnianitalmidim.Text = "תלמידים";
            this.btnAnianitalmidim.UseVisualStyleBackColor = false;
            this.btnAnianitalmidim.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelmerkazi
            // 
            this.panelmerkazi.Location = new System.Drawing.Point(0, 0);
            this.panelmerkazi.Name = "panelmerkazi";
            this.panelmerkazi.Size = new System.Drawing.Size(890, 666);
            this.panelmerkazi.TabIndex = 1;
            this.panelmerkazi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmerkazi_Paint);
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 666);
            this.Controls.Add(this.panelmerkazi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNew";
            this.Text = "FormNew";
            this.Load += new System.EventHandler(this.FormNew_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnianitalmidim;
        private System.Windows.Forms.Panel panelmerkazi;
    }
}