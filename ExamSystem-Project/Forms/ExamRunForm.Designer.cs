namespace ExamSystem_Project.Forms
{
    partial class ExamRunForm
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
            button_startExam = new Button();
            label_timer = new Label();
            label_clock = new Label();
            SuspendLayout();
            // 
            // button_startExam
            // 
            button_startExam.Location = new Point(636, 594);
            button_startExam.Name = "button_startExam";
            button_startExam.Size = new Size(345, 147);
            button_startExam.TabIndex = 0;
            button_startExam.Text = "Start Exam";
            button_startExam.UseVisualStyleBackColor = true;
            button_startExam.Click += button_startExam_Click;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Location = new Point(604, 305);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(80, 25);
            label_timer.TabIndex = 1;
            label_timer.Text = "00:00:00";
            // 
            // label_clock
            // 
            label_clock.AutoSize = true;
            label_clock.Location = new Point(980, 278);
            label_clock.Name = "label_clock";
            label_clock.Size = new Size(52, 25);
            label_clock.TabIndex = 2;
            label_clock.Text = "clock";
            // 
            // ExamRunForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 1126);
            Controls.Add(label_clock);
            Controls.Add(label_timer);
            Controls.Add(button_startExam);
            Name = "ExamRunForm";
            Text = "ExamRunForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_startExam;
        private Label label_timer;
        private Label label_clock;
    }
}