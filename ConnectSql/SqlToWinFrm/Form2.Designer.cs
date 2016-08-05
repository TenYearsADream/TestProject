namespace SqlToWinFrm
{
    partial class Form2
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Transform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 176);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 16;
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(51, 185);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(29, 12);
            this.course.TabIndex = 15;
            this.course.Text = "课程";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 14;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(51, 147);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(53, 12);
            this.date.TabIndex = 13;
            this.date.Text = "入学日期";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 12;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(51, 110);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(29, 12);
            this.score.TabIndex = 11;
            this.score.Text = "成绩";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 10;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(51, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 9;
            this.name.Text = "姓名";
            // 
            // Transform
            // 
            this.Transform.Location = new System.Drawing.Point(133, 230);
            this.Transform.Name = "Transform";
            this.Transform.Size = new System.Drawing.Size(75, 23);
            this.Transform.TabIndex = 17;
            this.Transform.Text = "Transform";
            this.Transform.UseVisualStyleBackColor = true;
            this.Transform.Click += new System.EventHandler(this.Transform_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 293);
            this.Controls.Add(this.Transform);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.course);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button Transform;

    }
}