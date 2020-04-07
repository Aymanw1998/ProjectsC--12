namespace WindowsFormsApplication1
{
    partial class frmkhirot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ms2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dhmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.sokhanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sokhanimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.sokhanimTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.lAKOHOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAKOHOTTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.LAKOHOTTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.misparHeshbonitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tzLakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahAiskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemSokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahCmotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dhmTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.dhmTableAdapter();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokhanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAKOHOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1339, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "שם סוכן";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "דוח מכירות";
            this.label6.Click += new System.EventHandler(this.דוח_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 89);
            this.button1.TabIndex = 12;
            this.button1.Text = "הוספה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1134, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1356, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "search";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(1134, 265);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(1134, 520);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1343, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "מספר חשבונית";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1339, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "תאריך";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "סכום עסקה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(738, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "סך כמות";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1339, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "אל:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ms2
            // 
            this.ms2.Enabled = false;
            this.ms2.Location = new System.Drawing.Point(1134, 446);
            this.ms2.Mask = "00/00/0000";
            this.ms2.Name = "ms2";
            this.ms2.Size = new System.Drawing.Size(181, 20);
            this.ms2.TabIndex = 32;
            this.ms2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ms2_MaskInputRejected);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1134, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 33;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 89);
            this.button3.TabIndex = 35;
            this.button3.Text = "עדכון";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1293, 651);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 89);
            this.button4.TabIndex = 36;
            this.button4.Text = "חזרה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 66);
            this.button5.TabIndex = 38;
            this.button5.Text = "מפרט מכירות";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dhmBindingSource, "sah aiska", true));
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(546, 343);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(181, 20);
            this.textBox9.TabIndex = 40;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged_1);
            // 
            // dhmBindingSource
            // 
            this.dhmBindingSource.DataMember = "dhm";
            this.dhmBindingSource.DataSource = this.abedDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1339, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "ת.ז לקוח";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dhmBindingSource, "sah cmot", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(546, 413);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(181, 20);
            this.textBox6.TabIndex = 42;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // comboBox8
            // 
            this.comboBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dhmBindingSource, "shem soken", true));
            this.comboBox8.Enabled = false;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(1134, 402);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(181, 21);
            this.comboBox8.TabIndex = 43;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // sokhanimBindingSource
            // 
            this.sokhanimBindingSource.DataMember = "sokhanim";
            this.sokhanimBindingSource.DataSource = this.abedDataSet;
            // 
            // sokhanimTableAdapter
            // 
            this.sokhanimTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(526, 611);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 89);
            this.button6.TabIndex = 44;
            this.button6.Text = "עדכון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lAKOHOTBindingSource
            // 
            this.lAKOHOTBindingSource.DataMember = "LAKOHOT";
            this.lAKOHOTBindingSource.DataSource = this.abedDataSet;
            // 
            // lAKOHOTTableAdapter
            // 
            this.lAKOHOTTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dhmBindingSource, "tz lak", true));
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1134, 311);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 21);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.misparHeshbonitDataGridViewTextBoxColumn,
            this.ellDataGridViewTextBoxColumn,
            this.tzLakDataGridViewTextBoxColumn,
            this.sahAiskaDataGridViewTextBoxColumn,
            this.tarikhDataGridViewTextBoxColumn,
            this.shemSokenDataGridViewTextBoxColumn,
            this.sahCmotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dhmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(265, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 150);
            this.dataGridView1.TabIndex = 48;
            // 
            // misparHeshbonitDataGridViewTextBoxColumn
            // 
            this.misparHeshbonitDataGridViewTextBoxColumn.DataPropertyName = "mispar heshbonit";
            this.misparHeshbonitDataGridViewTextBoxColumn.HeaderText = "מספר חשבונית";
            this.misparHeshbonitDataGridViewTextBoxColumn.Name = "misparHeshbonitDataGridViewTextBoxColumn";
            // 
            // ellDataGridViewTextBoxColumn
            // 
            this.ellDataGridViewTextBoxColumn.DataPropertyName = "ell";
            this.ellDataGridViewTextBoxColumn.HeaderText = "אל";
            this.ellDataGridViewTextBoxColumn.Name = "ellDataGridViewTextBoxColumn";
            // 
            // tzLakDataGridViewTextBoxColumn
            // 
            this.tzLakDataGridViewTextBoxColumn.DataPropertyName = "tz lak";
            this.tzLakDataGridViewTextBoxColumn.HeaderText = "ת.ז לקוח";
            this.tzLakDataGridViewTextBoxColumn.Name = "tzLakDataGridViewTextBoxColumn";
            // 
            // sahAiskaDataGridViewTextBoxColumn
            // 
            this.sahAiskaDataGridViewTextBoxColumn.DataPropertyName = "sah aiska";
            this.sahAiskaDataGridViewTextBoxColumn.HeaderText = "סך עסקה";
            this.sahAiskaDataGridViewTextBoxColumn.Name = "sahAiskaDataGridViewTextBoxColumn";
            // 
            // tarikhDataGridViewTextBoxColumn
            // 
            this.tarikhDataGridViewTextBoxColumn.DataPropertyName = "tarikh";
            this.tarikhDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.tarikhDataGridViewTextBoxColumn.Name = "tarikhDataGridViewTextBoxColumn";
            // 
            // shemSokenDataGridViewTextBoxColumn
            // 
            this.shemSokenDataGridViewTextBoxColumn.DataPropertyName = "shem soken";
            this.shemSokenDataGridViewTextBoxColumn.HeaderText = "שם סוכן";
            this.shemSokenDataGridViewTextBoxColumn.Name = "shemSokenDataGridViewTextBoxColumn";
            // 
            // sahCmotDataGridViewTextBoxColumn
            // 
            this.sahCmotDataGridViewTextBoxColumn.DataPropertyName = "sah cmot";
            this.sahCmotDataGridViewTextBoxColumn.HeaderText = "סך כמות";
            this.sahCmotDataGridViewTextBoxColumn.Name = "sahCmotDataGridViewTextBoxColumn";
            // 
            // dhmTableAdapter
            // 
            this.dhmTableAdapter.ClearBeforeFill = true;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(1134, 556);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(181, 20);
            this.textBox8.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1356, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "יעד";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1356, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "עמה נשאר";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(743, 611);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 89);
            this.button7.TabIndex = 52;
            this.button7.Text = "הוספה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button9.Location = new System.Drawing.Point(12, 505);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 52);
            this.button9.TabIndex = 55;
            this.button9.Text = "סיום";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(1134, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 56;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1127, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 79);
            this.label12.TabIndex = 57;
            this.label12.Text = "extreme car";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(128, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 52);
            this.button2.TabIndex = 58;
            this.button2.Text = "סיום תוכנה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmkhirot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1429, 797);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ms2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "frmkhirot";
            this.Text = "frmkhirot";
            this.Load += new System.EventHandler(this.frmkhirot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokhanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAKOHOTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridViewTextBoxColumn codeMotzarDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn shemMotzarDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn camaNmcharDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn sokhenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox ms2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn cmotDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn mikomDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.BindingSource sokhanimBindingSource;
        private abedDataSetTableAdapters.sokhanimTableAdapter sokhanimTableAdapter;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource lAKOHOTBindingSource;
        private abedDataSetTableAdapters.LAKOHOTTableAdapter lAKOHOTTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dhmBindingSource;
        private abedDataSetTableAdapters.dhmTableAdapter dhmTableAdapter;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparHeshbonitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzLakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahAiskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarikhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemSokenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahCmotDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;

    }
}