using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnovi
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value > 0 && value < 24) hours = value;
                else throw new Exception("Введите корректное значение часов");
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value > 0 && value < 60) minutes = value;
                else throw new Exception("Введите корректное значение минут");
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value > 0 && value < 60) seconds = value;
                else throw new Exception("Введите корректное значение секунды");
            }
        }
        public void AddHours(int addHours)
        {

            if (hours + addHours >= 24) hours = hours + addHours - (hours + addHours) / 24 * 24;
            else hours = hours + addHours;
        }
        public void AddMinutes(int addMinutes)
        {
            if (minutes + addMinutes >= 59)
            {
                hours = hours + (minutes + addMinutes) / 60;
                minutes = minutes + addMinutes - (minutes + addMinutes) / 60 * 60;
            }
            else minutes = minutes + addMinutes;
        }
        public void AddSeconds(int addSeconds)
        {
            TimeOnly dateTime = new TimeOnly(hours, minutes, seconds);
            dateTime = dateTime.Add(TimeSpan.FromSeconds(addSeconds));
            hours = dateTime.Hour;
            minutes = dateTime.Minute;
            seconds = dateTime.Second;
        }
        public void Print()
        {
            Console.WriteLine(Hours + "ч " + Minutes + "м " + seconds + "с");
        }
        public void SubHours(int subHours)
        {
            TimeOnly dateTime = new TimeOnly(hours, minutes, seconds);
            dateTime = dateTime.AddHours(-subHours);
            hours = dateTime.Hour;
            minutes = dateTime.Minute;
            seconds = dateTime.Second;
        }
        public void SubMinutes(int subMinutes)
        {
            TimeOnly dateTime = new TimeOnly(hours, minutes, seconds);
            dateTime = dateTime.AddMinutes(-subMinutes);
            hours = dateTime.Hour;
            minutes = dateTime.Minute;
            seconds = dateTime.Second;
        }
        public void SubSeconds(int subSeconds)
        {
            TimeOnly dateTime = new TimeOnly(hours, minutes, seconds);
            dateTime = dateTime.Add(TimeSpan.FromSeconds(-subSeconds));
            hours = dateTime.Hour;
            minutes = dateTime.Minute;
            seconds = dateTime.Second;
        }
    }
}
