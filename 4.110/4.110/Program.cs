﻿using System;
using static System.Console;
public class Mainclass
{
    public static void Main()
    {
        string suit, nominal;
        suit = "Select1";
        nominal = "Select2";
        WriteLine("Выберите масть карты: 1) Пики; 2) Трефы; 3) Бубны; 4) Червы");
        int suitSelection = int.Parse(ReadLine());
        WriteLine("Выберите достоинтсво карты : 1) Шестерка, 2) Семерка, 3) Восьмерка, 4) Девятка, 5) Десятка, 6) Валет, 7) Дама, 8) Король, 9) Туз");
        int nominalSelection = int.Parse(ReadLine());
        switch (suitSelection)
        {
            case 1:
                suit = "пики";
                break;
            case 2:
                suit = "трефы";
                break;
            case 3:
                suit = "бубны";
                break;
            case 4:
                suit = "червы";
                break;
        }
        switch (nominalSelection)
        {
            case 1:
                nominal = "Шестерка";
                break;
            case 2:
                nominal = "Семерка";
                break;
            case 3:
                nominal = "Восьмерка";
                break;
            case 4:
                nominal = "Девятка";
                break;
            case 5:
                nominal = "Десятка";
                break;
            case 6:
                nominal = "Валет";
                break;
            case 7:
                nominal = "Дама";
                break;
            case 8:
                nominal = "Король";
                break;
            case 9:
                nominal = "Туз";
                break;
        }
        Console.WriteLine($"Ваша карта: {nominal} {suit}");
    }
}