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
    class ProductAdd : Baseclass
    {
       public void ProductCreate(string url,string email,string password,string status,string producttitle,
           string brandname,string sellersku,string productmodel,string barcode,string fullfillby,string parentcategory,string weightselect,string dimensionselect,
           string weightvalue,string length,string width,string height,string description,string feature,string image,string shippingtemplate,
           string condition,string productmrp,string listprice,string orderamount,string saleprice,string purchaseamount,string quantity,
           string maxorderquantity,string monthlymax,string dailymaxorderquantity,string consumedays,string utilize, string orderreturntimeperiod,string productwarranty,
           string warrantyvalue,string ProductTags1,string ProductTags2,string ProductTags3,string searchfilterattribute,string searchfilterattributevalue,
           string productattribute,string productattributevalue,string productmeta1, string productmeta2, string productmeta3,string productmetavalue1,
           string productmetavalue2, string productmetavalue3,string slugurl)
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
            var selection = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[4]/select[1]"));
            var selectdropdown = new SelectElement(selection);
            selectdropdown.SelectByText(status);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='content']//div[@class='container-fluid']//div//button[@type='submit'][normalize-space()='Search']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//div[normalize-space()='GS Electronics']")).Click();
            js.ExecuteScript("window.scrollBy(0,100);");
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[4]/div[1]/div[1]/button[1]")).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//div[contains(text(),'Mobile & Tablets')]")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'Smartphones')]")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'Nokia Mobiles')]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@name='Continue']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@id='title']")).SendKeys(producttitle);
            driver.FindElement(By.XPath("//input[@id='brandName']")).SendKeys(brandname);
            driver.FindElement(By.XPath("//div[@class='mt-0 border bg-white input-group-append']//*[name()='svg']")).Click();
            driver.FindElement(By.XPath("//input[@id='sku']")).SendKeys(sellersku);
            driver.FindElement(By.XPath("//input[@name='productModel']")).SendKeys(productmodel);
            driver.FindElement(By.XPath("//input[@name='vendorBarcode']")).SendKeys(barcode);
            js.ExecuteScript("window.scrollBy(0,500);");
            var selection1 = driver.FindElement(By.XPath("//select[@id='sku']"));
            var selectdropdown1 = new SelectElement(selection1);
            selectdropdown1.SelectByText(fullfillby);

            var selection2 = driver.FindElement(By.XPath("//select[@id='parentCategory']"));
            var selectdropdown2 = new SelectElement(selection2);
            selectdropdown2.SelectByText(parentcategory);

            var selection3 = driver.FindElement(By.XPath("//select[@name='massUnit']"));
            var selectdropdown3 = new SelectElement(selection3);
            selectdropdown3.SelectByText(weightselect);

            var selection4 = driver.FindElement(By.XPath("//select[@name='measurementUnit']"));
            var selectdropdown4 = new SelectElement(selection4);
            selectdropdown4.SelectByText(dimensionselect);

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/form[1]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[11]/td[2]/div[1]/div[2]")).Click();
            driver.FindElement(By.XPath("//input[@name='weight']")).SendKeys(weightvalue);
            driver.FindElement(By.XPath("//input[@placeholder='Length']")).SendKeys(length);
            driver.FindElement(By.XPath("//input[@placeholder='Width']")).SendKeys(width);
            driver.FindElement(By.XPath("//input[@placeholder='Height']")).SendKeys(height);
            js.ExecuteScript("window.scrollBy(200,-200);");
            driver.FindElement(By.XPath("//a[normalize-space()='Description']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/form[1]/div[1]/div[2]/div[5]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/textarea[1]")).SendKeys(description);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[3]/div[1]/form[1]/div[1]/div[2]/div[5]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/input[1]")).SendKeys(feature);
            Thread.Sleep(2000);
            
            driver.FindElement(By.XPath("//div[@class='px-4 col-10']//input[@type='file']")).SendKeys("C:\\Users\\840 G3\\Desktop\\vendor portal\\ic_launcher.png");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//a[normalize-space()='Alternative Language']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[normalize-space()='Images']")).Click();
            driver.FindElement(By.XPath("//div[@name='Images']//input[@type='file']")).SendKeys("C:\\Users\\840 G3\\Desktop\\vendor portal\\ic_launcher.png");
          
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//a[normalize-space()='Offer']")).Click();



            var selection5 = driver.FindElement(By.XPath("//select[@name='shippingClassId']"));
            var selectdropdown5 = new SelectElement(selection5);
            selectdropdown5.SelectByText(shippingtemplate);

            var selection6 = driver.FindElement(By.XPath("//select[@name='productConditionId']"));
            var selectdropdown6 = new SelectElement(selection6);
            selectdropdown6.SelectByText(condition);


            driver.FindElement(By.XPath("//input[@name='price']")).SendKeys(productmrp);
            driver.FindElement(By.XPath("//input[@name='listPrice']")).SendKeys(listprice);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@name='listPriceStartDate']")).Click();
            driver.FindElement(By.XPath("//div[@aria-label='Choose Wednesday, May 31st, 2023']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@name='listPriceEndDate']")).Click();
            driver.FindElement(By.XPath("//div[@aria-label='Choose Thursday, June 1st, 2023']")).Click();
            driver.FindElement(By.XPath("//input[@name='amountSaved']")).SendKeys(orderamount);
            js.ExecuteScript("window.scrollBy(0,300);");
            driver.FindElement(By.XPath("//input[@name='salePrice']")).SendKeys(saleprice);
            driver.FindElement(By.XPath("//input[@name='saleStartDate']")).Click();
            driver.FindElement(By.XPath("//div[@aria-label='Choose Tuesday, May 30th, 2023']")).Click();
            driver.FindElement(By.XPath("//input[@name='saleEndDate']")).Click();
            driver.FindElement(By.XPath("//div[@aria-label='Choose Wednesday, May 31st, 2023']")).Click();
            driver.FindElement(By.XPath("//input[@name='purchaseAmount']")).SendKeys(purchaseamount);
            driver.FindElement(By.XPath("//input[@name='stock']")).SendKeys(quantity);
            IWebElement elements = driver.FindElement(By.XPath("//input[@name='purchaseLimit']"));
            elements.Clear();
            elements.SendKeys(maxorderquantity);
            IWebElement elements1 = driver.FindElement(By.XPath("//input[@name='monthlyPurchaseLimit']"));
            elements1.Clear();
            elements1.SendKeys(monthlymax);
            IWebElement elements2 = driver.FindElement(By.XPath("//input[@name='dailyPurchaseLimit']"));
            elements2.Clear();
            elements2.SendKeys(dailymaxorderquantity);
          
            var selection7 = driver.FindElement(By.XPath("//select[@name='consumeDays']"));
            var selectdropdown7 = new SelectElement(selection7);
            selectdropdown7.SelectByText(consumedays);

            var selection8 = driver.FindElement(By.XPath("//select[@name='utilize']"));
            var selectdropdown8 = new SelectElement(selection8);
            selectdropdown8.SelectByText(utilize);
            driver.FindElement(By.XPath("//input[@name='daysOfReturn']")).SendKeys(orderreturntimeperiod);
            js.ExecuteScript("window.scrollBy(0,700);");

            var selection9 = driver.FindElement(By.XPath("//select[@name='timeUnit']"));
            var selectdropdown9 = new SelectElement(selection9);
            selectdropdown9.SelectByText(productwarranty);
            driver.FindElement(By.XPath("//input[@name='warranty']")).SendKeys(warrantyvalue);
            js.ExecuteScript("window.scrollBy(700,-700);");

            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//a[normalize-space()='Keywords']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@data-index='0']")).SendKeys(ProductTags1);
            driver.FindElement(By.XPath("//button[@name='tags']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@data-index='1']")).SendKeys(ProductTags2);
            driver.FindElement(By.XPath("//button[@name='tags']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@data-index='2']")).SendKeys(ProductTags3);
            js.ExecuteScript("window.scrollBy(0,300);");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Search FieldName')])[1]")).SendKeys(searchfilterattribute);
            driver.FindElement(By.XPath("//input[@name='attributes']")).SendKeys(searchfilterattributevalue);
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Search FieldName')])[2]")).SendKeys(productattribute);
            driver.FindElement(By.XPath("//input[@name='spec']")).SendKeys(productattributevalue);
            js.ExecuteScript("window.scrollBy(0,500);");
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Search FieldName')])[3]")).SendKeys(productmeta1);
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Search FieldName')])[5]")).SendKeys(productmeta2);
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Search FieldName')])[7]")).SendKeys(productmeta3);
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Content')])[1]")).SendKeys(productmetavalue1);
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Content')])[2]")).SendKeys(productmetavalue2);
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Content')])[3]")).SendKeys(productmetavalue3);
            driver.FindElement(By.XPath("//input[@name='slugUrl']")).SendKeys(slugurl);
            Thread.Sleep(2000);
            
            driver.FindElement(By.XPath("//button[@name='submitForm']")).Click();
            Thread.Sleep(4000);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string ScreenShotName = @"C:\\Users\\840 G3\\Desktop\\vendor portal\\Vendor Portal\\Vendor Portal\\productupload.png";
            screenshot.SaveAsFile(ScreenShotName, ScreenshotImageFormat.Png);
            Thread.Sleep(2000);
            SeleniumClose();

        }
    }
}
