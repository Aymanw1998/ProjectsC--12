namespace WindowsFormsApplication1
{
    partial class frmOvdim
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ovdimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.mstextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.mstextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tzOvdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemOvdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemMeshpahaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taphkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaShaotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascoretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovdimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.ovdimTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ovdimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(1313, 616);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(80, 55);
            this.btn.TabIndex = 1;
            this.btn.Text = "חזרה";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(684, 498);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(123, 81);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "הוסף עובד";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(488, 495);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(130, 81);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "מחק עובד";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(434, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "עובדים";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(1181, 168);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(128, 20);
            this.txt1.TabIndex = 8;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "cama shaot", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1181, 496);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ovdimBindingSource
            // 
            this.ovdimBindingSource.DataMember = "ovdim";
            this.ovdimBindingSource.DataSource = this.abedDataSet;
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "ctovet", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(1181, 465);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "shem meshpaha", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(1180, 251);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(128, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "shem ovd", true));
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(1181, 205);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(128, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1378, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ת.ז עובד";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1378, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "שם עובד";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1366, 502);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "שכירות לשעה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1365, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "שם משפחה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1403, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "גיל";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1404, 470);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "כתובת";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1376, 431);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "מספר טלפון";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 495);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 81);
            this.button1.TabIndex = 22;
            this.button1.Text = "עדכן";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "mascoret", true));
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(1181, 540);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(128, 20);
            this.textBox8.TabIndex = 24;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1397, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "משכורת";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1181, 127);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(128, 20);
            this.textBox9.TabIndex = 28;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1389, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "חיפוש";
            // 
            // txt2
            // 
            this.txt2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "tz ovd", true));
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(1181, 168);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(128, 20);
            this.txt2.TabIndex = 31;
            this.txt2.Click += new System.EventHandler(this.txt2_Click);
            this.txt2.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // mstextBox4
            // 
            this.mstextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "num tele", true));
            this.mstextBox4.Enabled = false;
            this.mstextBox4.Location = new System.Drawing.Point(1181, 428);
            this.mstextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.mstextBox4.Mask = "(999) 000-0000";
            this.mstextBox4.Name = "mstextBox4";
            this.mstextBox4.Size = new System.Drawing.Size(128, 20);
            this.mstextBox4.TabIndex = 32;
            this.mstextBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mstextBox5
            // 
            this.mstextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "gel", true));
            this.mstextBox5.Enabled = false;
            this.mstextBox5.Location = new System.Drawing.Point(1181, 383);
            this.mstextBox5.Margin = new System.Windows.Forms.Padding(2);
            this.mstextBox5.Mask = "00";
            this.mstextBox5.Name = "mstextBox5";
            this.mstextBox5.Size = new System.Drawing.Size(128, 20);
            this.mstextBox5.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1404, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "קוד";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "cod", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(1180, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tzOvdDataGridViewTextBoxColumn,
            this.shemOvdDataGridViewTextBoxColumn,
            this.shemMeshpahaDataGridViewTextBoxColumn,
            this.taphkidDataGridViewTextBoxColumn,
            this.codDataGridViewTextBoxColumn,
            this.gelDataGridViewTextBoxColumn,
            this.numTeleDataGridViewTextBoxColumn,
            this.ctovetDataGridViewTextBoxColumn,
            this.camaShaotDataGridViewTextBoxColumn,
            this.mascoretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ovdimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1048, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // tzOvdDataGridViewTextBoxColumn
            // 
            this.tzOvdDataGridViewTextBoxColumn.DataPropertyName = "tz ovd";
            this.tzOvdDataGridViewTextBoxColumn.HeaderText = "ת.ז עובד";
            this.tzOvdDataGridViewTextBoxColumn.Name = "tzOvdDataGridViewTextBoxColumn";
            // 
            // shemOvdDataGridViewTextBoxColumn
            // 
            this.shemOvdDataGridViewTextBoxColumn.DataPropertyName = "shem ovd";
            this.shemOvdDataGridViewTextBoxColumn.HeaderText = "שם עובד";
            this.shemOvdDataGridViewTextBoxColumn.Name = "shemOvdDataGridViewTextBoxColumn";
            // 
            // shemMeshpahaDataGridViewTextBoxColumn
            // 
            this.shemMeshpahaDataGridViewTextBoxColumn.DataPropertyName = "shem meshpaha";
            this.shemMeshpahaDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.shemMeshpahaDataGridViewTextBoxColumn.Name = "shemMeshpahaDataGridViewTextBoxColumn";
            // 
            // taphkidDataGridViewTextBoxColumn
            // 
            this.taphkidDataGridViewTextBoxColumn.DataPropertyName = "taphkid";
            this.taphkidDataGridViewTextBoxColumn.HeaderText = "תפקיד";
            this.taphkidDataGridViewTextBoxColumn.Name = "taphkidDataGridViewTextBoxColumn";
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "קוד";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            // 
            // gelDataGridViewTextBoxColumn
            // 
            this.gelDataGridViewTextBoxColumn.DataPropertyName = "gel";
            this.gelDataGridViewTextBoxColumn.HeaderText = "גיל";
            this.gelDataGridViewTextBoxColumn.Name = "gelDataGridViewTextBoxColumn";
            // 
            // numTeleDataGridViewTextBoxColumn
            // 
            this.numTeleDataGridViewTextBoxColumn.DataPropertyName = "num tele";
            this.numTeleDataGridViewTextBoxColumn.HeaderText = "מספר טלפון";
            this.numTeleDataGridViewTextBoxColumn.Name = "numTeleDataGridViewTextBoxColumn";
            // 
            // ctovetDataGridViewTextBoxColumn
            // 
            this.ctovetDataGridViewTextBoxColumn.DataPropertyName = "ctovet";
            this.ctovetDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.ctovetDataGridViewTextBoxColumn.Name = "ctovetDataGridViewTextBoxColumn";
            // 
            // camaShaotDataGridViewTextBoxColumn
            // 
            this.camaShaotDataGridViewTextBoxColumn.DataPropertyName = "cama shaot";
            this.camaShaotDataGridViewTextBoxColumn.HeaderText = "כמה שעות";
            this.camaShaotDataGridViewTextBoxColumn.Name = "camaShaotDataGridViewTextBoxColumn";
            // 
            // mascoretDataGridViewTextBoxColumn
            // 
            this.mascoretDataGridViewTextBoxColumn.DataPropertyName = "mascoret";
            this.mascoretDataGridViewTextBoxColumn.HeaderText = "משכורת";
            this.mascoretDataGridViewTextBoxColumn.Name = "mascoretDataGridViewTextBoxColumn";
            // 
            // ovdimTableAdapter
            // 
            this.ovdimTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1387, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "תפקיד";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1081, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "הראשון";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1081, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "הבא";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1081, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 43;
            this.button5.Text = "לפני";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1081, 376);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 44;
            this.button6.Text = "האחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(684, 496);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 85);
            this.button7.TabIndex = 45;
            this.button7.Text = "הוסף עובד";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(305, 495);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 81);
            this.button8.TabIndex = 46;
            this.button8.Text = "עדכן";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(488, 495);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 81);
            this.button10.TabIndex = 48;
            this.button10.Text = "מחק  עובד";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(35, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 66);
            this.button9.TabIndex = 49;
            this.button9.Text = "סיום";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ovdimBindingSource, "taphkid", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(1181, 300);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 50;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 66);
            this.button2.TabIndex = 51;
            this.button2.Text = "סיום מערכת";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1105, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(288, 79);
            this.label13.TabIndex = 52;
            this.label13.Text = "extreme car";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // frmOvdim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1457, 693);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mstextBox5);
            this.Controls.Add(this.mstextBox4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn);
            this.Name = "frmOvdim";
            this.Text = "frmOvdim";
            this.Load += new System.EventHandler(this.frmOvdim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ovdimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn shotYetseaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.MaskedTextBox mstextBox4;
        private System.Windows.Forms.MaskedTextBox mstextBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.BindingSource ovdimBindingSource;
        private abedDataSetTableAdapters.ovdimTableAdapter ovdimTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzOvdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemOvdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemMeshpahaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taphkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaShaotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascoretDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox4;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
    }
}