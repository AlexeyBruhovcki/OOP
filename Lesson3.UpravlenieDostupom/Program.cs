// Создать класс "Аэробус" и методы к нему.

using Lesson3.UpravlenieDostupom;

Airbus airbus = new Airbus(767, 20, 50, 100);
airbus.Print();

airbus.PassengersLeftPlayne(5, 15, 50);
airbus.Print();
airbus.TicketsBought(3, 11, 37);
airbus.Print();

