using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vendor_Portal
{
    class Portallogin : Baseclass
    {
        public void Positivelogin(string url,string email,string password,string message)
        {
            driver.Manage().Window.Maximize();
            driver.Url = url;
            driver.FindElement(By.XPath("//input[@id='loginEmail']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@id='loginPassword']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(4000);
            string actualmessage = driver.FindElement(By.XPath("//a[text()='Dashboard']")).Text;
            Assert.AreEqual(message, actualmessage, "Login Passed");
            SeleniumClose();
        }
    }
}
