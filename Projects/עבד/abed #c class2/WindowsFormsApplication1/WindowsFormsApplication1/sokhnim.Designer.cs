namespace WindowsFormsApplication1
{
    partial class sokhnim
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
            this.btn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shemSokhenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tzSokhenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemMeshpaheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktoetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.misperTeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskoretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yaadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamaMacharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamaNmcharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sokhanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.mstextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.sokhanimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.sokhanimTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokhanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn.Location = new System.Drawing.Point(1147, 542);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(98, 45);
            this.btn.TabIndex = 0;
            this.btn.Text = "סגור";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn1.Location = new System.Drawing.Point(879, 530);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 57);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "הוסף סוכן";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(709, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "מחק סוכן";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shemSokhenDataGridViewTextBoxColumn,
            this.tzSokhenDataGridViewTextBoxColumn,
            this.shemMeshpaheDataGridViewTextBoxColumn,
            this.ktoetDataGridViewTextBoxColumn,
            this.misperTeleDataGridViewTextBoxColumn,
            this.maskoretDataGridViewTextBoxColumn,
            this.yaadDataGridViewTextBoxColumn,
            this.kamaMacharDataGridViewTextBoxColumn,
            this.kamaNmcharDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sokhanimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 276);
            this.dataGridView1.TabIndex = 3;
            // 
            // shemSokhenDataGridViewTextBoxColumn
            // 
            this.shemSokhenDataGridViewTextBoxColumn.DataPropertyName = "shem sokhen";
            this.shemSokhenDataGridViewTextBoxColumn.HeaderText = "שם סוכן ";
            this.shemSokhenDataGridViewTextBoxColumn.Name = "shemSokhenDataGridViewTextBoxColumn";
            // 
            // tzSokhenDataGridViewTextBoxColumn
            // 
            this.tzSokhenDataGridViewTextBoxColumn.DataPropertyName = "tz sokhen";
            this.tzSokhenDataGridViewTextBoxColumn.HeaderText = "ת.ז סוכן";
            this.tzSokhenDataGridViewTextBoxColumn.Name = "tzSokhenDataGridViewTextBoxColumn";
            // 
            // shemMeshpaheDataGridViewTextBoxColumn
            // 
            this.shemMeshpaheDataGridViewTextBoxColumn.DataPropertyName = "shem meshpahe";
            this.shemMeshpaheDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.shemMeshpaheDataGridViewTextBoxColumn.Name = "shemMeshpaheDataGridViewTextBoxColumn";
            // 
            // ktoetDataGridViewTextBoxColumn
            // 
            this.ktoetDataGridViewTextBoxColumn.DataPropertyName = "ktoet";
            this.ktoetDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.ktoetDataGridViewTextBoxColumn.Name = "ktoetDataGridViewTextBoxColumn";
            // 
            // misperTeleDataGridViewTextBoxColumn
            // 
            this.misperTeleDataGridViewTextBoxColumn.DataPropertyName = "misper tele";
            this.misperTeleDataGridViewTextBoxColumn.HeaderText = "מספר טלפון";
            this.misperTeleDataGridViewTextBoxColumn.Name = "misperTeleDataGridViewTextBoxColumn";
            // 
            // maskoretDataGridViewTextBoxColumn
            // 
            this.maskoretDataGridViewTextBoxColumn.DataPropertyName = "maskoret";
            this.maskoretDataGridViewTextBoxColumn.HeaderText = "משכורת";
            this.maskoretDataGridViewTextBoxColumn.Name = "maskoretDataGridViewTextBoxColumn";
            // 
            // yaadDataGridViewTextBoxColumn
            // 
            this.yaadDataGridViewTextBoxColumn.DataPropertyName = "yaad";
            this.yaadDataGridViewTextBoxColumn.HeaderText = "יעד מכירות";
            this.yaadDataGridViewTextBoxColumn.Name = "yaadDataGridViewTextBoxColumn";
            // 
            // kamaMacharDataGridViewTextBoxColumn
            // 
            this.kamaMacharDataGridViewTextBoxColumn.DataPropertyName = "kama machar";
            this.kamaMacharDataGridViewTextBoxColumn.HeaderText = "כמה מכר";
            this.kamaMacharDataGridViewTextBoxColumn.Name = "kamaMacharDataGridViewTextBoxColumn";
            // 
            // kamaNmcharDataGridViewTextBoxColumn
            // 
            this.kamaNmcharDataGridViewTextBoxColumn.DataPropertyName = "kama nmchar";
            this.kamaNmcharDataGridViewTextBoxColumn.HeaderText = "כמה נשאר ";
            this.kamaNmcharDataGridViewTextBoxColumn.Name = "kamaNmcharDataGridViewTextBoxColumn";
            // 
            // sokhanimBindingSource
            // 
            this.sokhanimBindingSource.DataMember = "sokhanim";
            this.sokhanimBindingSource.DataSource = this.abedDataSetBindingSource;
            // 
            // abedDataSetBindingSource
            // 
            this.abedDataSetBindingSource.DataSource = this.abedDataSet;
            this.abedDataSetBindingSource.Position = 0;
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(427, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "סוכנים";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1212, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "kama machar", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1211, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "yaad", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(1211, 348);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "maskoret", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(1211, 322);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "ktoet", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(1211, 270);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "shem meshpahe", true));
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(1211, 244);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "tz sokhen", true));
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(1211, 217);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 12;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "kama nmchar", true));
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(1211, 419);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(1377, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "שם סוכן";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1381, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ת.ז סוכן";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1387, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "כתובת";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1359, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "מספר טלפון";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1379, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "משכורת";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1364, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "יעד מכירות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1364, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "שם משפחה ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1379, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "כמה מכר";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1342, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "כמה נשאר ליעד";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1341, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "חיפוש";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1211, 141);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 25;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(549, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 57);
            this.button1.TabIndex = 26;
            this.button1.Text = "עדכן ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "shem sokhen", true));
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(1211, 188);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 27;
            this.textBox11.Click += new System.EventHandler(this.textBox11_Click);
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // mstextBox5
            // 
            this.mstextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "misper tele", true));
            this.mstextBox5.Enabled = false;
            this.mstextBox5.Location = new System.Drawing.Point(1211, 299);
            this.mstextBox5.Margin = new System.Windows.Forms.Padding(2);
            this.mstextBox5.Mask = "(999) 000-0000";
            this.mstextBox5.Name = "mstextBox5";
            this.mstextBox5.Size = new System.Drawing.Size(100, 20);
            this.mstextBox5.TabIndex = 28;
            // 
            // sokhanimTableAdapter
            // 
            this.sokhanimTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(37, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 57);
            this.button3.TabIndex = 29;
            this.button3.Text = "דוח מכירות ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1039, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "הראשוון";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1039, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "הבא";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1039, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "לפני";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1039, 366);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 33;
            this.button7.Text = "האחרון";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(879, 530);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 57);
            this.button8.TabIndex = 34;
            this.button8.Text = "הוסף סוכן";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(709, 528);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 57);
            this.button9.TabIndex = 35;
            this.button9.Text = "מחק סוכן";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(549, 528);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 57);
            this.button10.TabIndex = 36;
            this.button10.Text = "עדכן ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(324, 492);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 55);
            this.button11.TabIndex = 37;
            this.button11.Text = "סיום";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(37, 626);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 55);
            this.button12.TabIndex = 38;
            this.button12.Text = "סיום מערכת";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1147, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 79);
            this.label12.TabIndex = 39;
            this.label12.Text = "extreme car";
            // 
            // sokhnim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1447, 693);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mstextBox5);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sokhanimBindingSource, "kama nmchar", true));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "sokhnim";
            this.Text = "sokhnim";
            this.Load += new System.EventHandler(this.sokhnim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokhanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button2;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.BindingSource abedDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sokhanimBindingSource;
        private abedDataSetTableAdapters.sokhanimTableAdapter sokhanimTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemSokhenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzSokhenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemMeshpaheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktoetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn misperTeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskoretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamaMacharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamaNmcharDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.MaskedTextBox mstextBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label12;
    }
}