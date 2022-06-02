using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class Tiger : Tank
    {
        public int Quantity { get; set; } // количество выпущенных танков
        public int Crew { get; set; } // экипаж танка
        public Tiger() : base()
        {
            Type = "Тяжелый";
            Country = "Германия";
            Weight = 57000;
            Quantity = 1347;
            Crew = 5;
        }
        public static string Description()
        {
            return "Panzerkampfwagen VI Ausf.H — E, «Тигр» — немецкий тяжёлый танк времён Второй мировой войны, " +
                "прототипом которого являлся танк VK4501 (H)," +
                " разработанный в 1942 году фирмой «Хеншель». Наряду с прототипом фирмы «Хеншель» руководству Рейха" +
                " был представлен и проект Фердинанда Порше — VK4501 (P), но выбор военной комиссии пал на вариант «Хеншель».";
        }

        public override string Info()
        {
            return $"{base.Info()},Кол-во выпущенных экземпляров: {Quantity}, Кол-во членов экипажа на один танк: {Crew}";
        }
    }
}
