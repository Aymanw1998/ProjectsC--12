namespace christina_hourses
{
    partial class mascoret
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
            this.oved = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.mscoret = new System.Windows.Forms.Label();
            this.txb_shem = new System.Windows.Forms.TextBox();
            this.txb_hour = new System.Windows.Forms.TextBox();
            this.txb_mscoret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_show = new System.Windows.Forms.CheckBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.combokod = new System.Windows.Forms.ComboBox();
            this.hoursesDataSet = new christina_hourses.hoursesDataSet();
            this.workeersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workeersTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.workeersTableAdapter();
            this.misparOvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeshoovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mishpahaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shaotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shaotTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.shaotTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mishmarotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mishmarotTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.mishmarotTableAdapter();
            this.misparOvedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oved
            // 
            this.oved.AutoSize = true;
            this.oved.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.oved.Location = new System.Drawing.Point(458, 239);
            this.oved.Name = "oved";
            this.oved.Size = new System.Drawing.Size(100, 29);
            this.oved.TabIndex = 1;
            this.oved.Text = "שם עובד";
            this.oved.Visible = false;
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour.Location = new System.Drawing.Point(458, 291);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(144, 29);
            this.hour.TabIndex = 2;
            this.hour.Text = "שעות עבודה ";
            this.hour.Visible = false;
            // 
            // mscoret
            // 
            this.mscoret.AutoSize = true;
            this.mscoret.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mscoret.Location = new System.Drawing.Point(458, 341);
            this.mscoret.Name = "mscoret";
            this.mscoret.Size = new System.Drawing.Size(95, 29);
            this.mscoret.TabIndex = 3;
            this.mscoret.Text = "משכורת";
            this.mscoret.Visible = false;
            // 
            // txb_shem
            // 
            this.txb_shem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_shem.Location = new System.Drawing.Point(299, 248);
            this.txb_shem.Name = "txb_shem";
            this.txb_shem.Size = new System.Drawing.Size(146, 20);
            this.txb_shem.TabIndex = 9;
            this.txb_shem.Visible = false;
            this.txb_shem.WordWrap = false;
            this.txb_shem.TextChanged += new System.EventHandler(this.txb_shem_TextChanged);
            // 
            // txb_hour
            // 
            this.txb_hour.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_hour.Location = new System.Drawing.Point(299, 300);
            this.txb_hour.Name = "txb_hour";
            this.txb_hour.Size = new System.Drawing.Size(146, 20);
            this.txb_hour.TabIndex = 10;
            this.txb_hour.Visible = false;
            // 
            // txb_mscoret
            // 
            this.txb_mscoret.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_mscoret.Location = new System.Drawing.Point(299, 350);
            this.txb_mscoret.Name = "txb_mscoret";
            this.txb_mscoret.Size = new System.Drawing.Size(146, 20);
            this.txb_mscoret.TabIndex = 11;
            this.txb_mscoret.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(237, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "הזן מספר עובד לבדיקת פרטי משכורת";
            // 
            // checkBox_show
            // 
            this.checkBox_show.AutoSize = true;
            this.checkBox_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox_show.Location = new System.Drawing.Point(583, 167);
            this.checkBox_show.Name = "checkBox_show";
            this.checkBox_show.Size = new System.Drawing.Size(53, 24);
            this.checkBox_show.TabIndex = 13;
            this.checkBox_show.Text = "הצג";
            this.checkBox_show.UseVisualStyleBackColor = true;
            this.checkBox_show.CheckedChanged += new System.EventHandler(this.checkBox_show_CheckedChanged);
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textbox_password.Location = new System.Drawing.Point(268, 158);
            this.textbox_password.Multiline = true;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(285, 39);
            this.textbox_password.TabIndex = 12;
            this.textbox_password.TextChanged += new System.EventHandler(this.textbox_password_TextChanged);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_close.Location = new System.Drawing.Point(35, 382);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(129, 75);
            this.bt_close.TabIndex = 15;
            this.bt_close.Text = "חזרה לדף הראשי";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.Highlight;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OK.Location = new System.Drawing.Point(147, 161);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(105, 36);
            this.OK.TabIndex = 16;
            this.OK.Text = "אישור";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // combokod
            // 
            this.combokod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combokod.FormattingEnabled = true;
            this.combokod.Location = new System.Drawing.Point(268, 167);
            this.combokod.Name = "combokod";
            this.combokod.Size = new System.Drawing.Size(285, 21);
            this.combokod.TabIndex = 17;
            this.combokod.Visible = false;
            this.combokod.SelectedIndexChanged += new System.EventHandler(this.combokod_SelectedIndexChanged);
            // 
            // hoursesDataSet
            // 
            this.hoursesDataSet.DataSetName = "hoursesDataSet";
            this.hoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workeersBindingSource
            // 
            this.workeersBindingSource.DataMember = "workeers";
            this.workeersBindingSource.DataSource = this.hoursesDataSet;
            // 
            // workeersTableAdapter
            // 
            this.workeersTableAdapter.ClearBeforeFill = true;
            // 
            // misparOvedDataGridViewTextBoxColumn
            // 
            this.misparOvedDataGridViewTextBoxColumn.DataPropertyName = "mispar oved";
            this.misparOvedDataGridViewTextBoxColumn.HeaderText = "mispar oved";
            this.misparOvedDataGridViewTextBoxColumn.Name = "misparOvedDataGridViewTextBoxColumn";
            // 
            // yeshoovDataGridViewTextBoxColumn
            // 
            this.yeshoovDataGridViewTextBoxColumn.DataPropertyName = "yeshoov";
            this.yeshoovDataGridViewTextBoxColumn.HeaderText = "yeshoov";
            this.yeshoovDataGridViewTextBoxColumn.Name = "yeshoovDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // gilDataGridViewTextBoxColumn
            // 
            this.gilDataGridViewTextBoxColumn.DataPropertyName = "gil";
            this.gilDataGridViewTextBoxColumn.HeaderText = "gil";
            this.gilDataGridViewTextBoxColumn.Name = "gilDataGridViewTextBoxColumn";
            // 
            // mishpahaDataGridViewTextBoxColumn
            // 
            this.mishpahaDataGridViewTextBoxColumn.DataPropertyName = "mishpaha";
            this.mishpahaDataGridViewTextBoxColumn.HeaderText = "mishpaha";
            this.mishpahaDataGridViewTextBoxColumn.Name = "mishpahaDataGridViewTextBoxColumn";
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "shem";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.shemDataGridViewTextBoxColumn,
            this.mishpahaDataGridViewTextBoxColumn,
            this.gilDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.yeshoovDataGridViewTextBoxColumn,
            this.misparOvedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workeersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(76, 35);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Visible = false;
            // 
            // shaotBindingSource
            // 
            this.shaotBindingSource.DataMember = "shaot";
            this.shaotBindingSource.DataSource = this.hoursesDataSet;
            // 
            // shaotTableAdapter
            // 
            this.shaotTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.misparOvedDataGridViewTextBoxColumn1,
            this.tarichDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.beginDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mishmarotBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(138, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(543, 62);
            this.dataGridView2.TabIndex = 19;
            // 
            // mishmarotBindingSource
            // 
            this.mishmarotBindingSource.DataMember = "mishmarot";
            this.mishmarotBindingSource.DataSource = this.hoursesDataSet;
            // 
            // mishmarotTableAdapter
            // 
            this.mishmarotTableAdapter.ClearBeforeFill = true;
            // 
            // misparOvedDataGridViewTextBoxColumn1
            // 
            this.misparOvedDataGridViewTextBoxColumn1.DataPropertyName = "mispar oved";
            this.misparOvedDataGridViewTextBoxColumn1.HeaderText = "mispar oved";
            this.misparOvedDataGridViewTextBoxColumn1.Name = "misparOvedDataGridViewTextBoxColumn1";
            // 
            // tarichDataGridViewTextBoxColumn
            // 
            this.tarichDataGridViewTextBoxColumn.DataPropertyName = "tarich";
            this.tarichDataGridViewTextBoxColumn.HeaderText = "tarich";
            this.tarichDataGridViewTextBoxColumn.Name = "tarichDataGridViewTextBoxColumn";
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "end";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            // 
            // beginDataGridViewTextBoxColumn
            // 
            this.beginDataGridViewTextBoxColumn.DataPropertyName = "begin";
            this.beginDataGridViewTextBoxColumn.HeaderText = "begin";
            this.beginDataGridViewTextBoxColumn.Name = "beginDataGridViewTextBoxColumn";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // mascoret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(764, 472);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combokod);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_show);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.txb_mscoret);
            this.Controls.Add(this.txb_hour);
            this.Controls.Add(this.txb_shem);
            this.Controls.Add(this.mscoret);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.oved);
            this.Name = "mascoret";
            this.Text = "mascoret";
            this.Load += new System.EventHandler(this.mascoret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oved;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label mscoret;
        private System.Windows.Forms.TextBox txb_shem;
        private System.Windows.Forms.TextBox txb_hour;
        private System.Windows.Forms.TextBox txb_mscoret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_show;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox combokod;
        private hoursesDataSet hoursesDataSet;
        private System.Windows.Forms.BindingSource workeersBindingSource;
        private hoursesDataSetTableAdapters.workeersTableAdapter workeersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparOvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeshoovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mishpahaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource shaotBindingSource;
        private hoursesDataSetTableAdapters.shaotTableAdapter shaotTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource mishmarotBindingSource;
        private hoursesDataSetTableAdapters.mishmarotTableAdapter mishmarotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparOvedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
    }
}