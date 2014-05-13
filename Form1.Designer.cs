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
            this.CountDisp = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountDisp
            // 
            this.CountDisp.Location = new System.Drawing.Point(88, 74);
            this.CountDisp.Name = "CountDisp";
            this.CountDisp.Size = new System.Drawing.Size(78, 20);
            this.CountDisp.TabIndex = 0;
            this.CountDisp.Text = "Counter: 0";
            this.CountDisp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(12, 154);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(75, 23);
            this.Count.TabIndex = 1;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(197, 154);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.CountDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountDisp;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Reset;
    }
}

