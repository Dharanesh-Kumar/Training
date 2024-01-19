using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore
{
    public class Appliances
    {
        public void Dishwashers()
        {
            Console.WriteLine("S.No     Brand       Specification      Price");
            Console.WriteLine(" 1       Bosch          13 Place        ₹40,000");
            Console.WriteLine(" 2       Voltas         12 Place        ₹27,399");
            int input =Convert.ToInt32(Console.ReadLine());
            if(input ==1)
            {
                Console.WriteLine("Bosch Diswasher - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 40000 * Quantity;
                Console.WriteLine("Total Amount :" +amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if (input == 2)
            {
                Console.WriteLine("Voltas Diswasher - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 27399 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else
            {
                Dishwashers();
            }
        }
        public void Refrigerators()
        {
            Console.WriteLine("S.No     Brand       Specification      Price");
            Console.WriteLine(" 1       Godrej          190 L         ₹16,290");
            Console.WriteLine(" 2        LG             190 L         ₹12,990");
            Console.WriteLine(" 3      Whirlpool        240 L         ₹26,790");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Godrej Refrigerators - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 16290 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if (input == 2)
            {
                Console.WriteLine("LG Refrigerators - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 12990 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if (input == 3)
            {
                Console.WriteLine("Godrej Refrigerators - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 26790 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else
            {
                Refrigerators();
            }
        }
        public void Television()
        {
            Console.WriteLine("S.No     Brand      Specification      Price");
            Console.WriteLine(" 1       Acer         50 inches       ₹31,999");
            Console.WriteLine(" 2       Redmi        32 inches       ₹12,999");
            Console.WriteLine(" 3       Sony         43 inches       ₹47,000");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Acer TV - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 31999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            if (input == 2)
            {
                Console.WriteLine("Redmi TV - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 12999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            if (input == 3)
            {
                Console.WriteLine("Sony TV - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 47000 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else
            {
                Television();
            }    
        }
        public Appliances() 
        {
            Console.WriteLine("List of Appliances");
            Console.WriteLine("1. Television\n2. Refrigerators\n3.Dishwashers");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Television();
            }
            else if(input == 2)
            {
                Refrigerators();
            }
            else if(input == 3)
            {
                Dishwashers();
            }
            else
            {
                Appliances obj = new Appliances();
            }
        } 
    }
}
