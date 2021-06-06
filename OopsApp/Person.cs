using System;
using System.Collections.Generic;
using System.Text;

namespace OopsApp
{
    class Person
    {
        public Person()
        {

        }
        //Banking purposes
        public Person(string aadhar)
        {
            Aadhar = aadhar;
        }
        //Filling a form
        public Person(string name,int age,string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        //Filling afrom for the bank or mobile connection
        public Person(string aadhar,string gender,string address,int age)
            :this(aadhar)
        {
            Aadhar = aadhar;
            Gender = gender;
        }
        //get: return Aadhar
        //set: Aadhar value
        public string Aadhar { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Complexion { get; set; }

        public bool Works(string pTask, out string msg)
        {
            msg=($"{Name} has completed task:{pTask}");
            return true;
        }
        public string Eats()
        {
            return $"{Name} had a specila meal";
        }
        public float Sleep()
        {
            return 8f;//returns 8 as a float
        }
        public string Speaks(string words)
        {
          switch(words.ToLower())
            {
                case "Good Day":
                    return $"{Name}:{words} {Environment.NewLine}Alexa:Good to you tool";
                case "How are you":
                    return $"{Name}:{words}{Environment.NewLine};Alexa:I'm doing good how about you";
                default:
                    return $"{Name}:{words} {Environment.NewLine}:Alexa: couldn't get that";
            }
        }
        ~Person()
        {

        }
    }
}
