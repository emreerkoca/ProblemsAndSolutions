using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemsAndSolutions
{
    class MultipleThreadSample
    {
        public MultipleThreadSample()
        {
            //Problem:
            //5 threads running at the same time. 
            //Each one creates a new variable apple. 
            //How many apple are generated?

            Worker workerObj = new Worker();
            Thread threadA = new Thread(workerObj.DoWork);
            Thread threadB = new Thread(workerObj.DoWork);
            Thread threadC = new Thread(workerObj.DoWork);
            Thread threadD = new Thread(workerObj.DoWork);
            Thread threadE = new Thread(workerObj.DoWork);


            threadA.Start("A");
            threadB.Start("B");
            threadC.Start("C");
            threadD.Start("D");
            threadE.Start("E");
        }
    }





    class Worker
    {
        private volatile int counter = 0;

        public void DoWork(object data)
        {
            while (true)
            {
                var apple = new Apple();
                counter++;
                Console.WriteLine("Created apple count: {0}", data + "-" + counter.ToString());
            }
        }
    }

    class Apple
    {
    }
}
