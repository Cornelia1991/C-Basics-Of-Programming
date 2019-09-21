using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLecture
{
    //common practice: begin name of interface with "I"

    interface IMyInterface
    {
        // all method specified in interface must be public
        //declare methods but on implement how they work
        void SomeMethod();
        int AnotherMethod(string sameString);
    }

    class MyClass : IMyInterface
    {
        //methods must match the return types of all metheds in interface

        private int x, y;

        public void myMethod()
        {
            //method code
        }

        public void SomeMethod()
        {
            //method code
        }

        public int AnotherMethod(string myString)
        {
            return 1;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface MyInterface;
            MyClass myClassObject = new MyClass();

            MyInterface = myClassObject;

            MyInterface.SomeMethod();
            MyInterface.AnotherMethod("hello");
        }
    }
}
