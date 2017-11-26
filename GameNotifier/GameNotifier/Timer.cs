using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotifier
{
    public class Timer
    {
        private String
            name, //holds a timer name
            timeHr, timeMin, //holds the time
            info;
        private int notify, repeat, alarmTimeHr, alarmTimeMin;
        private Boolean repeatIndef, ampm, notified = false; //will use repeat val if false. ampm: am if true, pm if false
        public int GID;

        public Timer(String name)
        {
            this.name = name;
        }

        //setters
        public void setName(String name)
        {
            this.name = name;
        }

        public void setTime(String timeHr, String timeMin, Boolean ampm)
        {
            this.timeHr = timeHr;
            this.timeMin = timeMin;
            this.ampm = ampm;
            setAlarmTime();
        }

        public void setNotify(int notify)
        {
            this.notify = notify;
        }

        public void setRepeat(int repeat, Boolean repeatIndef)
        {
            this.repeat = repeat;
            this.repeatIndef = repeatIndef;
        }

        public void setNotified(Boolean notified)
        {
            this.notified = notified;
        }

        //getters
        public String getName()
        {
            return name;
        }

        public String getTimeHr()
        {
            return timeHr;
        }

        public String getTimeMin()
        {
            return timeMin;
        }

        public int getAlarmTimeHr()
        {
            return alarmTimeHr;
        }

        public int getAlarmTimeMin()
        {
            return alarmTimeMin;
        }

        public Boolean getAMPM()
        {
            return ampm;
        }

        public int getNotify()
        {
            return notify;
        }

        public int getRepeat()
        {
            return repeat;
        }

        public Boolean getNotified()
        {
            return notified;
        }

        public Boolean repeatAlways()
        {
            return repeatIndef;
        }

        //will get all information on a timer as a string
        public String getTimerInfo()
        {
            info = "";

            info += "\nName: " + name +
                "\n\nTime: " + timeHr + " : " + timeMin + " ";

            if (ampm == true) info += "am";
            else info += "pm";

            info += "\n\nNotify: " + notify.ToString() +" min before";
            if (repeatIndef == true) info += "\n\nRepeat: Always";
            else info += "\n\nRepeat: " + repeat.ToString() + " Times";

            return info;
        }

        private void setAlarmTime()
        {
            if (Int32.Parse(timeMin) - notify < 0)
            {
                int temp = Int32.Parse(timeMin) - notify;
                this.alarmTimeMin = 60 + temp;
                this.alarmTimeHr = Int32.Parse(timeHr) - 1;
            }
            else
            {
                this.alarmTimeMin = Int32.Parse(timeMin) - notify;
                this.alarmTimeHr = Int32.Parse(timeHr);
            }
        }

    }
}
