// Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.


int[,] numbersPifagor()
{
Console.Write("Enter rows...");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter columns...");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] Pith = new int[rows, columns];

for (int i = 0; i < Pith.GetLength(0);i++)
{
    for (int j = 0; j < Pith.GetLength(1);j++)
    {
        Pith[i,j] = i+j;
        Console.Write($"{Pith[i,j]} ");
    }
    
}
  return Pith;
}
numbersPifagor();



// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.

// int[,] numbersPifagor()
// {
// Console.Write("Enter rows...");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Enter columns...");
// int columns = int.Parse(Console.ReadLine());
// Console.WriteLine();

// int[,] Pith = new int[rows, columns];

// for (int i = 0; i < Pith.GetLength(0);i++)
// {
//     for (int j = 0; j < Pith.GetLength(1);j++)
//     {
//         Pith[i,j] = new Random().Next(10);
//         Console.Write($"{Pith[i,j]} ");
//     }
//    Console.WriteLine();
// }
// Console.WriteLine();
// Console.WriteLine();

// for (int i = 0; i < Pith.GetLength(0);i++)
// {
//     for (int j = 0; j < Pith.GetLength(1);j++)
//     {
//         if (i % 2==0 && j % 2 ==0)
//         {
//             Pith[i,j] *= Pith[i,j];
//         }

//         Console.Write($"{Pith[i,j]} ");
//     }
//    Console.WriteLine();
// }
// return Pith;  
// }

// numbersPifagor();

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д

// int[,] numbersPifagor()
// {
// Console.Write("Enter rows...");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Enter columns...");
// int columns = int.Parse(Console.ReadLine());
// Console.WriteLine();

// int[,] Pith = new int[rows, columns];

// for (int i = 0; i < Pith.GetLength(0);i++)
// {
//     for (int j = 0; j < Pith.GetLength(1);j++)
//     {
//         Pith[i,j] = new Random().Next(10);
//         Console.Write($"{Pith[i,j]} ");
//     }
//    Console.WriteLine();
// }
// Console.WriteLine();
// Console.WriteLine();

// int summ=0;
// for (int i = 0; i < Pith.GetLength(0);i++)
// {
//     for (int j = 0; j < Pith.GetLength(1);j++)
//     {
//         if (i==j) summ = summ + Pith[i,j];       
           
//         Console.Write($"{Pith[i,j]} ");
//     }
//  Console.WriteLine(summ);
// }
// return Pith;  
// }
// numbersPifagor();