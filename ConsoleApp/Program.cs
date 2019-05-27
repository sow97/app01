using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = chrome.FindElement(By.Name("q"));
            element.SendKeys("Gym Near To Me");
            element.SendKeys(Keys.Enter);
            Console.ReadKey();
         

        }
    }
}
