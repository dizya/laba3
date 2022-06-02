using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class Tank
    {
        public string Type { get; set; }
        public string Country { get; set; }
        public int Weight { get; set; }
        public Tank() { }

        public Tank(string type)
        {
            Type = type;
        }

        public Tank(string type, string country)
        {
            Type = type;
            Country = country;
        }
        public Tank(string type, string country, int weight)
        {
            Type = type;
            Country = country;
            Weight = weight;
        }

        public virtual string Info() //метод вывода краткой информации о танке
        {
            return $"Тип: {Type}, Страна: {Country}, Вес: {Weight}";
        }
    }
}
