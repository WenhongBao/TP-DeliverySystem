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

    }
}
