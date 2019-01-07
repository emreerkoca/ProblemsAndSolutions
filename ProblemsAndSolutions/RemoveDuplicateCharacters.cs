using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAndSolutions
{
    public class RemoveDuplicateCharacters
    {
        string text = "aaaaabbcccddeeeeffffffdd";
        //output should be: 'abcdef'


        public RemoveDuplicateCharacters()
        {
            StringBuilder strBuilder = new StringBuilder();

            foreach (var character in text)
            {
                if(strBuilder.ToString().Contains(character))
                {
                    continue;
                }
                else
                {
                    strBuilder.Append(character);
                }
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
