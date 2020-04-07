namespace DarQuran
{
    partial class BetKasef
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetKasef));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersFamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tshlomYeshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tashlomnotarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betHKisifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darQuranDataSet = new DarQuran.DarQuranDataSet();
            this.betHKisifTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.BetHKisifTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.money = new System.Windows.Forms.MaskedTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.math = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FN = new System.Windows.Forms.Label();
            this.NT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.daymonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daymonthTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.DaymonthTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betHKisifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daymonthBindingSource)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tZDataGridViewTextBoxColumn,
            this.teachersNameDataGridViewTextBoxColumn,
            this.teachersFamilyDataGridViewTextBoxColumn,
            this.tshlomYeshDataGridViewTextBoxColumn,
            this.tashlomnotarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.betHKisifBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(512, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tZDataGridViewTextBoxColumn
            // 
            this.tZDataGridViewTextBoxColumn.DataPropertyName = "TZ";
            this.tZDataGridViewTextBoxColumn.HeaderText = "رقم الهوية";
            this.tZDataGridViewTextBoxColumn.Name = "tZDataGridViewTextBoxColumn";
            // 
            // teachersNameDataGridViewTextBoxColumn
            // 
            this.teachersNameDataGridViewTextBoxColumn.DataPropertyName = "teacher\'s name";
            this.teachersNameDataGridViewTextBoxColumn.HeaderText = "الاسم الشخصي";
            this.teachersNameDataGridViewTextBoxColumn.Name = "teachersNameDataGridViewTextBoxColumn";
            // 
            // teachersFamilyDataGridViewTextBoxColumn
            // 
            this.teachersFamilyDataGridViewTextBoxColumn.DataPropertyName = "teacher\'s family";
            this.teachersFamilyDataGridViewTextBoxColumn.HeaderText = "اسم العائلة";
            this.teachersFamilyDataGridViewTextBoxColumn.Name = "teachersFamilyDataGridViewTextBoxColumn";
            // 
            // tshlomYeshDataGridViewTextBoxColumn
            // 
            this.tshlomYeshDataGridViewTextBoxColumn.DataPropertyName = "tshlom yesh";
            this.tshlomYeshDataGridViewTextBoxColumn.HeaderText = "الميلغ المدفوع";
            this.tshlomYeshDataGridViewTextBoxColumn.Name = "tshlomYeshDataGridViewTextBoxColumn";
            // 
            // tashlomnotarDataGridViewTextBoxColumn
            // 
            this.tashlomnotarDataGridViewTextBoxColumn.DataPropertyName = "tashlomnotar";
            this.tashlomnotarDataGridViewTextBoxColumn.HeaderText = "المبلغ المتبقي للدفع";
            this.tashlomnotarDataGridViewTextBoxColumn.Name = "tashlomnotarDataGridViewTextBoxColumn";
            // 
            // betHKisifBindingSource
            // 
            this.betHKisifBindingSource.DataMember = "BetHKisif";
            this.betHKisifBindingSource.DataSource = this.darQuranDataSet;
            // 
            // darQuranDataSet
            // 
            this.darQuranDataSet.DataSetName = "DarQuranDataSet";
            this.darQuranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betHKisifTableAdapter
            // 
            this.betHKisifTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.money);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.math);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FN);
            this.panel1.Controls.Add(this.NT);
            this.panel1.Location = new System.Drawing.Point(158, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 150);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // money
            // 
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.money.Location = new System.Drawing.Point(103, 73);
            this.money.Mask = "000";
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(60, 29);
            this.money.TabIndex = 6;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(226, 159);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "اغلق";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // math
            // 
            this.math.BackColor = System.Drawing.Color.Lime;
            this.math.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.math.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.math.Location = new System.Drawing.Point(63, 127);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(183, 23);
            this.math.TabIndex = 4;
            this.math.Text = "ادخل المبلغ ";
            this.math.UseVisualStyleBackColor = false;
            this.math.Click += new System.EventHandler(this.math_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "أدخل المبلغ الدي تريد دفعه";
            // 
            // FN
            // 
            this.FN.AutoSize = true;
            this.FN.Font = new System.Drawing.Font("OCR A Extended", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.Location = new System.Drawing.Point(82, 19);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(94, 23);
            this.FN.TabIndex = 1;
            this.FN.Text = "label1";
            // 
            // NT
            // 
            this.NT.AutoSize = true;
            this.NT.Font = new System.Drawing.Font("OCR A Extended", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NT.Location = new System.Drawing.Point(171, 19);
            this.NT.Name = "NT";
            this.NT.Size = new System.Drawing.Size(94, 23);
            this.NT.TabIndex = 0;
            this.NT.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(1079, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 436);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(586, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "أضغط مرتيين متتاليتان غلر السطر الذي تريد ادخال بواسطته المبلغ";
            // 
            // daymonthTableAdapter
            // 
            this.daymonthTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(305, 76);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(755, 100);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Gold;
            this.panelSearch.Controls.Add(this.button1);
            this.panelSearch.Controls.Add(this.dataGridViewSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Location = new System.Drawing.Point(512, 375);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(552, 258);
            this.panelSearch.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(468, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 59;
            this.button1.Text = "أغلق بحث الكرس";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(0, 58);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewSearch.Size = new System.Drawing.Size(552, 197);
            this.dataGridViewSearch.TabIndex = 10;
            this.dataGridViewSearch.Visible = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxSearch.Location = new System.Drawing.Point(33, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(257, 29);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Miriam Fixed", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSearch.ForeColor = System.Drawing.Color.Red;
            this.labelSearch.Location = new System.Drawing.Point(318, 8);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(59, 35);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "بحث";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(724, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 42);
            this.label10.TabIndex = 36;
            this.label10.Text = "بيت المال";
            // 
            // BetKasef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 697);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BetKasef";
            this.Text = "BetKasef";
            this.Load += new System.EventHandler(this.BetKasef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betHKisifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daymonthBindingSource)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DarQuranDataSet darQuranDataSet;
        private System.Windows.Forms.BindingSource betHKisifBindingSource;
        private DarQuranDataSetTableAdapters.BetHKisifTableAdapter betHKisifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersFamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tshlomYeshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tashlomnotarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button math;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FN;
        private System.Windows.Forms.Label NT;
        private System.Windows.Forms.MaskedTextBox money;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource daymonthBindingSource;
        private DarQuranDataSetTableAdapters.DaymonthTableAdapter daymonthTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label label10;
    }
}