using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;


namespace myfirsttests
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new InternetExplorerDriver();

            driver.Navigate().GoToUrl("https://www.google.com");
            // IWebElement element = driver.FindElement(By.XPath("//*[@title='Szukaj']"));
            IWebElement searchbox = driver.FindElement(By.Name("q"));
            searchbox.SendKeys("Space x");
            IWebElement searchbutton = driver.FindElement(By.Name("btnK"));
            searchbutton.Click();
            IWebElement no1searchresult = driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div:nth-child(1) > div > div > div.r > a > div > cite"));
            string urladdress = no1searchresult.GetAttribute("innerHTML");
            // TEST 1
            if (urladdress == "www.spacex.com")
            {
                Console.WriteLine("Test 1 passed");
            }
            else
            {
                Console.WriteLine("Test 1 failed");
            }
            // TEST 2
            if (urladdress.Contains("wikipedia.org") == true)
            {
                Console.WriteLine("Test 2 passed");
            }
            else
            {
                Console.WriteLine("Test 2 failed");
            }
            //no1searchresult.Click();
            //string urladdress = driver.Url;
            //Uri urldomain = new Uri(urladdress);
        }
    }
}
