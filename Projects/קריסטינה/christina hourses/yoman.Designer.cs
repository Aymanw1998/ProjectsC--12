namespace christina_hourses
{
    partial class yoman
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
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sundayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursdyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fridayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satardayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoman1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoursesDataSet = new christina_hourses.hoursesDataSet();
            this.yoman1TableAdapter = new christina_hourses.hoursesDataSetTableAdapters.yoman1TableAdapter();
            this.hour = new System.Windows.Forms.MaskedTextBox();
            this.activity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hour2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.activityTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_tarich = new System.Windows.Forms.MaskedTextBox();
            this.txb_worker = new System.Windows.Forms.ComboBox();
            this.workeersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workeersTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.workeersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoman1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoursDataGridViewTextBoxColumn,
            this.sundayDataGridViewTextBoxColumn,
            this.mondayDataGridViewTextBoxColumn,
            this.tuesdayDataGridViewTextBoxColumn,
            this.wednesdayDataGridViewTextBoxColumn,
            this.thursdyDataGridViewTextBoxColumn,
            this.fridayDataGridViewTextBoxColumn,
            this.satardayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yoman1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 906);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "שעות";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            // 
            // sundayDataGridViewTextBoxColumn
            // 
            this.sundayDataGridViewTextBoxColumn.DataPropertyName = "sunday";
            this.sundayDataGridViewTextBoxColumn.HeaderText = "ראשון";
            this.sundayDataGridViewTextBoxColumn.Name = "sundayDataGridViewTextBoxColumn";
            // 
            // mondayDataGridViewTextBoxColumn
            // 
            this.mondayDataGridViewTextBoxColumn.DataPropertyName = "monday";
            this.mondayDataGridViewTextBoxColumn.HeaderText = "שני";
            this.mondayDataGridViewTextBoxColumn.Name = "mondayDataGridViewTextBoxColumn";
            // 
            // tuesdayDataGridViewTextBoxColumn
            // 
            this.tuesdayDataGridViewTextBoxColumn.DataPropertyName = "tuesday";
            this.tuesdayDataGridViewTextBoxColumn.HeaderText = "שלישי";
            this.tuesdayDataGridViewTextBoxColumn.Name = "tuesdayDataGridViewTextBoxColumn";
            // 
            // wednesdayDataGridViewTextBoxColumn
            // 
            this.wednesdayDataGridViewTextBoxColumn.DataPropertyName = "wednesday";
            this.wednesdayDataGridViewTextBoxColumn.HeaderText = "רביעי";
            this.wednesdayDataGridViewTextBoxColumn.Name = "wednesdayDataGridViewTextBoxColumn";
            // 
            // thursdyDataGridViewTextBoxColumn
            // 
            this.thursdyDataGridViewTextBoxColumn.DataPropertyName = "thursdy";
            this.thursdyDataGridViewTextBoxColumn.HeaderText = "חמישי";
            this.thursdyDataGridViewTextBoxColumn.Name = "thursdyDataGridViewTextBoxColumn";
            // 
            // fridayDataGridViewTextBoxColumn
            // 
            this.fridayDataGridViewTextBoxColumn.DataPropertyName = "friday";
            this.fridayDataGridViewTextBoxColumn.HeaderText = "שישי";
            this.fridayDataGridViewTextBoxColumn.Name = "fridayDataGridViewTextBoxColumn";
            // 
            // satardayDataGridViewTextBoxColumn
            // 
            this.satardayDataGridViewTextBoxColumn.DataPropertyName = "satarday";
            this.satardayDataGridViewTextBoxColumn.HeaderText = "שבת";
            this.satardayDataGridViewTextBoxColumn.Name = "satardayDataGridViewTextBoxColumn";
            // 
            // yoman1BindingSource
            // 
            this.yoman1BindingSource.DataMember = "yoman1";
            this.yoman1BindingSource.DataSource = this.hoursesDataSet;
            // 
            // hoursesDataSet
            // 
            this.hoursesDataSet.DataSetName = "hoursesDataSet";
            this.hoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yoman1TableAdapter
            // 
            this.yoman1TableAdapter.ClearBeforeFill = true;
            // 
            // hour
            // 
            this.hour.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hour.Location = new System.Drawing.Point(857, 214);
            this.hour.Mask = "90:00";
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(171, 29);
            this.hour.TabIndex = 12;
            this.hour.ValidatingType = typeof(System.DateTime);
            // 
            // activity
            // 
            this.activity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.activity.Location = new System.Drawing.Point(857, 395);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(171, 29);
            this.activity.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(900, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "פעילות";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(920, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "שעה";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.day.Location = new System.Drawing.Point(920, 15);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(44, 29);
            this.day.TabIndex = 8;
            this.day.Text = "יום";
            // 
            // combo
            // 
            this.combo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combo.FormattingEnabled = true;
            this.combo.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי",
            "שבת"});
            this.combo.Location = new System.Drawing.Point(863, 47);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(171, 32);
            this.combo.TabIndex = 7;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            this.combo.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.combo_ChangeUICues);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DodgerBlue;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(863, 536);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 39);
            this.add.TabIndex = 13;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(884, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "שעת סיום";
            // 
            // hour2
            // 
            this.hour2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hour2.Location = new System.Drawing.Point(857, 303);
            this.hour2.Mask = "90:00";
            this.hour2.Name = "hour2";
            this.hour2.Size = new System.Drawing.Size(171, 29);
            this.hour2.TabIndex = 15;
            this.hour2.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(876, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "עובד אחראי";
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "activity";
            this.activityBindingSource.DataSource = this.hoursesDataSet;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(903, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "תאריך";
            // 
            // txb_tarich
            // 
            this.txb_tarich.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_tarich.Location = new System.Drawing.Point(863, 130);
            this.txb_tarich.Mask = "00/00/0000";
            this.txb_tarich.Name = "txb_tarich";
            this.txb_tarich.Size = new System.Drawing.Size(171, 29);
            this.txb_tarich.TabIndex = 127;
            this.txb_tarich.ValidatingType = typeof(System.DateTime);
            // 
            // txb_worker
            // 
            this.txb_worker.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_worker.FormattingEnabled = true;
            this.txb_worker.Location = new System.Drawing.Point(857, 488);
            this.txb_worker.Name = "txb_worker";
            this.txb_worker.Size = new System.Drawing.Size(171, 32);
            this.txb_worker.TabIndex = 133;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 134;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // yoman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1149, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_worker);
            this.Controls.Add(this.txb_tarich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hour2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.activity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.day);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "yoman";
            this.Text = "yoman";
            this.Load += new System.EventHandler(this.yoman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoman1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private hoursesDataSet hoursesDataSet;
        private System.Windows.Forms.BindingSource yoman1BindingSource;
        private hoursesDataSetTableAdapters.yoman1TableAdapter yoman1TableAdapter;
        private System.Windows.Forms.MaskedTextBox hour;
        private System.Windows.Forms.TextBox activity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox hour2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private hoursesDataSetTableAdapters.activityTableAdapter activityTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txb_tarich;
        private System.Windows.Forms.ComboBox txb_worker;
        private System.Windows.Forms.BindingSource workeersBindingSource;
        private hoursesDataSetTableAdapters.workeersTableAdapter workeersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sundayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mondayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursdyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satardayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}