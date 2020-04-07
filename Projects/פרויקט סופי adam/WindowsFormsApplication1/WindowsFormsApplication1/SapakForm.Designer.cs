﻿namespace WindowsFormsApplication1
{
    partial class SapakForm
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
            this.splMoveUp = new System.Windows.Forms.Splitter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnCloseSrch = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.splResult = new System.Windows.Forms.Splitter();
            this.lblResult = new System.Windows.Forms.Label();
            this.splHalf = new System.Windows.Forms.Splitter();
            this.pnlUpperActionButtons = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlLowerActionButtons = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.misparDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new WindowsFormsApplication1.HospitalDataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splData = new System.Windows.Forms.Splitter();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlTexts = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtMispar = new System.Windows.Forms.TextBox();
            this.lblMispar = new System.Windows.Forms.Label();
            this.hintMispar = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtKtovet = new System.Windows.Forms.TextBox();
            this.lblKtovet = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.hintTelephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtShem = new System.Windows.Forms.TextBox();
            this.lblShem = new System.Windows.Forms.Label();
            this.hintShem = new System.Windows.Forms.Label();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.hintKtovet = new System.Windows.Forms.Label();
            this.hintCity = new System.Windows.Forms.Label();
            this.hintEmail = new System.Windows.Forms.Label();
            this.splSeparate = new System.Windows.Forms.Splitter();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.splMoveRight = new System.Windows.Forms.Splitter();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlResultButtons = new System.Windows.Forms.Panel();
            this.lblSearchQuantity = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.sapakTableAdapter = new WindowsFormsApplication1.HospitalDataSetTableAdapters.SapakTableAdapter();
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.pnlUpperActionButtons.SuspendLayout();
            this.pnlLowerActionButtons.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.pnlTexts.SuspendLayout();
            this.pnlTables.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlResultButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splMoveUp
            // 
            this.splMoveUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splMoveUp.Location = new System.Drawing.Point(0, 507);
            this.splMoveUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splMoveUp.Name = "splMoveUp";
            this.splMoveUp.Size = new System.Drawing.Size(809, 25);
            this.splMoveUp.TabIndex = 105;
            this.splMoveUp.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(381, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 85);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.btnCloseSrch);
            this.pnlResult.Controls.Add(this.dataGridViewResult);
            this.pnlResult.Controls.Add(this.splResult);
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Controls.Add(this.splHalf);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlResult.Location = new System.Drawing.Point(0, 0);
            this.pnlResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(904, 352);
            this.pnlResult.TabIndex = 83;
            this.pnlResult.Visible = false;
            // 
            // btnCloseSrch
            // 
            this.btnCloseSrch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCloseSrch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCloseSrch.FlatAppearance.BorderSize = 0;
            this.btnCloseSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCloseSrch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseSrch.Location = new System.Drawing.Point(3, 2);
            this.btnCloseSrch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseSrch.Name = "btnCloseSrch";
            this.btnCloseSrch.Size = new System.Drawing.Size(85, 33);
            this.btnCloseSrch.TabIndex = 21;
            this.btnCloseSrch.Text = "סגור";
            this.btnCloseSrch.UseVisualStyleBackColor = false;
            this.btnCloseSrch.Click += new System.EventHandler(this.btnCloseSrch_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 41);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewResult.MultiSelect = false;
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(899, 311);
            this.dataGridViewResult.TabIndex = 23;
            this.dataGridViewResult.SelectionChanged += new System.EventHandler(this.dataGridViewResult_SelectionChanged);
            // 
            // splResult
            // 
            this.splResult.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.splResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.splResult.Enabled = false;
            this.splResult.Location = new System.Drawing.Point(0, 37);
            this.splResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splResult.Name = "splResult";
            this.splResult.Size = new System.Drawing.Size(899, 4);
            this.splResult.TabIndex = 83;
            this.splResult.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(899, 37);
            this.lblResult.TabIndex = 82;
            this.lblResult.Text = "תוצאות החיפוש";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splHalf
            // 
            this.splHalf.BackColor = System.Drawing.Color.DimGray;
            this.splHalf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splHalf.Cursor = System.Windows.Forms.Cursors.Default;
            this.splHalf.Dock = System.Windows.Forms.DockStyle.Right;
            this.splHalf.Enabled = false;
            this.splHalf.Location = new System.Drawing.Point(899, 0);
            this.splHalf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splHalf.Name = "splHalf";
            this.splHalf.Size = new System.Drawing.Size(5, 352);
            this.splHalf.TabIndex = 84;
            this.splHalf.TabStop = false;
            this.splHalf.Visible = false;
            // 
            // pnlUpperActionButtons
            // 
            this.pnlUpperActionButtons.Controls.Add(this.btnAccept);
            this.pnlUpperActionButtons.Controls.Add(this.btnDel);
            this.pnlUpperActionButtons.Controls.Add(this.btnAdd);
            this.pnlUpperActionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpperActionButtons.Location = new System.Drawing.Point(0, 337);
            this.pnlUpperActionButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUpperActionButtons.Name = "pnlUpperActionButtons";
            this.pnlUpperActionButtons.Size = new System.Drawing.Size(809, 85);
            this.pnlUpperActionButtons.TabIndex = 84;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAccept.Location = new System.Drawing.Point(382, 0);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(191, 85);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "אישור";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDel.Location = new System.Drawing.Point(191, 0);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(191, 85);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "מחק";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 85);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlLowerActionButtons
            // 
            this.pnlLowerActionButtons.Controls.Add(this.btnCancel);
            this.pnlLowerActionButtons.Controls.Add(this.btnUpdate);
            this.pnlLowerActionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLowerActionButtons.Location = new System.Drawing.Point(0, 422);
            this.pnlLowerActionButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLowerActionButtons.Name = "pnlLowerActionButtons";
            this.pnlLowerActionButtons.Size = new System.Drawing.Size(809, 85);
            this.pnlLowerActionButtons.TabIndex = 85;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(381, 85);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dataGridView);
            this.pnlData.Controls.Add(this.btnRefresh);
            this.pnlData.Controls.Add(this.splData);
            this.pnlData.Controls.Add(this.lblData);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(904, 0);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(915, 352);
            this.pnlData.TabIndex = 91;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.misparDataGridViewTextBoxColumn,
            this.shemDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.sapakBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 41);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(915, 311);
            this.dataGridView.TabIndex = 22;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // misparDataGridViewTextBoxColumn
            // 
            this.misparDataGridViewTextBoxColumn.DataPropertyName = "mispar";
            this.misparDataGridViewTextBoxColumn.HeaderText = "מספר";
            this.misparDataGridViewTextBoxColumn.Name = "misparDataGridViewTextBoxColumn";
            this.misparDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "שם";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            this.shemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "אמייל";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "ישוב";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sapakBindingSource
            // 
            this.sapakBindingSource.DataMember = "Sapak";
            this.sapakBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Location = new System.Drawing.Point(0, -2);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 36);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "🔃";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // splData
            // 
            this.splData.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splData.Cursor = System.Windows.Forms.Cursors.Default;
            this.splData.Dock = System.Windows.Forms.DockStyle.Top;
            this.splData.Enabled = false;
            this.splData.Location = new System.Drawing.Point(0, 37);
            this.splData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splData.Name = "splData";
            this.splData.Size = new System.Drawing.Size(915, 4);
            this.splData.TabIndex = 63;
            this.splData.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblData.Location = new System.Drawing.Point(0, 0);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(915, 37);
            this.lblData.TabIndex = 62;
            this.lblData.Text = "טבלת ";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTexts
            // 
            this.pnlTexts.BackColor = System.Drawing.Color.Transparent;
            this.pnlTexts.Controls.Add(this.btnClean);
            this.pnlTexts.Controls.Add(this.txtMispar);
            this.pnlTexts.Controls.Add(this.lblMispar);
            this.pnlTexts.Controls.Add(this.hintMispar);
            this.pnlTexts.Controls.Add(this.lblCity);
            this.pnlTexts.Controls.Add(this.txtCity);
            this.pnlTexts.Controls.Add(this.txtKtovet);
            this.pnlTexts.Controls.Add(this.lblKtovet);
            this.pnlTexts.Controls.Add(this.txtEmail);
            this.pnlTexts.Controls.Add(this.lblEmail);
            this.pnlTexts.Controls.Add(this.hintTelephone);
            this.pnlTexts.Controls.Add(this.txtTelephone);
            this.pnlTexts.Controls.Add(this.lblTelephone);
            this.pnlTexts.Controls.Add(this.txtShem);
            this.pnlTexts.Controls.Add(this.lblShem);
            this.pnlTexts.Controls.Add(this.hintShem);
            this.pnlTexts.Controls.Add(this.comboSearch);
            this.pnlTexts.Controls.Add(this.btnSearch);
            this.pnlTexts.Controls.Add(this.txtSearch);
            this.pnlTexts.Controls.Add(this.lblSearch);
            this.pnlTexts.Controls.Add(this.hintKtovet);
            this.pnlTexts.Controls.Add(this.hintCity);
            this.pnlTexts.Controls.Add(this.hintEmail);
            this.pnlTexts.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTexts.Location = new System.Drawing.Point(868, 357);
            this.pnlTexts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTexts.Name = "pnlTexts";
            this.pnlTexts.Size = new System.Drawing.Size(951, 532);
            this.pnlTexts.TabIndex = 107;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(52, 60);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(92, 37);
            this.btnClean.TabIndex = 142;
            this.btnClean.Text = "נקה";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtMispar
            // 
            this.txtMispar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMispar.Location = new System.Drawing.Point(376, 144);
            this.txtMispar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMispar.Name = "txtMispar";
            this.txtMispar.ReadOnly = true;
            this.txtMispar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMispar.Size = new System.Drawing.Size(409, 36);
            this.txtMispar.TabIndex = 149;
            // 
            // lblMispar
            // 
            this.lblMispar.AutoSize = true;
            this.lblMispar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMispar.Location = new System.Drawing.Point(796, 144);
            this.lblMispar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMispar.Name = "lblMispar";
            this.lblMispar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMispar.Size = new System.Drawing.Size(77, 29);
            this.lblMispar.TabIndex = 148;
            this.lblMispar.Text = "מספר:";
            // 
            // hintMispar
            // 
            this.hintMispar.ForeColor = System.Drawing.Color.Red;
            this.hintMispar.Location = new System.Drawing.Point(379, 126);
            this.hintMispar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintMispar.Name = "hintMispar";
            this.hintMispar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintMispar.Size = new System.Drawing.Size(413, 16);
            this.hintMispar.TabIndex = 150;
            this.hintMispar.Text = "label1";
            this.hintMispar.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCity.Location = new System.Drawing.Point(793, 438);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCity.Size = new System.Drawing.Size(67, 29);
            this.lblCity.TabIndex = 145;
            this.lblCity.Text = "ישוב:";
            // 
            // txtCity
            // 
            this.txtCity.AutoCompleteCustomSource.AddRange(new string[] {
            "אבו ג\'ווייעד (שבט)",
            "אבו גוש",
            "אבו סנאן",
            "אבו סריחאן (שבט)",
            "אבו עבדון (שבט)",
            "אבו עמאר (שבט)",
            "אבו עמרה (שבט)",
            "אבו קורינאת (יישוב)",
            "אבו קורינאת (שבט)",
            "אבו רובייעה (שבט)",
            "אבו רוקייק (שבט)",
            "אבטין",
            "אבטליון",
            "אביאל",
            "אביבים",
            "אביגדור",
            "אביחיל",
            "אביטל",
            "אביעזר",
            "אבירים",
            "אבן יהודה",
            "אבן מנחם",
            "אבן ספיר",
            "אבן שמואל",
            "אבני איתן",
            "אבני חפץ",
            "אבנת",
            "אבשלום",
            "אדורה",
            "אדירים",
            "אדמית",
            "אדרת",
            "אודים",
            "אודם",
            "אוהד",
            "אום אל-פחם",
            "אום אל-קוטוף",
            "אומן",
            "אומץ",
            "אופקים",
            "אור הגנוז",
            "אור הנר",
            "אור יהודה",
            "אור עקיבא",
            "אורה",
            "אורון",
            "אורות",
            "אורטל",
            "אורים",
            "אורנים",
            "אורנית",
            "אושה",
            "אזור",
            "אזור תעשייה אכזיב (מילואות)",
            "אזור תעשייה נעמן (מילואות)",
            "אחווה",
            "אחוזם",
            "אחוזת ברק",
            "אחיהוד",
            "אחיטוב",
            "אחיסמך",
            "אחיעזר",
            "אטרש (שבט)",
            "איבים",
            "אייל",
            "איילת השחר",
            "אילון",
            "אילון תבור*",
            "אילות",
            "אילנייה",
            "אילת",
            "איתמר",
            "איתן",
            "איתנים",
            "אכסאל",
            "אל -עזי",
            "אל -עריאן",
            "אל -רום",
            "אלומה",
            "אלומות",
            "אלון הגליל",
            "אלון מורה",
            "אלון שבות",
            "אלוני אבא",
            "אלוני הבשן",
            "אלוני יצחק",
            "אלונים",
            "אלי-עד",
            "אלי סיני",
            "אליכין",
            "אליפז",
            "אליפלט",
            "אליקים",
            "אלישיב",
            "אלישמע",
            "אלמגור",
            "אלמוג",
            "אלעד",
            "אלעזר",
            "אלפי מנשה",
            "אלקוש",
            "אלקנה",
            "אמונים",
            "אמירים",
            "אמנון",
            "אמציה",
            "אניעם",
            "אסד (שבט)",
            "אספר",
            "אעבלין",
            "אעצם (שבט)",
            "אפיניש (שבט)",
            "אפיק",
            "אפיקים",
            "אפעל-מרכז סמינריוני",
            "אפק",
            "אפרתה",
            "ארבל",
            "ארגמן",
            "ארז",
            "אריאל",
            "ארסוף",
            "אשבול",
            "אשבל",
            "אשדוד",
            "אשדות יעקב (איחוד)",
            "אשדות יעקב (מאוחד)",
            "אשחר",
            "אשכולות",
            "אשל הנשיא",
            "אשלים",
            "אשקלון",
            "אשרת",
            "אשתאול",
            "באקה-ג\'ת*",
            "באר אורה",
            "באר טוביה",
            "באר יעקב",
            "באר שבע",
            "בארות יצחק",
            "בארותיים",
            "בארי",
            "בדולח",
            "בוסתן הגליל",
            "בועיינה-נוג\'ידאת",
            "בוקעאתא",
            "בורגתה",
            "בחן",
            "בטחה",
            "בי\"ס אזורי מקיף (אשר)",
            "ביצרון",
            "ביר אל-מכסור",
            "ביר הדאג\'",
            "בירייה",
            "בית אורן",
            "בית אל",
            "בית אלעזרי",
            "בית אלפא",
            "בית אריה",
            "בית ברל",
            "בית ג\'ן",
            "בית גוברין",
            "בית גמליאל",
            "בית דגן",
            "בית הגדי",
            "בית הלוי",
            "בית הלל",
            "בית העמק",
            "בית הערבה",
            "בית השיטה",
            "בית זיד",
            "בית זית",
            "בית זרע",
            "בית חולים פוריה",
            "בית חורון",
            "בית חירות",
            "בית חלקיה",
            "בית חנן",
            "בית חנניה",
            "בית חשמונאי",
            "בית יהושע",
            "בית יוסף",
            "בית ינאי",
            "בית יצחק-שער חפר",
            "בית לחם הגלילית",
            "בית מאיר",
            "בית נחמיה",
            "בית ניר",
            "בית נקופה",
            "בית עובד",
            "בית עוזיאל",
            "בית עזרא",
            "בית עריף",
            "בית צבי",
            "בית קמה",
            "בית קשת",
            "בית רבן",
            "בית רימון",
            "בית שאן",
            "בית שמש",
            "בית שערים",
            "בית שקמה",
            "ביתן אהרן",
            "ביתר עילית",
            "בלפוריה",
            "בן זכאי",
            "בן עמי",
            "בן שמן (כפר נוער)",
            "בן שמן (מושב)",
            "בני ברק",
            "בני דרום",
            "בני דרור",
            "בני יהודה",
            "בני עטרות",
            "בני עי\"ש",
            "בני עצמון",
            "בני ציון",
            "בני ראם",
            "בניה",
            "בנימינה-גבעת עדה*",
            "בסמ\"ה",
            "בסמת טבעון",
            "בצרה",
            "בצת",
            "בקוע",
            "בקעות",
            "בר גיורא",
            "בר יוחאי",
            "ברור חיל",
            "ברוש",
            "ברכה",
            "ברכיה",
            "ברעם",
            "ברק",
            "ברקאי",
            "ברקן",
            "ברקת",
            "בת הדר",
            "בת חפר",
            "בת חצור",
            "בת ים",
            "בת עין",
            "בת שלמה",
            "בתי זיקוק - קישון*",
            "בתי ספר של מרחבים*",
            "ג\'דיידה-מכר",
            "ג\'ולס",
            "ג\'לג\'וליה",
            "ג\'נאביב (שבט)",
            "ג\'סר א-זרקא",
            "ג\'ש (גוש חלב)",
            "גאולי תימן",
            "גאולים",
            "גאליה",
            "גבולות",
            "גבים",
            "גבע",
            "גבע בנימין",
            "גבע כרמל",
            "גבעולים",
            "גבעון החדשה",
            "גבעות בר",
            "גבעת אבני",
            "גבעת אלה",
            "גבעת ברנר",
            "גבעת השלושה",
            "גבעת זאב",
            "גבעת ח\"ן",
            "גבעת חביבה",
            "גבעת חיים (איחוד)",
            "גבעת חיים (מאוחד)",
            "גבעת יואב",
            "גבעת יערים",
            "גבעת ישעיהו",
            "גבעת כ\"ח",
            "גבעת ניל\"י",
            "גבעת עוז",
            "גבעת שמואל",
            "גבעת שמש",
            "גבעת שפירא",
            "גבעתי",
            "גבעתיים",
            "גברעם",
            "גבת",
            "גדות",
            "גדיד",
            "גדיש",
            "גדעונה",
            "גדרה",
            "גונן",
            "גורן",
            "גורנות הגליל",
            "גזית",
            "גזר",
            "גיאה",
            "גיבתון",
            "גיזו",
            "גילון",
            "גילת",
            "גינוסר",
            "גיניגר",
            "גינתון",
            "גיתה",
            "גיתית",
            "גלאון",
            "גלגל",
            "גליל ים",
            "גלעד (אבן יצחק)",
            "גמזו",
            "גן אור",
            "גן הדרום",
            "גן השומרון",
            "גן חיים",
            "גן יאשיה",
            "גן יבנה",
            "גן נר",
            "גן שורק",
            "גן שלמה",
            "גן שמואל",
            "גנות",
            "גנות הדר",
            "גני הדר",
            "גני טל",
            "גני יוחנן",
            "גני עם",
            "גני תקווה",
            "גנים",
            "געש",
            "געתון",
            "גפן",
            "גרופית",
            "גשור",
            "גשר",
            "גשר הזיו",
            "גת (קיבוץ)",
            "גת רימון",
            "דאלית אל-כרמל-עספיא*",
            "דבורה",
            "דבורייה",
            "דבירה",
            "דברת",
            "דגניה א\'",
            "דגניה ב\'",
            "דוב\"ב",
            "דוגית",
            "דולב",
            "דור",
            "דורות",
            "דחי",
            "דייר חנא",
            "דייר ראפאת",
            "דימונה",
            "דישון",
            "דלייה",
            "דלתון",
            "דמיידה",
            "דן",
            "דפנה",
            "דקל",
            "דריג\'את",
            "האון",
            "הבונים",
            "הגושרים",
            "הדר עם",
            "הוד השרון",
            "הודיות",
            "הודייה",
            "הוואשלה (שבט)",
            "הוזייל (שבט)",
            "הושעיה",
            "הזורע",
            "הזורעים",
            "החותרים",
            "היוגב",
            "הילה",
            "המעפיל",
            "המרכז למחקר-נחל שורק",
            "הסוללים",
            "העוגן",
            "הר אדר",
            "הר גילה",
            "הר עמשא",
            "הראל",
            "הרדוף",
            "הרצלייה",
            "הררית",
            "ורד יריחו",
            "ורדון",
            "זבארגה (שבט)",
            "זבדיאל",
            "זוהר",
            "זיקים",
            "זיתן",
            "זכרון יעקב",
            "זכריה",
            "זמר",
            "זמרת",
            "זנוח",
            "זרועה",
            "זרזיר",
            "זרחיה",
            "ח\'ואלד",
            "ח\'ואלד (שבט)",
            "חבצלת השרון",
            "חבר",
            "חגור",
            "חגי",
            "חגלה",
            "חד-נס",
            "חדיד",
            "חדרה",
            "חוג\'ייראת (ד\'הרה) (שבט)",
            "חולדה",
            "חולון",
            "חולית",
            "חולתה",
            "חומש",
            "חוסן",
            "חוסנייה",
            "חופית",
            "חוקוק",
            "חורה",
            "חורפיש",
            "חורשים",
            "חזון",
            "חיבת ציון",
            "חיננית",
            "חיפה",
            "חירות",
            "חלוץ",
            "חלמיש",
            "חלץ",
            "חמאם",
            "חמד",
            "חמדיה",
            "חמדת",
            "חמרה",
            "חניאל",
            "חניתה",
            "חנתון",
            "חספין",
            "חפץ חיים",
            "חפצי-בה",
            "חצב",
            "חצבה",
            "חצור-אשדוד",
            "חצור הגלילית",
            "חצרים",
            "חרב לאת",
            "חרוצים",
            "חרמש",
            "חרשים",
            "חשמונאים",
            "טבריה",
            "טובא-זנגרייה",
            "טורעאן",
            "טייבה",
            "טייבה (בעמק)",
            "טירה",
            "טירת יהודה",
            "טירת כרמל",
            "טירת צבי",
            "טל-אל",
            "טל שחר",
            "טללים",
            "טלמון",
            "טמרה",
            "טמרה (יזרעאל)",
            "טנא",
            "טפחות",
            "יאנוח-ג\'ת",
            "יבול",
            "יבנאל",
            "יבנה",
            "יגור",
            "יגל",
            "יד בנימין",
            "יד השמונה",
            "יד חנה",
            "יד מרדכי",
            "יד נתן",
            "יד רמב\"ם",
            "ידידה",
            "יהוד-נווה אפרים*",
            "יהל",
            "יובל",
            "יובלים",
            "יודפת",
            "יונתן",
            "יושיביה",
            "יזרעאל",
            "יחיעם",
            "יטבתה",
            "ייט\"ב",
            "יכיני",
            "ים המלח - בתי מלון",
            "ינוב",
            "ינון",
            "יסוד המעלה",
            "יסודות",
            "יסעור",
            "יעד",
            "יעל",
            "יעף",
            "יערה",
            "יפיע",
            "יפית",
            "יפעת",
            "יפתח",
            "יצהר",
            "יציץ",
            "יקום",
            "יקיר",
            "יקנעם (מושבה)",
            "יקנעם עילית",
            "יראון",
            "ירדנה",
            "ירוחם",
            "ירושלים",
            "ירחיב",
            "ירכא",
            "ירקונה",
            "ישע",
            "ישעי",
            "ישרש",
            "יתד",
            "כאבול",
            "כאוכב אבו אל-היג\'א",
            "כברי",
            "כדורי",
            "כדים",
            "כוכב השחר",
            "כוכב יאיר",
            "כוכב יעקב",
            "כוכב מיכאל",
            "כורזים",
            "כחל",
            "כיסופים",
            "כישור",
            "כליל",
            "כלנית",
            "כמאנה",
            "כמהין",
            "כמון",
            "כנות",
            "כנף",
            "כנרת (מושבה)",
            "כנרת (קבוצה)",
            "כסיפה",
            "כסלון",
            "כסרא-סמיע",
            "כעביה-טבאש-חג\'אג\'רה",
            "כפר אביב",
            "כפר אדומים",
            "כפר אוריה",
            "כפר אז\"ר",
            "כפר אחים",
            "כפר ביאליק",
            "כפר ביל\"ו",
            "כפר בלום",
            "כפר בן נון",
            "כפר ברא",
            "כפר ברוך",
            "כפר גדעון",
            "כפר גלים",
            "כפר גליקסון",
            "כפר גלעדי",
            "כפר דניאל",
            "כפר דרום",
            "כפר האורנים",
            "כפר החורש",
            "כפר המכבי",
            "כפר הנגיד",
            "כפר הנוער הדתי",
            "כפר הנשיא",
            "כפר הס",
            "כפר הרא\"ה",
            "כפר הרי\"ף",
            "כפר ויתקין",
            "כפר ורבורג",
            "כפר ורדים",
            "כפר זוהרים",
            "כפר זיתים",
            "כפר חב\"ד",
            "כפר חושן",
            "כפר חיטים",
            "כפר חיים",
            "כפר חנניה",
            "כפר חסידים א\'",
            "כפר חסידים ב\'",
            "כפר חרוב",
            "כפר טרומן",
            "כפר יאסיף",
            "כפר ידידיה",
            "כפר יהושע",
            "כפר יונה",
            "כפר יחזקאל",
            "כפר יעבץ",
            "כפר כמא",
            "כפר כנא",
            "כפר מונש",
            "כפר מימון",
            "כפר מל\"ל",
            "כפר מנדא",
            "כפר מנחם",
            "כפר מסריק",
            "כפר מצר",
            "כפר מרדכי",
            "כפר נטר",
            "כפר סאלד",
            "כפר סבא",
            "כפר סילבר",
            "כפר סירקין",
            "כפר עבודה",
            "כפר עזה",
            "כפר עציון",
            "כפר פינס",
            "כפר קאסם",
            "כפר קיש",
            "כפר קרע",
            "כפר ראש הנקרה",
            "כפר רוזנואלד (זרעית)",
            "כפר רופין",
            "כפר רות",
            "כפר שמאי",
            "כפר שמואל",
            "כפר שמריהו",
            "כפר תבור",
            "כפר תפוח",
            "כרכום",
            "כרם בן זמרה",
            "כרם בן שמן",
            "כרם יבנה (ישיבה)",
            "כרם מהר\"ל",
            "כרם שלום",
            "כרמי יוסף",
            "כרמי צור",
            "כרמיאל",
            "כרמייה",
            "כרמים",
            "כרמל",
            "לבון",
            "לביא",
            "לבנים",
            "להב",
            "להבות הבשן",
            "להבות חביבה",
            "להבים",
            "לוד",
            "לוזית",
            "לוחמי הגיטאות",
            "לוטם",
            "לוטן",
            "לימן",
            "לכיש",
            "לפיד",
            "לפידות",
            "לקיה",
            "מאור",
            "מאיר שפיה",
            "מבוא ביתר",
            "מבוא דותן",
            "מבוא חורון",
            "מבוא חמה",
            "מבוא מודיעים",
            "מבואות ים",
            "מבועים",
            "מבטחים",
            "מבקיעים",
            "מבשרת ציון",
            "מג\'דל שמס",
            "מגאר",
            "מגדים",
            "מגדל",
            "מגדל העמק",
            "מגדל עוז",
            "מגדל תפן",
            "מגדלים",
            "מגידו",
            "מגל",
            "מגן",
            "מגן שאול",
            "מגשימים",
            "מדרך עוז",
            "מדרשת בן גוריון",
            "מדרשת רופין",
            "מודיעין-מכבים-רעות*",
            "מודיעין עילית",
            "מולדת",
            "מוצא עילית",
            "מוקייבלה",
            "מורג",
            "מורן",
            "מורשת",
            "מזור",
            "מזכרת בתיה",
            "מזרע",
            "מזרעה",
            "מחולה",
            "מחנה הילה*",
            "מחנה טלי*",
            "מחנה יבור",
            "מחנה יהודית*",
            "מחנה יוכבד*",
            "מחנה יפה*",
            "מחנה יתיר",
            "מחנה מרים*",
            "מחנה עדי*",
            "מחנה תל נוף*",
            "מחניים",
            "מחסיה",
            "מטולה",
            "מטע",
            "מי עמי",
            "מיטב",
            "מייסר",
            "מיצר",
            "מירב",
            "מירון",
            "מישר",
            "מיתר",
            "מכורה",
            "מכחול",
            "מכמורת",
            "מכמנים",
            "מלאה",
            "מלילות",
            "מלכייה",
            "מלכישוע",
            "מנוחה",
            "מנוף",
            "מנות",
            "מנחמיה",
            "מנרה",
            "מנשית זבדה",
            "מסד",
            "מסדה",
            "מסילות",
            "מסילת ציון",
            "מסלול",
            "מסעדה",
            "מסעודין אל-עזאזמה (שבט)",
            "מעברות",
            "מעגלים",
            "מעגן",
            "מעגן מיכאל",
            "מעוז חיים",
            "מעון",
            "מעונה",
            "מעיין ברוך",
            "מעיין צבי",
            "מעיליא",
            "מעלה אדומים",
            "מעלה אפרים",
            "מעלה גלבוע",
            "מעלה גמלא",
            "מעלה החמישה",
            "מעלה לבונה",
            "מעלה מכמש",
            "מעלה עירון",
            "מעלה עמוס",
            "מעלה שומרון",
            "מעלות-תרשיחא",
            "מענית",
            "מעש",
            "מפלסים",
            "מפעלי אבשלום",
            "מפעלי ברנר",
            "מפעלי ברקן*",
            "מפעלי גלבוע",
            "מפעלי גליל עליון",
            "מפעלי גרנות",
            "מפעלי הר טוב*",
            "מפעלי חפר",
            "מפעלי יזרעאל* (העמק)",
            "מפעלי ים המלח*",
            "מפעלי כנות",
            "מפעלי מעון*",
            "מפעלי עזה",
            "מפעלי צומת מלאכי*",
            "מפעלי צין - ערבה",
            "מפעלי שאן*",
            "מצדות יהודה",
            "מצובה",
            "מצליח",
            "מצפה",
            "מצפה אבי\"ב",
            "מצפה יריחו",
            "מצפה נטופה",
            "מצפה רמון",
            "מצפה שלם",
            "מצר",
            "מקווה ישראל",
            "מרגליות",
            "מרום גולן",
            "מרחב עם",
            "מרחביה (מושב)",
            "מרחביה (קיבוץ)",
            "מרכז אזורי כדורי",
            "מרכז אזורי מרום הגליל",
            "מרכז אזורי משגב",
            "מרכז כ\"ח",
            "מרכז שוהם",
            "מרכז שפירא",
            "מרכז תעשיות שער הנגב",
            "משאבי שדה",
            "משגב דב",
            "משגב עם",
            "משהד",
            "משואה",
            "משואות יצחק",
            "משכיות",
            "משמר איילון",
            "משמר דוד",
            "משמר הירדן",
            "משמר הנגב",
            "משמר העמק",
            "משמר השבעה",
            "משמר השרון",
            "משמרות",
            "משמרת",
            "משען",
            "מתן",
            "מתת",
            "מתתיהו",
            "נאות גולן",
            "נאות הכיכר",
            "נאות מרדכי",
            "נאות סמדר",
            "נאעורה",
            "נבטים",
            "נגבה",
            "נגוהות",
            "נהורה",
            "נהלל",
            "נהרייה",
            "נוב",
            "נוגה",
            "נווה אבות",
            "נווה אור",
            "נווה אטי\"ב",
            "נווה אילן",
            "נווה אילן*",
            "נווה איתן",
            "נווה אפעל",
            "נווה דניאל",
            "נווה דקלים",
            "נווה זוהר",
            "נווה זיו",
            "נווה חריף",
            "נווה ים",
            "נווה ימין",
            "נווה ירק",
            "נווה מבטח",
            "נווה מיכאל",
            "נווה שלום",
            "נועם",
            "נוף איילון",
            "נופים",
            "נופית",
            "נופך",
            "נוקדים",
            "נורדייה",
            "נורית",
            "נחושה",
            "נחל עוז",
            "נחלה",
            "נחליאל",
            "נחלים",
            "נחם",
            "נחף",
            "נחשולים",
            "נחשון",
            "נחשונים",
            "נטועה",
            "נטור",
            "נטעים",
            "נטף",
            "ניין",
            "ניל\"י",
            "ניסנית",
            "ניצן",
            "ניצנה (קהילת חינוך)",
            "ניצני סיני",
            "ניצני עוז",
            "ניצנים",
            "ניר אליהו",
            "ניר בנים",
            "ניר גלים",
            "ניר דוד (תל עמל)",
            "ניר ח\"ן",
            "ניר יפה",
            "ניר יצחק",
            "ניר ישראל",
            "ניר משה",
            "ניר עוז",
            "ניר עם",
            "ניר עציון",
            "ניר עקיבא",
            "ניר צבי",
            "נירים",
            "נירית",
            "נירן",
            "נמל תעופה בן-גוריון",
            "נס הרים",
            "נס עמים",
            "נס ציונה",
            "נעורים",
            "נעלה",
            "נעמי",
            "נען",
            "נצאצרה (שבט)",
            "נצר חזני",
            "נצר סרני",
            "נצרים",
            "נצרת",
            "נצרת עילית",
            "נשר",
            "נתיב הגדוד",
            "נתיב הל\"ה",
            "נתיב העשרה",
            "נתיב השיירה",
            "נתיבות",
            "נתניה",
            "סאג\'ור",
            "סאסא",
            "סביון*",
            "סגולה",
            "סואעד (חמרייה)*",
            "סואעד (כמאנה) (שבט)",
            "סולם",
            "סוסיה",
            "סופה",
            "סח\'נין",
            "סייד (שבט)",
            "סלמה",
            "סלעית",
            "סמר",
            "סנסנה",
            "סעד",
            "סער",
            "ספיר",
            "סתרייה",
            "ע\'ג\'ר",
            "עבדון",
            "עברון",
            "עגור",
            "עד הלום",
            "עדי",
            "עדנים",
            "עוזה",
            "עוזייר",
            "עולש",
            "עומר",
            "עופר",
            "עוצם",
            "עוקבי (בנו עוקבה) (שבט)",
            "עזוז",
            "עזר",
            "עזריאל",
            "עזריה",
            "עזריקם",
            "עטאוונה (שבט)",
            "עטרת",
            "עידן",
            "עיילבון",
            "עיינות",
            "עילוט",
            "עין איילה",
            "עין אל-אסד",
            "עין גב",
            "עין גדי",
            "עין דור",
            "עין הבשור",
            "עין הוד",
            "עין החורש",
            "עין המפרץ",
            "עין הנצי\"ב",
            "עין העמק",
            "עין השופט",
            "עין השלושה",
            "עין ורד",
            "עין זיוון",
            "עין חוד",
            "עין חצבה",
            "עין חרוד (איחוד)",
            "עין חרוד (מאוחד)",
            "עין יהב",
            "עין יעקב",
            "עין כרם-בי\"ס חקלאי",
            "עין כרמל",
            "עין מאהל",
            "עין נקובא",
            "עין עירון",
            "עין צורים",
            "עין קנייא",
            "עין ראפה",
            "עין שמר",
            "עין שריד",
            "עין תמר",
            "עינת",
            "עיר אובות",
            "עכו",
            "עלומים",
            "עלי",
            "עלי זהב",
            "עלמה",
            "עלמון",
            "עמוקה",
            "עמינדב",
            "עמיעד",
            "עמיעוז",
            "עמיקם",
            "עמיר",
            "עמנואל",
            "עמקה",
            "ענב",
            "עפולה",
            "עפרה",
            "עץ אפרים",
            "עראבה",
            "עראמשה*",
            "ערד",
            "ערוגות",
            "ערערה",
            "ערערה-בנגב",
            "עשרת",
            "עתלית",
            "עתניאל",
            "פארן",
            "פארק תמ\"ד*",
            "פאת שדה",
            "פדואל",
            "פדויים",
            "פדיה",
            "פוריידיס",
            "פורייה - כפר עבודה",
            "פורייה - נווה עובד",
            "פורייה עילית",
            "פורת",
            "פטיש",
            "פלך",
            "פלמחים",
            "פני חבר",
            "פסגות",
            "פסוטה",
            "פעמי תש\"ז",
            "פצאל",
            "פקיעין (בוקייעה)",
            "פקיעין חדשה",
            "פרדס חנה-כרכור",
            "פרדסייה",
            "פרוד",
            "פרזון",
            "פרי גן",
            "פתח תקווה",
            "פתחיה",
            "צאלים",
            "צביה",
            "צבעון",
            "צובה",
            "צוחר",
            "צופייה",
            "צופים",
            "צופית",
            "צופר",
            "צוקי ים",
            "צוקים",
            "צור הדסה",
            "צור משה",
            "צור נתן",
            "צוריאל",
            "צורית",
            "צורן-קדימה*",
            "ציפורי",
            "צלפון",
            "צמח - מפעלי עמק הירדן",
            "צנדלה",
            "צפרייה",
            "צפרירים",
            "צפת",
            "צרופה",
            "צרעה",
            "קבועה (שבט)",
            "קבוצת יבנה",
            "קדומים",
            "קדמה",
            "קדמת צבי",
            "קדר",
            "קדרון",
            "קדרים",
            "קודייראת א-צאנע (שבט)",
            "קוואעין (שבט)",
            "קוממיות",
            "קורנית",
            "קטורה",
            "קטיף",
            "קיסריה",
            "קלחים",
            "קליה",
            "קלנסווה",
            "קלע",
            "קציר-חריש",
            "קצר א-סר",
            "קצרין",
            "קריית אונו",
            "קריית ארבע",
            "קריית אתא",
            "קריית ביאליק",
            "קריית גת",
            "קריית טבעון",
            "קריית ים",
            "קריית יערים",
            "קריית יערים (מוסד)",
            "קריית מוצקין",
            "קריית מלאכי",
            "קריית נטפים",
            "קריית ענבים",
            "קריית עקרון",
            "קריית שלמה",
            "קריית שמונה",
            "קרית חינוך עזתה",
            "קרני שומרון",
            "קשת",
            "ראמה",
            "ראס אל-עין",
            "ראס עלי",
            "ראש העין",
            "ראש פינה",
            "ראש צורים",
            "ראשון לציון",
            "רבבה",
            "רבדים",
            "רביבים",
            "רביד",
            "רגבה",
            "רגבים",
            "רהט",
            "רווחה",
            "רוויה",
            "רוחמה",
            "רומאנה",
            "רומת הייב",
            "רועי",
            "רותם",
            "רחוב",
            "רחובות",
            "ריחאנייה",
            "ריחן",
            "ריינה",
            "רימונים",
            "רינתיה",
            "רכסים",
            "רם-און",
            "רמות",
            "רמות השבים",
            "רמות מאיר",
            "רמות מנשה",
            "רמות נפתלי",
            "רמלה",
            "רמת אפעל",
            "רמת גן",
            "רמת דוד",
            "רמת הכובש",
            "רמת השופט",
            "רמת השרון",
            "רמת חובב",
            "רמת יוחנן",
            "רמת ישי",
            "רמת מגשימים",
            "רמת פנקס",
            "רמת צבי",
            "רמת רזיאל",
            "רמת רחל",
            "רנן",
            "רעים",
            "רעננה",
            "רפיח ים",
            "רקפת",
            "רשפון",
            "רשפים",
            "רתמים",
            "שא-נור",
            "שאר ישוב",
            "שבי ציון",
            "שבי שומרון",
            "שבלי - אום אל-גנם",
            "שגב",
            "שגב-שלום",
            "שגור*",
            "שדה אילן",
            "שדה אליהו",
            "שדה אליעזר",
            "שדה בוקר",
            "שדה דוד",
            "שדה ורבורג",
            "שדה יואב",
            "שדה יעקב",
            "שדה יצחק",
            "שדה משה",
            "שדה נחום",
            "שדה נחמיה",
            "שדה ניצן",
            "שדה עוזיהו",
            "שדה צבי",
            "שדות ים",
            "שדות מיכה",
            "שדי אברהם",
            "שדי חמד",
            "שדי תרומות",
            "שדמה",
            "שדמות דבורה",
            "שדמות מחולה",
            "שדרות",
            "שואבה",
            "שובה",
            "שובל",
            "שוהם",
            "שומרה",
            "שומרייה",
            "שוקדה",
            "שורש",
            "שורשים",
            "שושנת העמקים",
            "שזור",
            "שחר",
            "שחרות",
            "שיבולים",
            "שיטים",
            "שייח\' דנון",
            "שילה",
            "שילת",
            "שכניה",
            "שלווה",
            "שלוחות",
            "שלומי",
            "שלומציון",
            "שליו",
            "שמיר",
            "שמעה",
            "שמרת",
            "שמשית",
            "שני",
            "שניר",
            "שעב",
            "שעל",
            "שעלבים",
            "שער אפרים",
            "שער הגולן",
            "שער העמקים",
            "שער מנשה",
            "שערי אברהם",
            "שערי תקווה",
            "שפיים",
            "שפיר",
            "שפר",
            "שפרעם",
            "שקד",
            "שקף",
            "שרונה",
            "שריגים (לי-און)",
            "שריד",
            "שרשרת",
            "שתולה",
            "שתולים",
            "תאשור",
            "תדהר",
            "תובל",
            "תומר",
            "תושייה",
            "תימורים",
            "תירוש",
            "תל-חי",
            "תל אביב -יפו",
            "תל יוסף",
            "תל יצחק",
            "תל מונד",
            "תל עדשים",
            "תל קציר",
            "תל שבע",
            "תל תאומים",
            "תלם",
            "תלמי אליהו",
            "תלמי אלעזר",
            "תלמי ביל\"ו",
            "תלמי יוסף",
            "תלמי יחיאל",
            "תלמי יפה",
            "תלמים",
            "תמרת",
            "תנובות",
            "תעוז",
            "תעשיון בינימין*",
            "תעשיון בר-לב",
            "תעשיון גליל תחתון",
            "תעשיון דלתון",
            "תעשיון חוף יבנה",
            "תעשיון מבצע*",
            "תעשיון צריפין",
            "תעשיון קש\"ת*",
            "תעשיון ראם*",
            "תעשיון שח\"ק",
            "תפרח",
            "תקומה",
            "תקוע",
            "תראבין א-צאנע (שבט)",
            "תרדיון",
            "תרום"});
            this.txtCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCity.Location = new System.Drawing.Point(376, 432);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCity.Size = new System.Drawing.Size(409, 36);
            this.txtCity.TabIndex = 146;
            // 
            // txtKtovet
            // 
            this.txtKtovet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKtovet.Location = new System.Drawing.Point(379, 374);
            this.txtKtovet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKtovet.Name = "txtKtovet";
            this.txtKtovet.ReadOnly = true;
            this.txtKtovet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKtovet.Size = new System.Drawing.Size(407, 36);
            this.txtKtovet.TabIndex = 143;
            // 
            // lblKtovet
            // 
            this.lblKtovet.AutoSize = true;
            this.lblKtovet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblKtovet.Location = new System.Drawing.Point(796, 378);
            this.lblKtovet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKtovet.Name = "lblKtovet";
            this.lblKtovet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblKtovet.Size = new System.Drawing.Size(85, 29);
            this.lblKtovet.TabIndex = 142;
            this.lblKtovet.Text = "כתובת:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmail.Location = new System.Drawing.Point(376, 315);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(409, 36);
            this.txtEmail.TabIndex = 140;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmail.Location = new System.Drawing.Point(796, 318);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmail.Size = new System.Drawing.Size(64, 29);
            this.lblEmail.TabIndex = 139;
            this.lblEmail.Text = "מייל:";
            // 
            // hintTelephone
            // 
            this.hintTelephone.ForeColor = System.Drawing.Color.Red;
            this.hintTelephone.Location = new System.Drawing.Point(377, 242);
            this.hintTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintTelephone.Name = "hintTelephone";
            this.hintTelephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintTelephone.Size = new System.Drawing.Size(413, 16);
            this.hintTelephone.TabIndex = 138;
            this.hintTelephone.Text = "label3";
            this.hintTelephone.Visible = false;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTelephone.Location = new System.Drawing.Point(376, 261);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelephone.MaxLength = 10;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.Size = new System.Drawing.Size(409, 36);
            this.txtTelephone.TabIndex = 137;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephone_KeyPress);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTelephone.Location = new System.Drawing.Point(796, 263);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTelephone.Size = new System.Drawing.Size(79, 29);
            this.lblTelephone.TabIndex = 136;
            this.lblTelephone.Text = "טלפון:";
            // 
            // txtShem
            // 
            this.txtShem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtShem.Location = new System.Drawing.Point(376, 203);
            this.txtShem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtShem.Name = "txtShem";
            this.txtShem.ReadOnly = true;
            this.txtShem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShem.Size = new System.Drawing.Size(409, 36);
            this.txtShem.TabIndex = 128;
            // 
            // lblShem
            // 
            this.lblShem.AutoSize = true;
            this.lblShem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblShem.Location = new System.Drawing.Point(796, 203);
            this.lblShem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShem.Name = "lblShem";
            this.lblShem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblShem.Size = new System.Drawing.Size(52, 29);
            this.lblShem.TabIndex = 127;
            this.lblShem.Text = "שם:";
            // 
            // hintShem
            // 
            this.hintShem.ForeColor = System.Drawing.Color.Red;
            this.hintShem.Location = new System.Drawing.Point(379, 185);
            this.hintShem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintShem.Name = "hintShem";
            this.hintShem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintShem.Size = new System.Drawing.Size(413, 16);
            this.hintShem.TabIndex = 129;
            this.hintShem.Text = "label2";
            this.hintShem.Visible = false;
            // 
            // comboSearch
            // 
            this.comboSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSearch.BackColor = System.Drawing.Color.White;
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.IntegralHeight = false;
            this.comboSearch.ItemHeight = 29;
            this.comboSearch.Items.AddRange(new object[] {
            "- בחר -"});
            this.comboSearch.Location = new System.Drawing.Point(376, 17);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboSearch.Size = new System.Drawing.Size(409, 37);
            this.comboSearch.TabIndex = 0;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(792, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.MaximumSize = new System.Drawing.Size(123, 37);
            this.btnSearch.MinimumSize = new System.Drawing.Size(123, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "חפש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearch.Location = new System.Drawing.Point(376, 60);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(409, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSearch.Location = new System.Drawing.Point(792, 20);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(124, 29);
            this.lblSearch.TabIndex = 79;
            this.lblSearch.Text = "חיפוש לפי:";
            // 
            // hintKtovet
            // 
            this.hintKtovet.ForeColor = System.Drawing.Color.Red;
            this.hintKtovet.Location = new System.Drawing.Point(376, 356);
            this.hintKtovet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintKtovet.Name = "hintKtovet";
            this.hintKtovet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintKtovet.Size = new System.Drawing.Size(413, 16);
            this.hintKtovet.TabIndex = 144;
            this.hintKtovet.Text = "label5";
            this.hintKtovet.Visible = false;
            // 
            // hintCity
            // 
            this.hintCity.ForeColor = System.Drawing.Color.Red;
            this.hintCity.Location = new System.Drawing.Point(377, 414);
            this.hintCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintCity.Name = "hintCity";
            this.hintCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintCity.Size = new System.Drawing.Size(413, 16);
            this.hintCity.TabIndex = 147;
            this.hintCity.Text = "label6";
            this.hintCity.Visible = false;
            // 
            // hintEmail
            // 
            this.hintEmail.ForeColor = System.Drawing.Color.Red;
            this.hintEmail.Location = new System.Drawing.Point(377, 295);
            this.hintEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintEmail.Name = "hintEmail";
            this.hintEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintEmail.Size = new System.Drawing.Size(413, 16);
            this.hintEmail.TabIndex = 141;
            this.hintEmail.Text = "label4";
            this.hintEmail.Visible = false;
            // 
            // splSeparate
            // 
            this.splSeparate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splSeparate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splSeparate.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splSeparate.Dock = System.Windows.Forms.DockStyle.Top;
            this.splSeparate.Enabled = false;
            this.splSeparate.Location = new System.Drawing.Point(0, 352);
            this.splSeparate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splSeparate.MinimumSize = new System.Drawing.Size(1500, 4);
            this.splSeparate.Name = "splSeparate";
            this.splSeparate.Size = new System.Drawing.Size(1819, 5);
            this.splSeparate.TabIndex = 108;
            this.splSeparate.TabStop = false;
            // 
            // pnlTables
            // 
            this.pnlTables.Controls.Add(this.pnlData);
            this.pnlTables.Controls.Add(this.pnlResult);
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTables.Location = new System.Drawing.Point(0, 0);
            this.pnlTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(1819, 352);
            this.pnlTables.TabIndex = 106;
            // 
            // splMoveRight
            // 
            this.splMoveRight.Location = new System.Drawing.Point(0, 357);
            this.splMoveRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splMoveRight.Name = "splMoveRight";
            this.splMoveRight.Size = new System.Drawing.Size(59, 532);
            this.splMoveRight.TabIndex = 110;
            this.splMoveRight.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.pnlResultButtons);
            this.pnlButtons.Controls.Add(this.pnlUpperActionButtons);
            this.pnlButtons.Controls.Add(this.pnlLowerActionButtons);
            this.pnlButtons.Controls.Add(this.splMoveUp);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(59, 357);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(809, 532);
            this.pnlButtons.TabIndex = 109;
            // 
            // pnlResultButtons
            // 
            this.pnlResultButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResultButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlResultButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResultButtons.Controls.Add(this.lblSearchQuantity);
            this.pnlResultButtons.Controls.Add(this.btnLast);
            this.pnlResultButtons.Controls.Add(this.btnFirst);
            this.pnlResultButtons.Controls.Add(this.btnNext);
            this.pnlResultButtons.Controls.Add(this.btnPrevious);
            this.pnlResultButtons.Location = new System.Drawing.Point(47, 20);
            this.pnlResultButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResultButtons.MaximumSize = new System.Drawing.Size(593, 160);
            this.pnlResultButtons.MinimumSize = new System.Drawing.Size(593, 160);
            this.pnlResultButtons.Name = "pnlResultButtons";
            this.pnlResultButtons.Size = new System.Drawing.Size(593, 160);
            this.pnlResultButtons.TabIndex = 106;
            this.pnlResultButtons.Visible = false;
            // 
            // lblSearchQuantity
            // 
            this.lblSearchQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSearchQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSearchQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSearchQuantity.Location = new System.Drawing.Point(0, 0);
            this.lblSearchQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchQuantity.Name = "lblSearchQuantity";
            this.lblSearchQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchQuantity.Size = new System.Drawing.Size(589, 60);
            this.lblSearchQuantity.TabIndex = 99;
            this.lblSearchQuantity.Text = "ציוד: X מתוך Y";
            this.lblSearchQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(33, 96);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(117, 43);
            this.btnLast.TabIndex = 14;
            this.btnLast.Text = "האחרון";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(445, 96);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(117, 43);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "הראשון";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(159, 96);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 43);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(320, 96);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(117, 43);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "הקודם";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // sapakTableAdapter
            // 
            this.sapakTableAdapter.ClearBeforeFill = true;
            // 
            // SapakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1819, 889);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTexts);
            this.Controls.Add(this.splMoveRight);
            this.Controls.Add(this.splSeparate);
            this.Controls.Add(this.pnlTables);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SapakForm";
            this.Text = "HazmanotForm";
            this.Load += new System.EventHandler(this.SapakForm_Load);
            this.SizeChanged += new System.EventHandler(this.SapakForm_SizeChanged);
            this.pnlResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.pnlUpperActionButtons.ResumeLayout(false);
            this.pnlLowerActionButtons.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.pnlTexts.ResumeLayout(false);
            this.pnlTexts.PerformLayout();
            this.pnlTables.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlResultButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splMoveUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Button btnCloseSrch;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Splitter splResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Splitter splHalf;
        private System.Windows.Forms.Panel pnlUpperActionButtons;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlLowerActionButtons;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel pnlTexts;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Splitter splSeparate;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.Splitter splMoveRight;
        private System.Windows.Forms.Panel pnlButtons;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource sapakBindingSource;
        private HospitalDataSetTableAdapters.SapakTableAdapter sapakTableAdapter;
        private System.Windows.Forms.TextBox txtShem;
        private System.Windows.Forms.Label lblShem;
        private System.Windows.Forms.Label hintShem;
        private System.Windows.Forms.Label hintTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label hintEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtKtovet;
        private System.Windows.Forms.Label lblKtovet;
        private System.Windows.Forms.Label hintKtovet;
        private System.Windows.Forms.TextBox txtMispar;
        private System.Windows.Forms.Label lblMispar;
        private System.Windows.Forms.Label hintMispar;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label hintCity;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Panel pnlResultButtons;
        private System.Windows.Forms.Label lblSearchQuantity;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}