using System;

namespace primeFind
{
    public class Program
    {

        /*
        质数又称素数。指在一个大于1的自然数中，除了1和此整数自身外，
        没法被其他自然数整除的数。换句话说，只有两个正因数（1和自己）的自然数即为素数。
        比1大但不是素数的数称为合数。1和0既非素数也非合数。合数是由若干个质数相乘而得到的。
        所以，质数是合数的基础，没有质数就没有合数。这也说明了前面所提到的质数在数论中有着重要地位。
        历史上曾将1也包含在质数之内，但后来为了算术基本定理，最终1被数学家排除在质数之外，
        而从高等代数的角度来看，1是乘法单位元，也不能算在质数之内，并且，
        所有的合数都可由若干个质数相乘而得到。
        在自然数中质数与素数没有区别。

质数(prime number)又称素数，有无限个。一个大于1的自然数，除了1和它本身外，不能被其他自然数整除，换句话说就是该数除了1和它本身以外不再有其他的因数;否则称为合数。

根据算术基本定理，每一个比1大的整数，要么本身是一个质数，要么可以写成一系列质数的乘积;而且如果不考虑这些质数在乘积中的顺序，那么写出来的形式是唯一的。最小的质数是2。
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World is Prime!");
            Console.WriteLine("输入一个数字，判读是否是质素？");
            bool isFlag = IsPrime(Convert.ToInt32(Console.ReadLine()));
            if(isFlag)
            {
                Console.WriteLine("是一个质数！");
            }
            else
            {
                Console.WriteLine("不是一个质数！");
            }
            Console.WriteLine("");
            Console.WriteLine("输入一个数字，判读是否是素数？");
            bool isFlagEx = IsPrimeEx(Convert.ToInt32(Console.ReadLine()));
            if(isFlagEx)
            {
                Console.WriteLine("是一个素数！");
            }
            else
            {
                Console.WriteLine("不是一个素数！");
            }

        }

        /// <summary>
        /// 是否是质数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsPrime(int n)
        {
            if(n < 2)
                return false;
            for(int i = 2; i < n-1; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 是否是素数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsPrimeEx(int n)
        {
            int i = 0;
            double k = Math.Sqrt(n);
            for (i = 2; i <= k; i++)
            {
                if(n%i == 0)
                {
                    break;
                }
            }

            if(i > k)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
