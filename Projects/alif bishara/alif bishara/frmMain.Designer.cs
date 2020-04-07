namespace alif_bishara
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnKabla = new System.Windows.Forms.Button();
            this.btnKors = new System.Windows.Forms.Button();
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnKabla);
            this.panel1.Controls.Add(this.btnKors);
            this.panel1.Controls.Add(this.buttonTeacher);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 49);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1190, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 42);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(921, 7);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(213, 39);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "תלמידים";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnKabla
            // 
            this.btnKabla.Location = new System.Drawing.Point(107, 7);
            this.btnKabla.Name = "btnKabla";
            this.btnKabla.Size = new System.Drawing.Size(246, 39);
            this.btnKabla.TabIndex = 2;
            this.btnKabla.Text = "קבלות";
            this.btnKabla.UseVisualStyleBackColor = true;
            this.btnKabla.Click += new System.EventHandler(this.btnKabla_Click);
            // 
            // btnKors
            // 
            this.btnKors.Location = new System.Drawing.Point(655, 7);
            this.btnKors.Name = "btnKors";
            this.btnKors.Size = new System.Drawing.Size(243, 39);
            this.btnKors.TabIndex = 1;
            this.btnKors.Text = "קורסים";
            this.btnKors.UseVisualStyleBackColor = true;
            this.btnKors.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.Location = new System.Drawing.Point(375, 7);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(254, 39);
            this.buttonTeacher.TabIndex = 0;
            this.buttonTeacher.Text = "מורים";
            this.buttonTeacher.UseVisualStyleBackColor = true;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMain.Location = new System.Drawing.Point(1, 54);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1290, 590);
            this.panelMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 578);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnKabla;
        private System.Windows.Forms.Button btnKors;
        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Panel panelMain;
    }
}