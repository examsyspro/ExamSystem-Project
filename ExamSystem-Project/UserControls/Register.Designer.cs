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
            label_pass = new Label();
            label_cour = new Label();
            label_id = new Label();
            label_teaStu = new Label();
            label_firlas = new Label();
            comboBox_Course_Select = new ComboBox();
            textBox_password = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox_Type = new ComboBox();
            textBox_textName = new TextBox();
            label_LoginNow = new Label();
            label2 = new Label();
            textBox_textid = new TextBox();
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
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 97);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(254, 255, 255);
            label1.Location = new Point(366, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(label_pass);
            panel2.Controls.Add(label_cour);
            panel2.Controls.Add(label_id);
            panel2.Controls.Add(label_teaStu);
            panel2.Controls.Add(label_firlas);
            panel2.Controls.Add(comboBox_Course_Select);
            panel2.Controls.Add(textBox_password);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox_Type);
            panel2.Controls.Add(textBox_textName);
            panel2.Controls.Add(label_LoginNow);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_textid);
            panel2.Controls.Add(button_loginStart);
            panel2.Controls.Add(panel1);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(78, 50);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(856, 542);
            panel2.TabIndex = 6;
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.ForeColor = SystemColors.GrayText;
            label_pass.Location = new Point(262, 361);
            label_pass.Margin = new Padding(2, 0, 2, 0);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(323, 20);
            label_pass.TabIndex = 18;
            label_pass.Text = "8+ characters, 1 uppercase, 1 lowercase, 1 digit.";
            // 
            // label_cour
            // 
            label_cour.AutoSize = true;
            label_cour.ForeColor = SystemColors.GrayText;
            label_cour.Location = new Point(546, 273);
            label_cour.Margin = new Padding(2, 0, 2, 0);
            label_cour.Name = "label_cour";
            label_cour.Size = new Size(101, 20);
            label_cour.TabIndex = 17;
            label_cour.Text = "Select Course.";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.ForeColor = SystemColors.GrayText;
            label_id.Location = new Point(502, 186);
            label_id.Margin = new Padding(2, 0, 2, 0);
            label_id.Name = "label_id";
            label_id.Size = new Size(150, 20);
            label_id.TabIndex = 16;
            label_id.Text = "Enter valid 9-digit ID.";
            // 
            // label_teaStu
            // 
            label_teaStu.AutoSize = true;
            label_teaStu.ForeColor = SystemColors.GrayText;
            label_teaStu.Location = new Point(245, 273);
            label_teaStu.Margin = new Padding(2, 0, 2, 0);
            label_teaStu.Name = "label_teaStu";
            label_teaStu.Size = new Size(140, 20);
            label_teaStu.TabIndex = 15;
            label_teaStu.Text = "Teacher or Student?";
            // 
            // label_firlas
            // 
            label_firlas.AutoSize = true;
            label_firlas.ForeColor = SystemColors.GrayText;
            label_firlas.Location = new Point(190, 186);
            label_firlas.Margin = new Padding(2, 0, 2, 0);
            label_firlas.Name = "label_firlas";
            label_firlas.Size = new Size(177, 20);
            label_firlas.TabIndex = 14;
            label_firlas.Text = "First name and last name.";
            // 
            // comboBox_Course_Select
            // 
            comboBox_Course_Select.BackColor = Color.Snow;
            comboBox_Course_Select.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Course_Select.ForeColor = SystemColors.ControlText;
            comboBox_Course_Select.FormattingEnabled = true;
            comboBox_Course_Select.Location = new Point(546, 238);
            comboBox_Course_Select.Margin = new Padding(2, 2, 2, 2);
            comboBox_Course_Select.Name = "comboBox_Course_Select";
            comboBox_Course_Select.Size = new Size(176, 33);
            comboBox_Course_Select.TabIndex = 13;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.Snow;
            textBox_password.BorderStyle = BorderStyle.FixedSingle;
            textBox_password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.ForeColor = SystemColors.ControlText;
            textBox_password.Location = new Point(366, 329);
            textBox_password.Margin = new Padding(2, 2, 2, 2);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(207, 32);
            textBox_password.TabIndex = 2;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 135, 209);
            label3.Location = new Point(254, 330);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 8;
            label3.Text = "Password :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 135, 209);
            label7.Location = new Point(454, 240);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 12;
            label7.Text = "Course :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 135, 209);
            label6.Location = new Point(78, 240);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 11;
            label6.Text = "Select your type :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 135, 209);
            label5.Location = new Point(78, 156);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 10;
            label5.Text = "Full Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 135, 209);
            label4.Location = new Point(454, 156);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 9;
            label4.Text = "Id :";
            // 
            // comboBox_Type
            // 
            comboBox_Type.BackColor = Color.Snow;
            comboBox_Type.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Type.ForeColor = SystemColors.ControlText;
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(245, 238);
            comboBox_Type.Margin = new Padding(2, 2, 2, 2);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(164, 33);
            comboBox_Type.TabIndex = 7;
            comboBox_Type.SelectedIndexChanged += comboBox_Type_SelectedIndexChanged;
            comboBox_Type.MouseClick += comboBox_Type_MouseClick;
            // 
            // textBox_textName
            // 
            textBox_textName.Anchor = AnchorStyles.Top;
            textBox_textName.BackColor = Color.Snow;
            textBox_textName.BorderStyle = BorderStyle.FixedSingle;
            textBox_textName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_textName.ForeColor = SystemColors.ControlText;
            textBox_textName.Location = new Point(193, 154);
            textBox_textName.Margin = new Padding(2, 2, 2, 2);
            textBox_textName.Name = "textBox_textName";
            textBox_textName.Size = new Size(216, 32);
            textBox_textName.TabIndex = 6;
            textBox_textName.TextChanged += textBox_textName_TextChanged;
            // 
            // label_LoginNow
            // 
            label_LoginNow.AutoSize = true;
            label_LoginNow.Cursor = Cursors.Hand;
            label_LoginNow.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label_LoginNow.ForeColor = Color.FromArgb(0, 160, 244);
            label_LoginNow.Location = new Point(388, 487);
            label_LoginNow.Margin = new Padding(2, 0, 2, 0);
            label_LoginNow.Name = "label_LoginNow";
            label_LoginNow.Size = new Size(97, 23);
            label_LoginNow.TabIndex = 4;
            label_LoginNow.Text = "Login Now";
            label_LoginNow.Click += label_LoginNow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(351, 467);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 3;
            label2.Text = "Already have an account ?";
            // 
            // textBox_textid
            // 
            textBox_textid.BackColor = Color.Snow;
            textBox_textid.BorderStyle = BorderStyle.FixedSingle;
            textBox_textid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_textid.ForeColor = SystemColors.ControlText;
            textBox_textid.Location = new Point(502, 154);
            textBox_textid.Margin = new Padding(2, 2, 2, 2);
            textBox_textid.Name = "textBox_textid";
            textBox_textid.Size = new Size(219, 32);
            textBox_textid.TabIndex = 1;
            textBox_textid.TextChanged += textBox_textid_TextChanged;
            // 
            // button_loginStart
            // 
            button_loginStart.BackColor = Color.FromArgb(0, 135, 209);
            button_loginStart.FlatStyle = FlatStyle.Flat;
            button_loginStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_loginStart.ForeColor = Color.White;
            button_loginStart.Location = new Point(366, 399);
            button_loginStart.Margin = new Padding(2, 2, 2, 2);
            button_loginStart.Name = "button_loginStart";
            button_loginStart.Size = new Size(146, 47);
            button_loginStart.TabIndex = 0;
            button_loginStart.Text = "Register";
            button_loginStart.UseVisualStyleBackColor = false;
            button_loginStart.Click += button_Register_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(25, 15);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(810, 506);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(235, 235, 235);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(56, 34);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(895, 575);
            panel3.TabIndex = 7;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Register";
            Size = new Size(1022, 641);
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label_LoginNow;
        private Label label2;
        private TextBox textBox_password;
        private TextBox textBox_textid;
        private Button button_loginStart;
        private Panel panel4;
        private Panel panel3;
        private TextBox textBox_textName;
        private ComboBox comboBox_Type;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private ComboBox comboBox_Course_Select;
        private Label label_cour;
        private Label label_id;
        private Label label_teaStu;
        private Label label_firlas;
        private Label label_pass;
    }
}
