using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    class Program
    {
        static void Main(string[] args)
        {   
            #region первое задание
            Console.WriteLine("1. Определение является ли число четным / нечетным \nПожалуйста введите целое число:");
            bool userData = int.Parse(Console.ReadLine()) % 2 == 0;
            string result = userData ? "Введеное число четное" : "Введеное число нечетное";
            Console.WriteLine(result);
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
            #endregion 
            #region второе задание
            Console.WriteLine("2. Подсчет очков в карточной игре \"21\" \nДоброго времени суток! Сколько карт у вас на руках? ");
            int cardsCount = int.Parse(Console.ReadLine());
            int cardsCountSumm = 0;
            Console.WriteLine("Введите номинал карты:");
            for (int i = 0; i < cardsCount; i++)
            {
                Console.WriteLine("Введите номинал следующей карты:");
                string userInput = Console.ReadLine();
                switch (userInput.ToUpper())
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        cardsCountSumm += 10;
                        break;
                    default:
                        cardsCountSumm += int.Parse(userInput);
                        break;
                }
            }
            Console.WriteLine($"Суммарное количество очков всех карт у вас в руке = {cardsCountSumm}");
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
            #endregion
            #region третье задание
            Console.WriteLine("3. Проверка является ли число \"Простым\" \nВведите число: ");
            int userIntInput = int.Parse(Console.ReadLine());
            int count = 1;
            bool isNumberSimple = false;
            while (count < userIntInput -1)
            {
                count += 1;
                if (userIntInput % count == 0) {
                    isNumberSimple = true;
                    break;
                }
            }
            string simpleResult = isNumberSimple ? "Введеное число не является простым" : "Введеное число простое";
            Console.WriteLine(simpleResult);
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
            #endregion
            #region четвертое задание
            Console.WriteLine("4. Вывести наименьший элемент в последовательности \nВведите количество элементов в последовательности:");
            int elementCount = int.Parse(Console.ReadLine());
            int MinValue = int.MaxValue;
            for (int i = 0; i < elementCount; i++)
            {
                Console.WriteLine($"Введите число #{i+1}: ");
                int userValue = int.Parse(Console.ReadLine());
                if (userValue < MinValue) {
                    MinValue = userValue;
                }
            }
            Console.WriteLine($"Минимальным числом в введеной последовательности чисел является: {MinValue}");
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
            #endregion
            #region пятое задание
            Console.WriteLine("5. Игра \"Угадай число\" \nЧто бы завершить игру в любой момент, вместо ввода числа нажмите клавишу ввода. \nВведите максимальное число. Загаданное число будет в дипазоне от нуля до введенного вами числа:");
            int userMaxValue = int.Parse(Console.ReadLine())+1;
            Random randomNumber = new Random();
            int getSecretNumber =  randomNumber.Next(0, userMaxValue);
            while (true)
            {
                Console.WriteLine("Введите число:");
                string userGuessedNumber = Console.ReadLine();
                if (userGuessedNumber == "")
                {
                    Console.WriteLine($"Вы не угадали загаданное число. Это было число: {getSecretNumber}");
                    break;
                }
                else if (int.Parse(userGuessedNumber) == getSecretNumber) {
                    Console.WriteLine($"Поздравляю! Вы угадали загаданное число. Это число: {getSecretNumber}!");
                    break;
                }
                else
                {
                    if (int.Parse(userGuessedNumber) > getSecretNumber) {
                        Console.WriteLine("Загаданное число меньше");
                    } else {
                        Console.WriteLine("Загаданное число больше");
                    }
                }
            }
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
            #endregion
        }
    }
}
