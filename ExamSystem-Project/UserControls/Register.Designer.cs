namespace ExamSystem_Project.UserControls
{
    partial class Register
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label_LoginNow = new Label();
            label2 = new Label();
            textBox_password = new TextBox();
            textBox_userId = new TextBox();
            button_loginStart = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 135, 209);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 121);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(254, 255, 255);
            label1.Location = new Point(416, 36);
            label1.Name = "label1";
            label1.Size = new Size(142, 45);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(label_LoginNow);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_password);
            panel2.Controls.Add(textBox_userId);
            panel2.Controls.Add(button_loginStart);
            panel2.Controls.Add(panel1);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(144, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 628);
            panel2.TabIndex = 6;
            // 
            // label_LoginNow
            // 
            label_LoginNow.AutoSize = true;
            label_LoginNow.Cursor = Cursors.Hand;
            label_LoginNow.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label_LoginNow.ForeColor = Color.FromArgb(0, 160, 244);
            label_LoginNow.Location = new Point(435, 571);
            label_LoginNow.Name = "label_LoginNow";
            label_LoginNow.Size = new Size(114, 28);
            label_LoginNow.TabIndex = 4;
            label_LoginNow.Text = "Login Now";
            label_LoginNow.Click += label_LoginNow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(389, 546);
            label2.Name = "label2";
            label2.Size = new Size(218, 25);
            label2.TabIndex = 3;
            label2.Text = "Already have an account ?";
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(235, 235, 235);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_password.ForeColor = Color.FromArgb(0, 135, 209);
            textBox_password.Location = new Point(71, 259);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(258, 47);
            textBox_password.TabIndex = 2;
            textBox_password.Text = "Password";
            // 
            // textBox_userId
            // 
            textBox_userId.BackColor = Color.FromArgb(235, 235, 235);
            textBox_userId.BorderStyle = BorderStyle.None;
            textBox_userId.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_userId.ForeColor = Color.FromArgb(0, 135, 209);
            textBox_userId.Location = new Point(71, 178);
            textBox_userId.Multiline = true;
            textBox_userId.Name = "textBox_userId";
            textBox_userId.Size = new Size(258, 50);
            textBox_userId.TabIndex = 1;
            textBox_userId.Text = "User Id";
            // 
            // button_loginStart
            // 
            button_loginStart.BackColor = Color.FromArgb(0, 135, 209);
            button_loginStart.FlatStyle = FlatStyle.Flat;
            button_loginStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_loginStart.ForeColor = Color.White;
            button_loginStart.Location = new Point(407, 461);
            button_loginStart.Name = "button_loginStart";
            button_loginStart.Size = new Size(182, 59);
            button_loginStart.TabIndex = 0;
            button_loginStart.Text = "Register";
            button_loginStart.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(31, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(1013, 632);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(235, 235, 235);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(116, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 670);
            panel3.TabIndex = 7;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Register";
            Size = new Size(1277, 801);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label_LoginNow;
        private Label label2;
        private TextBox textBox_password;
        private TextBox textBox_userId;
        private Button button_loginStart;
        private Panel panel4;
        private Panel panel3;
    }
}
