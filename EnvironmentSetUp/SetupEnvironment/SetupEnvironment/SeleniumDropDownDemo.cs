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
        static IWebElement elementFromTheDropDownMenu;

        public void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
            string dropDownMenuElements = ".entry-content > p:nth-child(6) > select:nth-child(1) > option:nth-child(1)";

            driver.Navigate().GoToUrl(url);


            dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

            Console.WriteLine("The Selected value is: " + dropDownMenu.GetAttribute("value"));

            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

            Console.WriteLine("The Selected value is: " + elementFromTheDropDownMenu.GetAttribute("value"));

            elementFromTheDropDownMenu.Click();


            for (int i = 1; i <= 4; i++)
            {
                dropDownMenuElements = ".entry-content > p:nth-child(6) > select:nth-child(1) > option:nth-child(" + i + ")";
                elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

                Console.WriteLine("The " + i + " option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
            }
            driver.Quit();
            Thread.Sleep(3000);
        }
    }
}