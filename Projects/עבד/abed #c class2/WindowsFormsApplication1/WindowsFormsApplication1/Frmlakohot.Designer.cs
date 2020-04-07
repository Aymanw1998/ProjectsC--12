namespace WindowsFormsApplication1
{
    partial class Frmlakohot
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
            this.shemLakoahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msparTeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemSokhenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.azorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lAKOHOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.lAKOHOTTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.LAKOHOTTableAdapter();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.mstextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.mstextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sokhanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sokhanimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.sokhanimTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAKOHOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokhanimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shemLakoahDataGridViewTextBoxColumn,
            this.msparTeleDataGridViewTextBoxColumn,
            this.tzDataGridViewTextBoxColumn,
            this.shemSokhenDataGridViewTextBoxColumn,
            this.azorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lAKOHOTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 120);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // shemLakoahDataGridViewTextBoxColumn
            // 
            this.shemLakoahDataGridViewTextBoxColumn.DataPropertyName = "shem lakoah";
            this.shemLakoahDataGridViewTextBoxColumn.HeaderText = "שם לקוח";
            this.shemLakoahDataGridViewTextBoxColumn.Name = "shemLakoahDataGridViewTextBoxColumn";
            // 
            // msparTeleDataGridViewTextBoxColumn
            // 
            this.msparTeleDataGridViewTextBoxColumn.DataPropertyName = "mspar tele";
            this.msparTeleDataGridViewTextBoxColumn.HeaderText = "מספר טלפון";
            this.msparTeleDataGridViewTextBoxColumn.Name = "msparTeleDataGridViewTextBoxColumn";
            // 
            // tzDataGridViewTextBoxColumn
            // 
            this.tzDataGridViewTextBoxColumn.DataPropertyName = "tz";
            this.tzDataGridViewTextBoxColumn.HeaderText = "ת.ז לקוח";
            this.tzDataGridViewTextBoxColumn.Name = "tzDataGridViewTextBoxColumn";
            // 
            // shemSokhenDataGridViewTextBoxColumn
            // 
            this.shemSokhenDataGridViewTextBoxColumn.DataPropertyName = "shem sokhen";
            this.shemSokhenDataGridViewTextBoxColumn.HeaderText = "שם סוכן ";
            this.shemSokhenDataGridViewTextBoxColumn.Name = "shemSokhenDataGridViewTextBoxColumn";
            // 
            // azorDataGridViewTextBoxColumn
            // 
            this.azorDataGridViewTextBoxColumn.DataPropertyName = "azor";
            this.azorDataGridViewTextBoxColumn.HeaderText = "אזור לקוח";
            this.azorDataGridViewTextBoxColumn.Name = "azorDataGridViewTextBoxColumn";
            // 
            // lAKOHOTBindingSource
            // 
            this.lAKOHOTBindingSource.DataMember = "LAKOHOT";
            this.lAKOHOTBindingSource.DataSource = this.abedDataSet;
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lAKOHOTTableAdapter
            // 
            this.lAKOHOTTableAdapter.ClearBeforeFill = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1141, 588);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 41);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "סגור";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(775, 471);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(87, 49);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "הוסף לקוח";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "מחק לקוח ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(303, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "עדכן";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(321, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "לקוחות";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(943, 237);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lAKOHOTBindingSource, "azor", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(943, 398);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1066, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "שם לקוח";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1066, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "מספר טלפון ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1066, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "סוכן שמתעסק איתו";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1066, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "ת.ז לקוח";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1066, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "אזור לקוח";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(943, 155);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1083, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "חיפוש";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lAKOHOTBindingSource, "shem lakoah", true));
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(943, 237);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 20);
            this.textBox7.TabIndex = 18;
            this.textBox7.Click += new System.EventHandler(this.textBox7_Click);
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // mstextBox5
            // 
            this.mstextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lAKOHOTBindingSource, "mspar tele", true));
            this.mstextBox5.Enabled = false;
            this.mstextBox5.Location = new System.Drawing.Point(943, 288);
            this.mstextBox5.Margin = new System.Windows.Forms.Padding(2);
            this.mstextBox5.Mask = "(999) 000-0000";
            this.mstextBox5.Name = "mstextBox5";
            this.mstextBox5.Size = new System.Drawing.Size(76, 20);
            this.mstextBox5.TabIndex = 19;
            this.mstextBox5.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstextBox5_MaskInputRejected);
            // 
            // mstextBox4
            // 
            this.mstextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lAKOHOTBindingSource, "tz", true));
            this.mstextBox4.Enabled = false;
            this.mstextBox4.Location = new System.Drawing.Point(943, 329);
            this.mstextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.mstextBox4.Mask = "0000000000";
            this.mstextBox4.Name = "mstextBox4";
            this.mstextBox4.Size = new System.Drawing.Size(76, 20);
            this.mstextBox4.TabIndex = 20;
            this.mstextBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstextBox4_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "הבא";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "לפני";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(685, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 23;
            this.button5.Text = "האחרון";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(685, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 24;
            this.button6.Text = "הראשון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(775, 471);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 49);
            this.button7.TabIndex = 25;
            this.button7.Text = "הוסף לקוח";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(563, 471);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 47);
            this.button8.TabIndex = 26;
            this.button8.Text = "מחק לקוח ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(303, 479);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 41);
            this.button9.TabIndex = 27;
            this.button9.Text = "עדכן";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 288);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 41);
            this.button10.TabIndex = 28;
            this.button10.Text = "סיום";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 618);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(91, 41);
            this.button11.TabIndex = 29;
            this.button11.Text = "סיום  מערכת";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lAKOHOTBindingSource, "shem sokhen", true));
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(943, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 30;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(963, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 79);
            this.label8.TabIndex = 31;
            this.label8.Text = "extreme car";
            // 
            // Frmlakohot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1273, 682);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mstextBox4);
            this.Controls.Add(this.mstextBox5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Frmlakohot";
            this.Text = "Frmlakohot";
            this.Load += new System.EventHandler(this.Frmlakohot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAKOHOTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokhanimBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.BindingSource lAKOHOTBindingSource;
        private abedDataSetTableAdapters.LAKOHOTTableAdapter lAKOHOTTableAdapter;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemLakoahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msparTeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemSokhenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn azorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.MaskedTextBox mstextBox5;
        private System.Windows.Forms.MaskedTextBox mstextBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sokhanimBindingSource;
        private abedDataSetTableAdapters.sokhanimTableAdapter sokhanimTableAdapter;
        private System.Windows.Forms.Label label8;
    }
}