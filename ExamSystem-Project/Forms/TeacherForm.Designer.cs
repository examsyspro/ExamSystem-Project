namespace ExamSystem_Project.Forms
{
    partial class TeacherForm
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
            button_createExam = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_createExam
            // 
            button_createExam.Location = new Point(58, 126);
            button_createExam.Name = "button_createExam";
            button_createExam.Size = new Size(192, 68);
            button_createExam.TabIndex = 0;
            button_createExam.Text = "Create Exam";
            button_createExam.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(277, 126);
            button2.Name = "button2";
            button2.Size = new Size(128, 68);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(428, 126);
            button1.Name = "button1";
            button1.Size = new Size(164, 68);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 688);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button_createExam);
            Name = "TeacherForm";
            Text = "TeacherForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button_createExam;
        private Button button2;
        private Button button1;
    }
}