using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAndSolutions
{
    public class FindMissingValue
    {
        Dictionary<int, int> numberList = new Dictionary<int, int>() { { 1, 2 }, { 2, 3 }, { 3, 22 }, { 4, 33 }, { 5, 21 }, { 6, 36 }, { 7, 242 }, { 8, 323 }, { 9, 2188 }, { 10, 36 } };
        Dictionary<int, int> numberListBackup = new Dictionary<int, int>() { { 1, 2 }, { 2, 3 }, { 3, 22 }, { 4, 33 }, { 5, 21 }, { 6, 36 }, { 7, 242 }, { 8, 323 }, { 9, 2188 }, { 10, 36 } };
        int keysSum = 0;

        public FindMissingValue()
        {

            keysSum = numberList.Count * (numberList.Count + 1) / 2; //the sum of consecutive numbers from 1 to n = n * (n + 1)/2;

            Random rnd = new Random();
            numberList.Remove(rnd.Next(1, 10)); //Remove one item ramomly 

            //Find missing value according to key
            int missingKeysSum = 0;

            foreach (var item in numberList)
            {
                missingKeysSum += item.Key;
            }

            int missingKey = keysSum - missingKeysSum;

            Console.WriteLine("Missing value: {0}", numberListBackup[missingKey].ToString());
        }
    }
}
