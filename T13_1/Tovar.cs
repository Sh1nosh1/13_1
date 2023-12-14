using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13_1
{
    class Tovar
    {
        /// <summary>
        /// Name with settings
        /// </summary>
        string name;
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Price with settings
        /// </summary>
        int price;
        public int Price { get => (price >= 1) & (price <= 10) ? price : 0; set => price = value; }
        /// <summary>
        /// KVO with settings
        /// </summary>
        int kvo;
        public int Kvo { get => (kvo >= 0) & (kvo <= 10) ? kvo : 0; set => kvo = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Tovar() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="kvo"></param>
        public Tovar(string name, int price, int kvo)
        {
            this.Name = name;
            this.Price = price;
            this.Kvo = kvo;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"\nName: {Name}\nPrice: {Price}\nKVO: {Kvo}\n");
        }
        /// <summary>
        /// Count cost
        /// </summary>
        /// <returns></returns>
        public int Cost()
        {
            return Price * Kvo;
        }
    }
}
