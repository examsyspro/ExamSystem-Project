using ExamSystem.Client.Helpers;
using ExamSystem_Project.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem_Project.Forms
{
    public partial class ExamRunForm : Form
    {

        TimerClass timer;
        LocalClock clock;
        public ExamRunForm()
        {
            InitializeComponent();

            timer = new TimerClass(0, 0, 10);
            timer.TimeUpdater += Timer_Update;
            clock = LocalClock.Get_Instance();
            clock.Clock_Run();
            clock.Clock_event += Clock_Update;

        }


        public void Clock_Update(object sender, EventArgs e)
        {

            label_clock.Invoke((MethodInvoker)delegate
            {
                label_clock.Text = sender.ToString();
            });

        }

        public void Timer_Update(object sender, MyTimerEventArgs e)
        {


            if (!e.IsExpired)
                label_clock.Invoke((MethodInvoker)delegate{label_timer.Text = sender.ToString();});
            else
            {
                label_clock.Invoke((MethodInvoker)delegate{label_timer.Text = sender.ToString();});
            }





        }

        private void button_startExam_Click(object sender, EventArgs e)
        {
            timer.StartTimer();
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = false;
        }
    }
}

