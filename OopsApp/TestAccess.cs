using System;
using System.Collections.Generic;
using System.Text;

namespace OopsApp
{
    internal class TestAccess
    {
        public int TAProp { get; set; }
        Test.TestAcrossNamespace obj = new Test.TestAcrossNamespace();//Field


        IAmPrrivate obj1= new IAmPrrivate(); //we cant

        IAmInternal obj2 = new IAmInternal(); // we cant


        private class IAmPrrivate
        {
            public int IAPProp { get; set; }


            IAmInternal obj = new IAmInternal();// we cam 
        }
        internal class IAmInternal
        {
            public int IAPuProp { get; set; }
            IAmPrrivate obj = new IAmPrrivate();// we can 
        }
    }
}
namespace Test
{
    internal class TestAcrossNamespace
    {
        public int DifferentNameSpaceProp { get; set; }

        //Accessiing above namespace class
        OopsApp.TestAccess obj = new OopsApp.TestAccess();

        OopsApp.TestAccess.IAmInternal obj2  = new OopsApp.TestAccess.IAmInternal(); //we cant
        //OopsApp.TestAccess.IAmPrivate obj1= new OopsApp.TestAccess.IAmPrivate();// we cant
    }
}
