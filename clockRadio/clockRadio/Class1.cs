using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockRadio
{
    class ClockRadio
    {
        public bool alarm;
        public string radioStation;

        public ClockRadio( bool OnOff, string station)
        {
            this.alarm = OnOff;
            this.radioStation = station;

        }

        public TimeSpan getTime ()
        {
            return DateTime.Now.TimeOfDay;
        }

        public void setAlarm(bool OnOff)
        {
            alarm = OnOff;
        }

        public void setStation(string station)
        {
            radioStation = station;
        }

        public void getStatus()
        {
            if (alarm == true) {
                Console.WriteLine("The alarm is on\n the station is"+ radioStation +" and the time is"+ DateTime.Now.TimeOfDay);
            }
            else
            {
                Console.WriteLine("The alarm is off \n The station is " + radioStation + "\n The time is " + DateTime.Now.TimeOfDay);

            }
        }
    }
}
