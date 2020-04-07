namespace WindowsFormsApplication1
{
    partial class formmahshireem
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
            this.lblmah = new System.Windows.Forms.Label();
            this.btnmahidk = new System.Windows.Forms.Button();
            this.btnmahmh = new System.Windows.Forms.Button();
            this.btnmahho = new System.Windows.Forms.Button();
            this.btnbkab = new System.Windows.Forms.Button();
            this.lblsmachines = new System.Windows.Forms.Label();
            this.tbmachines = new System.Windows.Forms.TextBox();
            this.lblmehir = new System.Windows.Forms.Label();
            this.lbldegem = new System.Windows.Forms.Label();
            this.lblsapak = new System.Windows.Forms.Label();
            this.lbshemmahshir = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.codmahshir = new System.Windows.Forms.TextBox();
            this.mahshireem2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razan22DataSet1 = new WindowsFormsApplication1.razan22DataSet1();
            this.shemmahshir = new System.Windows.Forms.TextBox();
            this.degem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahshireem2TableAdapter = new WindowsFormsApplication1.razan22DataSet1TableAdapters.mahshireem2TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mehir = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sapak = new System.Windows.Forms.ComboBox();
            this.sapakim2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sapakim2TableAdapter = new WindowsFormsApplication1.razan22DataSet1TableAdapters.sapakim2TableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mahshireem2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razan22DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakim2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmah
            // 
            this.lblmah.AutoSize = true;
            this.lblmah.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmah.Location = new System.Drawing.Point(291, 6);
            this.lblmah.Name = "lblmah";
            this.lblmah.Size = new System.Drawing.Size(537, 113);
            this.lblmah.TabIndex = 1;
            this.lblmah.Text = "Fitness Machines";
            this.lblmah.Click += new System.EventHandler(this.lblmah_Click);
            // 
            // btnmahidk
            // 
            this.btnmahidk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmahidk.ForeColor = System.Drawing.Color.Purple;
            this.btnmahidk.Location = new System.Drawing.Point(754, 387);
            this.btnmahidk.Name = "btnmahidk";
            this.btnmahidk.Size = new System.Drawing.Size(166, 69);
            this.btnmahidk.TabIndex = 11;
            this.btnmahidk.Text = "עדכן";
            this.btnmahidk.UseVisualStyleBackColor = true;
            this.btnmahidk.Click += new System.EventHandler(this.btnmahidk_Click);
            // 
            // btnmahmh
            // 
            this.btnmahmh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmahmh.ForeColor = System.Drawing.Color.Purple;
            this.btnmahmh.Location = new System.Drawing.Point(508, 387);
            this.btnmahmh.Name = "btnmahmh";
            this.btnmahmh.Size = new System.Drawing.Size(166, 69);
            this.btnmahmh.TabIndex = 10;
            this.btnmahmh.Text = "מחק";
            this.btnmahmh.UseVisualStyleBackColor = true;
            this.btnmahmh.Click += new System.EventHandler(this.btnmahmh_Click);
            // 
            // btnmahho
            // 
            this.btnmahho.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmahho.ForeColor = System.Drawing.Color.Purple;
            this.btnmahho.Location = new System.Drawing.Point(264, 387);
            this.btnmahho.Name = "btnmahho";
            this.btnmahho.Size = new System.Drawing.Size(166, 69);
            this.btnmahho.TabIndex = 9;
            this.btnmahho.Text = "הוסף";
            this.btnmahho.UseVisualStyleBackColor = true;
            this.btnmahho.Click += new System.EventHandler(this.btnmahho_Click);
            // 
            // btnbkab
            // 
            this.btnbkab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkab.ForeColor = System.Drawing.Color.Purple;
            this.btnbkab.Location = new System.Drawing.Point(12, 482);
            this.btnbkab.Name = "btnbkab";
            this.btnbkab.Size = new System.Drawing.Size(166, 69);
            this.btnbkab.TabIndex = 13;
            this.btnbkab.Text = "חזרה לדף הראשי";
            this.btnbkab.UseVisualStyleBackColor = true;
            this.btnbkab.Click += new System.EventHandler(this.btnbkab_Click);
            // 
            // lblsmachines
            // 
            this.lblsmachines.AutoSize = true;
            this.lblsmachines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblsmachines.Location = new System.Drawing.Point(1208, 99);
            this.lblsmachines.Name = "lblsmachines";
            this.lblsmachines.Size = new System.Drawing.Size(48, 20);
            this.lblsmachines.TabIndex = 16;
            this.lblsmachines.Text = "חיפוש";
            // 
            // tbmachines
            // 
            this.tbmachines.Location = new System.Drawing.Point(974, 101);
            this.tbmachines.Name = "tbmachines";
            this.tbmachines.Size = new System.Drawing.Size(210, 20);
            this.tbmachines.TabIndex = 6;
            this.tbmachines.TextChanged += new System.EventHandler(this.tbmachines_TextChanged);
            // 
            // lblmehir
            // 
            this.lblmehir.AutoSize = true;
            this.lblmehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblmehir.Location = new System.Drawing.Point(1213, 357);
            this.lblmehir.Name = "lblmehir";
            this.lblmehir.Size = new System.Drawing.Size(43, 20);
            this.lblmehir.TabIndex = 48;
            this.lblmehir.Text = "מחיר";
            // 
            // lbldegem
            // 
            this.lbldegem.AutoSize = true;
            this.lbldegem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbldegem.Location = new System.Drawing.Point(1219, 307);
            this.lbldegem.Name = "lbldegem";
            this.lbldegem.Size = new System.Drawing.Size(34, 20);
            this.lbldegem.TabIndex = 47;
            this.lbldegem.Text = "דגם";
            // 
            // lblsapak
            // 
            this.lblsapak.AutoSize = true;
            this.lblsapak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblsapak.Location = new System.Drawing.Point(1218, 255);
            this.lblsapak.Name = "lblsapak";
            this.lblsapak.Size = new System.Drawing.Size(35, 20);
            this.lblsapak.TabIndex = 46;
            this.lblsapak.Text = "ספק";
            // 
            // lbshemmahshir
            // 
            this.lbshemmahshir.AutoSize = true;
            this.lbshemmahshir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbshemmahshir.Location = new System.Drawing.Point(1180, 203);
            this.lbshemmahshir.Name = "lbshemmahshir";
            this.lbshemmahshir.Size = new System.Drawing.Size(76, 20);
            this.lbshemmahshir.TabIndex = 45;
            this.lbshemmahshir.Text = "שם מכשיר";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblcod.Location = new System.Drawing.Point(1177, 150);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(79, 20);
            this.lblcod.TabIndex = 44;
            this.lblcod.Text = "קוד מכשיר";
            // 
            // codmahshir
            // 
            this.codmahshir.Enabled = false;
            this.codmahshir.Location = new System.Drawing.Point(984, 156);
            this.codmahshir.Name = "codmahshir";
            this.codmahshir.Size = new System.Drawing.Size(151, 20);
            this.codmahshir.TabIndex = 1;
            this.codmahshir.TextChanged += new System.EventHandler(this.codmahshir_TextChanged);
            this.codmahshir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codmahshir_KeyPress);
            // 
            // mahshireem2BindingSource
            // 
            this.mahshireem2BindingSource.DataMember = "mahshireem2";
            this.mahshireem2BindingSource.DataSource = this.razan22DataSet1;
            // 
            // razan22DataSet1
            // 
            this.razan22DataSet1.DataSetName = "razan22DataSet1";
            this.razan22DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shemmahshir
            // 
            this.shemmahshir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahshireem2BindingSource, "shem", true));
            this.shemmahshir.Enabled = false;
            this.shemmahshir.Location = new System.Drawing.Point(984, 205);
            this.shemmahshir.Name = "shemmahshir";
            this.shemmahshir.Size = new System.Drawing.Size(151, 20);
            this.shemmahshir.TabIndex = 2;
            this.shemmahshir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shemmahshir_KeyPress);
            // 
            // degem
            // 
            this.degem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahshireem2BindingSource, "degem", true));
            this.degem.Enabled = false;
            this.degem.Location = new System.Drawing.Point(984, 309);
            this.degem.Name = "degem";
            this.degem.Size = new System.Drawing.Size(151, 20);
            this.degem.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDataGridViewTextBoxColumn,
            this.shemDataGridViewTextBoxColumn,
            this.sapakDataGridViewTextBoxColumn,
            this.degemDataGridViewTextBoxColumn,
            this.mehirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahshireem2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(321, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 183);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "קוד מכשיר";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "שם מכשיר";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            this.shemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sapakDataGridViewTextBoxColumn
            // 
            this.sapakDataGridViewTextBoxColumn.DataPropertyName = "sapak";
            this.sapakDataGridViewTextBoxColumn.HeaderText = "ספק";
            this.sapakDataGridViewTextBoxColumn.Name = "sapakDataGridViewTextBoxColumn";
            this.sapakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degemDataGridViewTextBoxColumn
            // 
            this.degemDataGridViewTextBoxColumn.DataPropertyName = "degem";
            this.degemDataGridViewTextBoxColumn.HeaderText = "דגם";
            this.degemDataGridViewTextBoxColumn.Name = "degemDataGridViewTextBoxColumn";
            this.degemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mehirDataGridViewTextBoxColumn
            // 
            this.mehirDataGridViewTextBoxColumn.DataPropertyName = "mehir";
            this.mehirDataGridViewTextBoxColumn.HeaderText = "מחיר מכשיר";
            this.mehirDataGridViewTextBoxColumn.Name = "mehirDataGridViewTextBoxColumn";
            this.mehirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mahshireem2TableAdapter
            // 
            this.mahshireem2TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(960, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "**";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(960, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "**";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(960, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "**";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(960, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "**";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(960, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "**";
            this.label5.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahshireem2BindingSource, "cod", true));
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(984, 156);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(151, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // mehir
            // 
            this.mehir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahshireem2BindingSource, "mehir", true));
            this.mehir.Enabled = false;
            this.mehir.Location = new System.Drawing.Point(984, 357);
            this.mehir.Mask = "0999";
            this.mehir.Name = "mehir";
            this.mehir.Size = new System.Drawing.Size(151, 20);
            this.mehir.TabIndex = 5;
            this.mehir.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mehir_MaskInputRejected);
            this.mehir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mehir_KeyPress);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(160, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 60;
            this.button2.Text = "אחרון";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(160, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 59;
            this.button1.Text = "ראשון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(160, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 46);
            this.button4.TabIndex = 62;
            this.button4.Text = "הבא";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(160, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 46);
            this.button3.TabIndex = 61;
            this.button3.Text = "הקודם";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Purple;
            this.button5.Location = new System.Drawing.Point(264, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 69);
            this.button5.TabIndex = 63;
            this.button5.Text = "הוסף";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Purple;
            this.button6.Location = new System.Drawing.Point(754, 387);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 69);
            this.button6.TabIndex = 64;
            this.button6.Text = "עדכן";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sapak
            // 
            this.sapak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sapak.Enabled = false;
            this.sapak.FormattingEnabled = true;
            this.sapak.Location = new System.Drawing.Point(984, 253);
            this.sapak.Name = "sapak";
            this.sapak.Size = new System.Drawing.Size(151, 21);
            this.sapak.TabIndex = 3;
            // 
            // sapakim2BindingSource
            // 
            this.sapakim2BindingSource.DataMember = "sapakim2";
            this.sapakim2BindingSource.DataSource = this.razan22DataSet1;
            // 
            // sapakim2TableAdapter
            // 
            this.sapakim2TableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Edwardian Script ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 33);
            this.label6.TabIndex = 65;
            this.label6.Text = "R.a Fitness";
            // 
            // formmahshireem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 563);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sapak);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mehir);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblmehir);
            this.Controls.Add(this.lbldegem);
            this.Controls.Add(this.lblsapak);
            this.Controls.Add(this.lbshemmahshir);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.codmahshir);
            this.Controls.Add(this.shemmahshir);
            this.Controls.Add(this.degem);
            this.Controls.Add(this.lblsmachines);
            this.Controls.Add(this.tbmachines);
            this.Controls.Add(this.btnbkab);
            this.Controls.Add(this.btnmahidk);
            this.Controls.Add(this.btnmahmh);
            this.Controls.Add(this.btnmahho);
            this.Controls.Add(this.lblmah);
            this.Name = "formmahshireem";
            this.Text = "formmahshireem";
            this.Load += new System.EventHandler(this.formmahshireem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahshireem2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razan22DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakim2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmah;
        private System.Windows.Forms.Button btnmahidk;
        private System.Windows.Forms.Button btnmahmh;
        private System.Windows.Forms.Button btnmahho;
        private System.Windows.Forms.Button btnbkab;
        private System.Windows.Forms.Label lblsmachines;
        private System.Windows.Forms.TextBox tbmachines;
        private System.Windows.Forms.Label lblmehir;
        private System.Windows.Forms.Label lbldegem;
        private System.Windows.Forms.Label lblsapak;
        private System.Windows.Forms.Label lbshemmahshir;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox codmahshir;
        private System.Windows.Forms.TextBox shemmahshir;
        private System.Windows.Forms.TextBox degem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private razan22DataSet1 razan22DataSet1;
        private System.Windows.Forms.BindingSource mahshireem2BindingSource;
        private razan22DataSet1TableAdapters.mahshireem2TableAdapter mahshireem2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mehir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox sapak;
        private System.Windows.Forms.BindingSource sapakim2BindingSource;
        private razan22DataSet1TableAdapters.sapakim2TableAdapter sapakim2TableAdapter;
        private System.Windows.Forms.Label label6;
    }
}