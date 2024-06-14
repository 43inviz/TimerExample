using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;// пространство имен в котором находится Timer
using System.Runtime.InteropServices;

namespace TimerEx
{
    internal class Program
    {
        //Класс Timer
        //Необходим для выполнения любого блока кода с одинаковым интервалом
        static void Main(string[] args)
        {
            //Методы класса
            //Dispose() - прекращение работы таймера,освобождение ресурсов
            //Change(int,int) - изменение интервала (1 - задержка,2 - интервал)

            //пример работы с методом

            Timer timer = new Timer(Method, null, 0, 1000);

            //Параметры: 
            //1 - Метод для вызова
            //2 - Обьект если нужен/null
            //3 - Время в миллисекундах сколько таймер ждет перед началом выполнения метода
            //4 - Интервал с которым будет вызван метод


            //Пример работы с использованием обьекта в методе
            Student student = new Student("Alex");
            Timer timer2 = new Timer(showStudentInfo, student, 0, 1000);
           
            

            Console.ReadKey();

        }

        public static void showStudentInfo(object student)
        {
            if (student != null)
            {
                Console.WriteLine(student.ToString());
            }
        }

        

        public static void Method(object obj)
        {
            Console.WriteLine("123");
        }
    }

    internal class Student
    {
        public string Name { get; set; }
        public Student(string name) { Name = name; }
        public override string ToString()
        {
            return $"Student name: {Name}";
        }
        
    }
}
