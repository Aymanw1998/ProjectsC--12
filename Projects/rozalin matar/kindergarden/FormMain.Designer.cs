namespace kindergarden
{
    partial class FormMain
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
        /// Required method for Designer support - do not Modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnl_Move = new System.Windows.Forms.Panel();
            this.pnl_chosenTable = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nameOfForm = new System.Windows.Forms.Label();
            this.btn_toHogim = new System.Windows.Forms.Button();
            this.btn_toKitot = new System.Windows.Forms.Button();
            this.btn_toMetaplot = new System.Windows.Forms.Button();
            this.btn_toYeladim = new System.Windows.Forms.Button();
            this.btn_toSfarim = new System.Windows.Forms.Button();
            this.lbl_sizeChange = new System.Windows.Forms.Label();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.lbl_hide = new System.Windows.Forms.Label();
            this.pnl_buttonsUp = new System.Windows.Forms.Panel();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.kindergardenDataSet = new kindergarden.kindergardenDataSet();
            this.sfarimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sfarimTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.sfarimTableAdapter();
            this.yeladimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yeladimTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.yeladimTableAdapter();
            this.pnl_Move.SuspendLayout();
            this.pnl_chosenTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            this.pnl_buttonsUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfarimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeladimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Move
            // 
            this.pnl_Move.Controls.Add(this.pnl_chosenTable);
            this.pnl_Move.Location = new System.Drawing.Point(0, 61);
            this.pnl_Move.Name = "pnl_Move";
            this.pnl_Move.Size = new System.Drawing.Size(1286, 604);
            this.pnl_Move.TabIndex = 0;
            this.pnl_Move.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Move_Paint_1);
            // 
            // pnl_chosenTable
            // 
            this.pnl_chosenTable.Controls.Add(this.lbl_welcome);
            this.pnl_chosenTable.Controls.Add(this.label1);
            this.pnl_chosenTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_chosenTable.Location = new System.Drawing.Point(0, 0);
            this.pnl_chosenTable.Name = "pnl_chosenTable";
            this.pnl_chosenTable.Size = new System.Drawing.Size(1286, 604);
            this.pnl_chosenTable.TabIndex = 5;
            this.pnl_chosenTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_chosenTable_Paint);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Narkisim", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_welcome.Location = new System.Drawing.Point(398, 187);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(394, 95);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Narkisim", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(895, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 95);
            this.label1.TabIndex = 1;
            // 
            // lbl_nameOfForm
            // 
            this.lbl_nameOfForm.AutoSize = true;
            this.lbl_nameOfForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_nameOfForm.Font = new System.Drawing.Font("Narkisim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_nameOfForm.Location = new System.Drawing.Point(651, 0);
            this.lbl_nameOfForm.Name = "lbl_nameOfForm";
            this.lbl_nameOfForm.Size = new System.Drawing.Size(113, 47);
            this.lbl_nameOfForm.TabIndex = 2;
            this.lbl_nameOfForm.Text = "Main";
            this.lbl_nameOfForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_toHogim
            // 
            this.btn_toHogim.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_toHogim.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_toHogim.Location = new System.Drawing.Point(0, 0);
            this.btn_toHogim.Name = "btn_toHogim";
            this.btn_toHogim.Size = new System.Drawing.Size(119, 61);
            this.btn_toHogim.TabIndex = 0;
            this.btn_toHogim.Text = "Courses";
            this.btn_toHogim.UseVisualStyleBackColor = true;
            this.btn_toHogim.Click += new System.EventHandler(this.btn_toHogim_Click);
            // 
            // btn_toKitot
            // 
            this.btn_toKitot.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_toKitot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_toKitot.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_toKitot.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_toKitot.Location = new System.Drawing.Point(119, 0);
            this.btn_toKitot.Name = "btn_toKitot";
            this.btn_toKitot.Size = new System.Drawing.Size(116, 61);
            this.btn_toKitot.TabIndex = 1;
            this.btn_toKitot.Text = "Classes";
            this.btn_toKitot.UseVisualStyleBackColor = true;
            this.btn_toKitot.Click += new System.EventHandler(this.btn_toKitot_Click);
            // 
            // btn_toMetaplot
            // 
            this.btn_toMetaplot.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_toMetaplot.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_toMetaplot.Location = new System.Drawing.Point(235, 0);
            this.btn_toMetaplot.Name = "btn_toMetaplot";
            this.btn_toMetaplot.Size = new System.Drawing.Size(128, 61);
            this.btn_toMetaplot.TabIndex = 2;
            this.btn_toMetaplot.Text = "Teachers";
            this.btn_toMetaplot.UseVisualStyleBackColor = true;
            this.btn_toMetaplot.Click += new System.EventHandler(this.btn_toMetaplot_Click);
            // 
            // btn_toYeladim
            // 
            this.btn_toYeladim.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_toYeladim.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_toYeladim.Location = new System.Drawing.Point(363, 0);
            this.btn_toYeladim.Name = "btn_toYeladim";
            this.btn_toYeladim.Size = new System.Drawing.Size(160, 61);
            this.btn_toYeladim.TabIndex = 3;
            this.btn_toYeladim.Text = "Children";
            this.btn_toYeladim.UseVisualStyleBackColor = true;
            this.btn_toYeladim.Click += new System.EventHandler(this.btn_toYeladim_Click);
            // 
            // btn_toSfarim
            // 
            this.btn_toSfarim.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_toSfarim.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_toSfarim.Location = new System.Drawing.Point(523, 0);
            this.btn_toSfarim.Name = "btn_toSfarim";
            this.btn_toSfarim.Size = new System.Drawing.Size(128, 61);
            this.btn_toSfarim.TabIndex = 4;
            this.btn_toSfarim.Text = "Books";
            this.btn_toSfarim.UseVisualStyleBackColor = true;
            this.btn_toSfarim.Click += new System.EventHandler(this.btn_toSfarim_Click);
            // 
            // lbl_sizeChange
            // 
            this.lbl_sizeChange.AutoSize = true;
            this.lbl_sizeChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sizeChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_sizeChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_sizeChange.Font = new System.Drawing.Font("Aharoni", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_sizeChange.Location = new System.Drawing.Point(1253, 0);
            this.lbl_sizeChange.Name = "lbl_sizeChange";
            this.lbl_sizeChange.Size = new System.Drawing.Size(31, 32);
            this.lbl_sizeChange.TabIndex = 5;
            this.lbl_sizeChange.Text = "🗖";
            this.lbl_sizeChange.Click += new System.EventHandler(this.lbl_sizeChange_Click);
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.BackgroundImage = global::kindergarden.Properties.Resources.exit_icon;
            this.pictureBox_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_exit.Location = new System.Drawing.Point(1203, 0);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(50, 61);
            this.pictureBox_exit.TabIndex = 0;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // lbl_hide
            // 
            this.lbl_hide.AutoSize = true;
            this.lbl_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_hide.Location = new System.Drawing.Point(1182, 47);
            this.lbl_hide.Name = "lbl_hide";
            this.lbl_hide.Size = new System.Drawing.Size(21, 29);
            this.lbl_hide.TabIndex = 6;
            this.lbl_hide.Text = "🗕";
            this.lbl_hide.Click += new System.EventHandler(this.lbl_hide_Click);
            // 
            // pnl_buttonsUp
            // 
            this.pnl_buttonsUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_buttonsUp.Controls.Add(this.lbl_hide);
            this.pnl_buttonsUp.Controls.Add(this.lbl_nameOfForm);
            this.pnl_buttonsUp.Controls.Add(this.pictureBox_exit);
            this.pnl_buttonsUp.Controls.Add(this.lbl_sizeChange);
            this.pnl_buttonsUp.Controls.Add(this.btn_toSfarim);
            this.pnl_buttonsUp.Controls.Add(this.btn_toYeladim);
            this.pnl_buttonsUp.Controls.Add(this.btn_toMetaplot);
            this.pnl_buttonsUp.Controls.Add(this.btn_toKitot);
            this.pnl_buttonsUp.Controls.Add(this.btn_toHogim);
            this.pnl_buttonsUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_buttonsUp.Location = new System.Drawing.Point(0, 0);
            this.pnl_buttonsUp.Name = "pnl_buttonsUp";
            this.pnl_buttonsUp.Size = new System.Drawing.Size(1284, 61);
            this.pnl_buttonsUp.TabIndex = 0;
            this.pnl_buttonsUp.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_buttonsUp_Paint);
            // 
            // timer_clock
            // 
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // kindergardenDataSet
            // 
            this.kindergardenDataSet.DataSetName = "kindergardenDataSet";
            this.kindergardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sfarimBindingSource
            // 
            this.sfarimBindingSource.DataMember = "sfarim";
            this.sfarimBindingSource.DataSource = this.kindergardenDataSet;
            // 
            // sfarimTableAdapter
            // 
            this.sfarimTableAdapter.ClearBeforeFill = true;
            // 
            // yeladimBindingSource
            // 
            this.yeladimBindingSource.DataMember = "yeladim";
            this.yeladimBindingSource.DataSource = this.kindergardenDataSet;
            // 
            // yeladimTableAdapter
            // 
            this.yeladimTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 665);
            this.Controls.Add(this.pnl_Move);
            this.Controls.Add(this.pnl_buttonsUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnl_Move.ResumeLayout(false);
            this.pnl_chosenTable.ResumeLayout(false);
            this.pnl_chosenTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            this.pnl_buttonsUp.ResumeLayout(false);
            this.pnl_buttonsUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfarimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeladimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Move;
        private System.Windows.Forms.Panel pnl_chosenTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_nameOfForm;
        private System.Windows.Forms.Button btn_toHogim;
        private System.Windows.Forms.Button btn_toKitot;
        private System.Windows.Forms.Button btn_toMetaplot;
        private System.Windows.Forms.Button btn_toYeladim;
        private System.Windows.Forms.Button btn_toSfarim;
        private System.Windows.Forms.Label lbl_sizeChange;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.Label lbl_hide;
        private System.Windows.Forms.Panel pnl_buttonsUp;
        private System.Windows.Forms.Timer timer_clock;
        private kindergardenDataSet kindergardenDataSet;
        private System.Windows.Forms.BindingSource sfarimBindingSource;
        private kindergardenDataSetTableAdapters.sfarimTableAdapter sfarimTableAdapter;
        private System.Windows.Forms.BindingSource yeladimBindingSource;
        private kindergardenDataSetTableAdapters.yeladimTableAdapter yeladimTableAdapter;
    }
}