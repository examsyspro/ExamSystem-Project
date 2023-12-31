namespace ExamSystem_Project.UserControls
{
    partial class Login
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
            label_registerNow = new Label();
            label2 = new Label();
            textBox_password = new TextBox();
            textBox_userId = new TextBox();
            button_loginStart = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(487, 121);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(254, 255, 255);
            label1.Location = new Point(192, 38);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label_registerNow);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_password);
            panel2.Controls.Add(textBox_userId);
            panel2.Controls.Add(button_loginStart);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(394, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 628);
            panel2.TabIndex = 3;
            // 
            // label_registerNow
            // 
            label_registerNow.AutoSize = true;
            label_registerNow.Cursor = Cursors.Hand;
            label_registerNow.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label_registerNow.ForeColor = Color.FromArgb(0, 160, 244);
            label_registerNow.Location = new Point(162, 556);
            label_registerNow.Name = "label_registerNow";
            label_registerNow.Size = new Size(140, 28);
            label_registerNow.TabIndex = 4;
            label_registerNow.Text = "Register Now";
            label_registerNow.Click += label_registerNow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(135, 529);
            label2.Name = "label2";
            label2.Size = new Size(202, 25);
            label2.TabIndex = 3;
            label2.Text = "Don't have an account ?";
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(235, 235, 235);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_password.ForeColor = Color.FromArgb(0, 135, 209);
            textBox_password.Location = new Point(76, 258);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(336, 46);
            textBox_password.TabIndex = 2;
            textBox_password.Text = "Password";
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // textBox_userId
            // 
            textBox_userId.BackColor = Color.FromArgb(235, 235, 235);
            textBox_userId.BorderStyle = BorderStyle.None;
            textBox_userId.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_userId.ForeColor = Color.FromArgb(0, 135, 209);
            textBox_userId.Location = new Point(76, 182);
            textBox_userId.Multiline = true;
            textBox_userId.Name = "textBox_userId";
            textBox_userId.Size = new Size(336, 45);
            textBox_userId.TabIndex = 1;
            textBox_userId.Text = "User Id";
            textBox_userId.TextChanged += textBox_userId_TextChanged;
            // 
            // button_loginStart
            // 
            button_loginStart.BackColor = Color.FromArgb(0, 135, 209);
            button_loginStart.FlatStyle = FlatStyle.Flat;
            button_loginStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_loginStart.ForeColor = Color.White;
            button_loginStart.Location = new Point(144, 376);
            button_loginStart.Name = "button_loginStart";
            button_loginStart.Size = new Size(182, 59);
            button_loginStart.TabIndex = 0;
            button_loginStart.Text = "Login";
            button_loginStart.UseVisualStyleBackColor = false;
            button_loginStart.Click += button_loginStart_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Location = new Point(375, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(523, 662);
            panel3.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Controls.Add(panel3);
            ForeColor = Color.FromArgb(100, 121, 95);
            Name = "Login";
            Size = new Size(1277, 801);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox_userId;
        private Button button_loginStart;
        private TextBox textBox_password;
        private Label label2;
        private Label label_registerNow;
        private Panel panel3;
    }
}
