using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.UpravlenieDostupom
{
    internal class Airbus
    {
        private int flightNumber;
        
        private int firstClassSeats;
        private int secondClassSeats;
        private int thirdClassSeats;
        public int FlightNumber
        {
            get { return flightNumber; }
            set { if (value > 0) flightNumber = value;
                else throw new Exception("Введите положительное значение");
            }
        }
        public int FirstClassSeats
        {
            get { return firstClassSeats; }
            set { if (value > 0) firstClassSeats = value;
                else throw new Exception("Введите положительное значение"); }
        }
        public int SecondClassSeats
        {
            get { return secondClassSeats; }
            set { if (value > 0) secondClassSeats = value;
                else throw new Exception("Введите положительное значение");
            }
        }
        public int ThirdClassSeats
        {
            get { return thirdClassSeats; }
            set { if (value > 0) thirdClassSeats = value;
                else throw new Exception("Введите положительное значение");
            }
        }
        private int firstClassOccupied;
        private int secondClassOccupied;
        private int thirdClassOccupied;
        public Airbus(int flightNumber, int firstClassSeats, int secondClassSeats, int thirdClassSeats)
        {
            this.flightNumber = flightNumber;
            this.firstClassSeats = firstClassSeats;
            this.secondClassSeats = secondClassSeats;
            this.thirdClassSeats = thirdClassSeats;
            this.firstClassOccupied = firstClassSeats;
            this.secondClassOccupied = secondClassSeats;
            this.thirdClassOccupied = thirdClassSeats;
        }
        public void Print()
        {
            Console.WriteLine($"Количество свободных мест в первом классе: {firstClassSeats-firstClassOccupied}\nКоличество свободных мест во втором классе: {secondClassSeats-secondClassOccupied}\nКоличество мест в третьем классе: {thirdClassSeats-thirdClassOccupied}");
            Console.WriteLine();
        }
        public void PassengersLeftPlayne(int FCquantity, int SCquantity,int TCquantity)
        {
            firstClassOccupied = firstClassOccupied - FCquantity;
            secondClassOccupied = secondClassOccupied - SCquantity;
            thirdClassOccupied = thirdClassOccupied - TCquantity;
            Console.WriteLine($"Вышло пассажиров:\n" +
                $"1 класс: {FCquantity}\n" +
                $"2 класс: {SCquantity}\n" +
                $"3 класс: {TCquantity}\n");
        }
        public void TicketsBought(int FCquantity, int SCquantity, int TCquantity)
        {
            if(firstClassOccupied+ FCquantity <= firstClassSeats)
            {
                firstClassOccupied = firstClassOccupied + FCquantity;
            }
            else Console.WriteLine($"Недостаточно мест в первом классе, мест доступно: {firstClassSeats-firstClassOccupied}");
            if (secondClassOccupied + SCquantity <= secondClassSeats)
            {
                secondClassOccupied = secondClassOccupied + FCquantity;
            }
            else Console.WriteLine($"Недостаточно мест во втором классе, мест доступно: {secondClassSeats - secondClassOccupied}");
            if (thirdClassOccupied + TCquantity <= thirdClassSeats)
            {
                thirdClassOccupied = thirdClassOccupied + FCquantity;
            }
            else Console.WriteLine($"Недостаточно мест в третьем классе, мест доступно: {thirdClassSeats - thirdClassOccupied}");
            Console.WriteLine($"Билетов куплено:\n" +
                $"1 класс: {FCquantity}\n" +
                $"2 класс: {SCquantity}\n" +
                $"3 класс: {TCquantity}\n");
        }
       

    }
}
