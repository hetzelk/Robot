using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstractSample
{
    abstract class absClass
    {
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }
    
    class absDerived : absClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            absDerived calculate = new absDerived();
            int added = calculate.AddTwoNumbers(10, 20);
            int multiplied = calculate.MultiplyTwoNumbers(10, 20);
            Console.WriteLine("Added : {0}, Multiplied: { 1}", added, multiplied);
        }
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
