using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vendor_Portal
{
    class Promotion : Baseclass
    {
        public void Promotioncreate(string url,string email,string password,string storename,string status,string
            decomission,string creatortype,string searchby,string proid,string promotiontype,string buyquantity,string discountvalue,
            string valuetype,string promotionduration,string description)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            driver.Manage().Window.Maximize();
            driver.Url = url;
            driver.FindElement(By.XPath("//input[@id='loginEmail']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@id='loginPassword']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//p[text()='Manage Stores']")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//div[@class='content']//div[@class='container-fluid']//div//input[@placeholder='Store Name']")).SendKeys(storename);
            var selection = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[4]/select[1]"));
            var selectdropdown = new SelectElement(selection);
            selectdropdown.SelectByText(status);
            var selection1 = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[5]/select[1]"));
            var selectdropdown1 = new SelectElement(selection1);
            selectdropdown1.SelectByText(decomission);
            driver.FindElement(By.XPath("//div[@class='content']//div[@class='container-fluid']//div//button[@type='submit'][normalize-space()='Search']")).Click();
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//div[normalize-space()='GS Electronics']")).Click();
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[4]/div[1]/div[1]/button[3]")).Click();
            Thread.Sleep(8000);

            var selection2 = driver.FindElement(By.XPath("//select[@name='lookupCreatorTypeId']"));
            var selectdropdown2 = new SelectElement(selection2);
            selectdropdown2.SelectByText(creatortype);
            driver.FindElement(By.XPath("//button[normalize-space()='Select']")).Click();

            var selection8 = driver.FindElement(By.XPath("//select[@name='columnName']"));
            var selectdropdown8 = new SelectElement(selection8);
            selectdropdown8.SelectByText(searchby);
            driver.FindElement(By.XPath("(//input[@placeholder='Search...'])[1]")).SendKeys(proid);

            driver.FindElement(By.XPath("//button[contains(@class,'ml-2 btn btn-primary')]")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[contains(@class,'btn btn-warning btn-block')][normalize-space()='Select']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[normalize-space()='Close']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Promotion Start Date']")).Click();
            driver.FindElement(By.XPath("//div[@aria-label='Choose Thursday, June 1st, 2023']")).Click();

            var selection3 = driver.FindElement(By.XPath("//select[@id='promotion']"));
            var selectdropdown3 = new SelectElement(selection3);
            selectdropdown3.SelectByText(promotiontype);
            js.ExecuteScript("window.scrollBy(0,400);");
            driver.FindElement(By.XPath("//input[@id='buyQuantity']")).SendKeys(buyquantity);
            driver.FindElement(By.XPath("//input[@id='discount']")).SendKeys(discountvalue);

            var selection4 = driver.FindElement(By.XPath("//select[@id='valueType']"));
            var selectdropdown4 = new SelectElement(selection4);
            selectdropdown4.SelectByText(valuetype);

            var selection5 = driver.FindElement(By.XPath("//select[@id='promotionDuration']"));
            var selectdropdown5 = new SelectElement(selection5);
            selectdropdown5.SelectByText(promotionduration);
            js.ExecuteScript("window.scrollBy(0,600);");
            driver.FindElement(By.XPath("//textarea[@id='promotionDesc']")).SendKeys(description);
            js.ExecuteScript("window.scrollBy(0,700);");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(4000);
            SeleniumClose();
        }
    }
}
