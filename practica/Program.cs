//Библиотеки
using System;

//Папка
namespace practica
{
    //Класс -- название программы
    class Program
    {
        //Без Main не будет запущена программа, это одно из главных тел программы
        static void Main()
        {
            //Вывод в консоль
            //\n -- перевод на следущую строку
            Console.Write("Hello 2\n");
            Console.WriteLine("Hello!!");
            //Ожидания когда пользователь введёт символ в консоль
            Console.ReadKey();
            //Ожидания когда пользователь введёт символ в консоль и нажмёт enter
            Console.ReadLine();
        }
    }
}