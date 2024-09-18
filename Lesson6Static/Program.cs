// Static Lesson6
using Lesson6Static;
//задание 1
//Random rnd =new Random();
//int n = rnd.Next(10, 20);
//MethodStatic arr=new MethodStatic(n);
//arr.PrintMas();
//Console.WriteLine(MethodStatic.Avg(arr.Mas));

// задание 2
int x = 10;
CharStatic charMas = new CharStatic(x);
charMas.PrintMas();
CharStatic.PairSwap(charMas.Chars);
charMas.PrintMas();
