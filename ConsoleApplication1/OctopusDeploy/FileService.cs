using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.OctopusDeploy
{
    internal class FileService
    {
        internal void CreateFile(string filePath, IEnumerable<Movie> movies)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(movies));
        }
    }
}
