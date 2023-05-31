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
    class Addcoupon : Baseclass
    {
        public void Coupons(string url,string email,string password,string storename,string status,string decomission,
         string creatortype,string couponunit,string couponvalue,string couponscope,string couponscopevalue,string couponature,string coupondevice,
         string userid,string description,string maxlimit,string userlimit,string
            minorderamount,string maxdiscountamount)
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
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[4]/div[1]/div[1]/button[2]")).Click();
            Thread.Sleep(8000);

            var selection2 = driver.FindElement(By.XPath("//select[@name='lookupCreatorTypeId']"));
            var selectdropdown2 = new SelectElement(selection2);
            selectdropdown2.SelectByText(creatortype);

            var selection3 = driver.FindElement(By.XPath("//select[@name='lookupCouponUnitId']"));
            var selectdropdown3 = new SelectElement(selection3);
            selectdropdown3.SelectByText(couponunit);
            driver.FindElement(By.XPath("//input[@placeholder='Coupon Value']")).SendKeys(couponvalue);
            js.ExecuteScript("window.scrollBy(0,300);");

            var selection4 = driver.FindElement(By.XPath("//select[@name='couponScopeId']"));
            var selectdropdown4 = new SelectElement(selection4);
            selectdropdown4.SelectByText(couponscope);
            driver.FindElement(By.XPath("//input[@placeholder='e.g : 123,34,345,66,33 (comma seperated ids)']")).SendKeys(couponscopevalue);

            var selection5 = driver.FindElement(By.XPath("//select[@name='couponNatureId']"));
            var selectdropdown5 = new SelectElement(selection5);
            selectdropdown5.SelectByText(couponature);

            var selection6 = driver.FindElement(By.XPath("//select[@name='lookupCouponDeviceId']"));
            var selectdropdown6 = new SelectElement(selection6);
            selectdropdown6.SelectByText(coupondevice);
            driver.FindElement(By.XPath("//input[@placeholder='coupon for particular user']")).SendKeys(userid);
            js.ExecuteScript("window.scrollBy(0,600);");
            driver.FindElement(By.XPath("//input[@placeholder='Start Date']")).Click();
            driver.FindElement(By.XPath("//div[@aria-label='Choose Thursday, June 1st, 2023']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@placeholder='End Date']")).Click();
            driver.FindElement(By.XPath("//div[@aria-label='Choose Saturday, July 1st, 2023']")).Click();
            driver.FindElement(By.XPath("//button[normalize-space()='Generate Random']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='description']")).SendKeys(description);
            driver.FindElement(By.XPath("//input[@placeholder='Maximum Limit']")).SendKeys(maxlimit);
            driver.FindElement(By.XPath("//input[@placeholder='User Limit']")).SendKeys(userlimit);
            driver.FindElement(By.XPath("//input[@placeholder='Minimum Order Amount']")).SendKeys(minorderamount);
            js.ExecuteScript("window.scrollBy(0,800);");
            driver.FindElement(By.XPath("//input[@placeholder='Maximum Discount Amount']")).SendKeys(maxdiscountamount);
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//button[@id='submitForm']")).Click();
            Thread.Sleep(6000);
            SeleniumClose();
            






        }
    }
}
