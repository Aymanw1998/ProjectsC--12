namespace DarQuran
{
    partial class HodorHeiab
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
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darQuranDataSet = new DarQuran.DarQuranDataSet();
            this.studentsTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.studentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.hodorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hodorTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.HodorTableAdapter();
            this.heiabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heiabTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.heiabTableAdapter();
            this.taakherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taakherTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.TaakherTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxKors = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hodorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heiabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taakherBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.darQuranDataSet;
            // 
            // darQuranDataSet
            // 
            this.darQuranDataSet.DataSetName = "DarQuranDataSet";
            this.darQuranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(312, 447);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(727, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hodorTableAdapter
            // 
            this.hodorTableAdapter.ClearBeforeFill = true;
            // 
            // heiabTableAdapter
            // 
            this.heiabTableAdapter.ClearBeforeFill = true;
            // 
            // taakherTableAdapter
            // 
            this.taakherTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(431, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(453, 54);
            this.label10.TabIndex = 36;
            this.label10.Text = "حضور وغياب لكل الطلاب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "بكل نهاية اسبوع عليك تعبئة كل خانات الحضور والغياب";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.comboBoxKors);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(700, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 64);
            this.panel2.TabIndex = 38;
            // 
            // comboBoxKors
            // 
            this.comboBoxKors.FormattingEnabled = true;
            this.comboBoxKors.Location = new System.Drawing.Point(4, 25);
            this.comboBoxKors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxKors.Name = "comboBoxKors";
            this.comboBoxKors.Size = new System.Drawing.Size(160, 24);
            this.comboBoxKors.TabIndex = 31;
            this.comboBoxKors.SelectedIndexChanged += new System.EventHandler(this.comboBoxKors_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(173, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = ":اختار الدورة تعلم فيها\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(901, 185);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // HodorHeiab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 694);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HodorHeiab";
            this.Text = "HodorHeiab";
            this.Load += new System.EventHandler(this.HodorHeiab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hodorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heiabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taakherBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarQuranDataSet darQuranDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DarQuranDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hodorBindingSource;
        private DarQuranDataSetTableAdapters.HodorTableAdapter hodorTableAdapter;
        private System.Windows.Forms.BindingSource heiabBindingSource;
        private DarQuranDataSetTableAdapters.heiabTableAdapter heiabTableAdapter;
        private System.Windows.Forms.BindingSource taakherBindingSource;
        private DarQuranDataSetTableAdapters.TaakherTableAdapter taakherTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxKors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}