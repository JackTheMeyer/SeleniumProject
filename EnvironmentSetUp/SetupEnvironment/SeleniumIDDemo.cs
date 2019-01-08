using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{
    public class SeleniumIDDemo
    {
        static void Main()
        {
            string url = "http://testing.todorvachev.com/selectors/id/";
            string ID = "testImage";
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.Id(ID));

            if (element.Displayed)
            {
                GreenMessage("Yes, I can see it!");
            }
            else
            {
                RedMessage("Nope, it is not there");
            }

            Thread.Sleep(2000);
            driver.Quit();
            Console.ReadLine();
        }
    }
}