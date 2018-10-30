using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetResultFromTaskTResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<object, long> del = (end) => 
            {
                long sum = 0;
                for (int i = 0; i < (int)end; i++)
                {
                    sum += i;
                }

                return sum;
            };

            // Task<long> tsk = new Task<long>(del, 100000);
            // tsk.Start();

            Task<long> tsk = Task.Factory.StartNew(del, 100000);

            Console.WriteLine("程序运行结果为{0}", tsk.Result); // tsk.Result 阻塞线程
            Console.ReadKey();
        }
    }
}
