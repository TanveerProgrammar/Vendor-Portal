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
    class Storedetails : Baseclass
    {
        public void Storesdatainsert(string url,string email,string password,string storename,string status,string decomission,
            string cnic,string ntnumber,string personname,string personnumber,string personemail,string cnicfront,string cnicback,
            string storeaddress,string country,string state,string city,string zipcode,string storephoneno,string alternatenumber)
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
            driver.FindElement(By.XPath("//div[@class='collapse show']//div[contains(@class,'ml-3 my-2 col')]//button[1]")).Click();
            Thread.Sleep(2000);
            IWebElement elements1 = driver.FindElement(By.XPath("//input[@placeholder='Cnic / Passport Number']"));
            elements1.Clear();
            elements1.SendKeys(cnic);

            IWebElement elements2 = driver.FindElement(By.XPath("//input[@placeholder='Ntn Number']"));
            elements2.Clear();
            elements2.SendKeys(ntnumber);

            IWebElement elements3 = driver.FindElement(By.XPath("//input[@placeholder='Point Person Name']"));
            elements3.Clear();
            elements3.SendKeys(personname);

            IWebElement elements4 = driver.FindElement(By.XPath("//tbody//tr//td//div[@class=' react-tel-input ']//input[@value='+92 312-4648787']"));
            elements4.Clear();
            elements4.SendKeys(personnumber);
            Thread.Sleep(3000);

            IWebElement elements5 = driver.FindElement(By.XPath("//input[@placeholder='Point Person Email']"));
            elements5.Clear();
            elements5.SendKeys(personemail);
            Thread.Sleep(2000);
            js.ExecuteScript("document.getElementsByClassName('w-25 form-control')[0].setAttribute('value', '#2caf4d')");

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//tbody/tr[4]/td[1]/input[1]")).SendKeys(cnicfront);
            //driver.FindElement(By.XPath("//tbody/tr[4]/td[2]/div[1]//*[name()='svg']")).SendKeys(cnicback);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//a[@id='profile-tab-tab-AddressDetail']")).Click();
            IWebElement elements6 = driver.FindElement(By.XPath("//div[@class='input-group']//input[@id='userEmail']"));
            elements6.Clear();
            elements6.SendKeys(storeaddress);
            driver.FindElement(By.XPath("//span[@id='basic-addon2']//*[name()='svg']")).Click();
            Thread.Sleep(4000);

            var selection2 = driver.FindElement(By.XPath("//select[@name='countryId']"));
            var selectdropdown2 = new SelectElement(selection2);
            selectdropdown2.SelectByText(country);

            var selection3 = driver.FindElement(By.XPath("//select[@name='stateId']"));
            var selectdropdown3 = new SelectElement(selection3);
            selectdropdown3.SelectByText(state);

            var selection4 = driver.FindElement(By.XPath("//select[@name='cityId']"));
            var selectdropdown4 = new SelectElement(selection4);
            selectdropdown4.SelectByText(city);

            IWebElement elements7 = driver.FindElement(By.XPath("//input[@id='zipCode']"));
            elements7.Clear();
            elements7.SendKeys(zipcode);

            IWebElement elements8 = driver.FindElement(By.XPath("//input[@name='phoneNo']"));
            elements8.Clear();
            elements8.SendKeys(storephoneno);

            IWebElement elements9 = driver.FindElement(By.XPath("//input[@name='alternativePhone']"));
            elements9.Clear();
            elements9.SendKeys(alternatenumber);
            js.ExecuteScript("window.scrollBy(0,400);");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[contains(text(),'Update')]")).Click();
            Thread.Sleep(3000);
            SeleniumClose();



            


        }
    }
}
