namespace חנות_נעליים
{
    partial class enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enter));
            this.bt1 = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.eye = new System.Windows.Forms.ImageList(this.components);
            this.dontshow = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.kopa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bt1.Location = new System.Drawing.Point(170, 222);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(194, 70);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "כניסת מנהל";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb2.Location = new System.Drawing.Point(495, 117);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(150, 31);
            this.lb2.TabIndex = 16;
            this.lb2.Text = "הקש סיסמא ";
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb2.Location = new System.Drawing.Point(170, 117);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(194, 38);
            this.tb2.TabIndex = 15;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb1.Location = new System.Drawing.Point(170, 57);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(194, 38);
            this.tb1.TabIndex = 18;
            this.tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb1.Location = new System.Drawing.Point(443, 57);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(202, 31);
            this.lb1.TabIndex = 19;
            this.lb1.Text = "הקש שם משתמש ";
            // 
            // eye
            // 
            this.eye.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("eye.ImageStream")));
            this.eye.TransparentColor = System.Drawing.Color.Transparent;
            this.eye.Images.SetKeyName(0, "if_eye_1608688.png");
            this.eye.Images.SetKeyName(1, "if_eye-slash_1608687.png");
            // 
            // dontshow
            // 
            this.dontshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dontshow.Image = ((System.Drawing.Image)(resources.GetObject("dontshow.Image")));
            this.dontshow.Location = new System.Drawing.Point(329, 117);
            this.dontshow.Name = "dontshow";
            this.dontshow.Size = new System.Drawing.Size(35, 38);
            this.dontshow.TabIndex = 21;
            this.dontshow.UseVisualStyleBackColor = true;
            this.dontshow.Visible = false;
            this.dontshow.Click += new System.EventHandler(this.dontshow_Click);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.show.Image = ((System.Drawing.Image)(resources.GetObject("show.Image")));
            this.show.Location = new System.Drawing.Point(329, 117);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(35, 38);
            this.show.TabIndex = 20;
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exit.Location = new System.Drawing.Point(12, 397);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(216, 75);
            this.exit.TabIndex = 28;
            this.exit.Text = "צא מהתוכנה";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // kopa
            // 
            this.kopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kopa.Location = new System.Drawing.Point(449, 397);
            this.kopa.Name = "kopa";
            this.kopa.Size = new System.Drawing.Size(216, 75);
            this.kopa.TabIndex = 29;
            this.kopa.Text = "לקופה";
            this.kopa.UseVisualStyleBackColor = true;
            this.kopa.Click += new System.EventHandler(this.kopa_Click);
            // 
            // enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(773, 534);
            this.Controls.Add(this.kopa);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dontshow);
            this.Controls.Add(this.show);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.bt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "כניסה למערכת";
            this.Load += new System.EventHandler(this.enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ImageList eye;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button dontshow;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button kopa;
    }
}

