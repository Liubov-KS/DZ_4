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
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


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

///проверить и удалить//
/*int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}
*/