using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conveer
{
    class Salon
    {
        public void Obtaj(int avt)
        {
            if (avt == 1)
            {
                Console.WriteLine("Салон обтянут кожезаменителем");
            }
            else if (avt == 2)
            {
                Console.WriteLine("Салон обтянут кожей");
            }
            else if (avt == 3)
            {
                Console.WriteLine("Салон обтянут алькантарой");
            }
            else
            {
                throw new Exception();
            }
        }
    }
    class Bagaj
    {
        public void Obtaj(int avt)
        {
            if (avt == 1)
            {
                Console.WriteLine("Багажник обтянут кожезаменителем");
            }
            else if (avt == 2)
            {
                Console.WriteLine("Багажник обтянут кожей");
            }
            else if (avt == 3)
            {
                Console.WriteLine("Багажник обтянут алькантарой");
            }
            else
            {
                throw new Exception();
            }
        }
    }
    class Capot
    {
        public void Ustanovka_motora(int avt)
        {
            if (avt == 1)
            {
                Console.WriteLine("Установка 100-сильного мотора");
            }
            else if (avt == 2)
            {
                Console.WriteLine("Установка 150-сильного мотора");
            }
            else if (avt == 3)
            {
                Console.WriteLine("Установка 200-сильного мотора");
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public class Conveer
    {
        Salon salon = new Salon();
        Bagaj bagaj = new Bagaj();
        Capot capot = new Capot();

        public int Offer()
        {
            Console.WriteLine("Введите комплектацию авто \n 1-Дешовая \n 2-Средняя \n 3-Дорогая");
            int avt = Convert.ToInt32(Console.ReadLine());
            if (avt != 1 && avt != 2 && avt != 3)
            {
                throw new Exception();
            }

            return avt;
        }
        public void Sborka(int avt)
        {
            salon.Obtaj(avt);
            bagaj.Obtaj(avt);
            capot.Ustanovka_motora(avt);
        }
        public void Svarka()
        {
            Console.WriteLine("Машина собрана");
        }
    }
}
