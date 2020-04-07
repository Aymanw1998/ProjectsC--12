namespace WindowsFormsApplication1
{
    partial class EnterWorkForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblWel = new System.Windows.Forms.Label();
            this.lblHide = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.HeaderSpl = new System.Windows.Forms.Splitter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mishmarotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new WindowsFormsApplication1.HospitalDataSet();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.mishmarotTableAdapter = new WindowsFormsApplication1.HospitalDataSetTableAdapters.MishmarotTableAdapter();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.HeaderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.BackColor = System.Drawing.SystemColors.Menu;
            this.HeaderPnl.Controls.Add(this.btnDisconnect);
            this.HeaderPnl.Controls.Add(this.lblWel);
            this.HeaderPnl.Controls.Add(this.lblHide);
            this.HeaderPnl.Controls.Add(this.lblClose);
            this.HeaderPnl.Controls.Add(this.lblClock);
            this.HeaderPnl.Controls.Add(this.lblHeader);
            this.HeaderPnl.Controls.Add(this.HeaderSpl);
            this.HeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPnl.Location = new System.Drawing.Point(0, 0);
            this.HeaderPnl.Margin = new System.Windows.Forms.Padding(2);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(811, 90);
            this.HeaderPnl.TabIndex = 9;
            this.HeaderPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPnl_MouseDown);
            this.HeaderPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPnl_MouseMove);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDisconnect.Location = new System.Drawing.Point(583, 11);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(66, 30);
            this.btnDisconnect.TabIndex = 12;
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
            this.lblWel.Location = new System.Drawing.Point(300, 11);
            this.lblWel.Name = "lblWel";
            this.lblWel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWel.Size = new System.Drawing.Size(279, 30);
            this.lblWel.TabIndex = 13;
            this.lblWel.Text = "שלום";
            this.lblWel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHide.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblHide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblHide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHide.Location = new System.Drawing.Point(36, 0);
            this.lblHide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(29, 29);
            this.lblHide.TabIndex = 9;
            this.lblHide.Text = " -";
            this.lblHide.Click += new System.EventHandler(this.lblHide_Click);
            this.lblHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHide_MouseDown);
            this.lblHide.MouseEnter += new System.EventHandler(this.lblHide_MouseEnter);
            this.lblHide.MouseLeave += new System.EventHandler(this.lblHide_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClose.Location = new System.Drawing.Point(0, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(36, 29);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "  x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblClose_MouseDown);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.SystemColors.Menu;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClock.ForeColor = System.Drawing.Color.DimGray;
            this.lblClock.Location = new System.Drawing.Point(0, 64);
            this.lblClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClock.Size = new System.Drawing.Size(664, 24);
            this.lblClock.TabIndex = 11;
            this.lblClock.Text = "סטטוס";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(664, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHeader.Size = new System.Drawing.Size(147, 88);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "כניסה למשמרת";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderSpl
            // 
            this.HeaderSpl.BackColor = System.Drawing.Color.DarkOrange;
            this.HeaderSpl.Cursor = System.Windows.Forms.Cursors.Default;
            this.HeaderSpl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HeaderSpl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HeaderSpl.Location = new System.Drawing.Point(0, 88);
            this.HeaderSpl.Margin = new System.Windows.Forms.Padding(2);
            this.HeaderSpl.Name = "HeaderSpl";
            this.HeaderSpl.Size = new System.Drawing.Size(811, 2);
            this.HeaderSpl.TabIndex = 10;
            this.HeaderSpl.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 90);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(811, 243);
            this.dataGridView.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "תעודת זהות";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "התחחלת משמרת";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "סיום משמרת";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // mishmarotBindingSource
            // 
            this.mishmarotBindingSource.DataMember = "Mishmarot";
            this.mishmarotBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(147, 389);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(207, 115);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "סיים משמרת";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(442, 389);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(207, 115);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "התחל משמרת";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mishmarotTableAdapter
            // 
            this.mishmarotTableAdapter.ClearBeforeFill = true;
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // EnterWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 569);
            this.ControlBox = false;
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.HeaderPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EnterWorkForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EnterWorkForm_Load);
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Splitter HeaderSpl;
        public System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource mishmarotBindingSource;
        private HospitalDataSetTableAdapters.MishmarotTableAdapter mishmarotTableAdapter;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button btnDisconnect;
        public System.Windows.Forms.Label lblWel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}