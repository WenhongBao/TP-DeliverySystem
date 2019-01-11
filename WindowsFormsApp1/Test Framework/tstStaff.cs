using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        //TEST PROPERTY OK

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 SomeStaffNo = 1;
            //assign the data to the property
            AStaff.StaffNo = SomeStaffNo;
            //test to see that it exists
            Assert.AreEqual(AStaff.StaffNo, SomeStaffNo);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeEmail = "a@qq.com";
            //assign the data to the property
            AStaff.Email = SomeEmail;
            //test to see that it exists
            Assert.AreEqual(AStaff.Email, SomeEmail);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeFirstName = "Alex";
            //assign the data to the property
            AStaff.FirstName = SomeFirstName;
            //test to see that it exists
            Assert.AreEqual(AStaff.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeLastName = "Peng";
            //assign the data to the property
            AStaff.LastName = SomeLastName;
            //test to see that it exists
            Assert.AreEqual(AStaff.LastName, SomeLastName);
        }

        [TestMethod]
        public void SectionPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeSection = "Manager";
            //assign the data to the property
            AStaff.Section = SomeSection;
            //test to see that it exists
            Assert.AreEqual(AStaff.Section, SomeSection);
        }

        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeTelephone = "07526913273";
            //assign the data to the property
            AStaff.Telephone = SomeTelephone;
            //test to see that it exists
            Assert.AreEqual(AStaff.Telephone, SomeTelephone);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeTitle = "Mr";
            //assign the data to the property
            AStaff.Title = SomeTitle;
            //test to see that it exists
            Assert.AreEqual(AStaff.Title, SomeTitle);
        }

        //Test Method OK

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Alex";
            string SomeLastName = "Peng";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            Boolean Found = false;
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            //invoke the method
            Found = AStaff.Find(SomeStaffNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        //Test property found
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check property on
            if (AStaff.Email != "a@qq.com")
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
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check property on
            if (AStaff.FirstName != "Alex")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check property on
            if (AStaff.LastName != "Peng")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSectionFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check property on
            if (AStaff.Section != "Manager")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check property on
            if (AStaff.Title != "Mr")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelephoneFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check property on
            if (AStaff.Telephone != "07526913273")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to pass to method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check property on
            if (AStaff.StaffNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Test StaffNo
        [TestMethod]
        public void StaffNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 0;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNoMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 2;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 2147483646;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 2147483647;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void StaffNoMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff AStaff = new clsStaff();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to method
        //    Int32 SomeStaffNo = 2147483648;
        //    string SomeEmail = "1030765617@qq.com";
        //    string SomeFirstName = "Parker";
        //    string SomeLastName = "Bao";
        //    string SomeSection = "LE2 7FZ";
        //    string SomeTelephone = "07526913273";
        //    string SomeTitle = "Mr";
        //    //invoke the method
        //    Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
        //    //test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void StaffNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1073741824;
            string SomeEmail = "1030765617@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "LE2 7FZ";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Email
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "aa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "aaaaaaaaaaaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "aaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test FirstName
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "a";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aa";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaaaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaaaaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = AStaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test LastName
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "a";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aa";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaaaaaaaaaaa";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaaaaaaaaaaaa";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaa";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeSection = "Manager";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Section
        [TestMethod]
        public void SectionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SectionMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "a";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SectionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "aa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SectionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "aaaaaaaaaaaaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SectionMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "aaaaaaaaaaaaaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SectionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SectionMid()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "aaaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SectionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeTelephone = "07526913273";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Telephone
        [TestMethod]
        public void TelephoneMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "a";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "aa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "aaaaaaaaaaaaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "aaaaaaaaaaaaaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "aaaaaaaaaaaaaaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMid()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "aaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SomeTitle = "Mr";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Test Title
        [TestMethod]
        public void TitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "11111111111";
            string SomeTitle = "";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "11111111111";
            string SomeTitle = "a";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aa";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaaaaaa";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaaaaaaa";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaaaaaaaa";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMid()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaa";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff ASaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method
            Int32 SomeStaffNo = 1;
            string SomeEmail = "a@qq.com";
            string SomeFirstName = "Parker";
            string SomeLastName = "Bao";
            string SomeSection = "Manager";
            string SomeTelephone = "11111111111";
            string SomeTitle = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ASaff.Valid(SomeStaffNo, SomeEmail, SomeFirstName, SomeLastName, SomeSection, SomeTelephone, SomeTitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
