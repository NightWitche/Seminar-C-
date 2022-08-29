// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for(int i = 1; i <= A; i++)
// {
//     sum = sum + i;
// }

// Console.Write("Сумма = " +sum);

/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
количество цифр в числе.*/

// Console.WriteLine("Enter number: ");
// int number = int.Parse(Console.ReadLine());
// int index = 0;
//  while(number > 0)
// {
//     number = number/10;
//     index++;
// }
// System.Console.WriteLine(index);

// второй вариант.

// Console.Write("Enter nymber...");

// string num = Console.ReadLine();
// int count = num.Length;
// Console.WriteLine("Amount digit.." +count);

/*Задача 28: Напишите программу, которая принимает на вход число N и
 выдаёт произведение чисел от 1 до N.*/



 /*void factorialdigit (string? data)
 
 
 {
    int num;
    while(true)
    {
        if(int.TryParse(data, out num))
        {
            break;
        }
        else
        {
            System.Console.WriteLine("error to enter");
            data = Console.ReadLine();
        }
    }
    int result = 1;
     for (int i = 2;i<=num;i++)
     {
        result*= i;
     }
    System.Console.WriteLine($"произведение чисел {result}");
 }

Console.WriteLine("Enter number: ");
factorialdigit(Console.ReadLine());
 ( работает только с маленькими числами)*/

//  void factorialdigit (string? data)
  
//  {
//     ulong num;
//     while(true)
//     {
//         if(ulong.TryParse(data, out num))
//         {
//             break;
//         }
//         else
//         {
//             System.Console.WriteLine("error to enter");
//             data = Console.ReadLine();
//         }
//     }
//     ulong result = 1;
//      for (ulong i = 2;i<=num;i++)
//      {
//         result*= i;
//      }
//     System.Console.WriteLine($"произведение чисел {result}");
//  }

// Console.WriteLine("Enter number: ");
// factorialdigit(Console.ReadLine());

// ( для двухначных чисел)


////Задача 30: Напишите программу, которая выводит массив из 8 
//элементов, заполненный нулями и единицами в случайном порядке.//

int[] array = new int[8];


for(int i = 0; i < 8; i++)
{
    array [i] = new Random().Next(0,2);
     System.Console.Write(array[i]+" ");
}

