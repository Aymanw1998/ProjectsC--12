namespace christina_hourses
{
    partial class enter
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
            this.checkBox_show = new System.Windows.Forms.CheckBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.misparOvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mishmarotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoursesDataSet = new christina_hourses.hoursesDataSet();
            this.mishmarotTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.mishmarotTableAdapter();
            this.OK = new System.Windows.Forms.Button();
            this.workeersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workeersTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.workeersTableAdapter();
            this.shaotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shaotTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.shaotTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_show
            // 
            this.checkBox_show.AutoSize = true;
            this.checkBox_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox_show.Location = new System.Drawing.Point(719, 216);
            this.checkBox_show.Name = "checkBox_show";
            this.checkBox_show.Size = new System.Drawing.Size(53, 24);
            this.checkBox_show.TabIndex = 4;
            this.checkBox_show.Text = "הצג";
            this.checkBox_show.UseVisualStyleBackColor = true;
            this.checkBox_show.CheckedChanged += new System.EventHandler(this.checkBox_show_CheckedChanged);
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textbox_password.Location = new System.Drawing.Point(404, 207);
            this.textbox_password.Multiline = true;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(285, 39);
            this.textbox_password.TabIndex = 3;
            this.textbox_password.TextChanged += new System.EventHandler(this.textbox_password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(320, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "הזן מספר עובד להתחלת או סיום משמרת";
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_close.Location = new System.Drawing.Point(12, 415);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(129, 75);
            this.bt_close.TabIndex = 14;
            this.bt_close.Text = "חזרה לדף הראשי";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::christina_hourses.Properties.Resources.the_horseman;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 203);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.misparOvedDataGridViewTextBoxColumn,
            this.tarichDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.beginDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mishmarotBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(204, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 220);
            this.dataGridView1.TabIndex = 15;
            // 
            // misparOvedDataGridViewTextBoxColumn
            // 
            this.misparOvedDataGridViewTextBoxColumn.DataPropertyName = "mispar oved";
            this.misparOvedDataGridViewTextBoxColumn.HeaderText = "מספר עובד";
            this.misparOvedDataGridViewTextBoxColumn.Name = "misparOvedDataGridViewTextBoxColumn";
            // 
            // tarichDataGridViewTextBoxColumn
            // 
            this.tarichDataGridViewTextBoxColumn.DataPropertyName = "tarich";
            this.tarichDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.tarichDataGridViewTextBoxColumn.Name = "tarichDataGridViewTextBoxColumn";
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "סיום";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            // 
            // beginDataGridViewTextBoxColumn
            // 
            this.beginDataGridViewTextBoxColumn.DataPropertyName = "begin";
            this.beginDataGridViewTextBoxColumn.HeaderText = "התחלה";
            this.beginDataGridViewTextBoxColumn.Name = "beginDataGridViewTextBoxColumn";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "סה\"כ ";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // mishmarotBindingSource
            // 
            this.mishmarotBindingSource.DataMember = "mishmarot";
            this.mishmarotBindingSource.DataSource = this.hoursesDataSet;
            // 
            // hoursesDataSet
            // 
            this.hoursesDataSet.DataSetName = "hoursesDataSet";
            this.hoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mishmarotTableAdapter
            // 
            this.mishmarotTableAdapter.ClearBeforeFill = true;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.Highlight;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OK.Location = new System.Drawing.Point(279, 209);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(105, 36);
            this.OK.TabIndex = 17;
            this.OK.Text = "אישור";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
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
            // shaotBindingSource
            // 
            this.shaotBindingSource.DataMember = "shaot";
            this.shaotBindingSource.DataSource = this.hoursesDataSet;
            // 
            // shaotTableAdapter
            // 
            this.shaotTableAdapter.ClearBeforeFill = true;
            // 
            // enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(954, 502);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_show);
            this.Controls.Add(this.textbox_password);
            this.Name = "enter";
            this.Text = "enter";
            this.Load += new System.EventHandler(this.enter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shaotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_show;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hoursesDataSet hoursesDataSet;
        private System.Windows.Forms.BindingSource mishmarotBindingSource;
        private hoursesDataSetTableAdapters.mishmarotTableAdapter mishmarotTableAdapter;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.BindingSource workeersBindingSource;
        private hoursesDataSetTableAdapters.workeersTableAdapter workeersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparOvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shaotBindingSource;
        private hoursesDataSetTableAdapters.shaotTableAdapter shaotTableAdapter;
    }
}