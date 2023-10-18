using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cashInserted = 0;

            List<string> stockNameList = new List<string>
            {
                "Skittles",
                "Pringles",
                "Pepsi",
                "Fanta",
                "Water",
                "Snickers",
                "Twix",
                "Wotsits",
                "Doritos",
                "Kitkat",
                "Mars",
                "Bounty"
            };

            List<double> stockPriceList = new List<double>
            {
                1.50, //skittles
                2.00, //pringles
                1.20, //pepsi
                1.20, //fanta
                1.00, //water
                1.35, //snickers
                1.50, //malteasers
                2.00, //wotsits
                2.00, //doritos
                1.35, //kitkat
                1.20, //starburst
                1.00  //bounty
            };

            writeMenu(stockNameList, stockPriceList);

            
            Console.ReadLine();
        }

        static void insertCash(ref double moneyInserted)
        {
            Console.Clear();
            Console.WriteLine("The machine only accepts the following coins: 5p, 10p, 20p, 50p, £1, and £2.");

            Console.WriteLine("\n Please insert a coin: ");

            double coin;

            try
            {
                coin = double.Parse(Console.ReadLine());
            } catch
            {
                coin = 3;
            }

            switch(coin)
            {
                default:
                    Console.WriteLine("thats not a real coin");
                    break;
            }
        }
        static void writeMenu(List<string> stock, List<double> price)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("                   \n ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" VENDING MACHINE ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" \n                   ");

            for (int i = 0; i < stock.Count; i++)
            {
                Console.Write("\n ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" " + stock[i] + " - £" + price[i] + " ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                Console.SetCursorPosition(18, (i+2));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(' ');
                Console.SetCursorPosition(0, (i + 3));
                
            }

            Console.SetCursorPosition(18 ,Console.CursorTop);
            Console.WriteLine(" \n                   \n");
            Console.BackgroundColor= ConsoleColor.Black;
            
            Console.WriteLine("Please choose an option: \n1. Insert Coins\n2. Select Product\n3. Exit");

            int choice = 0;

            try
            {
                choice = int.Parse(Console.ReadLine());
                
            } catch
            {
                choice = 4;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("switch 1");
                    break;
                case 2:
                    Console.WriteLine("switch 2");
                    break;
                case 3:
                    Console.WriteLine("switch 3");
                    break;
                default:
                    writeMenu(stock, price);
                    break;
            }
        }
    }
}
