using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    //1.Вывести на экран таблицу умножения на N от 1 до 20 где N число введенное пользователем
    static class Multiplication
    {
        static int Number = 1;

        public static void Multiple()
        {
            Console.WriteLine("таблица умножения (1-20):");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Number * i);
            }
        }
    }

    //2.Пользователь вводит число вывесли на экран количество разрядов в этом числе
    static class LevelofNumber
    {
        static int Number = 100;

        public static void Output()
        {
            int num = Number;
            int count = 0;
            while (Number > 0)
            {
                count++;
                Number /= 10;
            }
            Console.WriteLine("в числе {0} : {1} разрядов ", num, count);
        }
    }

    //3.Программа загадывает число от 1 до 146.
    //Пользователь пытается его угадать. В случае не верного ответа программа дает подсказку «больше» или «меньше»

    static class RandomNumber
    {
        static int Number;

        public static void Rand(int RandomNumb)
        {
            Console.WriteLine("Введите число:");

            while (true)
            {
                Number = Int16.Parse(Console.ReadLine());
                if (Number > RandomNumb)
                {
                    Console.WriteLine("Число больше загаданного");
                }

                if (Number < RandomNumb)
                {
                    Console.WriteLine("Число меньше загаданного");
                }

                if (Number == RandomNumb)
                {
                    Console.WriteLine("Число угадано");
                    break;
                }

            }
        }
    }

    //4.Выведите все точные квадраты натуральных чисел,
    //которые (квадраты) меньше заданного числа N. (натуральные - это числа, которые мы используем при счёте: 1, 2, 3 и т.д.) 
    static class SquareNumber
    {
        static int Number = 100;

        public static void Output()
        {
            Console.WriteLine("Число: {0}", Number);
            int ch = 1;
            while (Math.Sqrt(ch) < Number)
            {
                ch++;
                if (ch * ch < Number)
                {
                    Console.WriteLine(ch * ch);
                }
            }
        }
    }

    //5.Прочитать с клавиатуры 5 целых чисел, посчитать их среднее арифметическое и сообщить его пользователю
    static class AverageValue
    {
        static int[] array = new int[5];

        public static void Output()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                sum += array[i];
            }
            Console.WriteLine("среднее арифметическое : {0}", sum / array.Length);
        }
        public static void Output(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("среднее арифметическое : {0}", sum / array.Length);
        }
    }

    //7.У гусей и кроликов вместе 64 лапы. Сколько может быть кроликов и гусей (указать все сочетания)?
    static class GR
    {
        public static void Output()
        {

            int i = 0;
            int j = 0;
            int count = 0;

            for (i = 0; i < 16; i++)
            {
                for (j = 0; j < 32; j++)
                {
                    if (4 * i + 2 * j == 64)
                    {
                        count++;
                        Console.WriteLine(" {0} :  кроликов: {1}   гусей: {2} ", count, i, j);
                    }
                }
            }
        }
    }

    //8.Напишите программу, которая будет «спрашивать» правильный пароль, до тех пор, пока он не будет введен.
    //Правильный пароль пусть будет «root». Если пароль не верный, программа должна сказать "Неверный пароль!" 
    static class Password
    {
        static string password = "";

        public static void Check()
        {
            while (true)
            {
                Console.WriteLine("Введите пароль: ");

                password = Console.ReadLine();

                if (password == "root")
                {
                    Console.WriteLine("Правильный пароль");
                    break;
                }

                else if (password != "root")
                {
                    Console.WriteLine("Вы ввели неверный пароль!");
                }
            }
        }
    }
}
