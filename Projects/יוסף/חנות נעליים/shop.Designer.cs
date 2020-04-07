namespace חנות_נעליים
{
    partial class shop
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.degem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degem_Tb = new System.Windows.Forms.TextBox();
            this.mehir_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oved = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(1004, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(847, 195);
            this.dataGridView1.TabIndex = 1;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degem,
            this.mehir});
            this.dataGridView2.Location = new System.Drawing.Point(1158, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(247, 332);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // degem
            // 
            this.degem.HeaderText = "degem";
            this.degem.Name = "degem";
            // 
            // mehir
            // 
            this.mehir.HeaderText = "mehir";
            this.mehir.Name = "mehir";
            // 
            // degem_Tb
            // 
            this.degem_Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.degem_Tb.Location = new System.Drawing.Point(795, 272);
            this.degem_Tb.Name = "degem_Tb";
            this.degem_Tb.Size = new System.Drawing.Size(179, 38);
            this.degem_Tb.TabIndex = 3;
            this.degem_Tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mehir_tb
            // 
            this.mehir_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mehir_tb.Location = new System.Drawing.Point(795, 329);
            this.mehir_tb.Name = "mehir_tb";
            this.mehir_tb.Size = new System.Drawing.Size(179, 38);
            this.mehir_tb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(795, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "הוסף לחשבון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(1158, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 74);
            this.button2.TabIndex = 6;
            this.button2.Text = "סכם קופה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oved
            // 
            this.oved.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oved.Location = new System.Drawing.Point(12, 630);
            this.oved.Name = "oved";
            this.oved.Size = new System.Drawing.Size(215, 85);
            this.oved.TabIndex = 7;
            this.oved.Text = "כניסת עובד ";
            this.oved.UseVisualStyleBackColor = true;
            this.oved.Click += new System.EventHandler(this.oved_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1243, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "רשום קוד נעל";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(998, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "קוד נעל";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(1027, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "מחיר";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(276, 630);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 84);
            this.button3.TabIndex = 11;
            this.button3.Text = "כניסה למנהל";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(1004, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 48);
            this.button4.TabIndex = 12;
            this.button4.Text = "בדוק קוד אחר";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(1158, 640);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 74);
            this.button5.TabIndex = 13;
            this.button5.Text = "חשבון חדש";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1479, 727);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oved);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mehir_tb);
            this.Controls.Add(this.degem_Tb);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "shop";
            this.Text = "shop";
            this.Load += new System.EventHandler(this.shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn degem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mehir;
        private System.Windows.Forms.TextBox degem_Tb;
        private System.Windows.Forms.TextBox mehir_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button oved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}