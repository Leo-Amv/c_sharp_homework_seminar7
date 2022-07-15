namespace Homework
{
    class Text
    {
        /// <summary>Метод выводит в консоль меню домашнего задания</summary>
        public static void Menu()
        {
            Console.WriteLine("\nSELECT A MENU ITEM AND PRESS THE CORRESPONDING KEY:\n");
            Console.WriteLine("If you want to choose Task47 press the button:\t1");
            Console.WriteLine("If you want to choose Task50 press the button:\t2");
            Console.WriteLine("If you want to choose Task52 press the button:\t3");
            Console.WriteLine("\nIf you want to exit program press any other button");
        }
        /// <summary>Метод выводит в консоль условие задачи 47</summary>
        public static void Task47()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 47. Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.");
        }
        /// <summary>Метод выводит в консоль условие задачи 50</summary>
        public static void Task50()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        }
        /// <summary>Метод выводит в консоль условие задачи 52</summary>
        public static void Task52()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце");
        }
    }
}