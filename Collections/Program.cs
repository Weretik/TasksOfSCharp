﻿using System.Text;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /*
             * Завдання 2

                Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть колекцію MyList. 
                Реалізуйте у найпростішому наближенні можливість використання її екземпляра аналогічно екземпляру класу List. 
                Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента,
                індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів. 
                Реалізуйте можливість перебору елементів колекції у циклі наперед.
            */

            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(12);
            myList.Add(6);
            myList.Add(25);

            Console.WriteLine($"Довжина колекції: { myList.Lenth}");
            Console.WriteLine($"Перший елемент масиву: {myList[0]}");
            Console.WriteLine("Весь масив:");
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }

            /*
             * Завдання 3 

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть колекцію MyDictionary. Реалізуйте у найпростішому наближенні можливість використання її екземпляра аналогічно екземпляру класу Dictionary. 
            Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, 
            індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів. 
            Реалізуйте можливість перебору елементів колекції у циклі наперед.
            */

            MyDictionary<string, int> myDict = new MyDictionary<string, int>();

            myDict.Add("Молоко", 5);
            myDict.Add("Сахар", 10);
            myDict.Add("Йогурт", 15);

            Console.WriteLine("Кількість елементів: " + myDict.Count);

            Console.WriteLine("1-й елемент за індексом: " + myDict[0]);

            Console.WriteLine("\nПеребір елементів:");
            myDict.Iterate();
            /*
             * Завдання 4 

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…} З
            астосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому завданні 2 для даного уроку. 
            Виведіть на екран значення елементів масиву, який повернув метод GetArray(), що розширює метод.
            */
            Console.WriteLine();
            int[] array = myList.GetArray();

            Console.WriteLine("Елементи масиву що розширює метод:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
    public static class Extensions
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            List<T> tempList = new List<T>();
            foreach (var item in list)
            {
                tempList.Add(item);
            }
            return tempList.ToArray();
        }
    }
}
