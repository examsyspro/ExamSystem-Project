﻿using System.Timers;

namespace ExamSystem.Client.Helpers
{
    public class TimerClass
    {
        #region consts_msg
         const string Msg_start ="starting";
         const string Msg_Err = "An error occurred: ";
         const string Msg_Expired = "Timer expired: ";
         const string Msg_Remaining = "Time remaining: ";
        #endregion
        
        public event EventHandler<MyTimerEventArgs> TimeUpdater;
        private int Hours = 0;
        private int Minutes = 0;
        private int Seconds = 0;
        public string FormattedTime = "";
        public string Msg = "";
        private System.Timers.Timer timer;
        MyTimerEventArgs Timer_Args;

        public TimerClass( int initialHours, int initialMinutes, int initialSeconds)
        {
            Hours = initialHours;
            Minutes = initialMinutes;
            Seconds = initialSeconds;
            Timer_Args = new MyTimerEventArgs();



        }

        public void StartTimer()
        {
           

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

        }

        private void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            
            try
            {
                    UpdateTime();
                    Msg = Msg_Remaining + FormattedTime;
                TimeUpdater?.Invoke(Msg, new MyTimerEventArgs { IsExpired = false }) ;


                // Check for timer expiration outside of Dispatcher.Invoke
                if (Hours == 0 && Minutes == 0 && Seconds == 0)
                {
                    timer.Stop();
                    timer.Dispose();
                    Timer_Args.IsExpired = true;
                    Msg = Msg_Expired + FormattedTime;
                    TimeUpdater?.Invoke(Msg, new MyTimerEventArgs { IsExpired = true});

                }
            }
            catch (Exception ex)
            {
                Msg = Msg_Err + ex.Message;
                TimeUpdater?.Invoke(Msg,new MyTimerEventArgs { IsExpired = true});
              
            }
        }

        private void UpdateTime()
        {

            if (Seconds > 0)
            {
                Seconds--;
            }
            else if (Minutes > 0)
            {
                Minutes--;
                Seconds = 59;
            }
            else if (Hours > 0)
            {
                Hours--;
                Minutes = 59;
                Seconds = 59;
            }

            FormattedTime = $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

        public void Stop ()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }

        }


    }

    public class MyTimerEventArgs : EventArgs
    {
        public bool IsExpired {get; set;}

    }
}
