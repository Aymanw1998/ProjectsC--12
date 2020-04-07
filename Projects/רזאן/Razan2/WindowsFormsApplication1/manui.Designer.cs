namespace WindowsFormsApplication1
{
    partial class manui
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
            this.tzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mishpahaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeshuvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitamneem2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razan22DataSet1 = new WindowsFormsApplication1.razan22DataSet1();
            this.mitamneem2TableAdapter = new WindowsFormsApplication1.razan22DataSet1TableAdapters.mitamneem2TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tz = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitamneem2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razan22DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tzDataGridViewTextBoxColumn,
            this.shemDataGridViewTextBoxColumn,
            this.mishpahaDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.ktovetDataGridViewTextBoxColumn,
            this.gilDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.tarikhDataGridViewTextBoxColumn,
            this.yeshuvDataGridViewTextBoxColumn,
            this.hiovDataGridViewTextBoxColumn,
            this.hugDataGridViewTextBoxColumn,
            this.tokefDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mitamneem2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tzDataGridViewTextBoxColumn
            // 
            this.tzDataGridViewTextBoxColumn.DataPropertyName = "tz";
            this.tzDataGridViewTextBoxColumn.HeaderText = "תעודת זהות מתאמן";
            this.tzDataGridViewTextBoxColumn.Name = "tzDataGridViewTextBoxColumn";
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "שם מתאמן";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // mishpahaDataGridViewTextBoxColumn
            // 
            this.mishpahaDataGridViewTextBoxColumn.DataPropertyName = "mishpaha";
            this.mishpahaDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.mishpahaDataGridViewTextBoxColumn.Name = "mishpahaDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "מספר פלאפון";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // ktovetDataGridViewTextBoxColumn
            // 
            this.ktovetDataGridViewTextBoxColumn.DataPropertyName = "ktovet";
            this.ktovetDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.ktovetDataGridViewTextBoxColumn.Name = "ktovetDataGridViewTextBoxColumn";
            // 
            // gilDataGridViewTextBoxColumn
            // 
            this.gilDataGridViewTextBoxColumn.DataPropertyName = "gil";
            this.gilDataGridViewTextBoxColumn.HeaderText = "גיל";
            this.gilDataGridViewTextBoxColumn.Name = "gilDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn.HeaderText = "מין";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // tarikhDataGridViewTextBoxColumn
            // 
            this.tarikhDataGridViewTextBoxColumn.DataPropertyName = "tarikh";
            this.tarikhDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.tarikhDataGridViewTextBoxColumn.Name = "tarikhDataGridViewTextBoxColumn";
            // 
            // yeshuvDataGridViewTextBoxColumn
            // 
            this.yeshuvDataGridViewTextBoxColumn.DataPropertyName = "yeshuv";
            this.yeshuvDataGridViewTextBoxColumn.HeaderText = "ישוב";
            this.yeshuvDataGridViewTextBoxColumn.Name = "yeshuvDataGridViewTextBoxColumn";
            // 
            // hiovDataGridViewTextBoxColumn
            // 
            this.hiovDataGridViewTextBoxColumn.DataPropertyName = "hiov";
            this.hiovDataGridViewTextBoxColumn.HeaderText = "חיוב";
            this.hiovDataGridViewTextBoxColumn.Name = "hiovDataGridViewTextBoxColumn";
            // 
            // hugDataGridViewTextBoxColumn
            // 
            this.hugDataGridViewTextBoxColumn.DataPropertyName = "hug";
            this.hugDataGridViewTextBoxColumn.HeaderText = "חוג";
            this.hugDataGridViewTextBoxColumn.Name = "hugDataGridViewTextBoxColumn";
            // 
            // tokefDataGridViewTextBoxColumn
            // 
            this.tokefDataGridViewTextBoxColumn.DataPropertyName = "tokef";
            this.tokefDataGridViewTextBoxColumn.HeaderText = "תוקף מנוי";
            this.tokefDataGridViewTextBoxColumn.Name = "tokefDataGridViewTextBoxColumn";
            // 
            // mitamneem2BindingSource
            // 
            this.mitamneem2BindingSource.DataMember = "mitamneem2";
            this.mitamneem2BindingSource.DataSource = this.razan22DataSet1;
            // 
            // razan22DataSet1
            // 
            this.razan22DataSet1.DataSetName = "razan22DataSet1";
            this.razan22DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitamneem2TableAdapter
            // 
            this.mitamneem2TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(221, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "מנויים אשר פג תוקפם";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "תעודת זהות";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(448, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "חידוש מנוי";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(309, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "מחיקת מתאמן ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "תוקף מנוי";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "tz", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(241, 354);
            this.maskedTextBox1.Mask = "000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "tokef", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(488, 354);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(12, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 60);
            this.button3.TabIndex = 10;
            this.button3.Text = "מתאמנים";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Edwardian Script ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "R.a Fitness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "בדוק אם המתאמן הדרוש נמצא ברשימת המתאמנים אשר פג תוקפם";
            // 
            // tz
            // 
            this.tz.Location = new System.Drawing.Point(766, 416);
            this.tz.Mask = "000000000";
            this.tz.Name = "tz";
            this.tz.Size = new System.Drawing.Size(149, 20);
            this.tz.TabIndex = 11;
            this.tz.MaskChanged += new System.EventHandler(this.tz_MaskChanged);
            this.tz.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tz_MaskInputRejected);
            this.tz.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.tz_TypeValidationCompleted);
            this.tz.TextChanged += new System.EventHandler(this.tz_TextChanged);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(701, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 27);
            this.button4.TabIndex = 13;
            this.button4.Text = "בדוק";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // manui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tz);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "manui";
            this.Text = "manui";
            this.Load += new System.EventHandler(this.manui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitamneem2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razan22DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private razan22DataSet1 razan22DataSet1;
        private System.Windows.Forms.BindingSource mitamneem2BindingSource;
        private razan22DataSet1TableAdapters.mitamneem2TableAdapter mitamneem2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mishpahaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarikhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeshuvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokefDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tz;
        private System.Windows.Forms.Button button4;
    }
}