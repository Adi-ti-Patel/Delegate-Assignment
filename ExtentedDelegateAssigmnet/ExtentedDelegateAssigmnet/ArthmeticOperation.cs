using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentedDelegateAssigmnet
{
   
    
    public delegate double arithmatic(double x, double y);


    public class ArthmeticOperation
    {

        static void PerformArithmeticOperation(double num1, double num2, arithmatic arOperation)
        {
            var result = arOperation(num1, num2);
            Console.WriteLine(result);
        }
        public void arthematicOperation()
        {
            double n1;
            double n2;
            Console.WriteLine("Please Enter First Number");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            n2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1> Add");
            Console.WriteLine("2> Miltiply");
            Console.WriteLine("3> Subtaract");
            Console.WriteLine("4> Divide");
            Console.WriteLine("5> Exit"); 

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    arithmatic arOperation = (double num1, double num2) => (num1 + num2);
                    PerformArithmeticOperation(n1, n2, arOperation);
                    break;
                case 2:
                    arithmatic arOperation1 = (double num1, double num2) => (num1*num2);
                    PerformArithmeticOperation(n1, n2, arOperation1);
                    break;
                case 3:
                    arithmatic arOperation3 = (double num1, double num2) => num1 - num2;
                    PerformArithmeticOperation(n1, n2, arOperation3);
                    break;
                case 4:
                    arithmatic arOperation4 = (double num1, double num2) => num1 / num2;
                    PerformArithmeticOperation(n1, n2, arOperation4);
                    break;

              
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

    }
}
