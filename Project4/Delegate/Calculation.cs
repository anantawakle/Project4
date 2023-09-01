using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Delegate
{
    public class Calculation
    {   public delegate int MyDelegate(int x, int y);
        public delegate double Delegate(double x, double y);
        public int Addition(int a,int b)
        {
            return a + b;
        }
        public double Division(double a,double b) 
        {
            return a / b;
        }


        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            MyDelegate myDelegate = c1.Addition;
            // invoke the method using delegate//
            int result = myDelegate.Invoke(45, 67);
            Console.WriteLine(" The addition is "+result);
            
        }
    }
}
