using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace ConsoleApp1
{
    class Bot1
    {
        private IWebDriver driver;

        public Bot1(bool isHeadless)
        {
            ChromeOptions options = new ChromeOptions();
            if(isHeadless)
                options.AddArgument("headless");
            driver = new ChromeDriver(options);
        }
        /*
        static void Main(string[] args)
        {
        }
        */

        public void RunBot()
        {
            driver.Navigate().GoToUrl("https://www.supremenewyork.com/shop/all/sweatshirts");
            Console.WriteLine("At www.supremenewyork.com");
            IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Id("container"));
            foreach(IWebElement element in elements)
            {
                Console.Write(element.Text);
                string imageLocation = element.FindElement(By.XPath("//div/a/img")).GetAttribute("src");
                //Uri imageURI = new Uri(imageLocation);
                Console.Write(imageLocation);
                
            }
        }

        public void GetImage()
        {

        }

        public void Close()
        {
            driver.Dispose();
        }
    }
}
