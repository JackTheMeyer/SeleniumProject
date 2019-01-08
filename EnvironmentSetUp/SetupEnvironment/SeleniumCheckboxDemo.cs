using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{
    public class SeleniumCheckboxDemo
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement checkBox;

        public void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
            string option = "1";

            driver.Navigate().GoToUrl(url);

            //checkBox = driver.FindElement(By.CssSelector(".entry-content > p:nth-child(8) > input:nth-child(1)"));
            checkBox = driver.FindElement(By.CssSelector(".entry-content > p:nth-child(8) > input:nth-child(" + option + ")"));
            checkBox.Click();

            if (checkBox.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The checkbox is checked!");
            }
            else
            {
                Console.WriteLine("The checkbox is NOT checked!");
            }

            Console.WriteLine(checkBox.GetAttribute("value"));

            option = "3";

            checkBox = driver.FindElement(By.CssSelector(".entry-content > p:nth-child(8) > input:nth-child(" + option + ")"));

            Console.WriteLine("value");

            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
}