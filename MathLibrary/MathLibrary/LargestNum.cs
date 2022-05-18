using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    /// <summary>
    /// This library has three methods to determine which number is largest
    /// </summary>

    public class LargestNum
    {
        public int LargestNumber (int num1, int num2)
        {
            // learned about ternary operators in my Swift class, thought I'd try it out
            return num1 > num2 ? num1 : num2;
        } // end method

        public int LargestNumber (int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else 
            {
                return num3;
            }
        } // end method

        public int LargestNumber (int num1, int num2, int num3, int num4)
        {
            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                return num2;
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                return num3;
            }
            else
            {
                return num4;
            }
        } // end method

    } // end class
} // end namespace
