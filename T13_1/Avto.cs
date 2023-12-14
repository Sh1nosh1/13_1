using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13_1
{
    class Avto
    {
        /// <summary>
        /// brand
        /// </summary>
        private string brand;
        public string Brand { get => brand; set => brand = value; }
        /// <summary>
        /// color
        /// </summary>
        private string color;
        public string Color { get => color; set => color = value; }
        /// <summary>
        /// speed
        /// </summary>
        private int speed;
        public int Speed { get => (speed>=20)&(speed<=120) ? speed : 0 ; set => speed = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Avto() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="color"></param>
        /// <param name="speed"></param>
        public Avto(string brand, string color, int speed)
        {
            this.Brand = brand;
            this.Color = color;
            this.Speed = speed;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void ShowInfo()
        {
            WriteLine($"Brand: {Brand}\nColor: {Color}\nSpeed: {Speed} km/h\n");
        }
    }
}
