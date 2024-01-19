using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore
{
    public class Mobile
    {
        public Mobile()
        {
            Console.WriteLine(" S.No    Brand     Specification      Price");
            Console.WriteLine("  1      ASUS        3G & 32GB        ₹9,999");
            Console.WriteLine("  2      Redmi       4G & 64GB        ₹14,999");
            Console.WriteLine("  3      RealMe      4G & 64GB        ₹13,999");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Asus Mobile - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 9999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if (input == 2)
            {
                Console.WriteLine("Redmi Mobile - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 14999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if(input == 3)
            {
                Console.WriteLine("Realme Mobile - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 13999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else
            {
                Mobile obj = new Mobile();
            }
        }
    }
    public class HeadPhone
    {
        public HeadPhone() 
        {
            Console.WriteLine(" S.No    Brand      Price");
            Console.WriteLine("  1      Boat       ₹999");
            Console.WriteLine("  2      Noise      ₹1,200");
            Console.WriteLine("  3      Ptron      ₹899");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Boat Headphone - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if (input == 2)
            {
                Console.WriteLine("Noise Headphone - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 1200 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if(input == 3)
            {
                Console.WriteLine("Ptron Headphone - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 899 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else
            {
                HeadPhone obj = new HeadPhone();
            }
        }
    }
    public class Laptop
    {
        public Laptop() 
        {
            Console.WriteLine(" S.No    Company     Specification      Price");
            Console.WriteLine("  1      Lenovo         AMD-A6         ₹27,000");
            Console.WriteLine("  2       Dell         Intel[i3]       ₹37,999");
            Console.WriteLine("  3        HP          Intel[i3]       ₹44,366");
            var input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Lenovo Laptop - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine()); 
                int amt = 27000*Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if(input == 2)
            {
                Console.WriteLine("Dell Laptop - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 37999 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else if(input == 3)
            {
                Console.WriteLine("HP Laptop - Payment Path");
                Console.WriteLine("Enter number of Quantity");
                int Quantity = Convert.ToInt32(Console.ReadLine());
                int amt = 44366 * Quantity;
                Console.WriteLine("Total Amount :" + amt);
                Payment obj = new Payment();
                obj.PaymentPath(amt);
            }
            else
            {
                Laptop obj = new Laptop();
            }
        }
    }
    public class Electronics
    {
        public Electronics() 
        {
            Console.WriteLine("List of Electronic");
            Console.WriteLine("1. Laptop\n2. Headphones\n3. Moblie");
            var input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Laptop obj1 = new Laptop();
            }
            else if(input == 2)
            {
                HeadPhone obj3 = new HeadPhone();
            }
            else if(input == 3 )
            {
                Mobile obj3 = new Mobile();
            }
            else
            {
                Electronics obj = new Electronics();
            }
        }
    }
}