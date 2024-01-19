using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore
{
    public class Furniture
    {
        public Furniture() 
        {
            Console.WriteLine("List of Furniture");
            Console.WriteLine(" S.No       Product          Price ");
            Console.WriteLine("  1          Sofa           ₹16,999");
            Console.WriteLine("  2       Study Desks       ₹9,999");
            Console.WriteLine("  3        Wardrobes        ₹19,999");
            var input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Sofa - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 16999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if (input == 2)
            {
                Console.WriteLine("Study Desks - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 9999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if (input == 3)
            {
                Console.WriteLine("Wardrobes - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 19999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else
            {
                Furniture obj = new Furniture();
            }
        }
    }
}
