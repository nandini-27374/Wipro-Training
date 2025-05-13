using System;

delegate void CustomDel(string s);
    
    class TestClass
    {
        static void Hello(string s)
        {
            Console.WriteLine($"Hello,{s}!");
        }

        static void Goodbye(string s)
        {
            Console.WriteLine($"Goodbye,{s}!");
        }
        
        static void Main()
        {
            CustomDel hiDel, byeDel, multiDel,multiMinusHiDel;
            hiDel = Hello;
            //create the delegate object byeDel that references the
            //method Goodbye

            byeDel = Goodbye;

            multiDel = hiDel + byeDel;

            multiMinusHiDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate hiDel");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel");
            multiDel("C");
            Console.WriteLine("Invoking delegate nultiMinusHidel:");
            multiMinusHiDel("D");


        }
    }