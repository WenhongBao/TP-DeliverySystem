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
            DateTime SomeDateCreated = Convert.ToDateTime("16/09/2018");
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
            DateTime SomeDateCreated = Convert.ToDateTime("01/02/2018");
            double SomePrice = 1.1;
            string SomePostcode = "LE2 7FZ";
            Int32 SomeOrderNo = 1;
            //invoke the method
            Error = AInvoice.Valid(SomeInvoiceNo, SomeDateCreated, SomePrice, SomePostcode, SomeOrderNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
