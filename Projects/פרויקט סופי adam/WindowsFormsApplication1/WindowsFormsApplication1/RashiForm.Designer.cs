namespace WindowsFormsApplication1
{
    partial class RashiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.hospitalDataSet = new WindowsFormsApplication1.HospitalDataSet();
            this.mishmarotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mishmarotTableAdapter = new WindowsFormsApplication1.HospitalDataSetTableAdapters.MishmarotTableAdapter();
            this.dataDoctorsNurses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBDoctorsNurses = new System.Windows.Forms.ProgressBar();
            this.doctorsNursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsNursesTableAdapter = new WindowsFormsApplication1.HospitalDataSetTableAdapters.DoctorsNursesTableAdapter();
            this.pnlDoctorsNurses = new System.Windows.Forms.Panel();
            this.lblDoctorsNurses = new System.Windows.Forms.Label();
            this.pnlInWork = new System.Windows.Forms.Panel();
            this.pnlOvdim = new System.Windows.Forms.Panel();
            this.dataOvdim = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBOvdim = new System.Windows.Forms.ProgressBar();
            this.lblOvdim = new System.Windows.Forms.Label();
            this.splHalf = new System.Windows.Forms.Splitter();
            this.splSeparate = new System.Windows.Forms.Splitter();
            this.ovdimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ovdimTableAdapter = new WindowsFormsApplication1.HospitalDataSetTableAdapters.OvdimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctorsNurses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsNursesBindingSource)).BeginInit();
            this.pnlDoctorsNurses.SuspendLayout();
            this.pnlInWork.SuspendLayout();
            this.pnlOvdim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOvdim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovdimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(811, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(207, 115);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "התחל משמרת";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.btnStop.Location = new System.Drawing.Point(316, 104);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(207, 115);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "סיים משמרת";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            // dataDoctorsNurses
            // 
            this.dataDoctorsNurses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDoctorsNurses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataDoctorsNurses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDoctorsNurses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDoctorsNurses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoctorsNurses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDoctorsNurses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDoctorsNurses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoctorsNurses.Location = new System.Drawing.Point(0, 49);
            this.dataDoctorsNurses.MultiSelect = false;
            this.dataDoctorsNurses.Name = "dataDoctorsNurses";
            this.dataDoctorsNurses.ReadOnly = true;
            this.dataDoctorsNurses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataDoctorsNurses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDoctorsNurses.Size = new System.Drawing.Size(678, 297);
            this.dataDoctorsNurses.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "תעודת זהות";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "שם";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "משפחה";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "התחיל";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // pBDoctorsNurses
            // 
            this.pBDoctorsNurses.BackColor = System.Drawing.Color.White;
            this.pBDoctorsNurses.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBDoctorsNurses.Location = new System.Drawing.Point(0, 41);
            this.pBDoctorsNurses.Name = "pBDoctorsNurses";
            this.pBDoctorsNurses.Size = new System.Drawing.Size(678, 8);
            this.pBDoctorsNurses.Step = 1;
            this.pBDoctorsNurses.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBDoctorsNurses.TabIndex = 4;
            // 
            // doctorsNursesBindingSource
            // 
            this.doctorsNursesBindingSource.DataMember = "DoctorsNurses";
            this.doctorsNursesBindingSource.DataSource = this.hospitalDataSet;
            // 
            // doctorsNursesTableAdapter
            // 
            this.doctorsNursesTableAdapter.ClearBeforeFill = true;
            // 
            // pnlDoctorsNurses
            // 
            this.pnlDoctorsNurses.Controls.Add(this.dataDoctorsNurses);
            this.pnlDoctorsNurses.Controls.Add(this.pBDoctorsNurses);
            this.pnlDoctorsNurses.Controls.Add(this.lblDoctorsNurses);
            this.pnlDoctorsNurses.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDoctorsNurses.Location = new System.Drawing.Point(686, 0);
            this.pnlDoctorsNurses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDoctorsNurses.Name = "pnlDoctorsNurses";
            this.pnlDoctorsNurses.Size = new System.Drawing.Size(678, 346);
            this.pnlDoctorsNurses.TabIndex = 5;
            // 
            // lblDoctorsNurses
            // 
            this.lblDoctorsNurses.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoctorsNurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDoctorsNurses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDoctorsNurses.Location = new System.Drawing.Point(0, 0);
            this.lblDoctorsNurses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorsNurses.Name = "lblDoctorsNurses";
            this.lblDoctorsNurses.Size = new System.Drawing.Size(678, 41);
            this.lblDoctorsNurses.TabIndex = 5;
            this.lblDoctorsNurses.Text = "label1";
            this.lblDoctorsNurses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInWork
            // 
            this.pnlInWork.Controls.Add(this.pnlOvdim);
            this.pnlInWork.Controls.Add(this.pnlDoctorsNurses);
            this.pnlInWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInWork.Location = new System.Drawing.Point(0, 376);
            this.pnlInWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlInWork.Name = "pnlInWork";
            this.pnlInWork.Size = new System.Drawing.Size(1364, 346);
            this.pnlInWork.TabIndex = 6;
            // 
            // pnlOvdim
            // 
            this.pnlOvdim.Controls.Add(this.dataOvdim);
            this.pnlOvdim.Controls.Add(this.pBOvdim);
            this.pnlOvdim.Controls.Add(this.lblOvdim);
            this.pnlOvdim.Controls.Add(this.splHalf);
            this.pnlOvdim.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOvdim.Location = new System.Drawing.Point(8, 0);
            this.pnlOvdim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOvdim.Name = "pnlOvdim";
            this.pnlOvdim.Size = new System.Drawing.Size(678, 346);
            this.pnlOvdim.TabIndex = 7;
            // 
            // dataOvdim
            // 
            this.dataOvdim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOvdim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataOvdim.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOvdim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataOvdim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOvdim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOvdim.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataOvdim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOvdim.Location = new System.Drawing.Point(0, 49);
            this.dataOvdim.MultiSelect = false;
            this.dataOvdim.Name = "dataOvdim";
            this.dataOvdim.ReadOnly = true;
            this.dataOvdim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataOvdim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOvdim.Size = new System.Drawing.Size(673, 297);
            this.dataOvdim.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "תעודת זהות";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "שם";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "משפחה";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "התחיל";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // pBOvdim
            // 
            this.pBOvdim.BackColor = System.Drawing.Color.White;
            this.pBOvdim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBOvdim.Location = new System.Drawing.Point(0, 41);
            this.pBOvdim.Name = "pBOvdim";
            this.pBOvdim.Size = new System.Drawing.Size(673, 8);
            this.pBOvdim.Step = 1;
            this.pBOvdim.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBOvdim.TabIndex = 4;
            // 
            // lblOvdim
            // 
            this.lblOvdim.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOvdim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOvdim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOvdim.Location = new System.Drawing.Point(0, 0);
            this.lblOvdim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOvdim.Name = "lblOvdim";
            this.lblOvdim.Size = new System.Drawing.Size(673, 41);
            this.lblOvdim.TabIndex = 5;
            this.lblOvdim.Text = "label2";
            this.lblOvdim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splHalf
            // 
            this.splHalf.BackColor = System.Drawing.Color.DimGray;
            this.splHalf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splHalf.Cursor = System.Windows.Forms.Cursors.Default;
            this.splHalf.Dock = System.Windows.Forms.DockStyle.Right;
            this.splHalf.Enabled = false;
            this.splHalf.Location = new System.Drawing.Point(673, 0);
            this.splHalf.Name = "splHalf";
            this.splHalf.Size = new System.Drawing.Size(5, 346);
            this.splHalf.TabIndex = 85;
            this.splHalf.TabStop = false;
            this.splHalf.Visible = false;
            // 
            // splSeparate
            // 
            this.splSeparate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splSeparate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splSeparate.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splSeparate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splSeparate.Enabled = false;
            this.splSeparate.Location = new System.Drawing.Point(0, 371);
            this.splSeparate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splSeparate.MinimumSize = new System.Drawing.Size(1126, 4);
            this.splSeparate.Name = "splSeparate";
            this.splSeparate.Size = new System.Drawing.Size(1364, 5);
            this.splSeparate.TabIndex = 109;
            this.splSeparate.TabStop = false;
            // 
            // ovdimBindingSource
            // 
            this.ovdimBindingSource.DataMember = "Ovdim";
            this.ovdimBindingSource.DataSource = this.hospitalDataSet;
            // 
            // ovdimTableAdapter
            // 
            this.ovdimTableAdapter.ClearBeforeFill = true;
            // 
            // RashiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 722);
            this.Controls.Add(this.splSeparate);
            this.Controls.Add(this.pnlInWork);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RashiForm";
            this.Text = "RashiForm";
            this.Load += new System.EventHandler(this.RashiForm_Load);
            this.SizeChanged += new System.EventHandler(this.RashiForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctorsNurses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsNursesBindingSource)).EndInit();
            this.pnlDoctorsNurses.ResumeLayout(false);
            this.pnlInWork.ResumeLayout(false);
            this.pnlOvdim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOvdim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovdimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource mishmarotBindingSource;
        private HospitalDataSetTableAdapters.MishmarotTableAdapter mishmarotTableAdapter;
        private System.Windows.Forms.DataGridView dataDoctorsNurses;
        private System.Windows.Forms.ProgressBar pBDoctorsNurses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.BindingSource doctorsNursesBindingSource;
        private HospitalDataSetTableAdapters.DoctorsNursesTableAdapter doctorsNursesTableAdapter;
        private System.Windows.Forms.Panel pnlDoctorsNurses;
        private System.Windows.Forms.Label lblDoctorsNurses;
        private System.Windows.Forms.Panel pnlInWork;
        private System.Windows.Forms.Panel pnlOvdim;
        private System.Windows.Forms.Label lblOvdim;
        private System.Windows.Forms.ProgressBar pBOvdim;
        private System.Windows.Forms.Splitter splHalf;
        private System.Windows.Forms.Splitter splSeparate;
        private System.Windows.Forms.BindingSource ovdimBindingSource;
        private HospitalDataSetTableAdapters.OvdimTableAdapter ovdimTableAdapter;
        private System.Windows.Forms.DataGridView dataOvdim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}