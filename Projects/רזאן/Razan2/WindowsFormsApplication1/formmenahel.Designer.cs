namespace WindowsFormsApplication1
{
    partial class formmenahel
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
            this.btnsap = new System.Windows.Forms.Button();
            this.lblm = new System.Windows.Forms.Label();
            this.btnbkab = new System.Windows.Forms.Button();
            this.ovdeem = new System.Windows.Forms.Button();
            this.meamnim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsap
            // 
            this.btnsap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsap.ForeColor = System.Drawing.Color.Purple;
            this.btnsap.Location = new System.Drawing.Point(666, 186);
            this.btnsap.Name = "btnsap";
            this.btnsap.Size = new System.Drawing.Size(166, 69);
            this.btnsap.TabIndex = 3;
            this.btnsap.Text = "ספקים";
            this.btnsap.UseVisualStyleBackColor = true;
            this.btnsap.Click += new System.EventHandler(this.btnsap_Click);
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm.Location = new System.Drawing.Point(341, 9);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(329, 113);
            this.lblm.TabIndex = 8;
            this.lblm.Text = "Manager";
            // 
            // btnbkab
            // 
            this.btnbkab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkab.ForeColor = System.Drawing.Color.Purple;
            this.btnbkab.Location = new System.Drawing.Point(12, 342);
            this.btnbkab.Name = "btnbkab";
            this.btnbkab.Size = new System.Drawing.Size(166, 69);
            this.btnbkab.TabIndex = 11;
            this.btnbkab.Text = "חזרה לדף הראשי";
            this.btnbkab.UseVisualStyleBackColor = true;
            this.btnbkab.Click += new System.EventHandler(this.btnbkab_Click);
            // 
            // ovdeem
            // 
            this.ovdeem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ovdeem.ForeColor = System.Drawing.Color.Purple;
            this.ovdeem.Location = new System.Drawing.Point(152, 186);
            this.ovdeem.Name = "ovdeem";
            this.ovdeem.Size = new System.Drawing.Size(166, 69);
            this.ovdeem.TabIndex = 17;
            this.ovdeem.Text = "עובדים";
            this.ovdeem.UseVisualStyleBackColor = true;
            this.ovdeem.Click += new System.EventHandler(this.ovdeem_Click);
            // 
            // meamnim
            // 
            this.meamnim.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meamnim.ForeColor = System.Drawing.Color.Purple;
            this.meamnim.Location = new System.Drawing.Point(411, 186);
            this.meamnim.Name = "meamnim";
            this.meamnim.Size = new System.Drawing.Size(166, 69);
            this.meamnim.TabIndex = 16;
            this.meamnim.Text = "מאמנים";
            this.meamnim.UseVisualStyleBackColor = true;
            this.meamnim.Click += new System.EventHandler(this.meamnim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "R.a Fitness";
            // 
            // formmenahel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ovdeem);
            this.Controls.Add(this.meamnim);
            this.Controls.Add(this.btnbkab);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.btnsap);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "formmenahel";
            this.Text = "מנהל";
            this.Load += new System.EventHandler(this.formmenahel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsap;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.Button btnbkab;
        private System.Windows.Forms.Button ovdeem;
        private System.Windows.Forms.Button meamnim;
        private System.Windows.Forms.Label label1;
    }
}