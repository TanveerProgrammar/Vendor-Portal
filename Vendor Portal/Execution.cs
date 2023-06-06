using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using System.Configuration;

namespace Vendor_Portal
{
    [TestClass]
    public class Execution
    {
        //Initialize TestContext
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext instance;

        //Create Getter and Setter Method TestContext
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        public string dataSourceConnection;
        [SetUp]
        public void Setup()
        {
            // Retrieve the connection string from configuration
            dataSourceConnection = ConfigurationManager.ConnectionStrings["DataSourceConnection"]?.ConnectionString;
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"PositiveLogin.csv", "PositiveLogin#csv", DataAccessMethod.Sequential)]
        [TestCategory("Login")]
        [TestCategory("Positive")]
        public void Login()
        {
            Portallogin portallogin = new Portallogin();
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            portallogin.Positivelogin(url, email, pass, message);


        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Productadd.csv", "Productadd#csv", DataAccessMethod.Sequential)]
        [TestCategory("ProductCreate")]
        [TestCategory("Positive")]
        public void ProductCreation()
        {
            ProductAdd productAdd = new ProductAdd();
            string url = TestContext.DataRow["URL"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string status = TestContext.DataRow["status"].ToString();
            string producttitle = TestContext.DataRow["producttitle"].ToString();
            string brandname = TestContext.DataRow["brandname"].ToString();
            string sellersku = TestContext.DataRow["sellersku"].ToString();
            string productmodel = TestContext.DataRow["productmodel"].ToString();
            string barcode = TestContext.DataRow["barcode"].ToString();
            string fullfillby = TestContext.DataRow["fullfillby"].ToString();
            string parentcategory = TestContext.DataRow["parentcategory"].ToString();
            string weightselect = TestContext.DataRow["weightselect"].ToString();
            string dimensionselect = TestContext.DataRow["dimensionselect"].ToString();
            string weightvalue = TestContext.DataRow["weightvalue"].ToString();
            string length = TestContext.DataRow["length"].ToString();
            string width = TestContext.DataRow["width"].ToString();
            string height = TestContext.DataRow["height"].ToString();
            string description = TestContext.DataRow["description"].ToString();
            string feature = TestContext.DataRow["feature"].ToString();
            string image = TestContext.DataRow["image"].ToString();
            string shippingtemplate = TestContext.DataRow["shippingtemplate"].ToString();
            string condition = TestContext.DataRow["condition"].ToString();
            string productmrp = TestContext.DataRow["productmrp"].ToString();
            string listprice = TestContext.DataRow["listprice"].ToString();
            string orderamount = TestContext.DataRow["orderamount"].ToString();
            string saleprice = TestContext.DataRow["saleprice"].ToString();
            string purchaseamount = TestContext.DataRow["purchaseamount"].ToString();
            string quantity = TestContext.DataRow["quantity"].ToString();
            string maxorderquantity = TestContext.DataRow["maxorderquantity"].ToString();
            string monthlymax = TestContext.DataRow["monthlymax"].ToString();
            string dailymaxorderquantity = TestContext.DataRow["dailymaxorderquantity"].ToString();
            string consumedays = TestContext.DataRow["consumedays"].ToString();
            string utilize = TestContext.DataRow["utilize"].ToString();
            string orderreturntimeperiod = TestContext.DataRow["orderreturntimeperiod"].ToString();
            string productwarranty = TestContext.DataRow["productwarranty"].ToString();
            string warrantyvalue = TestContext.DataRow["warrantyvalue"].ToString();
            string ProductTags1 = TestContext.DataRow["ProductTags1"].ToString();
            string ProductTags2 = TestContext.DataRow["ProductTags2"].ToString();
            string ProductTags3 = TestContext.DataRow["ProductTags3"].ToString();
            string searchfilterattribute = TestContext.DataRow["searchfilterattribute"].ToString();
            string searchfilterattributevalue = TestContext.DataRow["searchfilterattributevalue"].ToString();
            string productattribute = TestContext.DataRow["productattribute"].ToString();
            string productattributevalue = TestContext.DataRow["productattributevalue"].ToString();
            string productmeta1 = TestContext.DataRow["productmeta1"].ToString();
            string productmeta2 = TestContext.DataRow["productmeta2"].ToString();
            string productmeta3 = TestContext.DataRow["productmeta3"].ToString();
            string productmetavalue1 = TestContext.DataRow["productmetavalue1"].ToString();
            string productmetavalue2 = TestContext.DataRow["productmetavalue2"].ToString();
            string productmetavalue3 = TestContext.DataRow["productmetavalue3"].ToString();
            string slugurl = TestContext.DataRow["slugurl"].ToString();
            productAdd.ProductCreate(url, email, pass, status, producttitle, brandname, sellersku, productmodel, barcode,
                fullfillby, parentcategory, weightselect, dimensionselect, weightvalue, length, width, height, description, feature, image, shippingtemplate,
                condition, productmrp, listprice, orderamount, saleprice, purchaseamount, quantity, maxorderquantity, monthlymax, dailymaxorderquantity,
               consumedays, utilize, orderreturntimeperiod, productwarranty, warrantyvalue, ProductTags1, ProductTags2, ProductTags3, searchfilterattribute,
               searchfilterattributevalue, productattribute, productattributevalue, productmeta1, productmeta2, productmeta3, productmetavalue1, productmetavalue2, productmetavalue3, slugurl);


        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Storedetails.csv", "Storedetails#csv", DataAccessMethod.Sequential)]
        [TestCategory("Storedetail")]
        [TestCategory("Positive")]
        public void Storedetails()
        {
            Storedetails storedetails = new Storedetails();
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string storename = TestContext.DataRow["storename"].ToString();
            string status = TestContext.DataRow["status"].ToString();
            string decomission = TestContext.DataRow["decomission"].ToString();
            string cnic = TestContext.DataRow["cnic"].ToString();
            string ntnumber = TestContext.DataRow["ntnumber"].ToString();
            string personname = TestContext.DataRow["personname"].ToString();
            string personnumber = TestContext.DataRow["personnumber"].ToString();
            string personemail = TestContext.DataRow["personemail"].ToString();
            string cnicfront = TestContext.DataRow["cnicfront"].ToString();
            string cnicback = TestContext.DataRow["cnicback"].ToString();
            string storeaddress = TestContext.DataRow["storeaddress"].ToString();
            string country = TestContext.DataRow["country"].ToString();
            string state = TestContext.DataRow["state"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string zipcode = TestContext.DataRow["zipcode"].ToString();
            string storephoneno = TestContext.DataRow["storephoneno"].ToString();
            string alternatenumber = TestContext.DataRow["alternatenumber"].ToString();
            storedetails.Storesdatainsert(url, email, pass, storename, status, decomission, cnic, ntnumber, personname, personnumber, personemail,
                cnicfront, cnicback, storeaddress, country, state, city, zipcode, storephoneno, alternatenumber);


        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Coupon.csv", "Coupon#csv", DataAccessMethod.Sequential)]
        [TestCategory("Coupon")]
        [TestCategory("Positive")]
        public void Createcoupon()
        {
            Addcoupon addcoupon = new Addcoupon();
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string storename = TestContext.DataRow["storename"].ToString();
            string status = TestContext.DataRow["status"].ToString();
            string decomission = TestContext.DataRow["decomission"].ToString();
            string creatortype = TestContext.DataRow["creatortype"].ToString();
            string couponunit = TestContext.DataRow["couponunit"].ToString();
            string couponvalue = TestContext.DataRow["couponvalue"].ToString();
            string couponscope = TestContext.DataRow["couponscope"].ToString();
            string couponscopevalue = TestContext.DataRow["couponscopevalue"].ToString();
            string couponature = TestContext.DataRow["couponature"].ToString();
            string coupondevice = TestContext.DataRow["coupondevice"].ToString();
            string userid = TestContext.DataRow["userid"].ToString();
            string description = TestContext.DataRow["description"].ToString();
            string maxlimit = TestContext.DataRow["maxlimit"].ToString();
            string userlimit = TestContext.DataRow["userlimit"].ToString();
            string minorderamount = TestContext.DataRow["minorderamount"].ToString();
            string maxdiscountamount = TestContext.DataRow["maxdiscountamount"].ToString();
            addcoupon.Coupons(url, email, pass, storename, status, decomission, creatortype, couponunit, couponvalue, couponscope, couponscopevalue, couponature,
                coupondevice, userid, description, maxlimit, userlimit, minorderamount, maxdiscountamount);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Promotion.csv", "Promotion#csv", DataAccessMethod.Sequential)]
        [TestCategory("Promotion")]
        [TestCategory("Positive")]
        public void Createpromotion()
        {
            Promotion promotion = new Promotion();
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string storename = TestContext.DataRow["storename"].ToString();
            string status = TestContext.DataRow["status"].ToString();
            string decomission = TestContext.DataRow["decomission"].ToString();
            string creatortype = TestContext.DataRow["creatortype"].ToString();
            string searchby = TestContext.DataRow["searchby"].ToString();
            string proid = TestContext.DataRow["proid"].ToString();
            string promotiontype = TestContext.DataRow["promotiontype"].ToString();
            string buyquantity = TestContext.DataRow["buyquantity"].ToString();
            string discountvalue = TestContext.DataRow["discountvalue"].ToString();
            string valuetype = TestContext.DataRow["valuetype"].ToString();
            string promotionduration = TestContext.DataRow["promotionduration"].ToString();
            string description = TestContext.DataRow["description"].ToString();
            promotion.Promotioncreate(url, email, pass, storename, status, decomission, creatortype, searchby, proid, promotiontype,
                buyquantity, discountvalue, valuetype, promotionduration, description);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Manageproduct.csv", "Manageproduct#csv", DataAccessMethod.Sequential)]
        [TestCategory("product")]
        [TestCategory("Positive")]
        public void Manageproduct()
        {
            Manageproduct manageproduct = new Manageproduct();
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            //string status = TestContext.DataRow["status"].ToString();
            //manageproduct.product(url, email, pass, status);
            manageproduct.Productdiscard(url, email, pass);
        }
    }
}
