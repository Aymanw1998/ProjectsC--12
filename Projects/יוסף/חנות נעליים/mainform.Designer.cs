namespace חנות_נעליים
{
    partial class mainform
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
            this.oved = new System.Windows.Forms.Button();
            this.kopa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oved
            // 
            this.oved.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oved.Location = new System.Drawing.Point(80, 419);
            this.oved.Name = "oved";
            this.oved.Size = new System.Drawing.Size(250, 100);
            this.oved.TabIndex = 0;
            this.oved.Text = "כניסת עובד ";
            this.oved.UseVisualStyleBackColor = true;
            this.oved.Click += new System.EventHandler(this.oved_Click);
            // 
            // kopa
            // 
            this.kopa.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kopa.Location = new System.Drawing.Point(80, 243);
            this.kopa.Name = "kopa";
            this.kopa.Size = new System.Drawing.Size(250, 100);
            this.kopa.TabIndex = 1;
            this.kopa.Text = "לקופה";
            this.kopa.UseVisualStyleBackColor = true;
            this.kopa.Click += new System.EventHandler(this.kopa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kopa);
            this.Controls.Add(this.oved);
            this.Name = "mainform";
            this.Text = "mainform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oved;
        private System.Windows.Forms.Button kopa;
        private System.Windows.Forms.Button button1;

    }
}