using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersService
{
    class Review
    {
        public void answer()
        {
            Console.WriteLine("Ваше мнение очень важно для нас");
        }
    }
    class TechSupport
    {
        public void answer()
        {
            Console.WriteLine("Расскажите о вашей проблеме");

        }
    }
    class Billing
    {
        public void answer()
        {
            Console.WriteLine("Поздравляю вы оплатили счета");

        }

    }

    public class Service
    {
        Review review = new Review();
        TechSupport techSupport = new TechSupport();
        Billing billing = new Billing();   

        public int Offer()
        {
            Console.WriteLine("Вас приветсвует служба поддержки нажмите на: " +
                "\n 1-если хотите обратится в тех. поддержку " +
                "\n 2-если хотте оставить отзыв " +
                "\n 3-если хотите оплатить счет ");
            int off = Convert.ToInt32(Console.ReadLine());
            if (off != 1 && off != 2 && off != 3)
            {
                throw new Exception();
            }

            return off;
        }

        public void Ansver(int off)
        {
            if(off == 1)
            {
                Console.WriteLine("Вас отправляют в  тех. поддержку");
                techSupport.answer();

            }
            else if (off == 2)
            {
                Console.WriteLine("Вы можете оставить отзыв");
                review.answer();

            }
            else if (off == 3)
            {
                Console.WriteLine("Вы можете оплатить счет");
                billing.answer();
            }
            else
            {
                throw new Exception();
            }
        }

    }
}
