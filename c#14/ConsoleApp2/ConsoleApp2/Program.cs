// using System;
//
// namespace Practica
// {
//     class Program
//     {
//         delegate bool Number(int number);
//         static bool Chetni(int number)
//         {
//             return number % 2 == 0;
//         }
//         static bool Nechetni(int number)
//         {
//             return number % 2 != 0;
//         }
//         static bool Proste(int number)
//         {
//             if (number < 2)
//                 return false;
//             for (int i = 2; i * i <= number; i++)
//             {
//                 if (number % i == 0)
//                     return false;
//             }
//             return true;
//         }
//
//         static bool Fibonacci(int number)
//         {
//             int a = 0;
//             int b = 1;
//             while (b < number)
//             {
//                 int temp = b;
//                 b = a + b;
//                 a = temp;
//             }
//             return b == number || number == 0;
//         }
//
//         static void Main(string[] args)
//         {
//             Console.Write("Введите число: ");
//             int number = int.Parse(Console.ReadLine());
//             
//             Number chetni = Chetni;
//             Number nechetni = Nechetni;
//             Number proste = Proste;
//             Number fibonacci = Fibonacci;
//             
//             Console.WriteLine($"Число является четным? {chetni(number)}");
//             Console.WriteLine($"Число является нечетным? {nechetni(number)}");
//             Console.WriteLine($"Число является простым? {proste(number)}");
//             Console.WriteLine($"Число является числом Фибоначчи? {fibonacci(number)}");
//         }
//     }
// }





//задание 1
using System;

// namespace Practica
// {
//     class Program
//     {
//         delegate bool Number(int number);
//         static bool Chetni(int number)
//         {
//             return number % 2 == 0;
//         }
//         static bool Nechetni(int number)
//         {
//             return number % 2 != 0;
//         }
//         static bool Proste(int number)
//         {
//             if (number < 2)
//                 return false;
//             for (int i = 2; i * i <= number; i++)
//             {
//                 if (number % i == 0)
//                     return false;
//             }
//             return true;
//         }
//
//         static bool Fibonacci(int number)
//         {
//             int a = 0;
//             int b = 1;
//             while (b < number)
//             {
//                 int temp = b;
//                 b = a + b;
//                 a = temp;
//             }
//             return b == number || number == 0;
//         }
//
//         static int[] Arr(int[] array, Number predicate)
//         {
//             List<int> res = new List<int>();
//             foreach (int number in array)
//             {
//                 if (predicate(number))
//                 {
//                     res.Add(number);
//                 }
//             }
//             return res.ToArray();
//         }
//         static void Main(string[] args)
//         {
//             int[] chicla = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//             int[] chetni = Arr(chicla, Chetni);
//             int[] nechetni = Arr(chicla, Nechetni);
//             int[] proste = Arr(chicla, Proste);
//             int[] fibonacci = Arr(chicla, Fibonacci);
//             
//             Console.WriteLine("Четные числа: "+string.Join(", ",chetni));
//             Console.WriteLine("Нeчетные числа: "+string.Join(", ",nechetni));
//             Console.WriteLine("Простые числа: "+string.Join(", ",proste));
//             Console.WriteLine("Фибоначчи числа: "+string.Join(", ",fibonacci));
//          
//         }
//     }
// }



//задание 2
// namespace Practica
// {
//     class Program
//     {
//         delegate void Print();
//
//         static void Vrema()
//         {
//             Console.WriteLine("Время: " + DateTime.Now.ToString("HH::mm:ss"));
//         }
//
//         static void Data()
//         {
//             Console.WriteLine("Дата: " + DateTime.Now.ToString("dd.MM.yyyy"));
//         }
//
//         static void Nedela()
//         {
//             Console.WriteLine("День недели: " + DateTime.Now.DayOfWeek);
//         }
//
//         static void Treygolnik()
//         {
//             Console.Write("Oснование треугольника: ");
//             double length = double.Parse(Console.ReadLine());
//             Console.Write("Bысотa треугольника: ");
//             double height = double.Parse(Console.ReadLine());
//             double S = 0.5 * length * height;
//             Console.WriteLine($"Площадь: {S}");
//         }
//
//         static void Pramaygolnik()
//         {
//             Console.Write("Длина прямоугольника: ");
//             double length = double.Parse(Console.ReadLine());
//             Console.Write("Ширина прямоугольника: ");
//             double width = double.Parse(Console.ReadLine());
//             double S = length * width;
//             Console.WriteLine($"Площадь: {S}");
//         }
//
//         static void Main(string[] args)
//         {
//             Print[] predicate = { Vrema, Data, Nedela, Treygolnik, Pramaygolnik };
//
//             int vibor = 0;
//             while (vibor != 5)
//             {
//                 Console.WriteLine("\nВыберите:");
//                 Console.WriteLine("1 - Показать время");
//                 Console.WriteLine("2 - Показать дату");
//                 Console.WriteLine("3 - Показать день недели");
//                 Console.WriteLine("4 - Посчитать площадь треугольника");
//                 Console.WriteLine("5 - Посчитать площадь прямоугольника");
//
//                 Console.Write("Выбор: ");
//                 vibor = int.Parse(Console.ReadLine());
//                 if (vibor >= 1 && vibor <= 5)
//                 {
//                     predicate[vibor - 1]();
//                 }
//             }
//         }
//     }
// }
        
    
