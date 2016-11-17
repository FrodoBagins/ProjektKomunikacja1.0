using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    class Alarms
    {
        string h;
        string m;
        string s;
        public Alarms(string h, string m, string s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
            Thread thread = new Thread(new ThreadStart(addAlarm));
            thread.Start();
        }
        public void addAlarm()
        {
            while (true)
            {
                if (Convert.ToInt16(DateTime.Now.ToString("HH")) == Int16.Parse(h) && Convert.ToInt16(DateTime.Now.ToString("mm")) == Int16.Parse(m) && Convert.ToInt16(DateTime.Now.ToString("ss")) == Int16.Parse(s))
                {
                    SoundPlayer s1 = new SoundPlayer("C:/Alarm.wav");
                    s1.Play();
                    break;
                }
                else continue;
            }
        }
    }
}