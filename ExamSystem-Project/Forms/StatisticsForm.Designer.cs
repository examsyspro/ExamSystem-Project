namespace ExamSystem_Project.Forms
{
    partial class StatisticsForm
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
            panel4 = new Panel();
            label11 = new Label();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 135, 209);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1717, 114);
            panel4.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(685, 28);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(335, 60);
            label11.TabIndex = 7;
            label11.Text = "Statistics Panel";
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1717, 1155);
            Controls.Add(panel4);
            Name = "StatisticForm";
            Text = "StatisticForm";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label11;
    }
}