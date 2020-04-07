namespace liii
{
    partial class btokef
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
            this.liDataSet = new liii.liDataSet();
            this.kartisKorehBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartis_korehTableAdapter = new liii.liDataSetTableAdapters.kartis_korehTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartisKorehBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 489);
            this.dataGridView1.TabIndex = 0;
            // 
            // liDataSet
            // 
            this.liDataSet.DataSetName = "liDataSet";
            this.liDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartisKorehBindingSource
            // 
            this.kartisKorehBindingSource.DataMember = "kartis koreh";
            this.kartisKorehBindingSource.DataSource = this.liDataSet;
            // 
            // kartis_korehTableAdapter
            // 
            this.kartis_korehTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Guttman Frank", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(372, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 88);
            this.label3.TabIndex = 10;
            this.label3.Text = "דוח מנויים בתוקך";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 18);
            this.label15.TabIndex = 40;
            this.label15.Text = "JD LIBRARY";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 26);
            this.label16.TabIndex = 39;
            this.label16.Text = "JD";
            this.label16.MouseHover += new System.EventHandler(this.label16_MouseHover);
            // 
            // btokef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1235, 662);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "btokef";
            this.Text = "btokef";
            this.Load += new System.EventHandler(this.btokef_Load);
            this.MouseHover += new System.EventHandler(this.btokef_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartisKorehBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private liDataSet liDataSet;
        private System.Windows.Forms.BindingSource kartisKorehBindingSource;
        private liDataSetTableAdapters.kartis_korehTableAdapter kartis_korehTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}