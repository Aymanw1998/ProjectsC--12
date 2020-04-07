namespace christina_hourses
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.btovdim = new System.Windows.Forms.Button();
            this.bt_horses = new System.Windows.Forms.Button();
            this.bt_tsiod = new System.Windows.Forms.Button();
            this.bt_lehohot = new System.Windows.Forms.Button();
            this.bt_sapakim = new System.Windows.Forms.Button();
            this.bt_activities = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.start = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mscoret = new System.Windows.Forms.Button();
            this.hoursesDataSet = new christina_hourses.hoursesDataSet();
            this.workeersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workeersTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.workeersTableAdapter();
            this.enterform1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btovdim
            // 
            this.btovdim.BackColor = System.Drawing.Color.DarkOrange;
            this.btovdim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btovdim.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btovdim.Location = new System.Drawing.Point(857, 169);
            this.btovdim.Name = "btovdim";
            this.btovdim.Size = new System.Drawing.Size(171, 85);
            this.btovdim.TabIndex = 0;
            this.btovdim.Text = "עובדים";
            this.btovdim.UseVisualStyleBackColor = false;
            this.btovdim.Click += new System.EventHandler(this.btovdim_Click);
            // 
            // bt_horses
            // 
            this.bt_horses.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_horses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_horses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_horses.Location = new System.Drawing.Point(857, 278);
            this.bt_horses.Name = "bt_horses";
            this.bt_horses.Size = new System.Drawing.Size(171, 83);
            this.bt_horses.TabIndex = 1;
            this.bt_horses.Text = "סוסים";
            this.bt_horses.UseVisualStyleBackColor = false;
            this.bt_horses.Click += new System.EventHandler(this.bt_horses_Click);
            // 
            // bt_tsiod
            // 
            this.bt_tsiod.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_tsiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_tsiod.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_tsiod.Location = new System.Drawing.Point(1050, 117);
            this.bt_tsiod.Name = "bt_tsiod";
            this.bt_tsiod.Size = new System.Drawing.Size(167, 80);
            this.bt_tsiod.TabIndex = 2;
            this.bt_tsiod.Text = "ציוד";
            this.bt_tsiod.UseVisualStyleBackColor = false;
            this.bt_tsiod.Click += new System.EventHandler(this.bt_tsiod_Click);
            // 
            // bt_lehohot
            // 
            this.bt_lehohot.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_lehohot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_lehohot.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_lehohot.Location = new System.Drawing.Point(1050, 221);
            this.bt_lehohot.Name = "bt_lehohot";
            this.bt_lehohot.Size = new System.Drawing.Size(167, 83);
            this.bt_lehohot.TabIndex = 3;
            this.bt_lehohot.Text = "לקוחות";
            this.bt_lehohot.UseVisualStyleBackColor = false;
            this.bt_lehohot.Click += new System.EventHandler(this.bt_lehohot_Click);
            // 
            // bt_sapakim
            // 
            this.bt_sapakim.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_sapakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_sapakim.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_sapakim.Location = new System.Drawing.Point(856, 401);
            this.bt_sapakim.Name = "bt_sapakim";
            this.bt_sapakim.Size = new System.Drawing.Size(172, 82);
            this.bt_sapakim.TabIndex = 4;
            this.bt_sapakim.Text = "ספקים";
            this.bt_sapakim.UseVisualStyleBackColor = false;
            this.bt_sapakim.Click += new System.EventHandler(this.bt_sapakim_Click);
            // 
            // bt_activities
            // 
            this.bt_activities.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_activities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_activities.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_activities.Location = new System.Drawing.Point(1045, 454);
            this.bt_activities.Name = "bt_activities";
            this.bt_activities.Size = new System.Drawing.Size(172, 80);
            this.bt_activities.TabIndex = 5;
            this.bt_activities.Text = "פעילויות";
            this.bt_activities.UseVisualStyleBackColor = false;
            this.bt_activities.Click += new System.EventHandler(this.bt_activities_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1050, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 82);
            this.button1.TabIndex = 6;
            this.button1.Text = "יומן";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.DarkOrange;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.start.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.start.Location = new System.Drawing.Point(665, 240);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(167, 83);
            this.start.TabIndex = 13;
            this.start.Text = "התחלת וסיום משמרות";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(384, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 185);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::christina_hourses.Properties.Resources.the_horseman;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 203);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mscoret
            // 
            this.mscoret.BackColor = System.Drawing.Color.DarkOrange;
            this.mscoret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mscoret.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mscoret.Location = new System.Drawing.Point(665, 351);
            this.mscoret.Name = "mscoret";
            this.mscoret.Size = new System.Drawing.Size(167, 83);
            this.mscoret.TabIndex = 14;
            this.mscoret.Text = "משכורת";
            this.mscoret.UseVisualStyleBackColor = false;
            this.mscoret.Click += new System.EventHandler(this.mscoret_Click);
            // 
            // hoursesDataSet
            // 
            this.hoursesDataSet.DataSetName = "hoursesDataSet";
            this.hoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workeersBindingSource
            // 
            this.workeersBindingSource.DataMember = "workeers";
            this.workeersBindingSource.DataSource = this.hoursesDataSet;
            // 
            // workeersTableAdapter
            // 
            this.workeersTableAdapter.ClearBeforeFill = true;
            // 
            // enterform1
            // 
            this.enterform1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.enterform1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.enterform1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterform1.Location = new System.Drawing.Point(423, 454);
            this.enterform1.Name = "enterform1";
            this.enterform1.Size = new System.Drawing.Size(159, 70);
            this.enterform1.TabIndex = 15;
            this.enterform1.Text = "לכניסת מנהל";
            this.enterform1.UseVisualStyleBackColor = false;
            this.enterform1.Visible = false;
            this.enterform1.Click += new System.EventHandler(this.enterform1_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1316, 668);
            this.Controls.Add(this.enterform1);
            this.Controls.Add(this.mscoret);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_activities);
            this.Controls.Add(this.bt_sapakim);
            this.Controls.Add(this.bt_lehohot);
            this.Controls.Add(this.bt_tsiod);
            this.Controls.Add(this.bt_horses);
            this.Controls.Add(this.btovdim);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btovdim;
        private System.Windows.Forms.Button bt_horses;
        private System.Windows.Forms.Button bt_tsiod;
        private System.Windows.Forms.Button bt_lehohot;
        private System.Windows.Forms.Button bt_sapakim;
        private System.Windows.Forms.Button bt_activities;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button mscoret;
        private hoursesDataSet hoursesDataSet;
        private System.Windows.Forms.BindingSource workeersBindingSource;
        private hoursesDataSetTableAdapters.workeersTableAdapter workeersTableAdapter;
        private System.Windows.Forms.Button enterform1;
    }
}