using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNotifier
{

    class Game
    {
        private List<Timer> timers = new List<Timer>();
        private String name;

        public Game(String name)
        {
            this.name = name;
        }

        public void addTimer(Timer timer)
        {
            timers.Add(timer);
        }

        //returns a timer with the given name
        public Timer getTimer(String name)
        {
            foreach(Timer timer in timers)
            {
                if (timer.getName() == name) return timer;
                else continue; 
            }
            return null;
        }

        //retuns a list of all timers associated with a game
        public List<Timer> getAllTimers()
        {
            return timers;
        }

        public String getName()
        {
            return name;
        }

        public void removeTimer(Timer timer)
        {
            timers.Remove(timer);
        }
    }
}
