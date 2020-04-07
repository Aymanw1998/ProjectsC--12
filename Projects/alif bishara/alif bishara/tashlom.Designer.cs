namespace alif_bishara
{
    partial class tashlom
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codekablaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tzLkoahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shamfamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skhomkolalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aofnTashlomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tashlomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Alif_s_databaseDataSet = new alif_bishara._Alif_s_databaseDataSet();
            this.txtTz = new System.Windows.Forms.MaskedTextBox();
            this.txtSham = new System.Windows.Forms.MaskedTextBox();
            this.txtShamMshpha = new System.Windows.Forms.MaskedTextBox();
            this.tzLkoah = new System.Windows.Forms.Label();
            this.lblSham = new System.Windows.Forms.Label();
            this.lblShamFamily = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAofnTashlom = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtskhom = new System.Windows.Forms.TextBox();
            this.lblSkhom = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.tashlomTableAdapter = new alif_bishara._Alif_s_databaseDataSetTableAdapters.tashlomTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txthknsa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btncalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tashlomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Alif_s_databaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codekablaDataGridViewTextBoxColumn,
            this.tzLkoahDataGridViewTextBoxColumn,
            this.shamDataGridViewTextBoxColumn,
            this.shamfamilyDataGridViewTextBoxColumn,
            this.tarikhDataGridViewTextBoxColumn,
            this.skhomkolalDataGridViewTextBoxColumn,
            this.aofnTashlomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tashlomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(248, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 119);
            this.dataGridView1.TabIndex = 0;
            // 
            // codekablaDataGridViewTextBoxColumn
            // 
            this.codekablaDataGridViewTextBoxColumn.DataPropertyName = "codekabla";
            this.codekablaDataGridViewTextBoxColumn.HeaderText = "codekabla";
            this.codekablaDataGridViewTextBoxColumn.Name = "codekablaDataGridViewTextBoxColumn";
            // 
            // tzLkoahDataGridViewTextBoxColumn
            // 
            this.tzLkoahDataGridViewTextBoxColumn.DataPropertyName = "tzLkoah";
            this.tzLkoahDataGridViewTextBoxColumn.HeaderText = "tzLkoah";
            this.tzLkoahDataGridViewTextBoxColumn.Name = "tzLkoahDataGridViewTextBoxColumn";
            // 
            // shamDataGridViewTextBoxColumn
            // 
            this.shamDataGridViewTextBoxColumn.DataPropertyName = "sham";
            this.shamDataGridViewTextBoxColumn.HeaderText = "sham";
            this.shamDataGridViewTextBoxColumn.Name = "shamDataGridViewTextBoxColumn";
            // 
            // shamfamilyDataGridViewTextBoxColumn
            // 
            this.shamfamilyDataGridViewTextBoxColumn.DataPropertyName = "shamfamily";
            this.shamfamilyDataGridViewTextBoxColumn.HeaderText = "shamfamily";
            this.shamfamilyDataGridViewTextBoxColumn.Name = "shamfamilyDataGridViewTextBoxColumn";
            // 
            // tarikhDataGridViewTextBoxColumn
            // 
            this.tarikhDataGridViewTextBoxColumn.DataPropertyName = "tarikh";
            this.tarikhDataGridViewTextBoxColumn.HeaderText = "tarikh";
            this.tarikhDataGridViewTextBoxColumn.Name = "tarikhDataGridViewTextBoxColumn";
            // 
            // skhomkolalDataGridViewTextBoxColumn
            // 
            this.skhomkolalDataGridViewTextBoxColumn.DataPropertyName = "skhomkolal";
            this.skhomkolalDataGridViewTextBoxColumn.HeaderText = "skhomkolal";
            this.skhomkolalDataGridViewTextBoxColumn.Name = "skhomkolalDataGridViewTextBoxColumn";
            // 
            // aofnTashlomDataGridViewTextBoxColumn
            // 
            this.aofnTashlomDataGridViewTextBoxColumn.DataPropertyName = "aofnTashlom";
            this.aofnTashlomDataGridViewTextBoxColumn.HeaderText = "aofnTashlom";
            this.aofnTashlomDataGridViewTextBoxColumn.Name = "aofnTashlomDataGridViewTextBoxColumn";
            // 
            // tashlomBindingSource
            // 
            this.tashlomBindingSource.DataMember = "tashlom";
            this.tashlomBindingSource.DataSource = this._Alif_s_databaseDataSet;
            // 
            // _Alif_s_databaseDataSet
            // 
            this._Alif_s_databaseDataSet.DataSetName = "_Alif_s_databaseDataSet";
            this._Alif_s_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTz
            // 
            this.txtTz.Location = new System.Drawing.Point(37, 11);
            this.txtTz.Mask = "000000000";
            this.txtTz.Name = "txtTz";
            this.txtTz.Size = new System.Drawing.Size(100, 32);
            this.txtTz.TabIndex = 1;
            this.txtTz.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTz_MaskInputRejected);
            // 
            // txtSham
            // 
            this.txtSham.Location = new System.Drawing.Point(37, 36);
            this.txtSham.Mask = "LL????????????????";
            this.txtSham.Name = "txtSham";
            this.txtSham.Size = new System.Drawing.Size(100, 32);
            this.txtSham.TabIndex = 2;
            // 
            // txtShamMshpha
            // 
            this.txtShamMshpha.Location = new System.Drawing.Point(37, 63);
            this.txtShamMshpha.Mask = "LL???????????????";
            this.txtShamMshpha.Name = "txtShamMshpha";
            this.txtShamMshpha.Size = new System.Drawing.Size(100, 32);
            this.txtShamMshpha.TabIndex = 3;
            // 
            // tzLkoah
            // 
            this.tzLkoah.AutoSize = true;
            this.tzLkoah.Location = new System.Drawing.Point(157, 18);
            this.tzLkoah.Name = "tzLkoah";
            this.tzLkoah.Size = new System.Drawing.Size(95, 25);
            this.tzLkoah.TabIndex = 4;
            this.tzLkoah.Text = "תעודת זהות";
            // 
            // lblSham
            // 
            this.lblSham.AutoSize = true;
            this.lblSham.Location = new System.Drawing.Point(157, 43);
            this.lblSham.Name = "lblSham";
            this.lblSham.Size = new System.Drawing.Size(35, 25);
            this.lblSham.TabIndex = 5;
            this.lblSham.Text = "שם";
            // 
            // lblShamFamily
            // 
            this.lblShamFamily.AutoSize = true;
            this.lblShamFamily.Location = new System.Drawing.Point(157, 70);
            this.lblShamFamily.Name = "lblShamFamily";
            this.lblShamFamily.Size = new System.Drawing.Size(101, 25);
            this.lblShamFamily.TabIndex = 6;
            this.lblShamFamily.Text = "שם משפחה ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ציקים",
            "מזומן"});
            this.comboBox1.Location = new System.Drawing.Point(37, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // lblAofnTashlom
            // 
            this.lblAofnTashlom.AutoSize = true;
            this.lblAofnTashlom.Location = new System.Drawing.Point(159, 101);
            this.lblAofnTashlom.Name = "lblAofnTashlom";
            this.lblAofnTashlom.Size = new System.Drawing.Size(97, 25);
            this.lblAofnTashlom.TabIndex = 8;
            this.lblAofnTashlom.Text = "אופן תשלום";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(113, 170);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(109, 42);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtskhom
            // 
            this.txtskhom.Enabled = false;
            this.txtskhom.Location = new System.Drawing.Point(37, 120);
            this.txtskhom.Name = "txtskhom";
            this.txtskhom.Size = new System.Drawing.Size(100, 32);
            this.txtskhom.TabIndex = 10;
            // 
            // lblSkhom
            // 
            this.lblSkhom.AutoSize = true;
            this.lblSkhom.Location = new System.Drawing.Point(161, 127);
            this.lblSkhom.Name = "lblSkhom";
            this.lblSkhom.Size = new System.Drawing.Size(87, 25);
            this.lblSkhom.TabIndex = 11;
            this.lblSkhom.Text = "סכום כולל";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Guttman Frnew", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearch.Location = new System.Drawing.Point(647, 157);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSkhom);
            this.panel1.Controls.Add(this.txtskhom);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.lblAofnTashlom);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblShamFamily);
            this.panel1.Controls.Add(this.lblSham);
            this.panel1.Controls.Add(this.tzLkoah);
            this.panel1.Controls.Add(this.txtShamMshpha);
            this.panel1.Controls.Add(this.txtSham);
            this.panel1.Controls.Add(this.txtTz);
            this.panel1.Font = new System.Drawing.Font("Guttman Frnew", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(955, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 240);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Guttman Frnew", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(798, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "חיפוש";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Guttman Frnew", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btndelete.Location = new System.Drawing.Point(471, 152);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(97, 40);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "מחיקה";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // tashlomTableAdapter
            // 
            this.tashlomTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txthknsa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btncheck);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Font = new System.Drawing.Font("Guttman Frnew", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel2.Location = new System.Drawing.Point(471, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 222);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txthknsa
            // 
            this.txthknsa.Location = new System.Drawing.Point(76, 160);
            this.txthknsa.Name = "txthknsa";
            this.txthknsa.ReadOnly = true;
            this.txthknsa.Size = new System.Drawing.Size(96, 32);
            this.txthknsa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "סה\"כ הכנסה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "עד תאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "מתאריך";
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(188, 84);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(105, 49);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "בדוק";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(1054, 437);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(123, 49);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "חישוב הכנסות";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // tashlom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 511);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tashlom";
            this.Text = " ";
            this.Load += new System.EventHandler(this.tashlom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tashlomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Alif_s_databaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _Alif_s_databaseDataSet _Alif_s_databaseDataSet;
        private System.Windows.Forms.BindingSource tashlomBindingSource;
        private _Alif_s_databaseDataSetTableAdapters.tashlomTableAdapter tashlomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codekablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzLkoahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shamfamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarikhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skhomkolalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aofnTashlomDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox txtTz;
        private System.Windows.Forms.MaskedTextBox txtSham;
        private System.Windows.Forms.MaskedTextBox txtShamMshpha;
        private System.Windows.Forms.Label tzLkoah;
        private System.Windows.Forms.Label lblSham;
        private System.Windows.Forms.Label lblShamFamily;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAofnTashlom;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtskhom;
        private System.Windows.Forms.Label lblSkhom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txthknsa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btncalculate;
    }
}