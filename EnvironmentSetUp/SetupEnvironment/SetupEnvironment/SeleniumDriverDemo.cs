using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{
    public class SeleniumDriverDemo
    {
        static void Main()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            Thread.Sleep(3000);

            driver.Quit();

        }
    }
}