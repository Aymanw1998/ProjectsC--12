namespace alif_bishara
{
    partial class Form2
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
            this.tZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shamfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shaotAvodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Alif_s_databaseDataSet = new alif_bishara._Alif_s_databaseDataSet();
            this.teachersTableAdapter = new alif_bishara._Alif_s_databaseDataSetTableAdapters.teachersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Alif_s_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tZDataGridViewTextBoxColumn,
            this.shamDataGridViewTextBoxColumn,
            this.shamfDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.saharDataGridViewTextBoxColumn,
            this.shaotAvodaDataGridViewTextBoxColumn,
            this.airDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teachersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(262, 113);
            this.dataGridView1.TabIndex = 0;
            // 
            // tZDataGridViewTextBoxColumn
            // 
            this.tZDataGridViewTextBoxColumn.DataPropertyName = "TZ";
            this.tZDataGridViewTextBoxColumn.HeaderText = "TZ";
            this.tZDataGridViewTextBoxColumn.Name = "tZDataGridViewTextBoxColumn";
            // 
            // shamDataGridViewTextBoxColumn
            // 
            this.shamDataGridViewTextBoxColumn.DataPropertyName = "sham";
            this.shamDataGridViewTextBoxColumn.HeaderText = "sham";
            this.shamDataGridViewTextBoxColumn.Name = "shamDataGridViewTextBoxColumn";
            // 
            // shamfDataGridViewTextBoxColumn
            // 
            this.shamfDataGridViewTextBoxColumn.DataPropertyName = "shamf";
            this.shamfDataGridViewTextBoxColumn.HeaderText = "shamf";
            this.shamfDataGridViewTextBoxColumn.Name = "shamfDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // saharDataGridViewTextBoxColumn
            // 
            this.saharDataGridViewTextBoxColumn.DataPropertyName = "sahar";
            this.saharDataGridViewTextBoxColumn.HeaderText = "sahar";
            this.saharDataGridViewTextBoxColumn.Name = "saharDataGridViewTextBoxColumn";
            // 
            // shaotAvodaDataGridViewTextBoxColumn
            // 
            this.shaotAvodaDataGridViewTextBoxColumn.DataPropertyName = "shaot avoda";
            this.shaotAvodaDataGridViewTextBoxColumn.HeaderText = "shaot avoda";
            this.shaotAvodaDataGridViewTextBoxColumn.Name = "shaotAvodaDataGridViewTextBoxColumn";
            // 
            // airDataGridViewTextBoxColumn
            // 
            this.airDataGridViewTextBoxColumn.DataPropertyName = "air";
            this.airDataGridViewTextBoxColumn.HeaderText = "air";
            this.airDataGridViewTextBoxColumn.Name = "airDataGridViewTextBoxColumn";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this._Alif_s_databaseDataSet;
            // 
            // _Alif_s_databaseDataSet
            // 
            this._Alif_s_databaseDataSet.DataSetName = "_Alif_s_databaseDataSet";
            this._Alif_s_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Alif_s_databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _Alif_s_databaseDataSet _Alif_s_databaseDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private _Alif_s_databaseDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shamfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shaotAvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airDataGridViewTextBoxColumn;
    }
}