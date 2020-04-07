namespace WindowsFormsApplication1
{
    partial class EnterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.PassPnl = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.hintPass = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.PassSpl = new System.Windows.Forms.Splitter();
            this.UserPnl = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.hintUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.UserSpl = new System.Windows.Forms.Splitter();
            this.btnEnter = new System.Windows.Forms.Button();
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.lblHide = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.HeaderSpl = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.PassPnl.SuspendLayout();
            this.UserPnl.SuspendLayout();
            this.HeaderPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Name = "panel1";
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPass.Name = "txtPass";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnShow.Image = global::WindowsFormsApplication1.Properties.Resources._52882;
            this.btnShow.Name = "btnShow";
            this.btnShow.TabStop = false;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseDown);
            this.btnShow.MouseLeave += new System.EventHandler(this.btnShow_MouseLeave);
            this.btnShow.MouseHover += new System.EventHandler(this.btnShow_MouseHover);
            this.btnShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseUp);
            // 
            // PassPnl
            // 
            this.PassPnl.Controls.Add(this.panel1);
            this.PassPnl.Controls.Add(this.splitter2);
            this.PassPnl.Controls.Add(this.hintPass);
            this.PassPnl.Controls.Add(this.lblPass);
            this.PassPnl.Controls.Add(this.PassSpl);
            resources.ApplyResources(this.PassPnl, "PassPnl");
            this.PassPnl.Name = "PassPnl";
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // hintPass
            // 
            resources.ApplyResources(this.hintPass, "hintPass");
            this.hintPass.ForeColor = System.Drawing.Color.Red;
            this.hintPass.Name = "hintPass";
            // 
            // lblPass
            // 
            resources.ApplyResources(this.lblPass, "lblPass");
            this.lblPass.Name = "lblPass";
            // 
            // PassSpl
            // 
            this.PassSpl.BackColor = System.Drawing.SystemColors.Window;
            this.PassSpl.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.PassSpl, "PassSpl");
            this.PassSpl.Name = "PassSpl";
            this.PassSpl.TabStop = false;
            // 
            // UserPnl
            // 
            this.UserPnl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserPnl.Controls.Add(this.txtUser);
            this.UserPnl.Controls.Add(this.hintUser);
            this.UserPnl.Controls.Add(this.lblUser);
            this.UserPnl.Controls.Add(this.UserSpl);
            resources.ApplyResources(this.UserPnl, "UserPnl");
            this.UserPnl.Name = "UserPnl";
            // 
            // txtUser
            // 
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUser.Name = "txtUser";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // hintUser
            // 
            resources.ApplyResources(this.hintUser, "hintUser");
            this.hintUser.ForeColor = System.Drawing.Color.Red;
            this.hintUser.Name = "hintUser";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.Name = "lblUser";
            // 
            // UserSpl
            // 
            this.UserSpl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserSpl.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.UserSpl, "UserSpl");
            this.UserSpl.Name = "UserSpl";
            this.UserSpl.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnEnter, "btnEnter");
            this.btnEnter.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            this.btnEnter.Enter += new System.EventHandler(this.btnEnter_Enter);
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.BackColor = System.Drawing.SystemColors.Menu;
            this.HeaderPnl.Controls.Add(this.lblHide);
            this.HeaderPnl.Controls.Add(this.lblHeader);
            this.HeaderPnl.Controls.Add(this.lblClose);
            this.HeaderPnl.Controls.Add(this.HeaderSpl);
            resources.ApplyResources(this.HeaderPnl, "HeaderPnl");
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPnl_MouseDown);
            this.HeaderPnl.MouseEnter += new System.EventHandler(this.HeaderPnl_MouseEnter);
            this.HeaderPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPnl_MouseMove);
            // 
            // lblHide
            // 
            resources.ApplyResources(this.lblHide, "lblHide");
            this.lblHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblHide.Name = "lblHide";
            this.lblHide.Click += new System.EventHandler(this.lblHide_Click);
            this.lblHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHide_MouseDown);
            this.lblHide.MouseEnter += new System.EventHandler(this.lblHide_MouseEnter);
            this.lblHide.MouseLeave += new System.EventHandler(this.lblHide_MouseLeave);
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeader.Name = "lblHeader";
            // 
            // lblClose
            // 
            resources.ApplyResources(this.lblClose, "lblClose");
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblClose.Name = "lblClose";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblClose_MouseDown);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // HeaderSpl
            // 
            this.HeaderSpl.BackColor = System.Drawing.Color.DarkOrange;
            this.HeaderSpl.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.HeaderSpl, "HeaderSpl");
            this.HeaderSpl.Name = "HeaderSpl";
            this.HeaderSpl.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Window;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // EnterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ControlBox = false;
            this.Controls.Add(this.PassPnl);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.UserPnl);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.HeaderPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterForm";
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PassPnl.ResumeLayout(false);
            this.PassPnl.PerformLayout();
            this.UserPnl.ResumeLayout(false);
            this.UserPnl.PerformLayout();
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label hintUser;
        private System.Windows.Forms.Label hintPass;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel PassPnl;
        private System.Windows.Forms.Panel UserPnl;
        private System.Windows.Forms.Splitter PassSpl;
        private System.Windows.Forms.Splitter UserSpl;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Splitter HeaderSpl;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;

    }
}

