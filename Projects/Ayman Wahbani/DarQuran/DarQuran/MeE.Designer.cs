namespace DarQuran
{
    partial class MeE
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
            this.panelNewT = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.darQuranDataSet = new DarQuran.DarQuranDataSet();
            this.mnhelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnhelTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.mnhelTableAdapter();
            this.panelNewT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnhelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNewT
            // 
            this.panelNewT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelNewT.Controls.Add(this.buttonEdit);
            this.panelNewT.Controls.Add(this.comboBoxEmail);
            this.panelNewT.Controls.Add(this.label9);
            this.panelNewT.Controls.Add(this.label10);
            this.panelNewT.Controls.Add(this.labelEmail);
            this.panelNewT.Controls.Add(this.textBoxEmail);
            this.panelNewT.Controls.Add(this.labelGender);
            this.panelNewT.Controls.Add(this.label18);
            this.panelNewT.Controls.Add(this.comboBoxgender);
            this.panelNewT.Controls.Add(this.labelPassword);
            this.panelNewT.Controls.Add(this.labelUser);
            this.panelNewT.Controls.Add(this.label20);
            this.panelNewT.Controls.Add(this.label21);
            this.panelNewT.Controls.Add(this.textBoxPassword);
            this.panelNewT.Controls.Add(this.textBoxUsername);
            this.panelNewT.Controls.Add(this.labelPhone);
            this.panelNewT.Controls.Add(this.labelLName);
            this.panelNewT.Controls.Add(this.textBoxID);
            this.panelNewT.Controls.Add(this.textBoxPhone);
            this.panelNewT.Controls.Add(this.dateTimePickerBirth);
            this.panelNewT.Controls.Add(this.labelFName);
            this.panelNewT.Controls.Add(this.labelID);
            this.panelNewT.Controls.Add(this.label5);
            this.panelNewT.Controls.Add(this.label4);
            this.panelNewT.Controls.Add(this.label3);
            this.panelNewT.Controls.Add(this.label2);
            this.panelNewT.Controls.Add(this.label1);
            this.panelNewT.Controls.Add(this.textBoxLName);
            this.panelNewT.Controls.Add(this.textBoxFName);
            this.panelNewT.Location = new System.Drawing.Point(2, 1);
            this.panelNewT.Name = "panelNewT";
            this.panelNewT.Size = new System.Drawing.Size(336, 398);
            this.panelNewT.TabIndex = 23;
            this.panelNewT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNewT_Paint);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Lime;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(2, 351);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonEdit.Size = new System.Drawing.Size(100, 36);
            this.buttonEdit.TabIndex = 43;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Items.AddRange(new object[] {
            "(اختار طريق الارسال(الايميل",
            "hotmail.com",
            "gmail.com",
            "walla.co.il"});
            this.comboBoxEmail.Location = new System.Drawing.Point(101, 234);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(142, 21);
            this.comboBoxEmail.TabIndex = 42;
            this.comboBoxEmail.Text = "(اختار طريق الارسال(الايميل";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "@";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "الايميل";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.Red;
            this.labelEmail.Location = new System.Drawing.Point(109, 258);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 13);
            this.labelEmail.TabIndex = 39;
            this.labelEmail.Text = "label21";
            this.labelEmail.Visible = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(10, 235);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(76, 20);
            this.textBoxEmail.TabIndex = 38;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.ForeColor = System.Drawing.Color.Red;
            this.labelGender.Location = new System.Drawing.Point(112, 300);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(41, 13);
            this.labelGender.TabIndex = 37;
            this.labelGender.Text = "label25";
            this.labelGender.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(251, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "الجنس";
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.comboBoxgender.Location = new System.Drawing.Point(115, 276);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(116, 21);
            this.comboBoxgender.TabIndex = 35;
            this.comboBoxgender.Text = ":اختار جنس الطالي\\ة";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.Red;
            this.labelPassword.Location = new System.Drawing.Point(116, 64);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(41, 13);
            this.labelPassword.TabIndex = 34;
            this.labelPassword.Text = "label26";
            this.labelPassword.Visible = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.Red;
            this.labelUser.Location = new System.Drawing.Point(116, 29);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(41, 13);
            this.labelUser.TabIndex = 33;
            this.labelUser.Text = "label20";
            this.labelUser.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(226, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "كلمة السر";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(226, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "اسم المستخدم";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(109, 41);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(112, 20);
            this.textBoxPassword.TabIndex = 30;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(109, 6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(112, 20);
            this.textBoxUsername.TabIndex = 29;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.ForeColor = System.Drawing.Color.Red;
            this.labelPhone.Location = new System.Drawing.Point(116, 222);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 25;
            this.labelPhone.Text = "label24";
            this.labelPhone.Visible = false;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.ForeColor = System.Drawing.Color.Red;
            this.labelLName.Location = new System.Drawing.Point(112, 183);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(41, 13);
            this.labelLName.TabIndex = 27;
            this.labelLName.Text = "label26";
            this.labelLName.Visible = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(110, 80);
            this.textBoxID.Mask = "000009999";
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(111, 20);
            this.textBoxID.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPhone.Location = new System.Drawing.Point(115, 200);
            this.textBoxPhone.Mask = "000-0000000";
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPhone.Size = new System.Drawing.Size(111, 20);
            this.textBoxPhone.TabIndex = 14;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimePickerBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirth.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(108, 314);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerBirth.TabIndex = 6;
            this.dateTimePickerBirth.Value = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.ForeColor = System.Drawing.Color.Red;
            this.labelFName.Location = new System.Drawing.Point(109, 138);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(41, 13);
            this.labelFName.TabIndex = 21;
            this.labelFName.Text = "label20";
            this.labelFName.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.Color.Red;
            this.labelID.Location = new System.Drawing.Point(116, 103);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 13);
            this.labelID.TabIndex = 20;
            this.labelID.Text = "label19";
            this.labelID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "تاريخ الميلاد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "رقم هاتف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "اسم العائلة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "اسم شخصي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "رقم الهوية";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(109, 154);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(112, 20);
            this.textBoxLName.TabIndex = 2;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(110, 117);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(112, 20);
            this.textBoxFName.TabIndex = 1;
            // 
            // darQuranDataSet
            // 
            this.darQuranDataSet.DataSetName = "DarQuranDataSet";
            this.darQuranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mnhelBindingSource
            // 
            this.mnhelBindingSource.DataMember = "mnhel";
            this.mnhelBindingSource.DataSource = this.darQuranDataSet;
            // 
            // mnhelTableAdapter
            // 
            this.mnhelTableAdapter.ClearBeforeFill = true;
            // 
            // MeE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 400);
            this.Controls.Add(this.panelNewT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeE";
            this.Text = "MeE";
            this.Load += new System.EventHandler(this.MeE_Load);
            this.panelNewT.ResumeLayout(false);
            this.panelNewT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnhelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewT;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.MaskedTextBox textBoxID;
        private System.Windows.Forms.MaskedTextBox textBoxPhone;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Button buttonEdit;
        private DarQuranDataSet darQuranDataSet;
        private System.Windows.Forms.BindingSource mnhelBindingSource;
        private DarQuranDataSetTableAdapters.mnhelTableAdapter mnhelTableAdapter;

    }
}