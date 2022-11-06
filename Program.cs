//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. // 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
Console.WriteLine("введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
int multiply = numA;

for (int i = 1; i < numB; i++)
{
multiply = multiply * numA;
}
Console.WriteLine("A в степени B равно: " + multiply);

*/



/*  Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);


/* 
int num  = SetNumber("A");
int digit = GetSumallSymbolsOfNum(num);
int sum = 0;
Print(sum);

int GetSumallSymbolsOfNum(int num);
{

while (num > 0)
    {
        digit = num % 10;
        if (digit != 0)  
        {
            sum = sum + digit;
            num = num; // 10;
        }
        return sum;
    }
}
int SetNumber(string str)
{
    System.Console.WriteLine($"Enter number {str}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Print(int num)
{
Console.WriteLine($"number = {num}");
}
*/



/*  Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*  int[] array = {0, 0, 0, 0, 0, 0, 0, 0};
 Random arr = new Random();
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = arr.Next(2);
   Console.WriteLine(array[i]);
  }
*/