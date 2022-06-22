using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHFStream
{
    public class MemoryStreamTest
    {
        static public void Test()
        {
            using (var mem = new MemoryStream())
            {
                using (var writer = new StreamWriter(mem))
                {
                    writer.WriteLine("The value is {0:0.00}", 123.45678);
                }
                Console.WriteLine(Encoding.UTF8.GetString(mem.ToArray()));
            }
        }
    }
}
