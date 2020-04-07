namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.btnOpenmnhlim = new System.Windows.Forms.Button();
            this.btnOpenOvdeem = new System.Windows.Forms.Button();
            this.btnOpenMotzarim = new System.Windows.Forms.Button();
            this.btnOpenLkohot = new System.Windows.Forms.Button();
            this.btnOpenSokhen = new System.Windows.Forms.Button();
            this.btnopensp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenmnhlim
            // 
            this.btnOpenmnhlim.Location = new System.Drawing.Point(156, 191);
            this.btnOpenmnhlim.Name = "btnOpenmnhlim";
            this.btnOpenmnhlim.Size = new System.Drawing.Size(144, 61);
            this.btnOpenmnhlim.TabIndex = 0;
            this.btnOpenmnhlim.Text = "מנהלים";
            this.btnOpenmnhlim.UseVisualStyleBackColor = true;
            this.btnOpenmnhlim.Click += new System.EventHandler(this.btnOpenmnhlim_Click);
            // 
            // btnOpenOvdeem
            // 
            this.btnOpenOvdeem.Location = new System.Drawing.Point(319, 191);
            this.btnOpenOvdeem.Name = "btnOpenOvdeem";
            this.btnOpenOvdeem.Size = new System.Drawing.Size(144, 61);
            this.btnOpenOvdeem.TabIndex = 1;
            this.btnOpenOvdeem.Text = "עובדים";
            this.btnOpenOvdeem.UseVisualStyleBackColor = true;
            this.btnOpenOvdeem.Click += new System.EventHandler(this.btnOpenOvdeem_Click);
            // 
            // btnOpenMotzarim
            // 
            this.btnOpenMotzarim.Location = new System.Drawing.Point(156, 286);
            this.btnOpenMotzarim.Name = "btnOpenMotzarim";
            this.btnOpenMotzarim.Size = new System.Drawing.Size(144, 61);
            this.btnOpenMotzarim.TabIndex = 2;
            this.btnOpenMotzarim.Text = "מוצרים";
            this.btnOpenMotzarim.UseVisualStyleBackColor = true;
            this.btnOpenMotzarim.Click += new System.EventHandler(this.btnOpenMotzarim_Click);
            // 
            // btnOpenLkohot
            // 
            this.btnOpenLkohot.Location = new System.Drawing.Point(319, 286);
            this.btnOpenLkohot.Name = "btnOpenLkohot";
            this.btnOpenLkohot.Size = new System.Drawing.Size(144, 61);
            this.btnOpenLkohot.TabIndex = 3;
            this.btnOpenLkohot.Text = "לקוחות";
            this.btnOpenLkohot.UseVisualStyleBackColor = true;
            this.btnOpenLkohot.Click += new System.EventHandler(this.btnOpenLkohot_Click);
            // 
            // btnOpenSokhen
            // 
            this.btnOpenSokhen.Location = new System.Drawing.Point(494, 286);
            this.btnOpenSokhen.Name = "btnOpenSokhen";
            this.btnOpenSokhen.Size = new System.Drawing.Size(144, 61);
            this.btnOpenSokhen.TabIndex = 4;
            this.btnOpenSokhen.Text = "סוכנים";
            this.btnOpenSokhen.UseVisualStyleBackColor = true;
            this.btnOpenSokhen.Click += new System.EventHandler(this.btnOpenSokhen_Click);
            // 
            // btnopensp
            // 
            this.btnopensp.Location = new System.Drawing.Point(494, 191);
            this.btnopensp.Name = "btnopensp";
            this.btnopensp.Size = new System.Drawing.Size(144, 61);
            this.btnopensp.TabIndex = 5;
            this.btnopensp.Text = "ספקים";
            this.btnopensp.UseVisualStyleBackColor = true;
            this.btnopensp.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "עבד אביזרי רכב";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnopensp);
            this.Controls.Add(this.btnOpenSokhen);
            this.Controls.Add(this.btnOpenLkohot);
            this.Controls.Add(this.btnOpenMotzarim);
            this.Controls.Add(this.btnOpenOvdeem);
            this.Controls.Add(this.btnOpenmnhlim);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenmnhlim;
        private System.Windows.Forms.Button btnOpenOvdeem;
        private System.Windows.Forms.Button btnOpenMotzarim;
        private System.Windows.Forms.Button btnOpenLkohot;
        private System.Windows.Forms.Button btnOpenSokhen;
        private System.Windows.Forms.Button btnopensp;
        private System.Windows.Forms.Label label1;
    }
}