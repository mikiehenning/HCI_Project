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
        private int notify, repeat;
        private Boolean repeatIndef, ampm; //will use repeat val if false. ampm: am if true, pm if false

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

        public Boolean repeatAlways()
        {
            return repeatIndef;
        }

        //will get all information on a timer as a string
        public String getTimerInfo()
        {
            info += "Name: " + name +
                "\nTime: " + timeHr + " : " + timeMin + " ";

            if (ampm == true) info += "am";
            else info += "pm";

            info += "\nNotify " + notify.ToString() +"min before";
            if (repeatIndef == true) info += "\nRepeat: Always";
            else info += "\nRepeat: " + repeat.ToString() + " Times";

            return info;
        }
    }

}
