using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{

    public class SeleniumInputTextBoxDemo
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement textBox;

        static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/text-input-field/";

            driver.Navigate().GoToUrl(url);

            textBox = driver.FindElement(By.Name("username"));

            textBox.SendKeys("Test Text");

            Thread.Sleep(3000);

            Console.WriteLine(textBox.GetAttribute("value"));
            Console.WriteLine(textBox.GetAttribute("maxlength"));

            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}