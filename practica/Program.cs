//Библиотеки
using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

//Первый урок 

//Папка
/*namespace practica
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
}*/

//Второй урок

namespace practica
{
    class Program
    {
        static void Main()
        {
            //Челочислинное number
            int number;
            //В байт нельзя хранить число больше 256
            //Позволяет хранить диапозон данных от 0 до 33000
            short number_3 = 256;
            Console.WriteLine(number_3);
            //Позволяет хранить очень огромный диапозон данных
            long number_4 = 900;
            Console.WriteLine(number_4);
            //Позволяет хранить дробное число
            double num = 3923.323;
            Console.WriteLine(num);
            //ПОзволяет хранить строку
            string word = "Привет!!!";
            Console.WriteLine(word);
            //Позволяет хранить символы
            char word_1 = 'h';
            Console.WriteLine(word_1);

            //TRue - False
            bool isHappy = false;
            Console.WriteLine(isHappy);


            number = 10;
            Console.WriteLine(number);
            number = 5;
            Console.WriteLine("Переменная number:: " + number);

            // Console.ReadKey();

            int num_1, num_2;

            num_1 = Convert.ToInt32(Console.ReadLine());
            num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число " + num_1 + " Второе число " + num_2);
        }
    }
}