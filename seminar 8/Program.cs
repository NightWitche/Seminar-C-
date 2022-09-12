// // Задайте двумерный массив. Напишите программу, 
// // которая поменяет местами первую и последнюю строку массива.

// int[,] GetArray()
// {

//     int[,] array = new int[new Random().Next(3, 6), new Random().Next(3, 6)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             array[i, j] = new Random().Next(10, 100);
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine();
//     return array;
// }

//  int [,] TPArray(int [,] Array)
//  {
//      for (int i = 0; i < Array.GetLength(1); i++)
//     {
//         var temp = Array [Array.GetLength(0)-1,i];

//         Array [Array.GetLength(0)-1,i] = Array [0,i];
//         Array [0,i] = temp;    
//     }   
//     return Array;
//   }    
//   void PrintArray(int [,] array)
//   {
//      for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//   }
// PrintArray(TPArray(GetArray()));

// // Задайте двумерный массив. Напишите программу, которая заменяет 
// // строки на столбцы. В случае, если это невозможно, программа должна 
// // вывести сообщение для пользователя.
Console.WriteLine($"___Задача 55: Программа, меняющая строки на столбцы___\n"); 
 
int[,] arr2 = GetArrayInt(); 
Console.WriteLine($"Ваш массив №2:\n"); 
PrintArray(arr2); 
 
int[,] turnArr = TurnArrayAndPrint(arr2); 
if (turnArr != null) 
{ 
    Console.WriteLine($"Массив №2, где заменены строки на столбцы:\n"); 
    PrintArray(turnArr); 
}

int[,] GetArrayInt() 
{ 
    var rand = new Random(); 
 
    int[,] array = new int[rand.Next(1, 10), rand.Next(1, 10)]; 
 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = new Random().Next(10, 100); 
        } 
    } 
 
    return array; 
}

void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        } 
 
    Console.WriteLine(); 
    } 
}

int[,] TurnArrayAndPrint(int[,] array) 
{ 
    int length = array.GetLength(0); 
 
    int[,] arrTurn = new int[length, length]; 
 
    if (array.GetLength(0) == array.GetLength(1)) 
    { 
    for (int i = 0; i < array.GetLength(0); i++) 
        { 
            for (int j = 0; j < array.GetLength(1); j++) 
            { 
                arrTurn[i, j] = array[j, i]; 
            } 
        } 
        return arrTurn; 
    } 
    else 
    { 
        Console.WriteLine("Данный массив нельзя перевернуть!"); 
        return null; 
    }    
}
// // Составить частотный словарь элементов двумерного массива. 
// // Частотный словарь содержит информацию о том, 
// // сколько раз встречается элемент входных данных.
// void GetArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     Console.Clear();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Random rnd = new Random();
// int m = rnd.Next(6, 10);
// int n = rnd.Next(6, 10);
// int[,] array = new int[m, n];

// GetArray(array);
// PrintArray(array);
// Console.WriteLine();
// int trg = 0;
// int[,] dict = new int[m * n, 2];
// int k = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         trg = 0;
//         for (int r = 0; r < k; r++)
//         {
//             if (dict[r, 0] == array[i, j])
//             {
//                 dict[r, 1]++;
//                 trg = 1;
//                 break;
//             }

//         }
//         if (trg == 0)
//         {
//             //dict = new int[k+1,2] (dict);
//             dict[k, 0] = array[i, j];
//             dict[k, 1]++;
//             k++;
//         }
//     }
// }

// for (int i = 0; i < k; i++)
// {
//     for (int j = 0; j < dict.GetLength(1); j++)
//     {
//         Console.Write($"{dict[i, j]} ");
//     }
//     System.Console.WriteLine();
// }
 
// // решение два.

// public static int[,] SlovArr(int [,] MyArr)
//     {
//         int rows = MyArr.GetLength(0), cols = MyArr.GetLength(1);
//         int[,] slovar = new int[2, rows*cols];
//         int count = 0;   //количество разных цифр в массиве
//         slovar[0,0] =MyArr[0,0];
//         for ( int i = 0; i < rows; i++ )
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 for (int k = 0; k < rows*cols; k++)
//                 {
//                     if  (slovar[0,k] == MyArr[i,j])
//                     {
//                         slovar [1, k] ++;
//                         break;
//                     } 
//                     else 
//                     {
//                         count++;
//                         slovar[0, count] = MyArr[i,j];
//                         slovar[1, count] = 1;
//                     }
//                 }
//             }
//         }

//         return slovar;
//     }

