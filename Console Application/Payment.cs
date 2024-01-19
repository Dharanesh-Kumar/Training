using OnlineSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore
{
    public class Payment
    {
        public void PaymentPath(int amt)
        {
            Console.WriteLine("Enter amount:");
            var amount = Convert.ToInt32(Console.ReadLine());
            if(amt == amount)
            {
                Console.WriteLine("     Order Placed\n Order Delivered Soon!!!");
                Extra();
            }
            else
            {
                Console.WriteLine("Please, Enter Valid Amount");
                PaymentPath(amt);
            }
        }
        public void Extra()
        {
            Console.WriteLine("Click 1 for further order");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                StorePage.Display();
            }
            else
            {
                Console.WriteLine("Thanks for Choosing Online Store");
            }
        }
    }
}
