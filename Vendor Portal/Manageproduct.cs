using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Vendor_Portal
{
    class Manageproduct : Baseclass
    {
        public void Product(string url,string email,string password,string status)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            driver.Manage().Window.Maximize();
            driver.Url = url;
            driver.FindElement(By.XPath("//input[@id='loginEmail']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@id='loginPassword']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//p[normalize-space()='Manage Products']")).Click();
            Thread.Sleep(8000);
            
            driver.FindElement(By.XPath("(//a[normalize-space()='All Product'])[1]")).Click();
            Thread.Sleep(8000);
            js.ExecuteScript("document.body.style.zoom = '75%' ;");
            Thread.Sleep(8000);
            ReadOnlyCollection<IWebElement> selection = driver.FindElements(By.XPath("(//select[@name='productStatusId'])"));
            foreach(var item in selection)
            {
                var selectdropdown = new SelectElement(item);
                selectdropdown.SelectByText(status);
                Thread.Sleep(3000);
            }
            Thread.Sleep(4000);
            SeleniumClose();
           



        }
        public void Productdiscard(string url, string email, string password)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            driver.Manage().Window.Maximize();
            driver.Url = url;
            driver.FindElement(By.XPath("//input[@id='loginEmail']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@id='loginPassword']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//p[normalize-space()='Manage Products']")).Click();
            Thread.Sleep(8000);

            driver.FindElement(By.XPath("(//a[normalize-space()='Approval Changes'])[1]")).Click();
            Thread.Sleep(8000);
            js.ExecuteScript("document.body.style.zoom = '80%' ;");
            Thread.Sleep(8000);
            ReadOnlyCollection<IWebElement> btn = driver.FindElements(By.XPath("(//button[contains(@type,'button')][normalize-space()='discard'])"));
            for (int i = 1; i < btn.Count; i++)
            {
                IWebElement element = btn[i];
                js.ExecuteScript("arguments[0].click();", element);
                Thread.Sleep(4000);
                IWebElement btn2 = driver.FindElement(By.XPath("//button[text()='Yes, discard it']"));
                js.ExecuteScript("arguments[0].click();", btn2);
                Thread.Sleep(4000);
            }
            Thread.Sleep(4000);
            SeleniumClose();




        }

    }
}
