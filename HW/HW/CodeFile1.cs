using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    // 1.Пользователь вводит два числа. Вывести на экран большее
    static class Number
    {
        static int number1 = 30;
        static int number2 = 100;
        public static void Output()
        {
            Console.WriteLine("The largest number is : {0}", (number1 > number2) ? number1 : number2);
        }
    }

    //2.Пользователь вводит слово «мяу» или слово «гав» если слово введенное пользователем «мяу» вывести на экран «Покорми кота» иначе «Погуляй с собакой»
    static class FeedAnimals
    {
        static string Word = "гав";
        public static void Feeding()
        {
            if (Word == "мяу")
            {
                Console.WriteLine("Покорми кота");
            }
            else if (Word == "гав")
            {
                Console.WriteLine("Погуляй с собакой");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

    //3.Пользователь вводит номер месяца если месяц 1,2,12 вывести на экран «Зима»; 3,4,5 – «Весна»; 6-8 – «Лето»; 9-11 – «Осень». В любом другом случае «На этой планете такого месяца нет»
    static class Seasons
    {
        static byte NumberofMonths = 1;
        public static void ChooseSeason()
        {
            switch (NumberofMonths)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Зима");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;

                case 6:
                case 8:
                    Console.WriteLine("Лето");
                    break;

                case 9:
                case 11:
                    Console.WriteLine("Осень");
                    break;

                default:
                    Console.WriteLine("На этой планете такого месяца нет");
                    break;
            }
        }
    }

    //4.Пользователь вводит число 1 или 0 с помощью одной строки кода вывести на экран «Хорошо» если пользователь ввел 1 или «Плохо» если пользователь ввел 0
    static class GoodOrBad
    {
        static byte number = 1;
        public static void Output()
        {
            Console.WriteLine((number == 1) ? "Хорошо" : "Плохо");
        }
    }
    //5.Вывести название дня недели по его номеру (1 - понедельник, 7 - воскресенье) 

    static class Weeks
    {
        enum Week { понедельник = 1, вторник, среда, четверг, пятница, суббота, воскресенье }
        static int NumberofWeek = 6;
        public static void Output()
        {
            Console.WriteLine(Enum.GetName(typeof(Week), NumberofWeek));
        }
    }

    //6.Служба такси заказала вам программу, которая спрашивает количество километров и количество минут простоя,
    //а дальше считает так: первые 5 километров (или до 5 км) 20 гривен, каждый следующий километр 3 гривны, плюс простой 1 грн за 1 минуту.
    static class Taxi
    {
        static int kilomitres = 20;
        static int minutes = 10;
        static int sum = 0;

        public static void Consider()
        {
            int count;
            sum += minutes;
            for (count = 1; count <= kilomitres; count++)
            {
                if (count == 5)
                {
                    sum += 20;
                }
                else if (count > 5)
                {
                    sum += 3;
                }
            }
            Console.WriteLine("Общая сумма оплаты за поездку: {0}", sum);
        }
    }

    //7.Дано натуральное число. Выяснить, является ли оно простым, т.е. делится только на 1 и на само себя. 

    static class SimpleNumber
    {
        static byte number = 5;

        public static void CheckNumberIsSimple()
        {
            bool check = false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    check = true;
                }
            }
            Console.WriteLine((!check) ? "Простое число" : "Не простое");
        }
    }

    //8.Вы организатор лотереи. Пользователь вводит ставку.
    //Вы бросаете 12-гранный кубик. Если выпадают значения от 1 до 5, пользователь проиграл.
    //Если выпадают значения от 6 до 8, пользователь получает свою ставку обратно. Если выпало от 9 до 11, пользователь получает двойную ставку, а если выпало 12 - ставку умноженную на 10. 
    //После окончания игры покажите пользователю, сколько он выиграл. 
    static class Lottery
    {

        static byte number = 12;
        static int rate = 5;

        public static void Won()
        {
            int win = Game(number, rate);
            Console.WriteLine("You won {0}", win);
        }

        private static int Game(byte number, int rate)
        {

            if (number >= 1 && number <= 5)
            {
                Console.WriteLine("Проигрыш");
                return 0;
            }
            else if (number >= 6 && number <= 8)
            {
                return rate;
            }
            else if (number >= 9 && number <= 11)
            {
                return rate * rate;
            }
            else if (number == 12)
            {
                return rate * 10;
            }
            else return -1;
        }
    }

    //9.Сделать программу перевода валют.
    //Вводится сумма, потом выбирается вид валюты – гривны или доллары или евро, программа переводит в две другие валюты. 
    // Текущий курс валюты считать известным.
    static class EchangeMoney
    {
        static double sum = 100230.1;
        static char symbol = '$';


        public static void Exchange()
        {
            double ExchangeRates_Dollar;
            double ExchangeRates_Euro;
            double ExchangeRates_UA;
            //CultureInfo ua = new CultureInfo("uk-UA");
            //CultureInfo eu = new CultureInfo("de-DE");
            CultureInfo us = new CultureInfo("en-US");

            switch (symbol)
            {
                case '$':
                    Console.WriteLine("Сумма: {0}", sum.ToString("c", us));
                    ExchangeRates_Euro = 0.94 * sum;
                    ExchangeRates_UA = sum * 24.6081;
                    Console.WriteLine("Перевод в евро: {0}Euro", ExchangeRates_Euro);
                    Console.WriteLine("Перевод в грн : {0}UAH", ExchangeRates_UA);
                    break;

                case 'E':
                    ExchangeRates_Dollar = sum * 1.06;
                    ExchangeRates_UA = sum * 25.99;
                    Console.WriteLine("Перевод в доллары : {0}", ExchangeRates_Dollar.ToString("c", us));
                    Console.WriteLine("Перевод в грн : {0}UAH", ExchangeRates_UA);
                    break;

                case 'U':
                    ExchangeRates_Dollar = sum / 25.4811;
                    ExchangeRates_Euro = sum / 27.1856;
                    Console.WriteLine("Перевод в доллары : {0}", ExchangeRates_Dollar.ToString("c", us));
                    Console.WriteLine("Перевод в евро: {0}UAH", ExchangeRates_Euro);
                    break;
            }
        }
    }
}