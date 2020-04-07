namespace WindowsFormsApplication1
{
    partial class frmazkirot
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mstextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.mstextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.mazkirotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mazkirotTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.mazkirotTableAdapter();
            this.tzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemMazkiraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemMeshpahaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaShaotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascoretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazkirotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 557);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "סגור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 557);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "מחק מזכירה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 557);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "הוסף מזכירה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 557);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "עדכון";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1206, 221);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1206, 263);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1206, 407);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1206, 455);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1206, 512);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 20);
            this.textBox8.TabIndex = 12;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1206, 160);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(76, 20);
            this.textBox9.TabIndex = 13;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1206, 221);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(76, 20);
            this.textBox10.TabIndex = 14;
            this.textBox10.Click += new System.EventHandler(this.textBox10_Click);
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(1326, 160);
            this.txt1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(40, 13);
            this.txt1.TabIndex = 15;
            this.txt1.Text = "חיפוש";
            this.txt1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1319, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ת.ז מזכירה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1319, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "שם מזכירה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1326, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "גיל";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1319, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "מספר טלפון";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1319, 412);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "כתובת";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1319, 458);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "שכירות לשעה";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1319, 516);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "משכורת";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1206, 298);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 20);
            this.textBox11.TabIndex = 24;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1325, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "שם משפחה";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1206, 564);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 20);
            this.textBox6.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1324, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "מייל";
            // 
            // mstextBox3
            // 
            this.mstextBox3.Location = new System.Drawing.Point(1206, 338);
            this.mstextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.mstextBox3.Mask = "00";
            this.mstextBox3.Name = "mstextBox3";
            this.mstextBox3.Size = new System.Drawing.Size(76, 20);
            this.mstextBox3.TabIndex = 29;
            // 
            // mstextBox4
            // 
            this.mstextBox4.Location = new System.Drawing.Point(1206, 375);
            this.mstextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.mstextBox4.Mask = "000-0000";
            this.mstextBox4.Name = "mstextBox4";
            this.mstextBox4.Size = new System.Drawing.Size(76, 20);
            this.mstextBox4.TabIndex = 30;
            this.mstextBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstextBox4_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(443, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 42);
            this.label10.TabIndex = 31;
            this.label10.Text = "מזכירות";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 559);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 74);
            this.button5.TabIndex = 32;
            this.button5.Text = "שעות נוכחות";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tzDataGridViewTextBoxColumn,
            this.shemMazkiraDataGridViewTextBoxColumn,
            this.shemMeshpahaDataGridViewTextBoxColumn,
            this.gelDataGridViewTextBoxColumn,
            this.numTeleDataGridViewTextBoxColumn,
            this.ctovetDataGridViewTextBoxColumn,
            this.camaShaotDataGridViewTextBoxColumn,
            this.mascoretDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mazkirotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1049, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mazkirotBindingSource
            // 
            this.mazkirotBindingSource.DataMember = "mazkirot";
            this.mazkirotBindingSource.DataSource = this.abedDataSet;
            // 
            // mazkirotTableAdapter
            // 
            this.mazkirotTableAdapter.ClearBeforeFill = true;
            // 
            // tzDataGridViewTextBoxColumn
            // 
            this.tzDataGridViewTextBoxColumn.DataPropertyName = "tz";
            this.tzDataGridViewTextBoxColumn.HeaderText = "tz";
            this.tzDataGridViewTextBoxColumn.Name = "tzDataGridViewTextBoxColumn";
            // 
            // shemMazkiraDataGridViewTextBoxColumn
            // 
            this.shemMazkiraDataGridViewTextBoxColumn.DataPropertyName = "shem mazkira";
            this.shemMazkiraDataGridViewTextBoxColumn.HeaderText = "shem mazkira";
            this.shemMazkiraDataGridViewTextBoxColumn.Name = "shemMazkiraDataGridViewTextBoxColumn";
            // 
            // shemMeshpahaDataGridViewTextBoxColumn
            // 
            this.shemMeshpahaDataGridViewTextBoxColumn.DataPropertyName = "shem meshpaha";
            this.shemMeshpahaDataGridViewTextBoxColumn.HeaderText = "shem meshpaha";
            this.shemMeshpahaDataGridViewTextBoxColumn.Name = "shemMeshpahaDataGridViewTextBoxColumn";
            // 
            // gelDataGridViewTextBoxColumn
            // 
            this.gelDataGridViewTextBoxColumn.DataPropertyName = "gel";
            this.gelDataGridViewTextBoxColumn.HeaderText = "gel";
            this.gelDataGridViewTextBoxColumn.Name = "gelDataGridViewTextBoxColumn";
            // 
            // numTeleDataGridViewTextBoxColumn
            // 
            this.numTeleDataGridViewTextBoxColumn.DataPropertyName = "num tele";
            this.numTeleDataGridViewTextBoxColumn.HeaderText = "num tele";
            this.numTeleDataGridViewTextBoxColumn.Name = "numTeleDataGridViewTextBoxColumn";
            // 
            // ctovetDataGridViewTextBoxColumn
            // 
            this.ctovetDataGridViewTextBoxColumn.DataPropertyName = "ctovet";
            this.ctovetDataGridViewTextBoxColumn.HeaderText = "ctovet";
            this.ctovetDataGridViewTextBoxColumn.Name = "ctovetDataGridViewTextBoxColumn";
            // 
            // camaShaotDataGridViewTextBoxColumn
            // 
            this.camaShaotDataGridViewTextBoxColumn.DataPropertyName = "cama shaot";
            this.camaShaotDataGridViewTextBoxColumn.HeaderText = "cama shaot";
            this.camaShaotDataGridViewTextBoxColumn.Name = "camaShaotDataGridViewTextBoxColumn";
            // 
            // mascoretDataGridViewTextBoxColumn
            // 
            this.mascoretDataGridViewTextBoxColumn.DataPropertyName = "mascoret";
            this.mascoretDataGridViewTextBoxColumn.HeaderText = "mascoret";
            this.mascoretDataGridViewTextBoxColumn.Name = "mascoretDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1329, 620);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "קוד";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1206, 617);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 36;
            // 
            // frmazkirot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1442, 732);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mstextBox4);
            this.Controls.Add(this.mstextBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmazkirot";
            this.Text = "          ";
            this.Load += new System.EventHandler(this.frmazkirot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazkirotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mstextBox3;
        private System.Windows.Forms.MaskedTextBox mstextBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.BindingSource mazkirotBindingSource;
        private abedDataSetTableAdapters.mazkirotTableAdapter mazkirotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemMazkiraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemMeshpahaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaShaotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascoretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
    }
}