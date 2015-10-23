using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace View
{
    class Program
    {

        static void Main(string[] args)
        {
            int menu = 0;
            Console.WriteLine("Input age of cat");
            Cat cat = new Cat(Console.ReadLine());

            do
            {
                Console.WriteLine("\nName: {0}", cat.Name);
                Console.WriteLine("Age: {0}", cat.Age);
                Console.WriteLine("Current Color: {0}", cat.CurrentColor);
                Console.WriteLine();
                Console.WriteLine("1) Input name");
                Console.WriteLine("2) Change color");
                Console.WriteLine("3) Punish");
                Console.WriteLine("4) Feed");
                Console.WriteLine("5) Exit");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        cat.Name = Convert.ToString(Console.ReadLine());
                        break;
                    case 2:
                        
                        cat.CurrentColor = Convert.ToString(Console.ReadLine());
                        break;
                    case 3:
                        cat.Punish();
                        break;
                    case 4:
                        cat.Feed();
                        break;
                }
            } while (menu!=5); 
            Console.ReadKey();
        }
    }
}
