using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1

                /*Student student1 = new Student();
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
                }*/

                //Task 2

                /*Avto avto = new Avto("BMW", "Blue", 110);
                avto.ShowInfo();*/

                //Task 3
                while (true)
                {
                    Write("Enter Model: ");
                    string model = ReadLine();
                    Write("Enter Ram: ");
                    sbyte ram = Convert.ToSByte(ReadLine());
                    Write("Enter Hdd: ");
                    int hdd = Convert.ToInt32(ReadLine());
                    Computer computer = new Computer(model, ram, hdd);
                    computer.ShowInfo();
                }

                //Task 4

                /*while (true)
                {
                    Write("Enter name: ");
                    string name = ReadLine();
                    Write("Enter price: ");
                    sbyte price = Convert.ToSByte(ReadLine());
                    Write("Enter kvo: ");
                    sbyte kvo = Convert.ToSByte(ReadLine());
                    Tovar tovar = new Tovar(name, price, kvo);
                    tovar.Output();
                    WriteLine($"Cost: {tovar.Cost()}\n");
                }*/

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
