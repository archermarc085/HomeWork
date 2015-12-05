using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayNSP.Output();

            #region Task1
            Task1.Number.Output();

            Task1.FeedAnimals.Feeding();

            Task1.Seasons.ChooseSeason();

            Task1.GoodOrBad.Output();

            Task1.Weeks.Output();

            Task1.Taxi.Consider();

            Task1.SimpleNumber.CheckNumberIsSimple();

            Task1.Lottery.Won();

            Task1.EchangeMoney.Exchange();
            #endregion
            Console.WriteLine();

            #region Task2
            Task2.Multiplication.Multiple();
            Task2.LevelofNumber.Output();

            Random rand = new Random();
            /*  int RandomNumb = rand.Next(1,147);
              Task2.RandomNumber.Rand(RandomNumb);*/

            Task2.SquareNumber.Output();

            Task2.AverageValue.Output();

            //6.Создать 5 случайных целых чисел, посчитать их среднее арифметическое и сообщить его пользователю 
            int[] array = { rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100) };
            Task2.AverageValue.Output(array);

            Task2.GR.Output();

            Task2.Password.Check();
            #endregion

            Console.ReadKey();
        }
    }
}
