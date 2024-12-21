namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnteredTextLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalCharsLbl = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CharacterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Just Testing For Latter Trackig Here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Some Words Here";
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.SystemColors.Menu;
            this.InputBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(294, 48);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(315, 40);
            this.InputBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "You type this";
            // 
            // EnteredTextLbl
            // 
            this.EnteredTextLbl.AutoSize = true;
            this.EnteredTextLbl.Location = new System.Drawing.Point(290, 127);
            this.EnteredTextLbl.Name = "EnteredTextLbl";
            this.EnteredTextLbl.Size = new System.Drawing.Size(25, 20);
            this.EnteredTextLbl.TabIndex = 4;
            this.EnteredTextLbl.Text = "\" \"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Characters in your type";
            // 
            // TotalCharsLbl
            // 
            this.TotalCharsLbl.AutoSize = true;
            this.TotalCharsLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCharsLbl.Location = new System.Drawing.Point(291, 177);
            this.TotalCharsLbl.Name = "TotalCharsLbl";
            this.TotalCharsLbl.Size = new System.Drawing.Size(24, 27);
            this.TotalCharsLbl.TabIndex = 6;
            this.TotalCharsLbl.Text = "0";
            // 
            // StartBtn
            // 
            this.StartBtn.AutoSize = true;
            this.StartBtn.BackColor = System.Drawing.Color.Turquoise;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(296, 260);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 39);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Click";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Turquoise;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(534, 260);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(78, 39);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Words";
            // 
            // CharacterLbl
            // 
            this.CharacterLbl.AutoSize = true;
            this.CharacterLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterLbl.Location = new System.Drawing.Point(292, 224);
            this.CharacterLbl.Name = "CharacterLbl";
            this.CharacterLbl.Size = new System.Drawing.Size(24, 27);
            this.CharacterLbl.TabIndex = 10;
            this.CharacterLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CharacterLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.TotalCharsLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EnteredTextLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Latter Tracking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EnteredTextLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalCharsLbl;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CharacterLbl;
    }
}

