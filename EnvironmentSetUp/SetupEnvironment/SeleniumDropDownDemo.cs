using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{

    public class SeleniumDropDownDemo
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement dropDownMenu;

        public static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";


            driver.Navigate().GoToUrl(url);


            dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

            Console.WriteLine(dropDownMenu.GetAttribute("value"));

            driver.Quit();
        }
    }
}