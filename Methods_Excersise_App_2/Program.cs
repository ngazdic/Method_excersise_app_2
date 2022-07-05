
using Methods_Excersise_App_2;




Console.WriteLine(Calculations.Add(2,4));
Console.WriteLine(Calculations.Subtract(2, 4));
Console.WriteLine(Calculations.Multiply(2, 4));
Console.WriteLine(Calculations.Divide(2, 4));
Console.WriteLine(Calculations.AddParams(2, 4, 5, 7));






































//using System;

//namespace Methods_Excersise_App_2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var name = Console.ReadLine();
//            int result = Add(2, 4);
//            int resultSubtracting = Subtract(5, 7);
//            int resultMultiply = Multiply(2, 7);
//            int resultDivide = Divide(10, 2);
//            int resultParams = AddParams(2, 4, 6);

//            Console.WriteLine(result);
//            Console.WriteLine(resultSubtracting);
//            Console.WriteLine(resultMultiply);
//            Console.WriteLine(resultDivide);
//            Console.WriteLine(resultParams);


//        }

//        public static int Add(int num1, int num2)
//        {

//            return num1 + num2;


//        }

//        public static int Subtract(int num1, int num2)
//        {

//            return num1 - num2;


//        }

//        public static int Multiply(int num1, int num2)
//        {

//            return num1 * num2;


//        }

//        public static int Divide(int num1, int num2)
//        {

//            return num1 / num2;


//        }




//        public static int AddParams(params int[] numbers)
//        {
//            int total = 0;


//            foreach (int i in numbers)
//            {
//                total += i;
//            }
//            return total;
//        }
//    }

//}



