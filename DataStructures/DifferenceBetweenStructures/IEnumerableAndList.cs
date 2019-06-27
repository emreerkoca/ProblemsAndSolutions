using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DifferenceBetweenStructures
{
    public class IEnumerableAndList
    {
        IEnumerable<int> numbersIEnumerable = from value in Enumerable.Range(0, 5) select value;

        public IEnumerableAndList()
        {
            //IEnumerable is an interface
            //IEnumerable is read-only, so you can' t (add or update or remove) IEnumerable items

            //You can convert IEnumerable to List
            //You can (add or update or remove) List items

            //IEnumerable
            Console.WriteLine("IEnumerable");

            foreach (int number in numbersIEnumerable)
            {
                Console.WriteLine(number);
            }

            //List
            List<int> numberList = numbersIEnumerable.ToList();

            Console.WriteLine("List");

            numberList.Add(56);

            for (int i = 0; i < numberList.Count(); i++)
            {
                numberList[i] += 5;
                Console.WriteLine(numberList[i]);
            }
        }
    }
}
