using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        //TEST PROPERTY OK

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 SomeCutomerNo = 1;
            //assign the data to the property
            ACustomer.CustomerNo = SomeCutomerNo;
            //test to see that it exists
            Assert.AreEqual(ACustomer.CustomerNo,SomeCutomerNo);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeEmail = "a@qq.com";
            //assign the data to the property
            ACustomer.Customer = SomeEmail;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Customer, SomeEmail);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeFirstName = "Parker";
            //assign the data to the property
            ACustomer.Customer = SomeFirstName;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Customer, SomeFirstName);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeLastName = "Bao";
            //assign the data to the property
            ACustomer.Customer = SomeLastName;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Customer, SomeLastName);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomePostCode = "LE2 7EE";
            //assign the data to the property
            ACustomer.Customer = SomePostCode;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Customer, SomePostCode);
        }

        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeTelephone = "07526913273";
            //assign the data to the property
            ACustomer.Customer = SomeTelephone;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Customer, SomeTelephone);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeTitle = "Mr";
            //assign the data to the property
            ACustomer.Customer = SomeTitle;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Customer, SomeTitle);
        }

        //Test Method OK

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ATutor = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ATutor.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            Boolean Found = false;
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(SomeCustomerNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        //Test property found
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check property on
            if (ACustomer.Email != "a@qq.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test property found
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check property on
            if (ACustomer.FirstName != "Parker")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check property on
            if (ACustomer.LastName != "Bao")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check property on
            if (ACustomer.Postcode != "LE2 7EE")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check property on
            if (ACustomer.Title != "Mr")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelephoneFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check property on
            if (ACustomer.Telephone != "07526913273")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check property on
            if (ACustomer.CustomerNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test CustomerNo
        [TestMethod]
        public void CustomerNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 0;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNoMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 2;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 2147483646;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 2147483647;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void CustomerNoMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomer ACustomer = new clsCustomer();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to method
        //    //Error here
        //    Int32 SomeCustomerNo = 2147483648;
        //    string SomeEmail = "1030765617@qq.com";
        //    string SomeFirstName = "Parker";
        //    string SomeLastName = "Bao";
        //    string SomePostcode = "LE2 7FZ";
        //    string SomeTelephone = "07526913273";
        //    string SomeTitle = "Mr";
        //    //invoke the method
        //    Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void CustomerNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1073741824;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Email
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "aa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "aaaaaaaaaaaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "aaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test FirstName
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "a";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "a";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaaaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaaaaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaa";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test LastName
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "a";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aa";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaaaaaaaaaaa";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaaaaaaaaaaaa";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaaaaaaaaaaaaa";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaa";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomePostcode = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Postcode
        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "a";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "aa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "aaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "aaaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "aaaaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "aaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Telephone
        [TestMethod]
        public void TelephoneMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "a";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "aa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "aaaaaaaaaaaaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "aaaaaaaaaaaaaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "aaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Title
        [TestMethod]
        public void TitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "11111111111";
            string SomeTitle = "";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "11111111111";
            string SomeTitle = "a";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aa";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeCustomerNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomePostcode = "LE2 7EE";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerNo, SomeEmail, SomeFirstName, SomeLastName, SomePostcode, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
