namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblWel = new System.Windows.Forms.Label();
            this.lblHide = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.splUpperTitle = new System.Windows.Forms.Splitter();
            this.splLowerTitle = new System.Windows.Forms.Splitter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splHeader = new System.Windows.Forms.Splitter();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.splMenu = new System.Windows.Forms.Splitter();
            this.btnHazmanot = new System.Windows.Forms.Button();
            this.btnSpak = new System.Windows.Forms.Button();
            this.btnTsyod = new System.Windows.Forms.Button();
            this.btnMishmarot = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnOvdim = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnRashi = new System.Windows.Forms.Button();
            this.splInfo = new System.Windows.Forms.Splitter();
            this.pnlInMenu = new System.Windows.Forms.Panel();
            this.lblRights = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.hospitalDataSet = new WindowsFormsApplication1.HospitalDataSet();
            this.mishmarotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mishmarotTableAdapter = new WindowsFormsApplication1.HospitalDataSetTableAdapters.MishmarotTableAdapter();
            this.pnlHeader.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlInMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Controls.Add(this.btnDisconnect);
            this.pnlHeader.Controls.Add(this.lblWel);
            this.pnlHeader.Controls.Add(this.lblHide);
            this.pnlHeader.Controls.Add(this.lblSize);
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Controls.Add(this.lblClock);
            this.pnlHeader.Controls.Add(this.pnlTitle);
            this.pnlHeader.Controls.Add(this.splHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(1027, 116);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1370, 116);
            this.pnlHeader.TabIndex = 7;
            this.pnlHeader.DoubleClick += new System.EventHandler(this.HeaderPnl_DoubleClick);
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPnl_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPnl_MouseMove);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDisconnect.Location = new System.Drawing.Point(872, 9);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(66, 30);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "התנתק";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblWel
            // 
            this.lblWel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWel.ForeColor = System.Drawing.Color.DimGray;
            this.lblWel.Location = new System.Drawing.Point(589, 9);
            this.lblWel.Name = "lblWel";
            this.lblWel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWel.Size = new System.Drawing.Size(279, 30);
            this.lblWel.TabIndex = 1;
            this.lblWel.Text = "שלום";
            this.lblWel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHide.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblHide.Location = new System.Drawing.Point(60, 0);
            this.lblHide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(21, 29);
            this.lblHide.TabIndex = 1;
            this.lblHide.Text = "🗕";
            this.lblHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHide.Click += new System.EventHandler(this.lblHide_Click);
            this.lblHide.MouseEnter += new System.EventHandler(this.lblHide_MouseEnter);
            this.lblHide.MouseLeave += new System.EventHandler(this.lblHide_MouseLeave);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSize.Location = new System.Drawing.Point(39, 0);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(21, 30);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "🗖";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            this.lblSize.MouseEnter += new System.EventHandler(this.lblSize_MouseEnter);
            this.lblSize.MouseLeave += new System.EventHandler(this.lblSize_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblClose.Location = new System.Drawing.Point(0, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(39, 30);
            this.lblClose.TabIndex = 0;
            this.lblClose.Tag = "";
            this.lblClose.Text = "  x";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClock.ForeColor = System.Drawing.Color.DimGray;
            this.lblClock.Location = new System.Drawing.Point(0, 90);
            this.lblClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClock.Size = new System.Drawing.Size(944, 24);
            this.lblClock.TabIndex = 10;
            this.lblClock.Text = "סטטוס";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlTitle.Controls.Add(this.splUpperTitle);
            this.pnlTitle.Controls.Add(this.splLowerTitle);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTitle.Location = new System.Drawing.Point(944, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(426, 114);
            this.pnlTitle.TabIndex = 4;
            // 
            // splUpperTitle
            // 
            this.splUpperTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.splUpperTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.splUpperTitle.Location = new System.Drawing.Point(0, 0);
            this.splUpperTitle.Name = "splUpperTitle";
            this.splUpperTitle.Size = new System.Drawing.Size(426, 39);
            this.splUpperTitle.TabIndex = 5;
            this.splUpperTitle.TabStop = false;
            // 
            // splLowerTitle
            // 
            this.splLowerTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.splLowerTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splLowerTitle.Location = new System.Drawing.Point(0, 77);
            this.splLowerTitle.Name = "splLowerTitle";
            this.splLowerTitle.Size = new System.Drawing.Size(426, 37);
            this.splLowerTitle.TabIndex = 4;
            this.splLowerTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(426, 114);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "מערכת ניהול בית חולים";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splHeader
            // 
            this.splHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.splHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splHeader.Location = new System.Drawing.Point(0, 114);
            this.splHeader.Margin = new System.Windows.Forms.Padding(2);
            this.splHeader.Name = "splHeader";
            this.splHeader.Size = new System.Drawing.Size(1370, 2);
            this.splHeader.TabIndex = 9;
            this.splHeader.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.splMenu);
            this.pnlMenu.Controls.Add(this.btnHazmanot);
            this.pnlMenu.Controls.Add(this.btnSpak);
            this.pnlMenu.Controls.Add(this.btnTsyod);
            this.pnlMenu.Controls.Add(this.btnMishmarot);
            this.pnlMenu.Controls.Add(this.splitter3);
            this.pnlMenu.Controls.Add(this.btnDoctors);
            this.pnlMenu.Controls.Add(this.btnOvdim);
            this.pnlMenu.Controls.Add(this.splitter1);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.splitter2);
            this.pnlMenu.Controls.Add(this.btnRashi);
            this.pnlMenu.Controls.Add(this.splInfo);
            this.pnlMenu.Controls.Add(this.pnlInMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(1186, 116);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(184, 662);
            this.pnlMenu.TabIndex = 6;
            // 
            // splMenu
            // 
            this.splMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.splMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.splMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.splMenu.Location = new System.Drawing.Point(0, 395);
            this.splMenu.Margin = new System.Windows.Forms.Padding(2);
            this.splMenu.Name = "splMenu";
            this.splMenu.Size = new System.Drawing.Size(184, 2);
            this.splMenu.TabIndex = 17;
            this.splMenu.TabStop = false;
            // 
            // btnHazmanot
            // 
            this.btnHazmanot.AccessibleDescription = "";
            this.btnHazmanot.AccessibleName = "";
            this.btnHazmanot.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHazmanot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHazmanot.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnHazmanot.FlatAppearance.BorderSize = 0;
            this.btnHazmanot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHazmanot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnHazmanot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHazmanot.Location = new System.Drawing.Point(0, 344);
            this.btnHazmanot.Margin = new System.Windows.Forms.Padding(2);
            this.btnHazmanot.Name = "btnHazmanot";
            this.btnHazmanot.Size = new System.Drawing.Size(184, 51);
            this.btnHazmanot.TabIndex = 11;
            this.btnHazmanot.Text = "הזמנות וטיפולים";
            this.btnHazmanot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHazmanot.UseVisualStyleBackColor = false;
            this.btnHazmanot.Click += new System.EventHandler(this.btnHazmanot_Click);
            // 
            // btnSpak
            // 
            this.btnSpak.AccessibleDescription = "";
            this.btnSpak.AccessibleName = "";
            this.btnSpak.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSpak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpak.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSpak.FlatAppearance.BorderSize = 0;
            this.btnSpak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSpak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpak.Location = new System.Drawing.Point(0, 293);
            this.btnSpak.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpak.Name = "btnSpak";
            this.btnSpak.Size = new System.Drawing.Size(184, 51);
            this.btnSpak.TabIndex = 10;
            this.btnSpak.Text = "ספק";
            this.btnSpak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpak.UseVisualStyleBackColor = false;
            this.btnSpak.Click += new System.EventHandler(this.btnSpak_Click);
            // 
            // btnTsyod
            // 
            this.btnTsyod.AccessibleDescription = "";
            this.btnTsyod.AccessibleName = "";
            this.btnTsyod.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTsyod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTsyod.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnTsyod.FlatAppearance.BorderSize = 0;
            this.btnTsyod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTsyod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnTsyod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTsyod.Location = new System.Drawing.Point(0, 242);
            this.btnTsyod.Margin = new System.Windows.Forms.Padding(2);
            this.btnTsyod.Name = "btnTsyod";
            this.btnTsyod.Size = new System.Drawing.Size(184, 51);
            this.btnTsyod.TabIndex = 9;
            this.btnTsyod.Text = "ציוד";
            this.btnTsyod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTsyod.UseVisualStyleBackColor = false;
            this.btnTsyod.Click += new System.EventHandler(this.btnTsyod_Click);
            // 
            // btnMishmarot
            // 
            this.btnMishmarot.AccessibleDescription = "";
            this.btnMishmarot.AccessibleName = "";
            this.btnMishmarot.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMishmarot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMishmarot.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnMishmarot.FlatAppearance.BorderSize = 0;
            this.btnMishmarot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMishmarot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMishmarot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMishmarot.Location = new System.Drawing.Point(0, 191);
            this.btnMishmarot.Margin = new System.Windows.Forms.Padding(2);
            this.btnMishmarot.Name = "btnMishmarot";
            this.btnMishmarot.Size = new System.Drawing.Size(184, 51);
            this.btnMishmarot.TabIndex = 4;
            this.btnMishmarot.Text = "משמרות";
            this.btnMishmarot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMishmarot.UseVisualStyleBackColor = false;
            this.btnMishmarot.Click += new System.EventHandler(this.btnMishmarot_Click);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.Window;
            this.splitter3.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(0, 189);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(184, 2);
            this.splitter3.TabIndex = 21;
            this.splitter3.TabStop = false;
            // 
            // btnDoctors
            // 
            this.btnDoctors.AccessibleDescription = "";
            this.btnDoctors.AccessibleName = "";
            this.btnDoctors.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctors.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnDoctors.FlatAppearance.BorderSize = 0;
            this.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDoctors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoctors.Location = new System.Drawing.Point(0, 138);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(184, 51);
            this.btnDoctors.TabIndex = 3;
            this.btnDoctors.Text = "רופאים/ות אחים/ות";
            this.btnDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoctors.UseVisualStyleBackColor = false;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnOvdim
            // 
            this.btnOvdim.AccessibleDescription = "";
            this.btnOvdim.AccessibleName = "";
            this.btnOvdim.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOvdim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOvdim.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnOvdim.FlatAppearance.BorderSize = 0;
            this.btnOvdim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOvdim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOvdim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOvdim.Location = new System.Drawing.Point(0, 87);
            this.btnOvdim.Margin = new System.Windows.Forms.Padding(2);
            this.btnOvdim.Name = "btnOvdim";
            this.btnOvdim.Size = new System.Drawing.Size(184, 51);
            this.btnOvdim.TabIndex = 2;
            this.btnOvdim.Text = "עובדי תחזוקה ונקיון";
            this.btnOvdim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOvdim.UseVisualStyleBackColor = false;
            this.btnOvdim.Click += new System.EventHandler(this.btnOvdim_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Window;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 85);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(184, 2);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "עובדים";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Window;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(0, 51);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(184, 2);
            this.splitter2.TabIndex = 20;
            this.splitter2.TabStop = false;
            // 
            // btnRashi
            // 
            this.btnRashi.AccessibleDescription = "";
            this.btnRashi.AccessibleName = "";
            this.btnRashi.BackColor = System.Drawing.Color.Orange;
            this.btnRashi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRashi.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnRashi.FlatAppearance.BorderSize = 0;
            this.btnRashi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRashi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRashi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRashi.Location = new System.Drawing.Point(0, 0);
            this.btnRashi.Margin = new System.Windows.Forms.Padding(2);
            this.btnRashi.Name = "btnRashi";
            this.btnRashi.Size = new System.Drawing.Size(184, 51);
            this.btnRashi.TabIndex = 1;
            this.btnRashi.Text = " ראשי";
            this.btnRashi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRashi.UseVisualStyleBackColor = false;
            this.btnRashi.Click += new System.EventHandler(this.btnRashi_Click);
            // 
            // splInfo
            // 
            this.splInfo.BackColor = System.Drawing.Color.DimGray;
            this.splInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splInfo.Location = new System.Drawing.Point(0, 603);
            this.splInfo.Margin = new System.Windows.Forms.Padding(2);
            this.splInfo.Name = "splInfo";
            this.splInfo.Size = new System.Drawing.Size(184, 2);
            this.splInfo.TabIndex = 16;
            this.splInfo.TabStop = false;
            // 
            // pnlInMenu
            // 
            this.pnlInMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlInMenu.Controls.Add(this.lblRights);
            this.pnlInMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInMenu.Location = new System.Drawing.Point(0, 605);
            this.pnlInMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInMenu.Name = "pnlInMenu";
            this.pnlInMenu.Size = new System.Drawing.Size(184, 57);
            this.pnlInMenu.TabIndex = 8;
            // 
            // lblRights
            // 
            this.lblRights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRights.Location = new System.Drawing.Point(0, 0);
            this.lblRights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRights.Name = "lblRights";
            this.lblRights.Size = new System.Drawing.Size(184, 57);
            this.lblRights.TabIndex = 7;
            this.lblRights.Text = "© YEAR";
            this.lblRights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.ForeColor = System.Drawing.Color.Black;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 116);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1186, 662);
            this.pnlDisplay.TabIndex = 8;
            this.pnlDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDisplay_Paint);
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mishmarotBindingSource
            // 
            this.mishmarotBindingSource.DataMember = "Mishmarot";
            this.mishmarotBindingSource.DataSource = this.hospitalDataSet;
            // 
            // mishmarotTableAdapter
            // 
            this.mishmarotTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 778);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1358, 726);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlInMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnDisconnect;
        public System.Windows.Forms.Label lblWel;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Splitter splHeader;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Splitter splMenu;
        private System.Windows.Forms.Splitter splInfo;
        private System.Windows.Forms.Button btnHazmanot;
        private System.Windows.Forms.Button btnSpak;
        private System.Windows.Forms.Button btnTsyod;
        private System.Windows.Forms.Button btnMishmarot;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnOvdim;
        private System.Windows.Forms.Button btnRashi;
        private System.Windows.Forms.Panel pnlInMenu;
        private System.Windows.Forms.Label lblRights;
        private System.Windows.Forms.Splitter splUpperTitle;
        private System.Windows.Forms.Splitter splLowerTitle;
        public System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource mishmarotBindingSource;
        private HospitalDataSetTableAdapters.MishmarotTableAdapter mishmarotTableAdapter;
        public System.Windows.Forms.Timer clock;
        public System.Windows.Forms.Label lblClock;

    }
}