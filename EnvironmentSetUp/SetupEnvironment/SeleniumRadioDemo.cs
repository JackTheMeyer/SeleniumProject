using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{

    public class SeleniumRadioButtonDemo
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement checkBox;

        public Main()
        {
            string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
            string option = "1";

            driver.Navigate().GoToUrl(url);

            SeleniumRadioButtonDemo = driver.FindElement(By.CssSelector(".entry-content > form:nth-child(2) > p:nth-child(6) > input:nth-child(1)"));

            if (radoButton.GetAttribute("checked") == true)
            {
                GreenMessage("The radio button is checked!");
            }
            else
            {
                RedMessage("This radio button is unchecked!");
            }

            driver.Quit();
            Console.ReadLine();
        }
    }
}