using System;

namespace Lesson1
{
    static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");

            MyClass myClass = new ()
            {
                Pro = 3
            };

            Console.WriteLine(myClass.Pro);
        }
    }

    class MyClass
    {
        public int Pro { get; set; }
    }
}
