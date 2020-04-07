namespace WindowsFormsApplication1
{
    partial class formabout
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
            this.lblab = new System.Windows.Forms.Label();
            this.lblph = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.lbladr = new System.Windows.Forms.Label();
            this.lblfax = new System.Windows.Forms.Label();
            this.btnbkab = new System.Windows.Forms.Button();
            this.lblhours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblab
            // 
            this.lblab.AutoSize = true;
            this.lblab.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblab.Location = new System.Drawing.Point(221, 23);
            this.lblab.Name = "lblab";
            this.lblab.Size = new System.Drawing.Size(640, 113);
            this.lblab.TabIndex = 1;
            this.lblab.Text = " About R.a  Fitness";
            // 
            // lblph
            // 
            this.lblph.AutoSize = true;
            this.lblph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblph.Location = new System.Drawing.Point(873, 190);
            this.lblph.Name = "lblph";
            this.lblph.Size = new System.Drawing.Size(133, 20);
            this.lblph.TabIndex = 2;
            this.lblph.Text = "טלפון:089252512";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblmail.Location = new System.Drawing.Point(777, 237);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(233, 20);
            this.lblmail.TabIndex = 3;
            this.lblmail.Text = "ra.fitness.2000@live.com :דוא\"ל";
            // 
            // lbladr
            // 
            this.lbladr.AutoSize = true;
            this.lbladr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbladr.Location = new System.Drawing.Point(841, 283);
            this.lbladr.Name = "lbladr";
            this.lbladr.Size = new System.Drawing.Size(169, 20);
            this.lbladr.TabIndex = 4;
            this.lbladr.Text = "כתובת: הפלמ\"ח 4, רמלה";
            // 
            // lblfax
            // 
            this.lblfax.AutoSize = true;
            this.lblfax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblfax.Location = new System.Drawing.Point(886, 331);
            this.lblfax.Name = "lblfax";
            this.lblfax.Size = new System.Drawing.Size(124, 20);
            this.lblfax.TabIndex = 5;
            this.lblfax.Text = "פקס: 089252512";
            this.lblfax.Click += new System.EventHandler(this.lblfax_Click);
            // 
            // btnbkab
            // 
            this.btnbkab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbkab.Location = new System.Drawing.Point(12, 495);
            this.btnbkab.Name = "btnbkab";
            this.btnbkab.Size = new System.Drawing.Size(166, 69);
            this.btnbkab.TabIndex = 7;
            this.btnbkab.Text = "חזרה לדף הראשי";
            this.btnbkab.UseVisualStyleBackColor = true;
            this.btnbkab.Click += new System.EventHandler(this.btnbkab_Click);
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblhours.Location = new System.Drawing.Point(714, 377);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(296, 20);
            this.lblhours.TabIndex = 8;
            this.lblhours.Text = "  שעות פעילות: כל ימות השבוע- 8:00-22:00";
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
            // formabout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhours);
            this.Controls.Add(this.btnbkab);
            this.Controls.Add(this.lblfax);
            this.Controls.Add(this.lbladr);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.lblph);
            this.Controls.Add(this.lblab);
            this.Name = "formabout";
            this.Text = "formabout";
            this.Load += new System.EventHandler(this.formabout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblab;
        private System.Windows.Forms.Label lblph;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lbladr;
        private System.Windows.Forms.Label lblfax;
        private System.Windows.Forms.Button btnbkab;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Label label1;
    }
}