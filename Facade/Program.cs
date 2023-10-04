using conveer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conveer con = new Conveer();

            Console.WriteLine("Введите комплектацию авто \n 1-Дешовая \n 2-Средняя \n 3-Дорогая");
            int avt = Convert.ToInt32(Console.ReadLine());
            if (avt != 1 && avt != 2 && avt != 3)
            {
                throw new Exception();
            }
            con.sborka(avt);
            con.svarka();
        }
    }
}
