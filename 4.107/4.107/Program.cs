using System;
using static System.Console;
public class MainClass
{
  public static void Main()
  {
    int month;
    restart:
    WriteLine("Введите порядковый номер месяца:");
    month = int.Parse(Console.ReadLine());
        if(1<=month||12<=month)
        {
            //Т.к. в условии задачи не указано вводится ли год с клавиатуры,то использовал уже заданные значения
            int leapYear = 2024;
            int notLeapYear = 2024;
            Console.Write("год високосный? ввести 1 если да:");
            Console.WriteLine($"в месяце {DateTime.DaysInMonth(Console.ReadLine() == "1" ? notLeapYear : leapYear, month)} дней");

        }
        else
        {
            WriteLine("Такого месяца не существует,повторите ввод...");
            goto restart;
        }


  }
}
