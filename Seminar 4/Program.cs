/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
[-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20*/

/*int[] array = new int[12];
int summPozArray=0;
int summNegArray=0;
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (array[i]<0)
    {
         summNegArray += array[i];
    }
    else if (array[i]>0)
    {
         summPozArray += array[i];
    }

   }
Console.WriteLine(string.Join(",", array));
Console.WriteLine(summNegArray);
Console.WriteLine(summPozArray);*/

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.

Задача 33: Задайте массив. Напишите 
программу, которая определяет, присутствует ли заданное число в массиве.


int[] array = new int[12];
int[] array2 = new int[12];

for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    array2[i] = array[i]*(-1);   
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine(string.Join(",", array2));*/

//Console.WriteLine(string.Join(",", array)) - вцыодит ряд без крайней запятойю

void NumberSearch() 
{ 
 
int number = new Random().Next(1,17); 
 
int num = new Random().Next(17); 
int[] array = new int[num]; 
 
bool search = false; 
 
for(int i=0;i < array.Length; i++) 
{ 
    array[i]=new Random().Next(17); 
    if(number == array[i]) 
    search = true; 
} 
Console.WriteLine($"{number}; array [{string.Join(",",array)}]->{(search?"да":"нет")}"); 
} 
 
NumberSearch();

/* Задача 35: Задайте одномерный массив из 123 случайных чисел. 
 Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
 Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123


int[] array = new int[123];
int count = 0;
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1, 200);
    if (array [i]>= 10 && array [i] <=99)
    {
        count++;
    }
}
Console.WriteLine($"[{string.Join(", ", array)}] -> {count}");*/
