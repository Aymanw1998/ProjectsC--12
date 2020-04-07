namespace WindowsFormsApplication1
{
    partial class frmhz1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dohSpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ms2 = new System.Windows.Forms.MaskedTextBox();
            this.spakimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spakimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.spakimTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.misparhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemSpakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doh_spTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.doh_spTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dohSpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spakimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "דוח מכירות ספקים";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1173, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1152, 348);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dohSpBindingSource, "price", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(1152, 617);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 5;
            // 
            // dohSpBindingSource
            // 
            this.dohSpBindingSource.DataMember = "doh sp";
            this.dohSpBindingSource.DataSource = this.abedDataSet;
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1379, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "חיפוש";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1379, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "מס חשבונית";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1379, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "שם ספק";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1379, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "מחיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1379, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "תאריך";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "הוספה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "עדכון";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "סיום";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dohSpBindingSource, "shem spak", true));
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1152, 413);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // ms2
            // 
            this.ms2.Enabled = false;
            this.ms2.Location = new System.Drawing.Point(1152, 530);
            this.ms2.Mask = "00/00/0000";
            this.ms2.Name = "ms2";
            this.ms2.Size = new System.Drawing.Size(121, 20);
            this.ms2.TabIndex = 16;
            this.ms2.ValidatingType = typeof(System.DateTime);
            // 
            // spakimBindingSource
            // 
            this.spakimBindingSource.DataMember = "spakim";
            this.spakimBindingSource.DataSource = this.abedDataSet;
            // 
            // spakimTableAdapter
            // 
            this.spakimTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.misparhDataGridViewTextBoxColumn,
            this.shemSpakDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.tarickDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dohSpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(442, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // misparhDataGridViewTextBoxColumn
            // 
            this.misparhDataGridViewTextBoxColumn.DataPropertyName = "misparh";
            this.misparhDataGridViewTextBoxColumn.HeaderText = "מספר חשבונית";
            this.misparhDataGridViewTextBoxColumn.Name = "misparhDataGridViewTextBoxColumn";
            // 
            // shemSpakDataGridViewTextBoxColumn
            // 
            this.shemSpakDataGridViewTextBoxColumn.DataPropertyName = "shem spak";
            this.shemSpakDataGridViewTextBoxColumn.HeaderText = "שם ספק";
            this.shemSpakDataGridViewTextBoxColumn.Name = "shemSpakDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "מחיר";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // tarickDataGridViewTextBoxColumn
            // 
            this.tarickDataGridViewTextBoxColumn.DataPropertyName = "tarick";
            this.tarickDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.tarickDataGridViewTextBoxColumn.Name = "tarickDataGridViewTextBoxColumn";
            // 
            // doh_spTableAdapter
            // 
            this.doh_spTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(801, 545);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 55);
            this.button4.TabIndex = 18;
            this.button4.Text = "הוספה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(586, 542);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 55);
            this.button5.TabIndex = 19;
            this.button5.Text = "עדכון";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(145, 723);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 55);
            this.button6.TabIndex = 20;
            this.button6.Text = "סיום תוכנה";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1238, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 79);
            this.label7.TabIndex = 21;
            this.label7.Text = "extreme car";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1369, 723);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 55);
            this.button7.TabIndex = 22;
            this.button7.Text = "חזרה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmhz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1538, 897);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ms2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmhz1";
            this.Text = "frmhz1";
            this.Load += new System.EventHandler(this.frmhz1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dohSpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spakimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource spakimBindingSource;
        private abedDataSetTableAdapters.spakimTableAdapter spakimTableAdapter;
        private System.Windows.Forms.MaskedTextBox ms2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dohSpBindingSource;
        private abedDataSetTableAdapters.doh_spTableAdapter doh_spTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemSpakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarickDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
    }
}