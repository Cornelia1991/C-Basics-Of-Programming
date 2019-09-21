using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLecture
{
    //protery is like a mixure between a field and a method
    //its used like a field but calls a block of code

    class MyClass
    {
        //short method
        public int MyInteger { get; set; }

        //private int _myInteger; //common pratice use "_" for field that will be used in property
        
        //public int MyInteger //The property || common practice same name as field w/o "_"
        //{
        //    // get and set are know as accessors
        //    //if the proprety does not have a set accessor it is readonly
        //    //if the proprety does not have a get accessor it is writeonly
        //    get
        //    {
        //        return _myInteger;
        //    }
        //    set
        //    {
        //        _myInteger = value;
        //    }
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyObject = new MyClass();

            MyObject.MyInteger = 5; // calls set accessor

            Console.WriteLine(MyObject.MyInteger); //calls get accessor

            Console.ReadKey();
        }
    }
}
