namespace DarQuran
{
    partial class Login
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labeltimer = new System.Windows.Forms.Label();
            this.buttonIN = new System.Windows.Forms.Button();
            this.buttonOUT = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerhasima = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLogin.Location = new System.Drawing.Point(85, 34);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(242, 54);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "تسجيل الدخول";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUser.Location = new System.Drawing.Point(248, 132);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(124, 29);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "اسم المستخدم";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPassword.Location = new System.Drawing.Point(275, 186);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 29);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "كلمة السر";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(105, 140);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(135, 22);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(105, 186);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(135, 22);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.Aqua;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(58, 184);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(39, 24);
            this.buttonShow.TabIndex = 39;
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labeltimer
            // 
            this.labeltimer.AutoSize = true;
            this.labeltimer.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimer.Location = new System.Drawing.Point(257, 231);
            this.labeltimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltimer.Name = "labeltimer";
            this.labeltimer.Size = new System.Drawing.Size(94, 44);
            this.labeltimer.TabIndex = 38;
            this.labeltimer.Text = "timer";
            // 
            // buttonIN
            // 
            this.buttonIN.BackColor = System.Drawing.Color.Lime;
            this.buttonIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIN.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIN.Location = new System.Drawing.Point(121, 221);
            this.buttonIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIN.Name = "buttonIN";
            this.buttonIN.Size = new System.Drawing.Size(100, 62);
            this.buttonIN.TabIndex = 37;
            this.buttonIN.Text = "دخول";
            this.buttonIN.UseVisualStyleBackColor = false;
            this.buttonIN.Click += new System.EventHandler(this.buttonIN_Click);
            // 
            // buttonOUT
            // 
            this.buttonOUT.BackColor = System.Drawing.Color.Red;
            this.buttonOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOUT.Location = new System.Drawing.Point(13, 221);
            this.buttonOUT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOUT.Name = "buttonOUT";
            this.buttonOUT.Size = new System.Drawing.Size(100, 62);
            this.buttonOUT.TabIndex = 36;
            this.buttonOUT.Text = "خروج";
            this.buttonOUT.UseVisualStyleBackColor = false;
            this.buttonOUT.Click += new System.EventHandler(this.buttonOUT_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(235, 352);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(55, 25);
            this.labelTime.TabIndex = 41;
            this.labelTime.Text = "time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.White;
            this.labelDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(27, 352);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 25);
            this.labelDate.TabIndex = 40;
            this.labelDate.Text = "date";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerhasima
            // 
            this.timerhasima.Interval = 1000;
            this.timerhasima.Tick += new System.EventHandler(this.timerhasima_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 443);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labeltimer);
            this.Controls.Add(this.buttonIN);
            this.Controls.Add(this.buttonOUT);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labeltimer;
        private System.Windows.Forms.Button buttonIN;
        private System.Windows.Forms.Button buttonOUT;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerhasima;
    }
}

