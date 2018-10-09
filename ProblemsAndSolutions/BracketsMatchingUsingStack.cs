using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsAndSolutions
{
    class BracketsMatchingUsingStack
    {
        //Problem: Brackets matching
        //Right formats: ({}), (()){}(), ({}())
        //Wrong formats: ({}(, ){}), (()
        //Write a method with a string parameter
        //if string patemeter value is right formats return true
        //else return false

        public bool GetBracketsMatchingBool(string parenthesis)
        {
            bool control = false;
            Stack<Char> stack = new Stack<Char>(); 

            for(int i = 0; i < parenthesis.Length; i++)
            {
                char c = parenthesis[i];
                if (c == '{' || c == '(')
                {
                    stack.Push(c);
                }
                else if(c == '}' || c == ')')
                {
                    if(stack.Count() == 0)
                    {
                        control = false;
                        return control;
                    }

                    if(c == '}')
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if(c == ')')
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return stack.Count() == 0;
        }

    }
}
