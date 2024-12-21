namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtRno = new TextBox();
            TxtFName = new TextBox();
            TxtName = new TextBox();
            TxtAge = new TextBox();
            dataGridView1 = new DataGridView();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 27);
            label1.Name = "label1";
            label1.Size = new Size(185, 33);
            label1.TabIndex = 0;
            label1.Text = "ABC SCHOOL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 78);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Roll No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 129);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 1;
            label3.Text = "Student Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 183);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 1;
            label4.Text = "Father Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 232);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 1;
            label5.Text = "Age";
            // 
            // TxtRno
            // 
            TxtRno.Enabled = false;
            TxtRno.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtRno.Location = new Point(319, 70);
            TxtRno.Name = "TxtRno";
            TxtRno.Size = new Size(489, 33);
            TxtRno.TabIndex = 2;
            TxtRno.TextChanged += textBox1_TextChanged;
            // 
            // TxtFName
            // 
            TxtFName.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtFName.Location = new Point(319, 175);
            TxtFName.Name = "TxtFName";
            TxtFName.Size = new Size(489, 33);
            TxtFName.TabIndex = 2;
            TxtFName.TextChanged += textBox1_TextChanged;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtName.Location = new Point(319, 121);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(489, 33);
            TxtName.TabIndex = 2;
            TxtName.TextChanged += textBox1_TextChanged;
            // 
            // TxtAge
            // 
            TxtAge.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtAge.Location = new Point(319, 224);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(489, 33);
            TxtAge.TabIndex = 2;
            TxtAge.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 385);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(700, 225);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(505, 301);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(112, 47);
            UpdateBtn.TabIndex = 4;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(696, 301);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(112, 47);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(319, 301);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(112, 47);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 639);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(dataGridView1);
            Controls.Add(TxtName);
            Controls.Add(TxtAge);
            Controls.Add(TxtFName);
            Controls.Add(TxtRno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtRno;
        private TextBox TxtFName;
        private TextBox TxtName;
        private TextBox TxtAge;
        private DataGridView dataGridView1;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button SaveBtn;
    }
}
