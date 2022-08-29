 //Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.Write("Введите число 1..."); 
int Number1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число 2..."); 
int Number2 = Convert.ToInt32(Console.ReadLine()); 
if(Number1 == Number2 * Number2) 
{ 
    Console.Write("Первое число является квадратом второго"); 
} 
else 
{ 
    Console.Write("Первое число НЕ является квадратом второго"); 
}
