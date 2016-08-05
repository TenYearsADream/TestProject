namespace XiaoFengBros
{
    partial class MainFrm
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBoxNav = new System.Windows.Forms.GroupBox();
            this.buttonNav = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.groupBoxNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(720, 389);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBoxNav
            // 
            this.groupBoxNav.Controls.Add(this.txtUrl);
            this.groupBoxNav.Controls.Add(this.buttonNav);
            this.groupBoxNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxNav.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNav.Name = "groupBoxNav";
            this.groupBoxNav.Size = new System.Drawing.Size(720, 100);
            this.groupBoxNav.TabIndex = 1;
            this.groupBoxNav.TabStop = false;
            // 
            // buttonNav
            // 
            this.buttonNav.Location = new System.Drawing.Point(549, 37);
            this.buttonNav.Name = "buttonNav";
            this.buttonNav.Size = new System.Drawing.Size(75, 23);
            this.buttonNav.TabIndex = 0;
            this.buttonNav.Text = "←";
            this.buttonNav.UseVisualStyleBackColor = true;
            this.buttonNav.Click += new System.EventHandler(this.buttonNav_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(21, 39);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(513, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 389);
            this.Controls.Add(this.groupBoxNav);
            this.Controls.Add(this.webBrowser1);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.groupBoxNav.ResumeLayout(false);
            this.groupBoxNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBoxNav;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button buttonNav;
    }
}