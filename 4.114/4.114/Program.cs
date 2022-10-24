using System;
     public class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Задайте число!");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте месяц!");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте год!");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:
                    if (d <= 1)
                    {
                        int yesterday = 31;
                        int last_month = 12;
                        int last_year = y - 1;
                        int visokos_last = last_year % 4;
                        if (visokos_last == 0)
                            Console.WriteLine("Високосный");
                        else
                            Console.WriteLine("Не високосный");
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + last_year);
                        int visokos_next = y % 4;
                        if (visokos_next == 0)
                            Console.WriteLine("Високосный");
                        else
                            Console.WriteLine("Не високосный");
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0)
                            Console.WriteLine("Високосный");
                        else
                            Console.WriteLine("Не високосный");
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + (d = 1) + "." + next_month + "." + y);
                        }
                        else
                            Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    break;

                case 12:
                    if (d <= 1)
                    {
                        int yesterday = 30;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0)
                            Console.WriteLine("Високосный");
                        else
                            Console.WriteLine("Не високосный");
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0)
                            Console.WriteLine("Високосный");
                        else
                            Console.WriteLine("Не високосный");
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1; int next_year = y + 1; m = 1;
                            Console.WriteLine("Завтра " + next_day + "." + m + "." + next_year);
                            if (next_year == 0)
                                Console.WriteLine("Високосный");
                            else
                                Console.WriteLine("Не високосный");
                        }
                        else
                            Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    break;

                case 2:
                    if (d <= 1)
                    {
                        int yesterday = 31;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0)
                            Console.WriteLine("Високосный");
                        else
                            Console.WriteLine("Не високосный");
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0)
                            Console.WriteLine("Високосный");
                        else
                            Console.WriteLine("Не високосный");
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 28 || d == 29)
                        {
                            int next_day = 1; int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else
                            Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    break;

                case 3:
                    if (d <= 1)
                    {
                        int visokos_yesterday = 29;
                        int nevisokos_yesterday = 28;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Вчера " + visokos_yesterday + "." + last_month + "." + y + " Високосный"); }
                        else { Console.WriteLine("Вчера " + nevisokos_yesterday + "." + last_month + "." + y + " Не високосный"); }
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 28 || d == 29)
                        {
                            int next_day = 1; int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;

                case 5:
                    if (d <= 1)
                    {
                        int yesterday = 30;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1;
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;

                case 7:
                    if (d <= 1)
                    {
                        int yesterday = 30;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1;
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;

                case 8:
                    if (d <= 1)
                    {
                        int yesterday = 31;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1;
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;

                case 10:
                    if (d <= 1)
                    {
                        int yesterday = 30;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1;
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;

                case 4:
                    if (d <= 1)
                    {
                        int yesterday = 31;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1;
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;

                case 6:
                    if (d <= 1)
                    {
                        int yesterday = 31;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1;
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;

                case 9:
                    if (d <= 1)
                    {
                        int yesterday = 31;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1;
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;

                case 11:
                    if (d <= 1)
                    {
                        int yesterday = 31;
                        int last_month = m - 1;
                        int visokos = y % 4;
                        if (visokos == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + yesterday + "." + last_month + "." + y);
                        Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y);
                    }
                    else
                    {
                        int year = y % 4;
                        if (year == 0) { Console.WriteLine("Високосный"); } else { Console.WriteLine("Не високосный"); }
                        Console.WriteLine("Вчера " + (d - 1) + "." + m + "." + y);
                        if (d == 31)
                        {
                            int next_day = 1;
                            int next_month = m + 1;
                            Console.WriteLine("Завтра " + next_day + "." + next_month + "." + y);
                        }
                        else { Console.WriteLine("Завтра " + (d + 1) + "." + m + "." + y); };
                    }
                    break;
            }   
        }
    }