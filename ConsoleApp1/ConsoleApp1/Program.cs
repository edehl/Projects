using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
namespace ConsoleApp1
{
    class Program
    {
        private static IWebDriver driver;

        static void Main(string[] args)
        {
            Setup();
            RunBot();
            Console.ReadLine();
            driver.Close();
        }

        static private void Setup()
        {
            driver = new FirefoxDriver();
        }

        static private void RunBot()
        {
            driver.Navigate().GoToUrl("http://www.supremenewyork.com");
            Console.WriteLine("At www.supremenewyork.com");
        }
    }
}
