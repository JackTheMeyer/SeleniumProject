using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{
    public class SeleniumNameDemo
    {
        public void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name");

            IWebElement element = driver.FindElement(By.Name("myName"));

            if (element.Displayed)
            {
                GreenMessage msg = new GreenMessage("Yes I can see the element!");
            } else
            {
                RedMessage msg = new RedMessage("Somethign went wrong, couldnt see the element!");
            }

            driver.Quit();
            Console.ReadLine();

        }
    }
}
