using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace LearnSelenium
{
    public class NoSuchElementExceptionDemo
    {
        static void Main()
        {

            string url = "http://testing.todvachev.com/selectors/css-path/";
            //string cssPath = "html.js body#mh-mobile.single.single-post.postid-108.single-format-standard.custom-background.mh-right-sb div.mh-container.mh-container-outer div.mh-wrapper.clearfix div#main-content.mh-content article#post-108.post-108.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors div.entry-content.clearfix figure.entry-thumbnail img";
            //string xPath = "/html/body/div/div[2]/div/article/div/figure/img";

            // Broken Element -  Exception handling
            string cssPath = "htl.js body#mh-mobile.single.single-post.postid-108.single-format-standard.custom-background.mh-right-sb div.mh-container.mh-container-outer div.mh-wrapper.clearfix div#main-content.mh-content article#post-108.post-108.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors div.entry-content.clearfix figure.entry-thumbnail img";
            string xPath = "/htl/body/div/div[2]/div/article/div/fig/img";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement cssPathElement;
            IWebElement xPathElement;

            try
            {
                cssPathElement = driver.FindElement(By.CssSelector(cssPath));
                xPathElement = driver.FindElement(By.XPath(xPath));
                if (cssPathElement.Displayed)
                {
                    GreenMessage("I can see the CSS path Element!");
                }
            }
            catch (NoSuchElementException)
            {
                RedMessage("something went wrong with CSS Path element");
            }

            try
            {
                xPathElement = driver.FindElement(By.XPath(xPath));
                if (xPathElement.Displayed)
                {
                    GreenMessage("I can see the Xpath Element!");
                }
            }
            catch (NoSuchElementException)
            {
                RedMessage("something went wrong with XPath element");
            }


            Thread.Sleep(2000);
            driver.Quit();
            Console.ReadLine();

        }

    }
}
