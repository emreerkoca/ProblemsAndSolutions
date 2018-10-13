using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAndSolutions
{
    public class PalindromeNumbers
    {
        //A palindromic number is a number (in some base ) that is the same when written
        //forwards or backwards, i.e., of the form . The first few palindromic numbers
        //are therefore are 0, 4, 44, 55, 66, 77, 88, 99, 101, 111, 121

        public PalindromeNumbers(int number)
        {
            string numberForward = number.ToString();
            string numberBackward = string.Empty;

            for(int i = numberForward.Length - 1; i >= 0; i--)
            {
                numberBackward += numberForward[i];
            }

            if(numberBackward == numberForward)
            {
                Console.WriteLine(number + " is palindrome number.");
            }
            else
            {
                Console.WriteLine(number + " is not palindrome number.");

            }
        }
    }
}
