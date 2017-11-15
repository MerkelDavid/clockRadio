using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();

            Console.WriteLine("Welcome to your basic alarm set up");

            //bool alarm = main.OnOrOff(main.getAlarmStatus());

            ClockRadio radio = new ClockRadio(main.OnOrOff(main.getAlarmStatus()), main.getRadioStation() );

            radio.getStatus();

            Console.ReadKey();
        }

        public string getRadioStation()
        {
            Console.WriteLine("What station would you like to set your alarm to?");

            return Console.ReadLine();

        }
        public string getAlarmStatus()
        {
            Console.WriteLine("Would you like to set your alarm to on or off?");

            return Console.ReadLine();
        }
        public bool OnOrOff(string input)
        {
            if(input == "on")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
