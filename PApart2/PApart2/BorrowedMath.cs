using System;
namespace PApart2
{

    //Library taken from: https://github.com/kms0079/seng560-Assignment1/blob/master/arithmeticLibrary/src/main/ArithmeticFunctions.java


    public class BorrowedMath
    {

        //adds two float values
        public float addition(float value1, float value2)
        {
            return value1 + value2;
        }

        //subtracts value2 from value 1 both of type float
        public float subtraction(float value1, float value2)
        {
            return value1 - value2;
        }

        //multiplies two float values
        public float multiplication(float value1, float value2)
        {
            return value1 * value2;
        }

        //divides two float values
        public float division(float value1, float value2)
        {
            return value1 / value2;
        }

        //returns the square root of a provided float value
        public float squareRoot(float value1)
        {
            return (float)Math.Sqrt(value1);
        }

        //performs exponent calculation of two float values (number, exponent)
        public float exponent(float value1, float value2)
        {
            return (float)Math.Pow(value1, value2);
        }

    }
}
