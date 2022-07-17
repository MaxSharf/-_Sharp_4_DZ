using System;

namespace С_Sharp_4_DZ
{
    class Program
    {
        static void Main(string[] args)
        {

            Program1();
            //Program2();
            //Program3();
            //Program4();

            Console.ReadKey(true);
        }


        static void Program1()
        {
            Human a1 = new Human();
            a1.FillInfo();
            a1.Out();
        }

    }
}
