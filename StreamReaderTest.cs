using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHFStream
{
    public class StreamReaderTest
    {
        static public void Test()
        {
            var folder = $@".{Path.DirectorySeparatorChar}";// Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var reader = new StreamReader($"{folder}{Path.DirectorySeparatorChar}secret_plan.txt");
            var writer = new StreamWriter($"{folder}{Path.DirectorySeparatorChar}emailToCaptainA.txt");
            writer.WriteLine("To: CaptainAmazing@objectville.net");
            writer.WriteLine("From: Commissioner@objectville.net");
            writer.WriteLine("Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine("We’ve discovered the Swindler’s terrible plan:");
            while (!reader.EndOfStream)
            {
                var lineFromThePlan = reader.ReadLine();
                writer.WriteLine($"The plan -> {lineFromThePlan}");
            }
            writer.WriteLine();
            writer.WriteLine("Can you help us?");
            writer.Close();
            reader.Close();
        }

    }
}
