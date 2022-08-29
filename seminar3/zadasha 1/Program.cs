// //  Напишите программу, которая по заданному
// // номеру четверти, показывает диапазон 
// // возможных координат точек в этой четверти 
// // (x и y)

// Console.WriteLine("Enter quater... ");
// int quaternumber = int.Parse(Console.ReadLine());
// if (quaternumber == 1)
// {
//     Console.WriteLine("x > 0, y > 0");

// }
// else if (quaternumber == 2)
// {
//     Console.WriteLine("x < 0, y > 0");

// }
// else if (quaternumber == 3)
// {
//     Console.WriteLine("x < 0, y < 0");

// }
// else if (quaternumber == 4)
// {
//     Console.WriteLine("x > 0, y < 0");

// }
// else
// {
//     Console.WriteLine("Bug Error");
// }

// //Второй вариант решения задачи.

// Console.Write("Введите номер четверти: "); 
// int Quarter = Convert.ToInt32(Console.ReadLine()); 
 
 
// switch(Quarter) 
// { 
//     case 1: 
//     System.Console.WriteLine("В первой четверти X>0 и Y>0"); 
//     break; 
 
//     case 2: 
//     System.Console.WriteLine("Во второй четверти X<0 и Y>0"); 
//     break; 
 
//     case 3: 
//     System.Console.WriteLine("В третьей четверти X<0 и Y<0"); 
//     break; 
 
//     case 4: 
//     System.Console.WriteLine("В четвёртой четверти X>0 и Y<0"); 
//     break; 
// }
////Напишите программу, которая принимает на вход координаты двух точек и 
////находит расстояние между ними в 2D пространстве.

// Console.WriteLine("Enter x1...");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y1...");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter x2...");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y2...");
// int y2 = int.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

// // Console.WriteLine("длинна отрезка"+result);

// Console.WriteLine($"A ({x1},{y1}); B ({x2},{y2}) -> {result}");


////Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
////квадратов чисел от 1 до N.

// Console.WriteLine("Enter number...");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Таблица квадратов");

// for(int i = 1;i<=number;i++)
// {
//         Console.WriteLine(Math.Pow(i,2));
// }

//// просто как выводить кусочек метода.

// static void MaxNumber2()
//         {
//             int number = new Random().Next(10, 100);
//             int number1 = number % 10;
//             int number2 = number / 10;

//             int max = number1;

//             if (number1 < number2)
//             {
//                 max = number2;
//             }
//             System.Console.WriteLine($"Number {number} Max {max}");
//         }
//         MaxNumber2();
