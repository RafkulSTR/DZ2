using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Выбери задачу
10 - программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа;
13 - программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет;
15 - программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным;
17 - интересное число;
q - выход из программы");

                string select = Console.ReadLine();
                switch (select)
                {
                    case "10":
                        SecondNumber();
                        break;
                    case "13":
                        WriteFirdNumber();
                        break;
                    case "15":
                        DayWeek();
                        break;
                    case "17":
                        InterestingNumber();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        //
        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        //
        static void SecondNumber()
        {
            Console.WriteLine("Введите трехзначное число");
            string number = Console.ReadLine();
            int count = number.Length;
            if (count == 3)
            {
                int numberint;
                bool isNumeric = int.TryParse(number, out numberint);
                if (isNumeric)
                {
                    Console.WriteLine($"из числа {number} выводим вторую цифру {number[1]}");
                }
                else
                {
                    Console.WriteLine("Требуется ввести число");
                }
            }
            else
            {
                Console.WriteLine("Требуется ввести трехзначное число");
            }
        }

        //
        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //
        static void WriteFirdNumber()
        {
            Console.WriteLine("Введите число");
            string number = Console.ReadLine();
            int count = number.Length;
            if (count > 2)
            {
                int numberint;
                bool isNumeric = int.TryParse(number, out numberint);
                if (isNumeric)
                {
                    Console.WriteLine($"из числа {number} выводим третье число {number[2]}");
                }
                else
                {
                    Console.WriteLine("Требуется ввести число");
                }
            }
            else
            {
                Console.WriteLine("Третьей цифры нет");

                string text = @"текст 
                                на разных строчках";
                Console.WriteLine(text);
            }
        }

        //
        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        //
        static void DayWeek()
        {
            Console.WriteLine("Введите день недели, числом от 1 до 7");
            string dayText = Console.ReadLine();
            int day = 0;
            bool isNumeric = int.TryParse(dayText, out day);
            if (isNumeric)
            {
                if ((day > 0) && (day < 8))
                {
                    if (day < 6) Console.WriteLine($"{day} - Нет");
                    else Console.WriteLine($"{day} - Да");

                }
                else
                {
                    Console.WriteLine($"Вы ввели {day} - такого дня недели не существует");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число, требуется ввести день недели, от 1 до 7");
            }
        }

        //
        //Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
        //
        static void InterestingNumber()
        {
            int[] array = new int[10];

            int count = 0;

            while (count < 10)
            {
                int rnd = new Random().Next(10, 1000);
                if (rnd < 100)
                {
                    int firstNumber = rnd / 10;
                    int secondNumber = rnd % 10;
                    if (((firstNumber * secondNumber) % (firstNumber + secondNumber)) == 0)
                    {
                        array[count] = rnd;
                        Console.Write($"{rnd}, ");
                        count++;
                    }
                }
                else
                {
                    int firstNumber = rnd / 100;
                    int secondNumber = (rnd - ((rnd / 100) * 100)) / 10;
                    int FirdNumber = rnd % 100 % 10;
                    if (((firstNumber * secondNumber * FirdNumber) % (firstNumber + secondNumber + FirdNumber)) == 0)
                    {
                        array[count] = rnd;
                        Console.Write($"{rnd}, ");
                        count++;
                    }
                }
                
            }
            Console.WriteLine();
        }
    }
}