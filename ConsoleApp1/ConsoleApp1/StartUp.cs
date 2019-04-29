using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Bot1 bot = new Bot1(false);
            bot.RunBot();
            Console.ReadLine();
            bot.Close();
        }
    }
}
