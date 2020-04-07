namespace DarQuran
{
    partial class ListStudents
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
            this.korsAndstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darQuranDataSet = new DarQuran.DarQuranDataSet();
            this.korsAndstudentsTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.korsAndstudentsTableAdapter();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelMName = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.listBoxNewSINK = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMa3lomat = new System.Windows.Forms.Button();
            this.buttonDeleteS = new System.Windows.Forms.Button();
            this.buttonAddS = new System.Windows.Forms.Button();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelKors = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.studentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.korsAndstudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // korsAndstudentsBindingSource
            // 
            this.korsAndstudentsBindingSource.DataMember = "korsAndstudents";
            this.korsAndstudentsBindingSource.DataSource = this.darQuranDataSet;
            // 
            // darQuranDataSet
            // 
            this.darQuranDataSet.DataSetName = "DarQuranDataSet";
            this.darQuranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korsAndstudentsTableAdapter
            // 
            this.korsAndstudentsTableAdapter.ClearBeforeFill = true;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(525, 135);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxStudents.Size = new System.Drawing.Size(180, 186);
            this.listBoxStudents.TabIndex = 1;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(537, 345);
            this.txtID.Mask = "000000000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(111, 20);
            this.txtID.TabIndex = 14;
            this.txtID.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPhone.Location = new System.Drawing.Point(345, 344);
            this.txtPhone.Mask = "000-0000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.Size = new System.Drawing.Size(111, 20);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.Visible = false;
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Location = new System.Drawing.Point(656, 444);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(50, 13);
            this.labelMName.TabIndex = 22;
            this.labelMName.Text = "اسم الوالد";
            this.labelMName.Visible = false;
            // 
            // txtMName
            // 
            this.txtMName.Enabled = false;
            this.txtMName.Location = new System.Drawing.Point(537, 441);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(113, 20);
            this.txtMName.TabIndex = 21;
            this.txtMName.Visible = false;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimePickerDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerDate.Location = new System.Drawing.Point(345, 377);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerDate.TabIndex = 6;
            this.dateTimePickerDate.Value = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            this.dateTimePickerDate.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(459, 383);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(62, 13);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "تاريخ الميلاد";
            this.labelDate.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(462, 348);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 13);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "رقم هاتف";
            this.labelPhone.Visible = false;
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(654, 410);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(55, 13);
            this.labelLname.TabIndex = 8;
            this.labelLname.Text = "اسم العائلة";
            this.labelLname.Visible = false;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(649, 377);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(62, 13);
            this.labelFName.TabIndex = 7;
            this.labelFName.Text = "اسم شخصي";
            this.labelFName.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(656, 348);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(53, 13);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "رقم الهوية";
            this.labelID.Visible = false;
            // 
            // txtLName
            // 
            this.txtLName.Enabled = false;
            this.txtLName.Location = new System.Drawing.Point(537, 408);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(111, 20);
            this.txtLName.TabIndex = 2;
            this.txtLName.Visible = false;
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(537, 377);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(111, 20);
            this.txtFName.TabIndex = 1;
            this.txtFName.Visible = false;
            // 
            // listBoxNewSINK
            // 
            this.listBoxNewSINK.FormattingEnabled = true;
            this.listBoxNewSINK.Location = new System.Drawing.Point(229, 135);
            this.listBoxNewSINK.Name = "listBoxNewSINK";
            this.listBoxNewSINK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxNewSINK.Size = new System.Drawing.Size(180, 108);
            this.listBoxNewSINK.TabIndex = 24;
            this.listBoxNewSINK.Visible = false;
            this.listBoxNewSINK.SelectedIndexChanged += new System.EventHandler(this.listBoxNewSINK_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(429, 135);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 27);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "إضافة طالب\r\n";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMa3lomat
            // 
            this.buttonMa3lomat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMa3lomat.Location = new System.Drawing.Point(431, 168);
            this.buttonMa3lomat.Name = "buttonMa3lomat";
            this.buttonMa3lomat.Size = new System.Drawing.Size(90, 42);
            this.buttonMa3lomat.TabIndex = 26;
            this.buttonMa3lomat.Text = "معلومات عن طالب";
            this.buttonMa3lomat.UseVisualStyleBackColor = true;
            this.buttonMa3lomat.Visible = false;
            this.buttonMa3lomat.Click += new System.EventHandler(this.buttonMa3lomat_Click);
            // 
            // buttonDeleteS
            // 
            this.buttonDeleteS.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteS.Location = new System.Drawing.Point(421, 216);
            this.buttonDeleteS.Name = "buttonDeleteS";
            this.buttonDeleteS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDeleteS.Size = new System.Drawing.Size(100, 36);
            this.buttonDeleteS.TabIndex = 26;
            this.buttonDeleteS.Text = "حذف";
            this.buttonDeleteS.UseVisualStyleBackColor = false;
            this.buttonDeleteS.Click += new System.EventHandler(this.buttonDeleteS_Click);
            // 
            // buttonAddS
            // 
            this.buttonAddS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAddS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddS.Location = new System.Drawing.Point(229, 249);
            this.buttonAddS.Name = "buttonAddS";
            this.buttonAddS.Size = new System.Drawing.Size(180, 23);
            this.buttonAddS.TabIndex = 27;
            this.buttonAddS.Text = "ادخل الطالب ع الكرس";
            this.buttonAddS.UseVisualStyleBackColor = false;
            this.buttonAddS.Visible = false;
            this.buttonAddS.Click += new System.EventHandler(this.buttonAddS_Click);
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTeacher.Location = new System.Drawing.Point(442, 59);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(70, 25);
            this.labelTeacher.TabIndex = 28;
            this.labelTeacher.Text = "label1";
            // 
            // labelKors
            // 
            this.labelKors.AutoSize = true;
            this.labelKors.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelKors.ForeColor = System.Drawing.Color.Aqua;
            this.labelKors.Location = new System.Drawing.Point(426, 22);
            this.labelKors.Name = "labelKors";
            this.labelKors.Size = new System.Drawing.Size(108, 37);
            this.labelKors.TabIndex = 29;
            this.labelKors.Text = "label2";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.darQuranDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // ListStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 481);
            this.Controls.Add(this.labelKors);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.buttonAddS);
            this.Controls.Add(this.buttonDeleteS);
            this.Controls.Add(this.buttonMa3lomat);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.listBoxNewSINK);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ListStudents";
            this.Text = "الكرس المختار";
            this.Load += new System.EventHandler(this.ListStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korsAndstudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarQuranDataSet darQuranDataSet;
        private System.Windows.Forms.BindingSource korsAndstudentsBindingSource;
        private DarQuranDataSetTableAdapters.korsAndstudentsTableAdapter korsAndstudentsTableAdapter;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label labelMName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.ListBox listBoxNewSINK;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMa3lomat;
        private System.Windows.Forms.Button buttonDeleteS;
        private System.Windows.Forms.Button buttonAddS;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelKors;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DarQuranDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
    }
}