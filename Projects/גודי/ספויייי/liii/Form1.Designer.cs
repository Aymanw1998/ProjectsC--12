namespace liii
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ספריםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ילדיםונוערToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מבוגריםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הכלToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הכלToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.דוחספריםToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ספריםזמיניםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ספריםלאזמיניםToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.דוחלקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.כרטיסיםבתוקףToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.כרטיסיםלאבתוקףToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.דוחהשאלותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.השאלותקיימותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.השאלותשבוטלוToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.דוחהזמנותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הזמנותקיימותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הזמנותהסתיימוToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.דוחספקיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אודותספקיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.liDataSet = new liii.liDataSet();
            this.borrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowTableAdapter = new liii.liDataSetTableAdapters.borrowTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kartisKorehBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartis_korehTableAdapter = new liii.liDataSetTableAdapters.kartis_korehTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.hazmanotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hazmanotTableAdapter = new liii.liDataSetTableAdapters.hazmanotTableAdapter();
            this.hazmanotlibraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hazmanotlibraryTableAdapter = new liii.liDataSetTableAdapters.hazmanotlibraryTableAdapter();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartisKorehBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmanotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmanotlibraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1723, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "השאלה";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(1528, 228);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "הוספה ו עידכון ספרים";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(1676, 324);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "כרטיס קורא";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ספריםToolStripMenuItem,
            this.דוחספריםToolStripMenuItem1,
            this.דוחלקוחותToolStripMenuItem,
            this.דוחהשאלותToolStripMenuItem,
            this.דוחהזמנותToolStripMenuItem,
            this.דוחספקיםToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1921, 36);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ספריםToolStripMenuItem
            // 
            this.ספריםToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ילדיםונוערToolStripMenuItem,
            this.מבוגריםToolStripMenuItem,
            this.הכלToolStripMenuItem,
            this.הכלToolStripMenuItem2});
            this.ספריםToolStripMenuItem.Name = "ספריםToolStripMenuItem";
            this.ספריםToolStripMenuItem.Size = new System.Drawing.Size(81, 32);
            this.ספריםToolStripMenuItem.Text = "ספרים";
            // 
            // ילדיםונוערToolStripMenuItem
            // 
            this.ילדיםונוערToolStripMenuItem.Name = "ילדיםונוערToolStripMenuItem";
            this.ילדיםונוערToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.ילדיםונוערToolStripMenuItem.Text = "ספרי לימוד";
            this.ילדיםונוערToolStripMenuItem.Click += new System.EventHandler(this.ילדיםונוערToolStripMenuItem_Click);
            // 
            // מבוגריםToolStripMenuItem
            // 
            this.מבוגריםToolStripMenuItem.Name = "מבוגריםToolStripMenuItem";
            this.מבוגריםToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.מבוגריםToolStripMenuItem.Text = "סיפורים";
            this.מבוגריםToolStripMenuItem.Click += new System.EventHandler(this.מבוגריםToolStripMenuItem_Click);
            // 
            // הכלToolStripMenuItem
            // 
            this.הכלToolStripMenuItem.Name = "הכלToolStripMenuItem";
            this.הכלToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.הכלToolStripMenuItem.Text = "אגדות ";
            this.הכלToolStripMenuItem.Click += new System.EventHandler(this.הכלToolStripMenuItem_Click);
            // 
            // הכלToolStripMenuItem2
            // 
            this.הכלToolStripMenuItem2.Name = "הכלToolStripMenuItem2";
            this.הכלToolStripMenuItem2.Size = new System.Drawing.Size(182, 32);
            this.הכלToolStripMenuItem2.Text = "הכל ";
            this.הכלToolStripMenuItem2.Click += new System.EventHandler(this.הכלToolStripMenuItem2_Click);
            // 
            // דוחספריםToolStripMenuItem1
            // 
            this.דוחספריםToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ספריםזמיניםToolStripMenuItem,
            this.ספריםלאזמיניםToolStripMenuItem1});
            this.דוחספריםToolStripMenuItem1.Name = "דוחספריםToolStripMenuItem1";
            this.דוחספריםToolStripMenuItem1.Size = new System.Drawing.Size(114, 32);
            this.דוחספריםToolStripMenuItem1.Text = "דוח ספרים";
            // 
            // ספריםזמיניםToolStripMenuItem
            // 
            this.ספריםזמיניםToolStripMenuItem.Name = "ספריםזמיניםToolStripMenuItem";
            this.ספריםזמיניםToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.ספריםזמיניםToolStripMenuItem.Text = "ספרים זמינים";
            this.ספריםזמיניםToolStripMenuItem.Click += new System.EventHandler(this.ספריםזמיניםToolStripMenuItem_Click);
            // 
            // ספריםלאזמיניםToolStripMenuItem1
            // 
            this.ספריםלאזמיניםToolStripMenuItem1.Name = "ספריםלאזמיניםToolStripMenuItem1";
            this.ספריםלאזמיניםToolStripMenuItem1.Size = new System.Drawing.Size(233, 32);
            this.ספריםלאזמיניםToolStripMenuItem1.Text = "ספרים לא זמינים";
            this.ספריםלאזמיניםToolStripMenuItem1.Click += new System.EventHandler(this.ספריםלאזמיניםToolStripMenuItem1_Click);
            // 
            // דוחלקוחותToolStripMenuItem
            // 
            this.דוחלקוחותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.כרטיסיםבתוקףToolStripMenuItem,
            this.כרטיסיםלאבתוקףToolStripMenuItem});
            this.דוחלקוחותToolStripMenuItem.Name = "דוחלקוחותToolStripMenuItem";
            this.דוחלקוחותToolStripMenuItem.Size = new System.Drawing.Size(119, 32);
            this.דוחלקוחותToolStripMenuItem.Text = "דוח לקוחות";
            // 
            // כרטיסיםבתוקףToolStripMenuItem
            // 
            this.כרטיסיםבתוקףToolStripMenuItem.Name = "כרטיסיםבתוקףToolStripMenuItem";
            this.כרטיסיםבתוקףToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.כרטיסיםבתוקףToolStripMenuItem.Text = "כרטיסים בתוקף";
            this.כרטיסיםבתוקףToolStripMenuItem.Click += new System.EventHandler(this.כרטיסיםבתוקףToolStripMenuItem_Click);
            // 
            // כרטיסיםלאבתוקףToolStripMenuItem
            // 
            this.כרטיסיםלאבתוקףToolStripMenuItem.Name = "כרטיסיםלאבתוקףToolStripMenuItem";
            this.כרטיסיםלאבתוקףToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.כרטיסיםלאבתוקףToolStripMenuItem.Text = "כרטיסים לא בתוקף";
            this.כרטיסיםלאבתוקףToolStripMenuItem.Click += new System.EventHandler(this.כרטיסיםלאבתוקףToolStripMenuItem_Click);
            // 
            // דוחהשאלותToolStripMenuItem
            // 
            this.דוחהשאלותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.השאלותקיימותToolStripMenuItem,
            this.השאלותשבוטלוToolStripMenuItem});
            this.דוחהשאלותToolStripMenuItem.Name = "דוחהשאלותToolStripMenuItem";
            this.דוחהשאלותToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.דוחהשאלותToolStripMenuItem.Text = "דוח השאלות";
            // 
            // השאלותקיימותToolStripMenuItem
            // 
            this.השאלותקיימותToolStripMenuItem.Name = "השאלותקיימותToolStripMenuItem";
            this.השאלותקיימותToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.השאלותקיימותToolStripMenuItem.Text = "השאלות קיימות";
            this.השאלותקיימותToolStripMenuItem.Click += new System.EventHandler(this.השאלותקיימותToolStripMenuItem_Click);
            // 
            // השאלותשבוטלוToolStripMenuItem
            // 
            this.השאלותשבוטלוToolStripMenuItem.Name = "השאלותשבוטלוToolStripMenuItem";
            this.השאלותשבוטלוToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.השאלותשבוטלוToolStripMenuItem.Text = "השאלות שבוטלו";
            this.השאלותשבוטלוToolStripMenuItem.Click += new System.EventHandler(this.השאלותשבוטלוToolStripMenuItem_Click);
            // 
            // דוחהזמנותToolStripMenuItem
            // 
            this.דוחהזמנותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הזמנותקיימותToolStripMenuItem,
            this.הזמנותהסתיימוToolStripMenuItem});
            this.דוחהזמנותToolStripMenuItem.Name = "דוחהזמנותToolStripMenuItem";
            this.דוחהזמנותToolStripMenuItem.Size = new System.Drawing.Size(119, 32);
            this.דוחהזמנותToolStripMenuItem.Text = "דוח הזמנות";
            // 
            // הזמנותקיימותToolStripMenuItem
            // 
            this.הזמנותקיימותToolStripMenuItem.Name = "הזמנותקיימותToolStripMenuItem";
            this.הזמנותקיימותToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.הזמנותקיימותToolStripMenuItem.Text = "הזמנות קיימות";
            this.הזמנותקיימותToolStripMenuItem.Click += new System.EventHandler(this.הזמנותקיימותToolStripMenuItem_Click);
            // 
            // הזמנותהסתיימוToolStripMenuItem
            // 
            this.הזמנותהסתיימוToolStripMenuItem.Name = "הזמנותהסתיימוToolStripMenuItem";
            this.הזמנותהסתיימוToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.הזמנותהסתיימוToolStripMenuItem.Text = "הזמנות שבוטלו ";
            this.הזמנותהסתיימוToolStripMenuItem.Click += new System.EventHandler(this.הזמנותהסתיימוToolStripMenuItem_Click);
            // 
            // דוחספקיםToolStripMenuItem
            // 
            this.דוחספקיםToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.אודותספקיםToolStripMenuItem});
            this.דוחספקיםToolStripMenuItem.Name = "דוחספקיםToolStripMenuItem";
            this.דוחספקיםToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
            this.דוחספקיםToolStripMenuItem.Text = "דוח ספקים";
            // 
            // אודותספקיםToolStripMenuItem
            // 
            this.אודותספקיםToolStripMenuItem.Name = "אודותספקיםToolStripMenuItem";
            this.אודותספקיםToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
            this.אודותספקיםToolStripMenuItem.Text = "אודות ספקים";
            this.אודותספקיםToolStripMenuItem.Click += new System.EventHandler(this.אודותספקיםToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(1723, 410);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 53);
            this.button5.TabIndex = 5;
            this.button5.Text = "הזמנות";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1795, 683);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "תקנון ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(1769, 591);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 52);
            this.button6.TabIndex = 7;
            this.button6.Text = "ספקים";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("AR DECODE", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1085, 629);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 146);
            this.label7.TabIndex = 11;
            this.label7.Text = "library";
            // 
            // liDataSet
            // 
            this.liDataSet.DataSetName = "liDataSet";
            this.liDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowBindingSource
            // 
            this.borrowBindingSource.DataMember = "borrow";
            this.borrowBindingSource.DataSource = this.liDataSet;
            // 
            // borrowTableAdapter
            // 
            this.borrowTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1769, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button7.Location = new System.Drawing.Point(1581, 499);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(327, 59);
            this.button7.TabIndex = 6;
            this.button7.Text = "הזמנת ספרים חדשים";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // hazmanotBindingSource
            // 
            this.hazmanotBindingSource.DataMember = "hazmanot";
            this.hazmanotBindingSource.DataSource = this.liDataSet;
            // 
            // hazmanotTableAdapter
            // 
            this.hazmanotTableAdapter.ClearBeforeFill = true;
            // 
            // hazmanotlibraryBindingSource
            // 
            this.hazmanotlibraryBindingSource.DataMember = "hazmanotlibrary";
            this.hazmanotlibraryBindingSource.DataSource = this.liDataSet;
            // 
            // hazmanotlibraryTableAdapter
            // 
            this.hazmanotlibraryTableAdapter.ClearBeforeFill = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.BackgroundImage = global::liii.Properties.Resources.recycle_bin;
            this.button9.Location = new System.Drawing.Point(21, 797);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 155);
            this.button9.TabIndex = 1;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.Location = new System.Drawing.Point(1800, 827);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 94);
            this.button8.TabIndex = 0;
            this.button8.Text = "check";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(599, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 147);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 457);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1921, 1055);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartisKorehBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmanotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazmanotlibraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ספריםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ילדיםונוערToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מבוגריםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הכלToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem הכלToolStripMenuItem2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem דוחספריםToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ספריםזמיניםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ספריםלאזמיניםToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem דוחלקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem כרטיסיםבתוקףToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem כרטיסיםלאבתוקףToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem דוחהשאלותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem השאלותקיימותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem דוחהזמנותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הזמנותקיימותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הזמנותהסתיימוToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem דוחספקיםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem אודותספקיםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem השאלותשבוטלוToolStripMenuItem;
        private liDataSet liDataSet;
        private System.Windows.Forms.BindingSource borrowBindingSource;
        private liDataSetTableAdapters.borrowTableAdapter borrowTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource kartisKorehBindingSource;
        private liDataSetTableAdapters.kartis_korehTableAdapter kartis_korehTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource hazmanotBindingSource;
        private liDataSetTableAdapters.hazmanotTableAdapter hazmanotTableAdapter;
        private System.Windows.Forms.BindingSource hazmanotlibraryBindingSource;
        private liDataSetTableAdapters.hazmanotlibraryTableAdapter hazmanotlibraryTableAdapter;
        private System.Windows.Forms.Button button9;

    }
}

