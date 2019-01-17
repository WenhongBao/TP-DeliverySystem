using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace Test_Framework
{

    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AOrder);
        }

        //TEST PROPERTY OK

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 SomeOrderNo = 1;
            //assign the data to the property
            AOrder.OrderNo = SomeOrderNo;
            //test to see that it exists
            Assert.AreEqual(AOrder.OrderNo, SomeOrderNo);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean SomeActive = true;
            //assign the data to the property
            AOrder.Active = SomeActive;
            //test to see that it exists
            Assert.AreEqual(AOrder.Active, SomeActive);
        }

        [TestMethod]
        public void CollectionPostcodePropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string SomeCollectionPostcode = "LE2 7EE";
            //assign the data to the property
            AOrder.CollectionPostcode = SomeCollectionPostcode;
            //test to see that it exists
            Assert.AreEqual(AOrder.CollectionPostcode, SomeCollectionPostcode);
        }

        [TestMethod]
        public void DestinationCountryPropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string SomeDestinationCountry = "UK";
            //assign the data to the property
            AOrder.DestinationCountry = SomeDestinationCountry;
            //test to see that it exists
            Assert.AreEqual(AOrder.DestinationCountry, SomeDestinationCountry);
        }

        [TestMethod]
        public void DestinationPostcodePropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string SomeDestinationPostcode = "UK";
            //assign the data to the property
            AOrder.DestinationPostcode = SomeDestinationPostcode;
            //test to see that it exists
            Assert.AreEqual(AOrder.DestinationPostcode, SomeDestinationPostcode);
        }

        [TestMethod]
        public void DateCreatedPropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string SomeDateCreated = "2018/01/02";
            //assign the data to the property
            AOrder.DateCreated = SomeDateCreated;
            //test to see that it exists
            Assert.AreEqual(AOrder.DateCreated, SomeDateCreated);
        }

        [TestMethod]
        public void ParcelSizePropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string SomeParcelSize = "M";
            //assign the data to the property
            AOrder.ParcelSize = SomeParcelSize;
            //test to see that it exists
            Assert.AreEqual(AOrder.ParcelSize, SomeParcelSize);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string SomeStatus = "Dispatching";
            //assign the data to the property
            AOrder.Status = SomeStatus;
            //test to see that it exists
            Assert.AreEqual(AOrder.Status, SomeStatus);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 SomeCustomerNo = 1;
            //assign the data to the property
            AOrder.CustomerNo = SomeCustomerNo;
            //test to see that it exists
            Assert.AreEqual(AOrder.CustomerNo, SomeCustomerNo);
        }

        //Test Method OK

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ"; 
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo,SomeActive,SomeCollectionPostcode,SomeDestinationCountry,SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            //invoke the method
            Found = AOrder.Find(SomeOrderNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        //Test property found
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.OrderNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCollectionPostcodeFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.CollectionPostcode != "LE2 7EE")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDestinationCountryFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.DestinationCountry != "United Kindon")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDestinationPostcodeFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.DestinationPostcode != "LE2 7FZ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateCreatedFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.DateCreated != "2018/01/02")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestParcelSizeFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.ParcelSize != "S")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.Status != "Dispatching")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check property on
            if (AOrder.CustomerNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test OrderNo
        [TestMethod]
        public void OrderNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 0;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderNoMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 2;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 2147483646;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 2147483647;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void OrderNoMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsOrder AOrder = new clsOrder();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to method
        //    Int32 SomeOrderNo = 2147483648;
        //    Boolean SomeActive = true;
        //    string SomeCollectionPostcode = "LE2 7EE";
        //    string SomeDestinationCountry = "UK";
        //    string SomeDestinationPostcode = "LE2 7FZ";
        //    DateTime TestDateCreated = DateTime.Now.Date;
        //    string SomeDateCreated = TestDateCreated.ToString();
        //    string SomeParcelSize = "M";
        //    string SomeStatus = "Dispatching";
        //    Int32 SomeCustomerNo = 1;
        //    //invoke the method
        //    Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}
        
        [TestMethod]
        public void OrderNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1073741824;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test CollectionPostcode
        [TestMethod]
        public void CollectionPostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CollectionPostcodeMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "a";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CollectionPostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "aa";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CollectionPostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "aaaaaaaaa";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CollectionPostcodeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "aaaaaaaaaa";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CollectionPostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "aaaaaaaaaaa";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CollectionPostcodeMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "aaaaa";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test DestinationCountry
        [TestMethod]
        public void DestinationCountryMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationCountryMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "a";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationCountryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "aa";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationCountryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "aaaaaaaaaaaaaaaaaaa";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationCountryMaxBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "aaaaaaaaaaaaaaaaaaaa";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationCountryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationCountryMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "aaaaaaaaaa";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test DestinationPostcode
        [TestMethod]
        public void DestinationPostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationPostcodeMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "a";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationPostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aa";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationPostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aaaaaaaaa";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationPostcodeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aaaaaaaaaa";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationPostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aaaaaaaaaaa";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DestinationPostcodeMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aaaaa";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test DateCreated
        [TestMethod]
        public void DateCreatedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "";
            DateTime TestDateCreated = DateTime.Now.Date;
            TestDateCreated = TestDateCreated.AddYears(-100);
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aa";
            DateTime TestDateCreated = DateTime.Now.Date;
            TestDateCreated = TestDateCreated.AddYears(-1);
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aa";
            DateTime TestDateCreated = DateTime.Now.Date;
            TestDateCreated = TestDateCreated.AddYears(1);
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aaaaaaaaa";
            DateTime TestDateCreated = DateTime.Now.Date;
            TestDateCreated = TestDateCreated.AddYears(100);
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "aaaaaaaaaa";
            //DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = "This is not a date";
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test ParcelSize
        [TestMethod]
        public void ParcelSizeMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ParcelSizeMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "a";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ParcelSizeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "aa";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ParcelSizeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "aaaaaaaaa";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ParcelSizeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "aaaaaaaaaa";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ParcelSizeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "aaaaaaaaaaa";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ParcelSizeMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "aaaaa";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Status
        [TestMethod]
        public void StatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "a";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "aa";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "aaaaaaaaaaaaaaaaaaa";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "aaaaaaaaaaaaaaaaaaaa";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "aaaaaaaaaaaaaaaaaaaaa";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "aaaaaaaaaa";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test CustomerNo
        [TestMethod]
        public void CustomerNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 0;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNoMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 2;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 2147483646;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMaxBoundary()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 2147483647;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void CustomerNoMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsOrder AOrder = new clsOrder();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to method
        //    Int32 SomeOrderNo = 1;
        //    Boolean SomeActive = true;
        //    string SomeCollectionPostcode = "LE2 7EE";
        //    string SomeDestinationCountry = "UK";
        //    string SomeDestinationPostcode = "LE2 7FZ";
        //    DateTime TestDateCreated = DateTime.Now.Date;
        //    string SomeDateCreated = TestDateCreated.ToString();
        //    string SomeParcelSize = "M";
        //    string SomeStatus = "Dispatching";
        //    Int32 SomeCustomerNo = 2147483648;
        //    //invoke the method
        //    Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void CustomerNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeOrderNo = 1;
            Boolean SomeActive = true;
            string SomeCollectionPostcode = "LE2 7EE";
            string SomeDestinationCountry = "UK";
            string SomeDestinationPostcode = "LE2 7FZ";
            DateTime TestDateCreated = DateTime.Now.Date;
            string SomeDateCreated = TestDateCreated.ToString();
            string SomeParcelSize = "M";
            string SomeStatus = "Dispatching";
            Int32 SomeCustomerNo = 1073741824;
            //invoke the method
            Error = AOrder.Valid(SomeOrderNo, SomeActive, SomeCollectionPostcode, SomeDestinationCountry, SomeDestinationPostcode, SomeDateCreated, SomeParcelSize, SomeStatus, SomeCustomerNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
