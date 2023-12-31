
using ExamSystem.Client.Pages.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamSystem.Client.Helpers
{
    public class LocalClock
    {
 
       private DateTime dateTime;
       private Thread Clock_Thread;
       private bool isRunning = true;
        public string currentTime;
        public event EventHandler Clock_event;


        private static LocalClock Clock_instance = null;

        private LocalClock()
        {
            

        }

        public static LocalClock Get_Instance()
        {
            if (Clock_instance == null)
            {
                Clock_instance = new LocalClock();
            }
            return Clock_instance;
        }

        private void Update_Clock()
        {
            while (isRunning)
            {
                currentTime = DateTime.Now.ToString("HH:mm:ss");
                Clock_event?.Invoke(currentTime, EventArgs.Empty);
                Thread.Sleep(1000);
            }
        }
        


        public void Clock_Run()
        {
         Clock_Thread = new Thread(()=> Update_Clock());
         Clock_Thread.Start();
        }

        public void Stop()
        {
            isRunning = false;
            Clock_Thread.Join();
        }

    }
}
