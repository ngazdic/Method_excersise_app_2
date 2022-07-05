using System;
namespace Methods_Excersise_App_2
{
    public class Calculations
    {
       

            public static int Add(int num1, int num2)
            {

                return num1 + num2;


            }

            public static int Subtract(int num1, int num2)
            {

                return num1 - num2;


            }

            public static int Multiply(int num1, int num2)
            {

                return num1 * num2;


            }

            public static int Divide(int num1, int num2)
            {

                return num1 / num2;


            }




        public static int AddParams(params int[] numbers)
        {
            int total = 0;


            foreach (int i in numbers)
            {
                total += i;
            }
            return total;
        }
        }
    }


