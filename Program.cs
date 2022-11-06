//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Введите числа A,  B");
String str  = int.Parse(Console.ReadLine());
//

int num = SetNumberA("A");
int SetNumberA() = (String str(0));

Print(multiply);

//multiply  = SetNumberA(string str) *  multiply;

int multiply = 1;
    
    for (int i = 0; i < size; i++)
    { 
        multiply = num*multiply;
        return multiply;
    }

int size = SetNumberB("B");
int SetNumberB(string str)
{
    System.Console.WriteLine($"Enter number {str}");
    int size = int.Parse(Console.ReadLine());
    return size;
}

int size = SetNumberB("B");
int num = SetNumberA("A");
int multiply = 1;
i = 0;

/* for(i=0; i < size; i++)
{
    multiply = num*multiply;
}
    return multiply;

Console.WriteLine(multiply); 
*/

/*  Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
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