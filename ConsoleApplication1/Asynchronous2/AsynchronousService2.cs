using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Asynchronous2
{
    public class AsynchronousService2
    {
        public async Task<int> CalculateTaskRunAsync(int start, int end)
        {
            int value = 0;
            await Task.Run(() => {
                Console.WriteLine($"CalculateTaskRunAsync Current Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                for (int i = start; i < end; i++)
                {
                    value += 1;
                }
            });
            await Task.Delay(10000);

            return value;
        }

        public async Task<int> CalculateAsync(int start, int end)
        {
            var task = await Task.FromResult<int>(Calculate(start, end));

            await Task.Delay(10000);

            return task;
        }

        private int Calculate(int start, int end)
        {
            Console.WriteLine($"Calculate Current Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            int value = 0;
            for (int i = start; i < end; i++)
            {
                value += 1;
            }
            return value;
        }
    }
}
