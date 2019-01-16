using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test_Framework
{

    [TestClass]
    public class tstInvoice
    {

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsInvoice AInvoice = new clsInvoice();
            //test to see that it exists
            Assert.IsNotNull(AInvoice);
        }

        //TEST PROPERTY OK

        [TestMethod]
        public void InvoiceNoPropertyOK()
        {
            //create an instance of the class
            clsInvoice AInvoice = new clsInvoice();
            //create some test data to assign to the property
            Int32 SomeInvoiceNo = 1;
            //assign the data to the property
            AInvoice.InvoiceNo = SomeInvoiceNo;
            //test to see that it exists
            Assert.AreEqual(AInvoice.InvoiceNo, SomeInvoiceNo);
        }

        [TestMethod]
        public void DateCreatedPropertyOK()
        {
            //create an instance of the class
            clsInvoice AInvoice = new clsInvoice();
            //create some test data to assign to the property
            string SomeDateCreated = "2018/09/06";
            //assign the data to the property
            AInvoice.DateCreated = SomeDateCreated;
            //test to see that it exists
            Assert.AreEqual(AInvoice.InvoiceNo, SomeDateCreated);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class
            clsInvoice AInvoice = new clsInvoice();
            //create some test data to assign to the property
            double SomePrice = 1.1;
            //assign the data to the property
            AInvoice.Price = SomePrice;
            //test to see that it exists
            Assert.AreEqual(AInvoice.Price, SomePrice);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            //create an instance of the class
            clsInvoice AInvoice = new clsInvoice();
            //create some test data to assign to the property
            string SomePostcode = "LE2 7EE";
            //assign the data to the property
            AInvoice.Postcode = SomePostcode;
            //test to see that it exists
            Assert.AreEqual(AInvoice.Postcode, SomePostcode);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class
            clsInvoice AInvoice = new clsInvoice();
            //create some test data to assign to the property
            Int32 SomeOrderNo = 1;
            //assign the data to the property
            AInvoice.OrderNo = SomeOrderNo;
            //test to see that it exists
            Assert.AreEqual(AInvoice.OrderNo, SomeOrderNo);
        }

        //Test Method OK

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            Boolean Found = false;
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            //invoke the method
            Found = AInvoice.Find(SomeInvoiceNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        //Test property found
        [TestMethod]
        public void TestInvoiceNoFound()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 InvoiceNo = 1;
            //invoke the method
            Found = AInvoice.Find(InvoiceNo);
            //check property on
            if (AInvoice.InvoiceNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test property found
        [TestMethod]
        public void TestDateCreatedFound()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 InvoiceNo = 1;
            //invoke the method
            Found = AInvoice.Find(InvoiceNo);
            //check property on
            if (AInvoice.DateCreated != "2018/09/08")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test property found
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 InvoiceNo = 1;
            //invoke the method
            Found = AInvoice.Find(InvoiceNo);
            //check property on
            if (AInvoice.Price != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test property found
        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 InvoiceNo = 1;
            //invoke the method
            Found = AInvoice.Find(InvoiceNo);
            //check property on
            if (AInvoice.Postcode != "LE2 7EE")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test property found
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 InvoiceNo = 1;
            //invoke the method
            Found = AInvoice.Find(InvoiceNo);
            //check property on
            if (AInvoice.OrderNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test InvoiceNo
        [TestMethod]
        public void InvoiceNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 0;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void InvoiceNoMinBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 2;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 2147483646;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceNoMaxBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 2147483647;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void InvoiceNoMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsInvoice AInvoice = new clsInvoice();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to method
        //    Int32 SomeInvoiceNo = 2147483648;
        //    DateTime TestDateCreated = DateTime.Now.Date;
        //    string SomeDateCreated = TestDateCreated.ToString();
        //    double SomePrice = 1.1;
        //    string SomePostcode = "LE2 7FZ";
        //    Int32 SomeOrderNo = 1;
        //    //invoke the method
        //    Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void InvoiceNoMid()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1073741824;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test DateCreated
        [TestMethod]
        public void DateCreatedMinBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMin()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            TestDateCreated = TestDateCreated.AddYears(-100);
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            TestDateCreated = TestDateCreated.AddYears(-1);
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            TestDateCreated = TestDateCreated.AddYears(1);
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMax()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            TestDateCreated = TestDateCreated.AddYears(100);
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedInvalidData()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            string SomeDateCreated = "This is not a date";
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Price
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 0;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 0;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMinBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 2;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Postcode
        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "a";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "aa";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "aaaaaaaaa";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "aaaaaaaaaa";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "aaaaaaaaaaa";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "aaaaa";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test InvoiceNo
        [TestMethod]
        public void OrderNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 0;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderNoMinBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 2;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 2147483646;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxBoundary()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 2147483647;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void OrderNoMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsInvoice AInvoice = new clsInvoice();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to method
        //    Int32 SomeInvoiceNo = 1;
        //    DateTime TestDateCreated = DateTime.Now.Date;
        //    string SomeDateCreated = TestDateCreated.ToString();
        //    double SomePrice = 1.1;
        //    string SomePostcode = "LE2 7FZ";
        //    Int32 SomeOrderNo = 2147483648;
        //    //invoke the method
        //    Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void OrderNoMid()
        {
            //create an instance of the class we want to create
            clsInvoice AInvoice = new clsInvoice();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeInvoiceNo = 1;
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1073741824;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
