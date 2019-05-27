using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp
{
    class Prgrm2
    {
        static void Main(string[] args)
        {

            IWebDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("http://localhost/CapgeminiWebApp01/StateMangement/QueryStringDemo/ex01.aspx");
            IWebElement element1 = chrome.FindElement(By.Name("TextBox1"));
            element1.SendKeys("sowmya");
            IWebElement button1 = chrome.FindElement(By.Name("Button1"));
            button1.Click();
            Console.ReadKey();
        }
    }
}
