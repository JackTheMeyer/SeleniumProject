using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{
    class SeleniumAlertBoxDemo
    {
        static IWebDriver driver = new ChromeDriver();
        static IAlert alert;
        static IWebElement image;

        public void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/alert-box/";
            driver.Navigate().GoToUrl(url);

            alert = driver.SwitchTo().Alert();

            Console.WriteLine(alert.Text);

            Thread.Sleep(3000);

            alert.Accept();

            image = driver.FindElement(By.CssSelector(".entry-thumbnail > img:nth-child(1)"));
            try
            {
                if (image.Displayed)
                {
                    Console.WriteLine("alert succesfully accepted and the image is displayed.");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Something Went Wrong");
            }

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}