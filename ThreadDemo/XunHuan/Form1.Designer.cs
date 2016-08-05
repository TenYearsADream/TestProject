namespace XunHuan
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
            this.btmLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmLoop
            // 
            this.btmLoop.Location = new System.Drawing.Point(122, 57);
            this.btmLoop.Name = "btmLoop";
            this.btmLoop.Size = new System.Drawing.Size(75, 23);
            this.btmLoop.TabIndex = 0;
            this.btmLoop.Text = "开启循环";
            this.btmLoop.UseVisualStyleBackColor = true;
            this.btmLoop.Click += new System.EventHandler(this.btmLoop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.btmLoop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmLoop;
    }
}

