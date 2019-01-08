using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

/// <summary>
///  Find class using Selenium and get element text
/// </summary>
namespace LearnSelenium
{
    public class SeleniumClassDemo
    {
        static void Main()
        {
            string url = "http://testing.todorvachev.com/selectors/class-name/";
            string className = "testClass";
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.ClassName(className));

            // element.Text returns the text in the element
            Console.WriteLine(element.Text);


            Thread.Sleep(2000);
            driver.Quit();
            Console.ReadLine();
        }
    }
}