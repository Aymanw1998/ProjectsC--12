namespace WindowsFormsApplication1
{
    partial class spakim
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shemSpakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemMeshpahaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemHebraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spakimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.spakimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.spakimTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.mstextBox7 = new System.Windows.Forms.MaskedTextBox();
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
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spakimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn.Location = new System.Drawing.Point(1447, 642);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(121, 49);
            this.btn.TabIndex = 0;
            this.btn.Text = "חזרה ";
            this.btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn2.Location = new System.Drawing.Point(652, 487);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(133, 74);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "הוסף ספק";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(439, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "מחק ספק";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shemSpakDataGridViewTextBoxColumn,
            this.shemMeshpahaDataGridViewTextBoxColumn,
            this.teleDataGridViewTextBoxColumn,
            this.ktovetDataGridViewTextBoxColumn,
            this.shemHebraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spakimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 230);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // shemSpakDataGridViewTextBoxColumn
            // 
            this.shemSpakDataGridViewTextBoxColumn.DataPropertyName = "shem spak";
            this.shemSpakDataGridViewTextBoxColumn.HeaderText = "שם ספק";
            this.shemSpakDataGridViewTextBoxColumn.Name = "shemSpakDataGridViewTextBoxColumn";
            // 
            // shemMeshpahaDataGridViewTextBoxColumn
            // 
            this.shemMeshpahaDataGridViewTextBoxColumn.DataPropertyName = "shem meshpaha";
            this.shemMeshpahaDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.shemMeshpahaDataGridViewTextBoxColumn.Name = "shemMeshpahaDataGridViewTextBoxColumn";
            // 
            // teleDataGridViewTextBoxColumn
            // 
            this.teleDataGridViewTextBoxColumn.DataPropertyName = "tele";
            this.teleDataGridViewTextBoxColumn.HeaderText = "מספר טלפון";
            this.teleDataGridViewTextBoxColumn.Name = "teleDataGridViewTextBoxColumn";
            // 
            // ktovetDataGridViewTextBoxColumn
            // 
            this.ktovetDataGridViewTextBoxColumn.DataPropertyName = "ktovet";
            this.ktovetDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.ktovetDataGridViewTextBoxColumn.Name = "ktovetDataGridViewTextBoxColumn";
            // 
            // shemHebraDataGridViewTextBoxColumn
            // 
            this.shemHebraDataGridViewTextBoxColumn.DataPropertyName = "shem hebra";
            this.shemHebraDataGridViewTextBoxColumn.HeaderText = "שם חברה";
            this.shemHebraDataGridViewTextBoxColumn.Name = "shemHebraDataGridViewTextBoxColumn";
            // 
            // spakimBindingSource
            // 
            this.spakimBindingSource.DataMember = "spakim";
            this.spakimBindingSource.DataSource = this.abedDataSet;
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spakimTableAdapter
            // 
            this.spakimTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(357, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "ספקים";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1229, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spakimBindingSource, "ktovet", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(1229, 308);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spakimBindingSource, "shem meshpaha", true));
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(1229, 219);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 12;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spakimBindingSource, "shem hebra", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1229, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1396, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "שם ספק ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1396, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "שם חברה";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1396, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "כתובת";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1396, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "מספר טלפון";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1396, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "שם משפחה";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(264, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 71);
            this.button1.TabIndex = 20;
            this.button1.Text = "עדכן";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1229, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1396, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "חיפוש";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spakimBindingSource, "shem spak", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(1229, 176);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // mstextBox7
            // 
            this.mstextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spakimBindingSource, "tele", true));
            this.mstextBox7.Enabled = false;
            this.mstextBox7.Location = new System.Drawing.Point(1229, 265);
            this.mstextBox7.Mask = "(999) 000-0000";
            this.mstextBox7.Name = "mstextBox7";
            this.mstextBox7.Size = new System.Drawing.Size(100, 20);
            this.mstextBox7.TabIndex = 24;
            this.mstextBox7.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(910, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "הראשון";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(910, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "הבא";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(910, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "לפני";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(910, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "האחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1153, 632);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 74);
            this.button7.TabIndex = 29;
            this.button7.Text = "הזמנת ספקים";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(652, 488);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 73);
            this.button8.TabIndex = 30;
            this.button8.Text = "הוסף ספק";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(264, 485);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 73);
            this.button9.TabIndex = 31;
            this.button9.Text = "עדכן";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(439, 487);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 73);
            this.button10.TabIndex = 32;
            this.button10.Text = "מחק ספק";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button11.Location = new System.Drawing.Point(12, 471);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(121, 49);
            this.button11.TabIndex = 33;
            this.button11.Text = "סיום";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button12.Location = new System.Drawing.Point(92, 623);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(222, 87);
            this.button12.TabIndex = 34;
            this.button12.Text = "סגור מערכת";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1280, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 79);
            this.label8.TabIndex = 35;
            this.label8.Text = "extreme car";
            // 
            // spakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1580, 722);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.mstextBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spakimBindingSource, "tele", true));
            this.Name = "spakim";
            this.Load += new System.EventHandler(this.spakim_Load);
            this.Click += new System.EventHandler(this.spakim_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spakimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.BindingSource spakimBindingSource;
        private abedDataSetTableAdapters.spakimTableAdapter spakimTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemSpakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemMeshpahaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemHebraDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MaskedTextBox mstextBox7;
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
        private System.Windows.Forms.Label label8;
    }
}