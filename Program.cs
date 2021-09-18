using System;

namespace AbstractClassExample
{
    class parent { }
    sealed class child : parent { }
    class example
    {
        public static void ex()
        {

        }
    }

    abstract class abstractexample
    {
        int a = 5;
        protected int b = 10;
        public void printa()
        {
            Console.WriteLine("Value of a : " + a);
        }
        public virtual void printb()
        {
            Console.WriteLine("Value of b : " + b);
        }
    }

    class sample : abstractexample
    {
        int a = 10;
        int b = 20;
        public override void printb()
        {
            Console.WriteLine("Value of sample b: " + base.b);
            Console.WriteLine("Value of sample b: " + b);
        }
    }

    class sample2 : abstractexample
    {

    }
    class Program
    {

        class AbstractClassExample
        {
            public static void Main()
            {
                //Static class example
                //example.ex();

                //Abstract class example
                sample s = new sample();
                s.printa();
                s.printb();

                sample2 s2 = new sample2();
                s2.printa();
                s2.printb();

                //-2,147,483,647 to 2,147,483,647
                checked
                {
                    try
                    { 
                        
                        int a = Int32.MaxValue;
                        Console.WriteLine("Value of a: " + a);
                        a++;
                        Console.WriteLine("Value of a: " + a);
                        a++;
                        Console.WriteLine("Value of a: " + a);
                    }
                    catch(Exception)
                    {

                    }
                }
            }
        }
    }
}
