namespace חנות_נעליים
{
    partial class mahlakot
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
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovdeemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meheerotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnevotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahlakotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoe_shopDataSet = new חנות_נעליים.shoe_shopDataSet();
            this.mahlakotTableAdapter = new חנות_נעליים.shoe_shopDataSetTableAdapters.mahlakotTableAdapter();
            this.shem = new System.Windows.Forms.MaskedTextBox();
            this.gnevot = new System.Windows.Forms.MaskedTextBox();
            this.meheerot = new System.Windows.Forms.MaskedTextBox();
            this.ovdeem = new System.Windows.Forms.MaskedTextBox();
            this.kamot = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kamot1 = new System.Windows.Forms.MaskedTextBox();
            this.ovdeem1 = new System.Windows.Forms.MaskedTextBox();
            this.meheerot1 = new System.Windows.Forms.MaskedTextBox();
            this.gnevot1 = new System.Windows.Forms.MaskedTextBox();
            this.shem1 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.edkon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahlakotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shemDataGridViewTextBoxColumn,
            this.ovdeemDataGridViewTextBoxColumn,
            this.meheerotDataGridViewTextBoxColumn,
            this.gnevotDataGridViewTextBoxColumn,
            this.kamotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahlakotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "shem";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // ovdeemDataGridViewTextBoxColumn
            // 
            this.ovdeemDataGridViewTextBoxColumn.DataPropertyName = "ovdeem";
            this.ovdeemDataGridViewTextBoxColumn.HeaderText = "ovdeem";
            this.ovdeemDataGridViewTextBoxColumn.Name = "ovdeemDataGridViewTextBoxColumn";
            // 
            // meheerotDataGridViewTextBoxColumn
            // 
            this.meheerotDataGridViewTextBoxColumn.DataPropertyName = "meheerot";
            this.meheerotDataGridViewTextBoxColumn.HeaderText = "meheerot";
            this.meheerotDataGridViewTextBoxColumn.Name = "meheerotDataGridViewTextBoxColumn";
            // 
            // gnevotDataGridViewTextBoxColumn
            // 
            this.gnevotDataGridViewTextBoxColumn.DataPropertyName = "gnevot";
            this.gnevotDataGridViewTextBoxColumn.HeaderText = "gnevot";
            this.gnevotDataGridViewTextBoxColumn.Name = "gnevotDataGridViewTextBoxColumn";
            // 
            // kamotDataGridViewTextBoxColumn
            // 
            this.kamotDataGridViewTextBoxColumn.DataPropertyName = "kamot";
            this.kamotDataGridViewTextBoxColumn.HeaderText = "kamot";
            this.kamotDataGridViewTextBoxColumn.Name = "kamotDataGridViewTextBoxColumn";
            // 
            // mahlakotBindingSource
            // 
            this.mahlakotBindingSource.DataMember = "mahlakot";
            this.mahlakotBindingSource.DataSource = this.shoe_shopDataSet;
            // 
            // shoe_shopDataSet
            // 
            this.shoe_shopDataSet.DataSetName = "shoe_shopDataSet";
            this.shoe_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahlakotTableAdapter
            // 
            this.mahlakotTableAdapter.ClearBeforeFill = true;
            // 
            // shem
            // 
            this.shem.Location = new System.Drawing.Point(1000, 243);
            this.shem.Name = "shem";
            this.shem.Size = new System.Drawing.Size(149, 20);
            this.shem.TabIndex = 1;
            // 
            // gnevot
            // 
            this.gnevot.Location = new System.Drawing.Point(1000, 393);
            this.gnevot.Name = "gnevot";
            this.gnevot.Size = new System.Drawing.Size(149, 20);
            this.gnevot.TabIndex = 2;
            // 
            // meheerot
            // 
            this.meheerot.Location = new System.Drawing.Point(1000, 343);
            this.meheerot.Name = "meheerot";
            this.meheerot.Size = new System.Drawing.Size(149, 20);
            this.meheerot.TabIndex = 3;
            this.meheerot.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.meheerot_MaskInputRejected);
            // 
            // ovdeem
            // 
            this.ovdeem.Location = new System.Drawing.Point(1000, 293);
            this.ovdeem.Name = "ovdeem";
            this.ovdeem.Size = new System.Drawing.Size(149, 20);
            this.ovdeem.TabIndex = 4;
            // 
            // kamot
            // 
            this.kamot.Location = new System.Drawing.Point(1000, 443);
            this.kamot.Name = "kamot";
            this.kamot.Size = new System.Drawing.Size(149, 20);
            this.kamot.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(629, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(383, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "מחק";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(12, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 78);
            this.button3.TabIndex = 8;
            this.button3.Text = "חזרה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1221, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "מחלקה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1188, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "מס\' עובדים";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(1217, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "מחירות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(1224, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "גניבות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(1236, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "כמות";
            // 
            // kamot1
            // 
            this.kamot1.Location = new System.Drawing.Point(807, 443);
            this.kamot1.Name = "kamot1";
            this.kamot1.Size = new System.Drawing.Size(149, 20);
            this.kamot1.TabIndex = 18;
            this.kamot1.Visible = false;
            // 
            // ovdeem1
            // 
            this.ovdeem1.Location = new System.Drawing.Point(807, 293);
            this.ovdeem1.Name = "ovdeem1";
            this.ovdeem1.Size = new System.Drawing.Size(149, 20);
            this.ovdeem1.TabIndex = 17;
            this.ovdeem1.Visible = false;
            // 
            // meheerot1
            // 
            this.meheerot1.Location = new System.Drawing.Point(807, 343);
            this.meheerot1.Name = "meheerot1";
            this.meheerot1.Size = new System.Drawing.Size(149, 20);
            this.meheerot1.TabIndex = 16;
            this.meheerot1.Visible = false;
            // 
            // gnevot1
            // 
            this.gnevot1.Location = new System.Drawing.Point(807, 393);
            this.gnevot1.Name = "gnevot1";
            this.gnevot1.Size = new System.Drawing.Size(149, 20);
            this.gnevot1.TabIndex = 15;
            this.gnevot1.Visible = false;
            // 
            // shem1
            // 
            this.shem1.Location = new System.Drawing.Point(807, 243);
            this.shem1.Name = "shem1";
            this.shem1.Size = new System.Drawing.Size(149, 20);
            this.shem1.TabIndex = 14;
            this.shem1.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(509, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 51);
            this.button4.TabIndex = 19;
            this.button4.Text = "עדכון";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // edkon
            // 
            this.edkon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edkon.Location = new System.Drawing.Point(883, 483);
            this.edkon.Name = "edkon";
            this.edkon.Size = new System.Drawing.Size(82, 51);
            this.edkon.TabIndex = 20;
            this.edkon.Text = "עדכן";
            this.edkon.UseVisualStyleBackColor = true;
            this.edkon.Visible = false;
            this.edkon.Click += new System.EventHandler(this.edkon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(914, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(1066, 483);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 51);
            this.button5.TabIndex = 28;
            this.button5.Text = "נקה פירוט";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(1089, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "חיפוש";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(1304, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 42;
            this.label6.Text = "00:00:00";
            // 
            // mahlakot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1436, 638);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.edkon);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.kamot1);
            this.Controls.Add(this.ovdeem1);
            this.Controls.Add(this.meheerot1);
            this.Controls.Add(this.gnevot1);
            this.Controls.Add(this.shem1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kamot);
            this.Controls.Add(this.ovdeem);
            this.Controls.Add(this.meheerot);
            this.Controls.Add(this.gnevot);
            this.Controls.Add(this.shem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mahlakot";
            this.Text = "ol";
            this.Load += new System.EventHandler(this.mahlakot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahlakotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shoe_shopDataSet shoe_shopDataSet;
        private System.Windows.Forms.BindingSource mahlakotBindingSource;
        private shoe_shopDataSetTableAdapters.mahlakotTableAdapter mahlakotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ovdeemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meheerotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnevotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamotDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox shem;
        private System.Windows.Forms.MaskedTextBox gnevot;
        private System.Windows.Forms.MaskedTextBox meheerot;
        private System.Windows.Forms.MaskedTextBox ovdeem;
        private System.Windows.Forms.MaskedTextBox kamot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox kamot1;
        private System.Windows.Forms.MaskedTextBox ovdeem1;
        private System.Windows.Forms.MaskedTextBox meheerot1;
        private System.Windows.Forms.MaskedTextBox gnevot1;
        private System.Windows.Forms.MaskedTextBox shem1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button edkon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}