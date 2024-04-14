namespace EXCERCISE_ARRAYS
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
            txtName = new TextBox();
            btnSaveName = new Button();
            label2 = new Label();
            txtGrades = new TextBox();
            btnSaveGrades = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // btnSaveName
            // 
            btnSaveName.Location = new Point(182, 24);
            btnSaveName.Name = "btnSaveName";
            btnSaveName.Size = new Size(86, 24);
            btnSaveName.TabIndex = 2;
            btnSaveName.Text = "Save Name";
            btnSaveName.UseVisualStyleBackColor = true;
            btnSaveName.Click += btnSaveName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 82);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Grades:";
            // 
            // txtGrades
            // 
            txtGrades.Location = new Point(60, 74);
            txtGrades.Name = "txtGrades";
            txtGrades.Size = new Size(100, 23);
            txtGrades.TabIndex = 4;
            // 
            // btnSaveGrades
            // 
            btnSaveGrades.Location = new Point(182, 72);
            btnSaveGrades.Name = "btnSaveGrades";
            btnSaveGrades.Size = new Size(86, 24);
            btnSaveGrades.TabIndex = 5;
            btnSaveGrades.Text = "Save Grades";
            btnSaveGrades.UseVisualStyleBackColor = true;
            btnSaveGrades.Click += btnSaveGrades_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 247);
            Controls.Add(btnSaveGrades);
            Controls.Add(txtGrades);
            Controls.Add(label2);
            Controls.Add(btnSaveName);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnSaveName;
        private Label label2;
        private TextBox txtGrades;
        private Button btnSaveGrades;
    }
}
