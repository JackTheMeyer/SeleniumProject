using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{
    class EntryPoint
    {

        private static void Main()
        {
            SeleniumAlertBoxDemo demo = new SeleniumAlertBoxDemo();
            //SeleniumDropDownDemo demo = new SeleniumDropDownDemo();
            //SeleniumClassDemo demo = new SeleniumClassDemo();
            //SeleniumDriverDemo demo = new SeleniumDriverDemo();
            //SeleniumDropDownDemo demo = new SeleniumDropDownDemo();
            //SeleniumIDDemo demo = new SeleniumIDDemo();
            //SeleniumInputTextBoxDemo demo = new SeleniumInputTextBoxDemo();
            //SeleniumNameDemo demo = new SeleniumNameDemo)();
            //SeleniumRadioDemo demo = new SeleniumRadioDemo();

            demo.Main();
        }
    }
}