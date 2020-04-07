namespace חנות_נעליים
{
    partial class shoes
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
            this.degemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhlakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoe_shopDataSet = new חנות_נעליים.shoe_shopDataSet();
            this.shoesTableAdapter = new חנות_נעליים.shoe_shopDataSetTableAdapters.shoesTableAdapter();
            this.kamot = new System.Windows.Forms.MaskedTextBox();
            this.color = new System.Windows.Forms.MaskedTextBox();
            this.mida = new System.Windows.Forms.MaskedTextBox();
            this.mehir = new System.Windows.Forms.MaskedTextBox();
            this.mhlaka = new System.Windows.Forms.MaskedTextBox();
            this.spak = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.degem = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.firma = new System.Windows.Forms.ComboBox();
            this.degem1 = new System.Windows.Forms.MaskedTextBox();
            this.firma1 = new System.Windows.Forms.ComboBox();
            this.mehir1 = new System.Windows.Forms.MaskedTextBox();
            this.mida1 = new System.Windows.Forms.MaskedTextBox();
            this.spak1 = new System.Windows.Forms.MaskedTextBox();
            this.mhlaka1 = new System.Windows.Forms.MaskedTextBox();
            this.color1 = new System.Windows.Forms.MaskedTextBox();
            this.kamot1 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degemDataGridViewTextBoxColumn,
            this.firmaDataGridViewTextBoxColumn,
            this.mehirDataGridViewTextBoxColumn,
            this.midaDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.kamotDataGridViewTextBoxColumn,
            this.mhlakaDataGridViewTextBoxColumn,
            this.spakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shoesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 508);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // degemDataGridViewTextBoxColumn
            // 
            this.degemDataGridViewTextBoxColumn.DataPropertyName = "degem";
            this.degemDataGridViewTextBoxColumn.HeaderText = "degem";
            this.degemDataGridViewTextBoxColumn.Name = "degemDataGridViewTextBoxColumn";
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "firma";
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            // 
            // mehirDataGridViewTextBoxColumn
            // 
            this.mehirDataGridViewTextBoxColumn.DataPropertyName = "mehir";
            this.mehirDataGridViewTextBoxColumn.HeaderText = "mehir";
            this.mehirDataGridViewTextBoxColumn.Name = "mehirDataGridViewTextBoxColumn";
            // 
            // midaDataGridViewTextBoxColumn
            // 
            this.midaDataGridViewTextBoxColumn.DataPropertyName = "mida";
            this.midaDataGridViewTextBoxColumn.HeaderText = "mida";
            this.midaDataGridViewTextBoxColumn.Name = "midaDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // kamotDataGridViewTextBoxColumn
            // 
            this.kamotDataGridViewTextBoxColumn.DataPropertyName = "kamot";
            this.kamotDataGridViewTextBoxColumn.HeaderText = "kamot";
            this.kamotDataGridViewTextBoxColumn.Name = "kamotDataGridViewTextBoxColumn";
            // 
            // mhlakaDataGridViewTextBoxColumn
            // 
            this.mhlakaDataGridViewTextBoxColumn.DataPropertyName = "mhlaka";
            this.mhlakaDataGridViewTextBoxColumn.HeaderText = "mhlaka";
            this.mhlakaDataGridViewTextBoxColumn.Name = "mhlakaDataGridViewTextBoxColumn";
            // 
            // spakDataGridViewTextBoxColumn
            // 
            this.spakDataGridViewTextBoxColumn.DataPropertyName = "spak";
            this.spakDataGridViewTextBoxColumn.HeaderText = "spak";
            this.spakDataGridViewTextBoxColumn.Name = "spakDataGridViewTextBoxColumn";
            // 
            // shoesBindingSource
            // 
            this.shoesBindingSource.DataMember = "shoes";
            this.shoesBindingSource.DataSource = this.shoe_shopDataSet;
            // 
            // shoe_shopDataSet
            // 
            this.shoe_shopDataSet.DataSetName = "shoe_shopDataSet";
            this.shoe_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoesTableAdapter
            // 
            this.shoesTableAdapter.ClearBeforeFill = true;
            // 
            // kamot
            // 
            this.kamot.Location = new System.Drawing.Point(1135, 450);
            this.kamot.Name = "kamot";
            this.kamot.Size = new System.Drawing.Size(200, 20);
            this.kamot.TabIndex = 2;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(1135, 400);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(200, 20);
            this.color.TabIndex = 3;
            // 
            // mida
            // 
            this.mida.Location = new System.Drawing.Point(1135, 350);
            this.mida.Mask = "00";
            this.mida.Name = "mida";
            this.mida.Size = new System.Drawing.Size(200, 20);
            this.mida.TabIndex = 5;
            this.mida.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mida_MaskInputRejected);
            this.mida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mida_KeyPress);
            // 
            // mehir
            // 
            this.mehir.Location = new System.Drawing.Point(1135, 300);
            this.mehir.Mask = "999₪";
            this.mehir.Name = "mehir";
            this.mehir.Size = new System.Drawing.Size(200, 20);
            this.mehir.TabIndex = 6;
            this.mehir.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mehir_MaskInputRejected);
            // 
            // mhlaka
            // 
            this.mhlaka.Location = new System.Drawing.Point(1135, 500);
            this.mhlaka.Name = "mhlaka";
            this.mhlaka.Size = new System.Drawing.Size(200, 20);
            this.mhlaka.TabIndex = 7;
            // 
            // spak
            // 
            this.spak.Location = new System.Drawing.Point(1135, 550);
            this.spak.Name = "spak";
            this.spak.Size = new System.Drawing.Size(200, 20);
            this.spak.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(378, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "מחק";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(997, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1483, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "דגם";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1487, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "סוג";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(1473, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "מחיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(1474, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "מידה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(1481, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "צבע";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(1472, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "כמות";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1459, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "מחלקה";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(1481, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "ספק";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(706, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(12, 602);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(87, 75);
            this.back.TabIndex = 25;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(1245, 597);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 41);
            this.button3.TabIndex = 26;
            this.button3.Text = "נקה פירוט";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // degem
            // 
            this.degem.Location = new System.Drawing.Point(1135, 206);
            this.degem.Mask = "0000000000";
            this.degem.Name = "degem";
            this.degem.Size = new System.Drawing.Size(200, 20);
            this.degem.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(1288, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "חיפוש";
            // 
            // firma
            // 
            this.firma.FormattingEnabled = true;
            this.firma.Items.AddRange(new object[] {
            "",
            "nike",
            "adidas",
            "nimrod",
            "blundstone",
            "franco bane",
            "truk",
            "tops",
            "fly foot",
            "asics",
            "new balance",
            "timberland",
            "teva naot",
            "moran",
            "rockport"});
            this.firma.Location = new System.Drawing.Point(1135, 256);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(200, 21);
            this.firma.TabIndex = 41;
            this.firma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // degem1
            // 
            this.degem1.Location = new System.Drawing.Point(888, 206);
            this.degem1.Mask = "0000000000";
            this.degem1.Name = "degem1";
            this.degem1.Size = new System.Drawing.Size(200, 20);
            this.degem1.TabIndex = 43;
            this.degem1.Visible = false;
            this.degem1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.degem1_MaskInputRejected);
            // 
            // firma1
            // 
            this.firma1.FormattingEnabled = true;
            this.firma1.Items.AddRange(new object[] {
            "",
            "nike",
            "adidas",
            "nimrod",
            "blundstone",
            "franco bane",
            "truk",
            "tops",
            "fly foot",
            "asics",
            "new balance",
            "timberland",
            "teva naot",
            "moran",
            "rockport"});
            this.firma1.Location = new System.Drawing.Point(888, 256);
            this.firma1.Name = "firma1";
            this.firma1.Size = new System.Drawing.Size(200, 21);
            this.firma1.TabIndex = 44;
            this.firma1.Visible = false;
            // 
            // mehir1
            // 
            this.mehir1.Location = new System.Drawing.Point(888, 300);
            this.mehir1.Mask = "999₪";
            this.mehir1.Name = "mehir1";
            this.mehir1.Size = new System.Drawing.Size(200, 20);
            this.mehir1.TabIndex = 45;
            this.mehir1.Visible = false;
            // 
            // mida1
            // 
            this.mida1.Location = new System.Drawing.Point(888, 350);
            this.mida1.Mask = "00";
            this.mida1.Name = "mida1";
            this.mida1.Size = new System.Drawing.Size(200, 20);
            this.mida1.TabIndex = 46;
            this.mida1.Visible = false;
            // 
            // spak1
            // 
            this.spak1.Location = new System.Drawing.Point(888, 550);
            this.spak1.Name = "spak1";
            this.spak1.Size = new System.Drawing.Size(200, 20);
            this.spak1.TabIndex = 50;
            this.spak1.Visible = false;
            // 
            // mhlaka1
            // 
            this.mhlaka1.Location = new System.Drawing.Point(888, 500);
            this.mhlaka1.Name = "mhlaka1";
            this.mhlaka1.Size = new System.Drawing.Size(200, 20);
            this.mhlaka1.TabIndex = 49;
            this.mhlaka1.Visible = false;
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(888, 400);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(200, 20);
            this.color1.TabIndex = 48;
            this.color1.Visible = false;
            // 
            // kamot1
            // 
            this.kamot1.Location = new System.Drawing.Point(888, 450);
            this.kamot1.Name = "kamot1";
            this.kamot1.Size = new System.Drawing.Size(200, 20);
            this.kamot1.TabIndex = 47;
            this.kamot1.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(548, 596);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 45);
            this.button4.TabIndex = 51;
            this.button4.Text = "עדכון";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(1009, 597);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 43);
            this.button5.TabIndex = 52;
            this.button5.Text = "עדכן";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(1463, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 31);
            this.label10.TabIndex = 53;
            this.label10.Text = "00:00:00";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // shoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1595, 689);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.spak1);
            this.Controls.Add(this.mhlaka1);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.kamot1);
            this.Controls.Add(this.mida1);
            this.Controls.Add(this.mehir1);
            this.Controls.Add(this.firma1);
            this.Controls.Add(this.degem1);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.degem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spak);
            this.Controls.Add(this.mhlaka);
            this.Controls.Add(this.mehir);
            this.Controls.Add(this.mida);
            this.Controls.Add(this.color);
            this.Controls.Add(this.kamot);
            this.Controls.Add(this.dataGridView1);
            this.Name = "shoes";
            this.Text = "shoes";
            this.Load += new System.EventHandler(this.shoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shoe_shopDataSet shoe_shopDataSet;
        private System.Windows.Forms.BindingSource shoesBindingSource;
        private shoe_shopDataSetTableAdapters.shoesTableAdapter shoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn degemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhlakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spakDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox kamot;
        private System.Windows.Forms.MaskedTextBox color;
        private System.Windows.Forms.MaskedTextBox mida;
        private System.Windows.Forms.MaskedTextBox mehir;
        private System.Windows.Forms.MaskedTextBox mhlaka;
        private System.Windows.Forms.MaskedTextBox spak;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox degem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox firma;
        private System.Windows.Forms.MaskedTextBox degem1;
        private System.Windows.Forms.ComboBox firma1;
        private System.Windows.Forms.MaskedTextBox mehir1;
        private System.Windows.Forms.MaskedTextBox mida1;
        private System.Windows.Forms.MaskedTextBox spak1;
        private System.Windows.Forms.MaskedTextBox mhlaka1;
        private System.Windows.Forms.MaskedTextBox color1;
        private System.Windows.Forms.MaskedTextBox kamot1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        //private System.Windows.Forms.MaskedTextBox firma1;
    }
}