// Виртуальные методы
using Lesson10VirtualMethod;

BaseClass num1= new BaseClass() {Number= 450};
Console.WriteLine(num1[1]);

ChildClass num2 = new ChildClass() {Number = 678, SecNumber = 567 };
Console.WriteLine(num2[1]);
Console.WriteLine(num2[1,0]);