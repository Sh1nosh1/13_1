using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13__1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student1 = new Student();
                student1.Surname = "Markov";
                student1.Course = 3;
                WriteLine($"{student1.ToString()}");
                Student student2 = new Student();
                student2.Surname = "";
                student2.Course = -2;
                WriteLine($"{student2.ToString()}");
                while (true)
                {
                    Write("Enter surname: ");
                    string surname = ReadLine();
                    Write("Enter course: ");
                    sbyte course = Convert.ToSByte(ReadLine());
                    Student student3 = new Student(surname, course);
                    WriteLine($"\n{student3.ToString()}");
                }


            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
