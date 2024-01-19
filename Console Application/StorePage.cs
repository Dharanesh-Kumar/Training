/* Project Description: Online store
 * Author : DHARANESH T K
 * Created Date: 18.11.2022
 * Modified Date : 20.11.2022
 * Reviewed by :
 * Reviewed Date : */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore;

namespace OnlineSystem
{
    public class StorePage
    {
        public StorePage() //Constructor
        {
            Console.WriteLine("Welcome to Online Store\nEnter Username and Password");
            Login();
        }
        public void Login()
        {
            var username = Console.ReadLine();
            var password = Convert.ToInt16(Console.ReadLine());
            var Username = "Dharan@123";
            int Password = 1234;
            var user2 = "Priya@23";
            var Password2 = 2311; 
            if ((username == Username && password == Password)|| (username == user2 && password == Password2))
            {
                Display(); 
            }
            else
            {
                Console.WriteLine("Please, Enter Valid Username and Password...");
                Login();
            }
        }
        public static void Display()
        {
            Console.WriteLine("List of Category");
            Console.WriteLine("1. Electronics");
            Console.WriteLine("2. Furniture");
            Console.WriteLine("3. Appliances");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Electronics obj = new Electronics();
            }
            else if (input == 2)
            {
                Furniture obj = new Furniture();
            }
            else if( input == 3)
            {
                Appliances obj = new Appliances();
            }
            else
            {
                Display();
            }
        }
    }
}
