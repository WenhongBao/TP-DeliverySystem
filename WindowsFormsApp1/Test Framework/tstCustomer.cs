using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void testInstanceOk()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
    }
}
