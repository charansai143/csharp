using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Sample1
    {
        //Constructor
        public Sample1() { }

        //Destructor
        ~Sample1() { }

        //Field
        public Sample1 s = null;
        public Int32 i = 0;
        public string str = string.Empty;

        //Property
        public string strProp { get; set; }//Auto-property press tab twice by typing prop

        //Function
        public string DoSomething()
        {
            return $"Value of strProp is:{strProp}";
        }

    }
}
