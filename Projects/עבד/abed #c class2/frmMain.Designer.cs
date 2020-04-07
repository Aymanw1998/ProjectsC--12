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
            this.components = new System.ComponentModel.Container();
            this.btnOpenOvdeem = new System.Windows.Forms.Button();
            this.btnOpenMotzarim = new System.Windows.Forms.Button();
            this.btnOpenLkohot = new System.Windows.Forms.Button();
            this.btnOpenSokhen = new System.Windows.Forms.Button();
            this.btnopensp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenOvdeem
            // 
            this.btnOpenOvdeem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenOvdeem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOpenOvdeem.Location = new System.Drawing.Point(170, 490);
            this.btnOpenOvdeem.Name = "btnOpenOvdeem";
            this.btnOpenOvdeem.Size = new System.Drawing.Size(215, 87);
            this.btnOpenOvdeem.TabIndex = 1;
            this.btnOpenOvdeem.Text = "עובדים";
            this.btnOpenOvdeem.UseVisualStyleBackColor = false;
            this.btnOpenOvdeem.Click += new System.EventHandler(this.btnOpenOvdeem_Click);
            // 
            // btnOpenMotzarim
            // 
            this.btnOpenMotzarim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenMotzarim.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOpenMotzarim.Location = new System.Drawing.Point(-14, 709);
            this.btnOpenMotzarim.Name = "btnOpenMotzarim";
            this.btnOpenMotzarim.Size = new System.Drawing.Size(215, 87);
            this.btnOpenMotzarim.TabIndex = 2;
            this.btnOpenMotzarim.Text = "מוצרים";
            this.btnOpenMotzarim.UseVisualStyleBackColor = false;
            this.btnOpenMotzarim.Click += new System.EventHandler(this.btnOpenMotzarim_Click);
            // 
            // btnOpenLkohot
            // 
            this.btnOpenLkohot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenLkohot.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOpenLkohot.Location = new System.Drawing.Point(1018, 963);
            this.btnOpenLkohot.Name = "btnOpenLkohot";
            this.btnOpenLkohot.Size = new System.Drawing.Size(245, 87);
            this.btnOpenLkohot.TabIndex = 3;
            this.btnOpenLkohot.Text = "לקוחות";
            this.btnOpenLkohot.UseVisualStyleBackColor = false;
            this.btnOpenLkohot.Click += new System.EventHandler(this.btnOpenLkohot_Click);
            // 
            // btnOpenSokhen
            // 
            this.btnOpenSokhen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenSokhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOpenSokhen.Location = new System.Drawing.Point(1018, 508);
            this.btnOpenSokhen.Name = "btnOpenSokhen";
            this.btnOpenSokhen.Size = new System.Drawing.Size(215, 87);
            this.btnOpenSokhen.TabIndex = 4;
            this.btnOpenSokhen.Text = "סוכנים";
            this.btnOpenSokhen.UseVisualStyleBackColor = false;
            this.btnOpenSokhen.Click += new System.EventHandler(this.btnOpenSokhen_Click);
            // 
            // btnopensp
            // 
            this.btnopensp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnopensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnopensp.Location = new System.Drawing.Point(1166, 220);
            this.btnopensp.Name = "btnopensp";
            this.btnopensp.Size = new System.Drawing.Size(215, 87);
            this.btnopensp.TabIndex = 5;
            this.btnopensp.Text = "ספקים";
            this.btnopensp.UseVisualStyleBackColor = false;
            this.btnopensp.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(-5, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 87);
            this.button1.TabIndex = 8;
            this.button1.Text = "מדפים";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1585, 989);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 67);
            this.button2.TabIndex = 9;
            this.button2.Text = "סגור";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(600, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 158);
            this.button3.TabIndex = 10;
            this.button3.Text = "דוח מכירות מספקים";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(1175, 747);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 112);
            this.button6.TabIndex = 13;
            this.button6.Text = "הזמהת סוכנים";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(538, 626);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(332, 87);
            this.button4.TabIndex = 14;
            this.button4.Text = "הזמנת ספקים";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(170, 951);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(255, 87);
            this.button5.TabIndex = 15;
            this.button5.Text = "החזרות";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1262, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 92.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 150);
            this.label3.TabIndex = 17;
            this.label3.Text = "extreme car";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(538, 812);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(332, 87);
            this.button7.TabIndex = 18;
            this.button7.Text = "דוח הזמנת לקוחות";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1725, 1062);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnopensp);
            this.Controls.Add(this.btnOpenSokhen);
            this.Controls.Add(this.btnOpenLkohot);
            this.Controls.Add(this.btnOpenMotzarim);
            this.Controls.Add(this.btnOpenOvdeem);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenOvdeem;
        private System.Windows.Forms.Button btnOpenMotzarim;
        private System.Windows.Forms.Button btnOpenLkohot;
        private System.Windows.Forms.Button btnOpenSokhen;
        private System.Windows.Forms.Button btnopensp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
    }
}