//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. // 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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





/*  Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
 int[] array = {0, 0, 0, 0, 0, 0, 0, 0};
 Random arr = new Random();
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = arr.Next(2);
   Console.WriteLine(array[i]);
    }