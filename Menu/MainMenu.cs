using Logic;
using System;
using Data;

const string Path = "D:\\Data.json";

static void ConvertMenu()
{
    LibraryLogic libraryLogic = new LibraryLogic();
    int choice = -1;
    Console.WriteLine("1. Из десятичной в двоичную систему счисления ");
    Console.WriteLine("2. Из десятичной в шестиричную систему счисления ");
    Console.WriteLine("3. Из десятичной в восьмеричную систему счисления ");
    Console.WriteLine("4. Из десятичной в двенадцатиричную систему счисления ");
    Console.WriteLine("5. Из десятичной в шестнадацитирчную систему счисления ");
    Console.WriteLine("6. Из десятичной в в другую систему счисления ");
    Console.WriteLine("0. вернуться в главное меню ");
    choice = Convert.ToInt16(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Clear();
            libraryLogic.ConvertToBase(2, Path);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            break;
        case 2:
            Console.Clear();
            libraryLogic.ConvertToBase(6, Path);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            break;
        case 3:
            Console.Clear();
            libraryLogic.ConvertToBase(8, Path);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            break;
        case 4:
            Console.Clear();
            libraryLogic.ConvertToBase(12, Path);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            break;
        case 5:
            Console.Clear();
            libraryLogic.ConvertToBase(16, Path);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            break;
        case 6:
            Console.Clear();
            int baseValue = -1;
            Console.WriteLine("В какую систему счсиления хотите перевести число? ( от 2 до 32 )");
            Console.Write("Ввод >> ");
            baseValue = Convert.ToInt16(Console.ReadLine());
            while (baseValue < 2 || baseValue > 32)
            {
                Console.Clear();
                Console.WriteLine("В какую систему счисления хотите перевести число? (от 2 до 32)");
                Console.Write("Ввод >> ");
                baseValue = Convert.ToInt16(Console.ReadLine());
            }
            libraryLogic.ConvertToBase(baseValue, Path);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            break;
        case 0:
            MainMenu();
            break;
    }
}


static void MainMenu()
{
    Console.Clear();
    int choice;
    LibraryData libraryData = new LibraryData("");
    Console.WriteLine("1 - Перевести число в другую систему счисления ");
    Console.WriteLine("2 - Просмотреть историю ");
    Console.WriteLine("_ - Выйти из приложения ");
    choice = Convert.ToInt16(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Clear();
            ConvertMenu();
            MainMenu();
            break;
        case 2:
            Console.Clear();
            libraryData.Read(Path);
            MainMenu();
            break;
        default:
            break;
    }
}

MainMenu();