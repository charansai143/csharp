using System;

namespace First
{
    class Program
    {
        public static int aInt = 100;
        public static string aStr = "Charan";
        static int temp = 0;
        static void Main(string[] args)
        {
            bool inMain = true;
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hiii");

            //Console.WriteLine(First.Program.aInt);
            //Console.WriteLine(First.Program.aStr);
            //Console.WriteLine(inMain);
            //TypeChanges();
            //CreateArray();
            //CreateArrayofthree(25,85,61);
            //ReadInput();
            //Moviedetails();
            int arg=4;
            squareVal(4);
            //Console.WriteLine($"value of arg after fun call is: {arg}");

            squareRef(ref arg);
            //Console.WriteLine($" value of arg after passing ref, fun call is: {arg}");

            //Testing in and out parameters
            squareIn(in arg);
            
            Guid licensekey = Guid.NewGuid();
            string outstatus = String.Empty;
            bool isVerified=VerifyLicense(in licensekey, out outstatus);
            //Console.WriteLine($"The licesne key is {licensekey}");
            //Console.WriteLine($"License verification returned {isVerified}. The status message  is {outstatus}");

            // Add numbers using params
            //UseParams(10,22,33,44);
            //UseParams(100);
            //UseParams(140,250,850);

            //Demo 9
            //UseDefault(1001);
            //UseDefault(9007,"HP");

            //Demo 10 about class//
            First.Sample1 objSample1 = new First.Sample1();
            objSample1.strProp = "Hello OOPS";
            Console.WriteLine($"Value of strProp is :{objSample1.DoSomething()}");



        }
        static void TypeChanges()
        {
            // TypeCasting
            int changedInt = 0;
            short shortInt = 100;

            changedInt = (int)shortInt;
            //Type Conversion
            string str = "100";
            int convertedToInt= Convert.ToInt32(str);

            Console.WriteLine(changedInt);
            Console.WriteLine(Convert.ToInt32(str));

            //print the datatype of a variable
            Console.WriteLine(changedInt.GetType().Name);
            Console.WriteLine(typeof(int).Name);
        }
        static void CreateArray()
        {
            int[] ints;
            ints = new int[3];
            ints[0] = 111;
            ints[1] = 222;
            ints[2] = 333;
            ints = new int[]{ 100, 200, 300, 400, 500 };
            foreach (int item in ints)
            {
                Console.WriteLine("Current Item:"+item);
                Console.WriteLine($"Current Item: {item}");
            }

        }
        static void CreateArrayofthree(int n1,int n2,int n3)
        {
            int[] result = new int[] { n1, n2, n3 };
            Console.WriteLine($"The value at position 1 is {result[1]}");
        }
        static void ReadInput()
        {
            string input = Console.ReadLine(); //100,200,300,400
            string[] arr = input.Split(',');
            foreach(string item in arr)
            {
                Console.WriteLine($"Value of Item: {item}");
            }
        }
        static void Moviedetails()
        {
            Console.WriteLine("Enter data");
            string input = Console.ReadLine();
            string[] data = input.Split(':');
            Console.WriteLine($"The movie name is: {data[0]}");
            Console.WriteLine($"The director is: {data[1]}");
            string[] cast = data[2].Split(',');
            foreach(string actor in cast)
            {
                Console.WriteLine($"Actor is: {actor}");
            }
        }
        static void squareVal(int valParameter)
        {
            valParameter = valParameter * valParameter;
        }
        static void squareRef(ref int refParameter)
        {
            refParameter = refParameter * refParameter;
        }
        static void squareIn(in int inParameter)
        {
            //inParameter = 100; --Not allowed
            int result = inParameter * inParameter;
            Console.WriteLine($"The result of square using IN parameter: {inParameter}");
        }

        //lsd4-ghsd-y542-cge21 => GUID
        static bool VerifyLicense(in Guid key, out string status)
        {
            if(key!= null)
            {
                status = "Key is validated successfully";
                return true;
            }
            else
            {
                status = "Invalid key";
                return false;
            }
        }
        static void UseParams(params int[] ints)
        {
            int result =0;
            foreach(int item in ints)
            {
                //result=result+item;
                result+=item;
            }
            Console.WriteLine($"The grand total is {result}");
        }
        static void UseDefault(int id,string empPrefix = "SAPI")
        {
            string empId = $"{empPrefix}-{id}-{Guid.NewGuid()}";
            Console.WriteLine($"Genertedd empId is: {empId}");
        }

    }
}

