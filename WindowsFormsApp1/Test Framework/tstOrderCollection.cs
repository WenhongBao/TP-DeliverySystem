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
    }
}
