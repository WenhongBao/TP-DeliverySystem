using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace Test_Framework
{

    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }

        //TEST PROPERTY OK

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrder.Count = SomeCount;
            //test to see that it exists
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.Active = true;
            TestItem.CollectionPostcode = "LE2 7EE";
            TestItem.DestinationCountry = "United Kingdom";
            TestItem.DestinationPostcode = "LE2 7FZ";
            TestItem.DateCreated = "2018/02/01";
            TestItem.ParcelSize = "M";
            TestItem.Status="Dispatching";
            TestItem.CustomerNo = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //set the properties of the test object
            TestItem.OrderNo = 1;
            TestItem.Active = true;
            TestItem.CollectionPostcode = "LE2 7EE";
            TestItem.DestinationCountry = "United Kingdom";
            TestItem.DestinationPostcode = "LE2 7FZ";
            TestItem.DateCreated = "2018/02/01";
            TestItem.ParcelSize = "M";
            TestItem.Status = "Dispatching";
            TestItem.CustomerNo = 1;
            //assign the data to the property
            AllOrders.ThisOrder = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set the properties of the test object
            TestItem.OrderNo = 1;
            TestItem.Active = true;
            TestItem.CollectionPostcode = "LE2 7EE";
            TestItem.DestinationCountry = "United Kingdom";
            TestItem.DestinationPostcode = "LE2 7FZ";
            TestItem.DateCreated = "2018/02/01";
            TestItem.ParcelSize = "M";
            TestItem.Status = "Dispatching";
            TestItem.CustomerNo = 1;
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        //[TestMethod]
        //public void AllTutorsOK()
        //{
        //    //create an instance of the class we want to create
        //    clsOrderCollection AllOrders = new clsOrderCollection();
        //    //create some test data to assign to the property
        //    //in this case the data needs to be a list of objects
        //    List<clsOrder> TestList = new List<clsOrder>();
        //    //add an item to the list
        //    //create the item of test data
        //    clsOrder TestItem = new clsOrder();
        //    TestItem.OrderNo = 1;
        //    TestItem. = "Parker";
        //    TestList.Add(TestItem);
        //    Tutors.AllTutors = TestList;
        //    Assert.AreEqual(Tutors.AllTutors, TestList);
        //}

        [TestMethod]
        public void TwoOrdersPresent()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 33;
            TestItem.Active = true;
            TestItem.CollectionPostcode = "LE2 7EE";
            TestItem.DestinationCountry = "United Kingdom";
            TestItem.DestinationPostcode = "LE2 7FZ";
            TestItem.DateCreated = "2018/02/01";
            TestItem.ParcelSize = "M";
            TestItem.Status = "Dispatching";
            TestItem.CustomerNo = 1;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            //TestItem.OrderNo = 33;
            TestItem.Active = true;
            TestItem.CollectionPostcode = "LE2 7EE";
            TestItem.DestinationCountry = "United Kingdom";
            TestItem.DestinationPostcode = "LE2 7FZ";
            TestItem.DateCreated = "2018/02/01";
            TestItem.ParcelSize = "M";
            TestItem.Status = "Dispatching";
            TestItem.CustomerNo = 1;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //modify the test data
            //TestItem.OrderNo = 33;
            TestItem.Active = true;
            TestItem.CollectionPostcode = "LE2 7EE";
            TestItem.DestinationCountry = "United Kingdom";
            TestItem.DestinationPostcode = "LE2 7FZ";
            TestItem.DateCreated = "2018/02/01";
            TestItem.ParcelSize = "M";
            TestItem.Status = "Delivered";
            TestItem.CustomerNo = 1;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the recode
            AllOrders.Update();
            //find the recode
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisTutor matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void FilterByDateCreatedMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.FilterByDateCreated("2018/02/01");
            //test to see ThisTutor matches the test data
            Assert.AreEqual(5, FilteredOrders.Count);
        }

        [TestMethod]
        public void FilterByDateCreatedTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredOrders.FilterByDateCreated("2018/02/01");
            if (FilteredOrders.Count == 5)
            {
                //check that the first record is ID 1
                if (FilteredOrders.OrderList[0].OrderNo != 33)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderNo != 34)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
