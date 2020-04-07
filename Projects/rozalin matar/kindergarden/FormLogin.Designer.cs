namespace kindergarden
{
    partial class FormLogin
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
        /// Required method for Designer support - do not Modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btm_save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.timerBlock = new System.Windows.Forms.Timer(this.components);
            this.lbl_timeLeft = new System.Windows.Forms.Label();
            this.cb_showP = new System.Windows.Forms.CheckBox();
            this.kindergardenDataSet = new kindergarden.kindergardenDataSet();
            this.metaplotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metaplotTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.metaplotTableAdapter();
            this.pnl_Move = new System.Windows.Forms.Panel();
            this.lbl_hide = new System.Windows.Forms.Label();
            this.lbl_mustPassword = new System.Windows.Forms.Label();
            this.lbl_mustUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaplotBindingSource)).BeginInit();
            this.pnl_Move.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_login.Font = new System.Drawing.Font("Narkisim", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_login.Location = new System.Drawing.Point(172, 39);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(79, 32);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "login";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_username.Location = new System.Drawing.Point(66, 99);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(70, 16);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_password.Location = new System.Drawing.Point(66, 139);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(63, 16);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_username.Location = new System.Drawing.Point(178, 96);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_password.Location = new System.Drawing.Point(177, 136);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btm_save
            // 
            this.btm_save.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btm_save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btm_save.Location = new System.Drawing.Point(105, 202);
            this.btm_save.Name = "btm_save";
            this.btm_save.Size = new System.Drawing.Size(81, 31);
            this.btm_save.TabIndex = 5;
            this.btm_save.Text = "Login";
            this.btm_save.UseVisualStyleBackColor = true;
            this.btm_save.Click += new System.EventHandler(this.btm_save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exit.Location = new System.Drawing.Point(237, 202);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 31);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // timerBlock
            // 
            this.timerBlock.Interval = 1000;
            this.timerBlock.Tick += new System.EventHandler(this.timerBlock_Tick);
            // 
            // lbl_timeLeft
            // 
            this.lbl_timeLeft.AutoSize = true;
            this.lbl_timeLeft.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_timeLeft.Location = new System.Drawing.Point(192, 204);
            this.lbl_timeLeft.Name = "lbl_timeLeft";
            this.lbl_timeLeft.Size = new System.Drawing.Size(50, 19);
            this.lbl_timeLeft.TabIndex = 7;
            this.lbl_timeLeft.Text = "label2";
            this.lbl_timeLeft.Visible = false;
            // 
            // cb_showP
            // 
            this.cb_showP.AutoSize = true;
            this.cb_showP.Font = new System.Drawing.Font("Narkisim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cb_showP.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_showP.Location = new System.Drawing.Point(177, 162);
            this.cb_showP.Name = "cb_showP";
            this.cb_showP.Size = new System.Drawing.Size(96, 16);
            this.cb_showP.TabIndex = 9;
            this.cb_showP.Text = "Show password";
            this.cb_showP.UseVisualStyleBackColor = true;
            this.cb_showP.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // kindergardenDataSet
            // 
            this.kindergardenDataSet.DataSetName = "kindergardenDataSet";
            this.kindergardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metaplotBindingSource
            // 
            this.metaplotBindingSource.DataMember = "metaplot";
            this.metaplotBindingSource.DataSource = this.kindergardenDataSet;
            // 
            // metaplotTableAdapter
            // 
            this.metaplotTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_Move
            // 
            this.pnl_Move.Controls.Add(this.lbl_hide);
            this.pnl_Move.Controls.Add(this.lbl_mustPassword);
            this.pnl_Move.Controls.Add(this.lbl_mustUsername);
            this.pnl_Move.Controls.Add(this.lbl_login);
            this.pnl_Move.Controls.Add(this.cb_showP);
            this.pnl_Move.Controls.Add(this.lbl_username);
            this.pnl_Move.Controls.Add(this.lbl_timeLeft);
            this.pnl_Move.Controls.Add(this.lbl_password);
            this.pnl_Move.Controls.Add(this.btn_Exit);
            this.pnl_Move.Controls.Add(this.txt_username);
            this.pnl_Move.Controls.Add(this.btm_save);
            this.pnl_Move.Controls.Add(this.txt_password);
            this.pnl_Move.Location = new System.Drawing.Point(0, 3);
            this.pnl_Move.Name = "pnl_Move";
            this.pnl_Move.Size = new System.Drawing.Size(440, 285);
            this.pnl_Move.TabIndex = 10;
            this.pnl_Move.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Move_Paint);
            this.pnl_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseDown);
            this.pnl_Move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseMove);
            // 
            // lbl_hide
            // 
            this.lbl_hide.AutoSize = true;
            this.lbl_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_hide.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_hide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_hide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_hide.Location = new System.Drawing.Point(0, 0);
            this.lbl_hide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hide.Name = "lbl_hide";
            this.lbl_hide.Size = new System.Drawing.Size(29, 29);
            this.lbl_hide.TabIndex = 13;
            this.lbl_hide.Text = " -";
            this.lbl_hide.Click += new System.EventHandler(this.lbl_hide_Click);
            this.lbl_hide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_hide_MouseDown);
            this.lbl_hide.MouseEnter += new System.EventHandler(this.lbl_hide_MouseEnter);
            this.lbl_hide.MouseLeave += new System.EventHandler(this.lbl_hide_MouseLeave);
            // 
            // lbl_mustPassword
            // 
            this.lbl_mustPassword.AutoSize = true;
            this.lbl_mustPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_mustPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_mustPassword.Location = new System.Drawing.Point(283, 136);
            this.lbl_mustPassword.Name = "lbl_mustPassword";
            this.lbl_mustPassword.Size = new System.Drawing.Size(17, 24);
            this.lbl_mustPassword.TabIndex = 11;
            this.lbl_mustPassword.Text = "*";
            this.lbl_mustPassword.Visible = false;
            // 
            // lbl_mustUsername
            // 
            this.lbl_mustUsername.AutoSize = true;
            this.lbl_mustUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_mustUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_mustUsername.Location = new System.Drawing.Point(283, 96);
            this.lbl_mustUsername.Name = "lbl_mustUsername";
            this.lbl_mustUsername.Size = new System.Drawing.Size(17, 24);
            this.lbl_mustUsername.TabIndex = 10;
            this.lbl_mustUsername.Text = "*";
            this.lbl_mustUsername.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.pnl_Move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaplotBindingSource)).EndInit();
            this.pnl_Move.ResumeLayout(false);
            this.pnl_Move.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btm_save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Timer timerBlock;
        private System.Windows.Forms.Label lbl_timeLeft;
        private System.Windows.Forms.CheckBox cb_showP;
        private kindergardenDataSet kindergardenDataSet;
        private System.Windows.Forms.BindingSource metaplotBindingSource;
        private kindergardenDataSetTableAdapters.metaplotTableAdapter metaplotTableAdapter;
        private System.Windows.Forms.Panel pnl_Move;
        private System.Windows.Forms.Label lbl_mustPassword;
        private System.Windows.Forms.Label lbl_mustUsername;
        private System.Windows.Forms.Label lbl_hide;
    }
}