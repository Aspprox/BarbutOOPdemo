namespace BarbutOOP
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
            this.lZar1 = new System.Windows.Forms.Label();
            this.lZar2 = new System.Windows.Forms.Label();
            this.bZarAt = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lZar1
            // 
            this.lZar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lZar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lZar1.Location = new System.Drawing.Point(13, 13);
            this.lZar1.Name = "lZar1";
            this.lZar1.Size = new System.Drawing.Size(100, 100);
            this.lZar1.TabIndex = 0;
            this.lZar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lZar2
            // 
            this.lZar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lZar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lZar2.Location = new System.Drawing.Point(119, 13);
            this.lZar2.Name = "lZar2";
            this.lZar2.Size = new System.Drawing.Size(100, 100);
            this.lZar2.TabIndex = 1;
            this.lZar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bZarAt
            // 
            this.bZarAt.Location = new System.Drawing.Point(13, 126);
            this.bZarAt.Name = "bZarAt";
            this.bZarAt.Size = new System.Drawing.Size(206, 23);
            this.bZarAt.TabIndex = 2;
            this.bZarAt.Text = "Zar At";
            this.bZarAt.UseVisualStyleBackColor = true;
            this.bZarAt.Click += new System.EventHandler(this.bZarAt_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(13, 165);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(206, 251);
            this.lbSonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 450);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.bZarAt);
            this.Controls.Add(this.lZar2);
            this.Controls.Add(this.lZar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lZar1;
        private System.Windows.Forms.Label lZar2;
        private System.Windows.Forms.Button bZarAt;
        private System.Windows.Forms.ListBox lbSonuc;
    }
}

