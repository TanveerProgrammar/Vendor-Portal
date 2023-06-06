using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor_Portal
{
    class Baseclass
    {
        public static IWebDriver driver = new ChromeDriver();
        public static string Headless { get; set; }
        public static string Browser { get; set; }


        public static void SeleniumStart()
        {
            if (Browser == "Chrome")
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("headless=false");
                chromeOptions.AddArguments("--incognito");
                chromeOptions.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeOptions);
            }

            else if (Browser == "FireFox")
            {
                //FirefoxOptions options = new FirefoxOptions();
                //// options.AddArguments("--headless");
                //driver = new FirefoxDriver(options);
            }
        }
        public static void SeleniumClose()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
