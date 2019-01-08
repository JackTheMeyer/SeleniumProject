using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{

    public class SeleniumRadioDemo
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radioButton;

        public void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
            string option = "1";

            driver.Navigate().GoToUrl(url);

            radioButton = driver.FindElement(By.CssSelector(".entry-content > form:nth-child(2) > p:nth-child(6) > input:nth-child(1)"));

            if (radioButton.GetAttribute("checked") == "true")
            {
                GreenMessage msg = new GreenMessage("The radio button is checked!");
            }
            else
            {
                RedMessage msg = new RedMessage("This radio button is unchecked!");
            }

            driver.Quit();
            Console.ReadLine();
        }
    }
}