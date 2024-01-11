namespace _27.Profession
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
            button1 = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            rdOther = new RadioButton();
            comboBox1 = new ComboBox();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(289, 397);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 121);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 1;
            label1.Text = "Name : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(308, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 183);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 3;
            label2.Text = "Gender : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 292);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 4;
            label3.Text = "Profession : ";
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(306, 167);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(75, 29);
            rdMale.TabIndex = 5;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(308, 207);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(93, 29);
            rdFemale.TabIndex = 6;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            rdFemale.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdOther
            // 
            rdOther.AutoSize = true;
            rdOther.Location = new Point(307, 242);
            rdOther.Name = "rdOther";
            rdOther.Size = new Size(82, 29);
            rdOther.TabIndex = 7;
            rdOther.TabStop = true;
            rdOther.Text = "Other";
            rdOther.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Teacher", "Engineer", "Lecture", "Nurse" });
            comboBox1.Location = new Point(308, 292);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Choose...";
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.BorderStyle = BorderStyle.Fixed3D;
            lblDisplay.Location = new Point(302, 346);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(294, 27);
            lblDisplay.TabIndex = 9;
            lblDisplay.Text = "                                                        ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 514);
            Controls.Add(lblDisplay);
            Controls.Add(comboBox1);
            Controls.Add(rdOther);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private RadioButton rdOther;
        private ComboBox comboBox1;
        private Label lblDisplay;
    }
}