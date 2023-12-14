using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13_1
{
    class Computer
    {
        /// <summary>
        /// Model with settings
        /// </summary>
        string model;
        public string Model { get => model; set => model = value; }
        /// <summary>
        /// Ram with settings
        /// </summary>
        int ram;
        public int Ram { get => (ram>=2)&(ram<=32) ? ram: 0; set => ram = value; }
        /// <summary>
        /// HDD with settings
        /// </summary>
        int hdd;
        public int Hdd { get => (hdd>=200)&(hdd<=2000) ? hdd : 0; set => hdd = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Computer() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="model"></param>
        /// <param name="ram"></param>
        /// <param name="hdd"></param>
        public Computer(string model, int ram, int hdd)
        {
            this.Model = model;
            this.Ram = ram;
            this.Hdd = hdd;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void ShowInfo()
        {
            WriteLine($"Model: {Model}\nRam: {Ram} gb\nHdd: {Hdd} gb\n");
        }

    }
}
