namespace חנות_נעליים
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
            this.tb_shem = new System.Windows.Forms.MaskedTextBox();
            this.tb_telphon = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.MaskedTextBox();
            this.tb_ktovet = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shem = new System.Windows.Forms.Label();
            this.telphon = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.ktovet = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telphonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapakeemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoe_shopDataSet = new חנות_נעליים.shoe_shopDataSet();
            this.sapakeemTableAdapter = new חנות_נעליים.shoe_shopDataSetTableAdapters.sapakeemTableAdapter();
            this.tb_shem1 = new System.Windows.Forms.TextBox();
            this.tb_email1 = new System.Windows.Forms.TextBox();
            this.tb_ktovet1 = new System.Windows.Forms.TextBox();
            this.edkon = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_telphon1 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakeemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_shem
            // 
            this.tb_shem.Location = new System.Drawing.Point(1006, 227);
            this.tb_shem.Name = "tb_shem";
            this.tb_shem.Size = new System.Drawing.Size(137, 20);
            this.tb_shem.TabIndex = 1;
            this.tb_shem.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_shem_MaskInputRejected);
            // 
            // tb_telphon
            // 
            this.tb_telphon.Location = new System.Drawing.Point(1006, 299);
            this.tb_telphon.Mask = "00-0000000";
            this.tb_telphon.Name = "tb_telphon";
            this.tb_telphon.Size = new System.Drawing.Size(137, 20);
            this.tb_telphon.TabIndex = 2;
            this.tb_telphon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_telphon_MaskInputRejected);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(1006, 367);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(137, 20);
            this.tb_email.TabIndex = 3;
            // 
            // tb_ktovet
            // 
            this.tb_ktovet.Location = new System.Drawing.Point(1006, 432);
            this.tb_ktovet.Name = "tb_ktovet";
            this.tb_ktovet.Size = new System.Drawing.Size(137, 20);
            this.tb_ktovet.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(638, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "הוסף ספק";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shem
            // 
            this.shem.AutoSize = true;
            this.shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shem.Location = new System.Drawing.Point(1247, 227);
            this.shem.Name = "shem";
            this.shem.Size = new System.Drawing.Size(35, 25);
            this.shem.TabIndex = 7;
            this.shem.Text = "שם";
            // 
            // telphon
            // 
            this.telphon.AutoSize = true;
            this.telphon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.telphon.Location = new System.Drawing.Point(1196, 294);
            this.telphon.Name = "telphon";
            this.telphon.Size = new System.Drawing.Size(86, 25);
            this.telphon.TabIndex = 8;
            this.telphon.Text = "מס\' טלפון";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Email.Location = new System.Drawing.Point(1218, 361);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(64, 25);
            this.Email.TabIndex = 9;
            this.Email.Text = "אימייל";
            // 
            // ktovet
            // 
            this.ktovet.AutoSize = true;
            this.ktovet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ktovet.Location = new System.Drawing.Point(1222, 426);
            this.ktovet.Name = "ktovet";
            this.ktovet.Size = new System.Drawing.Size(60, 25);
            this.ktovet.TabIndex = 10;
            this.ktovet.Text = "כתובת";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(296, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "מחק ספק";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shemDataGridViewTextBoxColumn,
            this.telphonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ktovetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sapakeemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 263);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "shem";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // telphonDataGridViewTextBoxColumn
            // 
            this.telphonDataGridViewTextBoxColumn.DataPropertyName = "telphon";
            this.telphonDataGridViewTextBoxColumn.HeaderText = "telphon";
            this.telphonDataGridViewTextBoxColumn.Name = "telphonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ktovetDataGridViewTextBoxColumn
            // 
            this.ktovetDataGridViewTextBoxColumn.DataPropertyName = "ktovet";
            this.ktovetDataGridViewTextBoxColumn.HeaderText = "ktovet";
            this.ktovetDataGridViewTextBoxColumn.Name = "ktovetDataGridViewTextBoxColumn";
            // 
            // sapakeemBindingSource
            // 
            this.sapakeemBindingSource.DataMember = "sapakeem";
            this.sapakeemBindingSource.DataSource = this.shoe_shopDataSet;
            // 
            // shoe_shopDataSet
            // 
            this.shoe_shopDataSet.DataSetName = "shoe_shopDataSet";
            this.shoe_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sapakeemTableAdapter
            // 
            this.sapakeemTableAdapter.ClearBeforeFill = true;
            // 
            // tb_shem1
            // 
            this.tb_shem1.Location = new System.Drawing.Point(832, 232);
            this.tb_shem1.Name = "tb_shem1";
            this.tb_shem1.Size = new System.Drawing.Size(137, 20);
            this.tb_shem1.TabIndex = 13;
            this.tb_shem1.Visible = false;
            // 
            // tb_email1
            // 
            this.tb_email1.Location = new System.Drawing.Point(832, 366);
            this.tb_email1.Name = "tb_email1";
            this.tb_email1.Size = new System.Drawing.Size(137, 20);
            this.tb_email1.TabIndex = 15;
            this.tb_email1.Visible = false;
            // 
            // tb_ktovet1
            // 
            this.tb_ktovet1.Location = new System.Drawing.Point(832, 431);
            this.tb_ktovet1.Name = "tb_ktovet1";
            this.tb_ktovet1.Size = new System.Drawing.Size(137, 20);
            this.tb_ktovet1.TabIndex = 16;
            this.tb_ktovet1.Visible = false;
            // 
            // edkon
            // 
            this.edkon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edkon.Location = new System.Drawing.Point(882, 476);
            this.edkon.Name = "edkon";
            this.edkon.Size = new System.Drawing.Size(87, 47);
            this.edkon.TabIndex = 17;
            this.edkon.Text = "עדכן";
            this.edkon.UseVisualStyleBackColor = true;
            this.edkon.Visible = false;
            this.edkon.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(471, 476);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 47);
            this.button4.TabIndex = 18;
            this.button4.Text = "עדכון";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(775, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(919, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "חיפוש";
            // 
            // tb_telphon1
            // 
            this.tb_telphon1.Location = new System.Drawing.Point(832, 300);
            this.tb_telphon1.Mask = "00-0000000";
            this.tb_telphon1.Name = "tb_telphon1";
            this.tb_telphon1.Size = new System.Drawing.Size(137, 20);
            this.tb_telphon1.TabIndex = 21;
            this.tb_telphon1.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(12, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 80);
            this.button3.TabIndex = 22;
            this.button3.Text = "חזרה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(1060, 476);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 47);
            this.button5.TabIndex = 29;
            this.button5.Text = "נקה פירוט";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "00:00:00";
            // 
            // spakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1447, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_telphon1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.edkon);
            this.Controls.Add(this.tb_ktovet1);
            this.Controls.Add(this.tb_email1);
            this.Controls.Add(this.tb_shem1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ktovet);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.telphon);
            this.Controls.Add(this.shem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_ktovet);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_telphon);
            this.Controls.Add(this.tb_shem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "spakim";
            this.Text = "spakim";
            this.Load += new System.EventHandler(this.spakim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakeemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_shem;
        private System.Windows.Forms.MaskedTextBox tb_telphon;
        private System.Windows.Forms.MaskedTextBox tb_email;
        private System.Windows.Forms.MaskedTextBox tb_ktovet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label shem;
        private System.Windows.Forms.Label telphon;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label ktovet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private shoe_shopDataSet shoe_shopDataSet;
        private System.Windows.Forms.BindingSource sapakeemBindingSource;
        private shoe_shopDataSetTableAdapters.sapakeemTableAdapter sapakeemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telphonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tb_shem1;
        private System.Windows.Forms.TextBox tb_email1;
        private System.Windows.Forms.TextBox tb_ktovet1;
        private System.Windows.Forms.Button edkon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tb_telphon1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}