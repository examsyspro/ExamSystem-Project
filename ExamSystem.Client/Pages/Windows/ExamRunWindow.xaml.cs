
using ExamSystem.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamSystem.Client.Pages.Windows
{
    /// <summary>
    /// Interaction logic for ExamRunWindow.xaml
    /// </summary>
    public partial class ExamRunWindow : Window
    {
       TimerClass timer;
        LocalClock clock;
        
        public ExamRunWindow()
        {
            InitializeComponent();
            timer = new TimerClass(0,0,10);
            timer.TimeUpdater+= Timer_Update;
            clock = LocalClock.Get_Instance();
            clock.Clock_Run();
            clock.Clock_event += Clock_Update;

           

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            timer.StartTimer();
            Button clickedButton = (Button)sender;
            clickedButton.IsEnabled = false;
        }

        public void Clock_Update(object sender, EventArgs e)
        {
             label1_Clock.Dispatcher.Invoke(() =>
            {

                label1_Clock.Content = sender.ToString();
            });
        }

        public void Timer_Update(object sender, MyTimerEventArgs e)
        {
           
            
                if (!e.IsExpired)
                    timer_labal.Dispatcher.Invoke(() =>
                    {
                        timer_labal.Content = sender.ToString();
                    });
                else
                {
                    timer_labal.Dispatcher.Invoke(() =>
                    {
                        timer_labal.Content = sender.ToString();
                    });
                }
            
     
           
        

        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clock.Stop();
            timer.Stop();

        }
    }
}
