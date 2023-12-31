namespace ExamSystem_Project
{
    partial class MainForm
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
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            panel1_main = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1704, 187);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 135, 209);
            label4.Location = new Point(914, 136);
            label4.Name = "label4";
            label4.Size = new Size(449, 28);
            label4.TabIndex = 8;
            label4.Text = "Student or Teacher? Create or solve your test here!\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(788, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(443, 159);
            label5.TabIndex = 7;
            label5.Text = "System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 135, 209);
            label6.Location = new Point(462, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(372, 159);
            label6.TabIndex = 6;
            label6.Text = "Exam";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1150);
            panel2.Name = "panel2";
            panel2.Size = new Size(1704, 47);
            panel2.TabIndex = 7;
            // 
            // panel1_main
            // 
            panel1_main.BackColor = Color.Transparent;
            panel1_main.Location = new Point(222, 266);
            panel1_main.Name = "panel1_main";
            panel1_main.Size = new Size(1277, 801);
            panel1_main.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 135, 209);
            ClientSize = new Size(1704, 1197);
            Controls.Add(panel1_main);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Panel panel1_main;
    }
}