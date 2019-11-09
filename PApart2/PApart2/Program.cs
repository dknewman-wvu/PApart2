using System;

namespace PApart2
{
    class Program
    {
        public static BorrowedMath b1;

        static void Main(string[] args)
        {
            b1 = new BorrowedMath();
         
            Console.WriteLine("ADD 2 + 2 = " + b1.addition(2.0f, 2.0f));
            Console.WriteLine("SUBTRACT 2 - 2 = " + b1.subtraction(2.0f, 2.0f));
            Console.WriteLine("MULTIPLY 5 x 5 = " + b1.multiplication(5.0f, 5.0f));
            Console.WriteLine("DIVIDE 10 / 2 = " + b1.division(10.0f, 5.0f));
            Console.WriteLine("SQUARE ROOT 25 = " + b1.squareRoot(25.0f));
            Console.WriteLine("EXPONENT 4 ^ 3 = " + b1.exponent(4.0f, 3.0f));

            
        }
    }
}
