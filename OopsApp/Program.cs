using System;

namespace OopsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 2 persons
            //<datatype> <var-name> = new <datatype>();
            Person Kishore = new Person();
            Person Sai = new Person();
            Person Charan = new Person();
            AssignProperties(ref Sai, "ALHPU3241L", "Sai", 23, "Male", "Chennai", "Wheatish");
            AssignProperties(ref Charan, "ALHPU3241L", "Charan", 25, "Male", "Bangalore", "Wheatish");
            //Call Function for Sai
            CallPersonFunctions(ref Sai);
            CallPersonFunctions(ref Charan);
            //Demo 15
            Square sq = new Square(10);
            Console.WriteLine(sq.CalculateArea());

            Rectangle rec = new Rectangle(10,5);
            Console.WriteLine(rec.CalculateArea());

        }

        private static void CallPersonFunctions(ref Person obj)
        {
            string workStatus = string.Empty;
            bool isWorks = obj.Works("Coding", out workStatus);
            Console.WriteLine($"{obj.Name} Completion status:{isWorks},Work Status:{workStatus}");

            Console.WriteLine(obj.Eats());
            Console.WriteLine($"{obj.Name} has a sleep cycle of {obj.Sleep()}");
            Console.WriteLine(obj.Speaks("Good Day"));
        }

        private static void AssignProperties(ref Person obj, string aadhar, string name, int age, string gender, string address, string complexion)
        {
            obj.Aadhar = aadhar;
            obj.Address = address;
            obj.Age = age;
            obj.Complexion = complexion;
            obj.Gender = gender;
            obj.Name = name;
        }
    }
}
