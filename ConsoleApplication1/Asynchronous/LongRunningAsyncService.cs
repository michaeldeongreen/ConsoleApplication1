using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Asynchronous
{
    public class LongRunningAsyncService
    {
        public async Task<string> WhatIsMyName()
        {
            var name = await GetMyName();

            return name;
        }

        public async Task<string> WhatIsMyNameException()
        {
            var name = await GetMyName();

            throw new Exception("I threw an exception");

            return name;
        }

        protected async Task<string> GetMyName()
        {
            await Task.Delay(10000);

            return "yaboy58";
        }

        

    }
}
