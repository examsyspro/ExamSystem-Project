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
            button_startExam.Location = new Point(961, 0);
            button_startExam.Margin = new Padding(2, 2, 2, 2);
            button_startExam.Name = "button_startExam";
            button_startExam.Size = new Size(276, 118);
            button_startExam.TabIndex = 0;
            button_startExam.Text = "Start Exam";
            button_startExam.UseVisualStyleBackColor = true;
            button_startExam.Click += button_startExam_Click;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Location = new Point(814, 9);
            label_timer.Margin = new Padding(2, 0, 2, 0);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(63, 20);
            label_timer.TabIndex = 1;
            label_timer.Text = "00:00:00";
            // 
            // label_clock
            // 
            label_clock.AutoSize = true;
            label_clock.Location = new Point(891, 9);
            label_clock.Margin = new Padding(2, 0, 2, 0);
            label_clock.Name = "label_clock";
            label_clock.Size = new Size(43, 20);
            label_clock.TabIndex = 2;
            label_clock.Text = "clock";
            // 
            // ExamRunForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 901);
            Controls.Add(label_clock);
            Controls.Add(label_timer);
            Controls.Add(button_startExam);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ExamRunForm";
            Text = "ExamRunForm";
            FormClosing += ExamRunForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_startExam;
        private Label label_timer;
        private Label label_clock;
    }
}