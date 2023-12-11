namespace yaztemizle
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
            this.BtnYaz = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.textYazı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnYaz
            // 
            this.BtnYaz.BackColor = System.Drawing.Color.Lime;
            this.BtnYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYaz.Location = new System.Drawing.Point(75, 32);
            this.BtnYaz.Name = "BtnYaz";
            this.BtnYaz.Size = new System.Drawing.Size(109, 41);
            this.BtnYaz.TabIndex = 0;
            this.BtnYaz.Text = "YAZ";
            this.BtnYaz.UseVisualStyleBackColor = false;
            this.BtnYaz.Click += new System.EventHandler(this.BtnYaz_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Red;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(75, 106);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(109, 41);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // textYazı
            // 
            this.textYazı.Location = new System.Drawing.Point(244, 43);
            this.textYazı.Name = "textYazı";
            this.textYazı.Size = new System.Drawing.Size(245, 20);
            this.textYazı.TabIndex = 2;
            this.textYazı.TextChanged += new System.EventHandler(this.textYazı_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textYazı);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.BtnYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnYaz;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox textYazı;
    }
}

