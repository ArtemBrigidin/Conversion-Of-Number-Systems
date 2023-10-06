using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Logic
{
    public class LibraryLogic
    {

        public void ConvertToBase(int baseValue, string Path) // Метод для конвертации числа в другую систему счисления (baseValue - C.C. в которую нужно перевести)
        {
            Console.WriteLine($"Введите десятичное число, которое нужно перевести в {baseValue}-ичную систему счисления >> ");
            int before = Convert.ToInt32(Console.ReadLine()); // Ввод десятичного числа, которое нужно перевести
            int x = before; // X - копия числа для вычисления
            string baseResult = ""; // Переменная для хранения результата конвертации

            while (x > 0)
            {
                int digit = x % baseValue; // Вычисление остатка от деления числа на baseValue
                baseResult = GetChar(digit) + baseResult; // Добавление числа (или символа) к результату
                x /= baseValue; // Целочисленное деление числа на baseValue
            }

            string result = $"Из десятичного числа - {before} перевели в {baseValue}-ичное число - {baseResult}"; // Формирование результата
            LibraryData mainData = new LibraryData(result); // Создание объекта для записи в историю
            mainData.Save(Path); // Сохранение результата в json
            Console.WriteLine(result); // Вывод результата в консоль
        }

        private char GetChar(int number)
        {
            if (number >= 10)
            {
                return (char)('A' + number - 10); // Если number больше или равен 10, то возвращаем символ (букву)
            }
            return number.ToString()[0]; // Возвращаем цифру как символ
        }
    }
}
