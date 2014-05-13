namespace WindowsFormsApplication1
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
            this.Count = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.CountDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(12, 154);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(75, 23);
            this.Count.TabIndex = 1;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(197, 154);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click_1);
            // 
            // CountDisp
            // 
            this.CountDisp.AutoSize = true;
            this.CountDisp.Location = new System.Drawing.Point(120, 55);
            this.CountDisp.Name = "CountDisp";
            this.CountDisp.Size = new System.Drawing.Size(47, 13);
            this.CountDisp.TabIndex = 3;
            this.CountDisp.Text = "Count: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CountDisp);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Count);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label CountDisp;
    }
}

