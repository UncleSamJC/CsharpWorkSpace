using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static string[] Keywords = {"abstract","add*", "as", "asending","cubse","break" };
        static void Main(string[] args)
        {
            IEnumerable<string> selection = from word in Keywords
                                            where !word.Contains('a')
                                            select word;
            foreach (var item in selection)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> fileNames = Directory.GetFiles(@"C:\", searchPattern:"*p*");

            IEnumerable<FileInfo> fileInfos = from fileName in fileNames
                                              select new FileInfo(fileName);

            foreach (var item in fileInfos)
            {
                Console.WriteLine(item.ToString() + item.LastWriteTime);
            }

            Console.ReadLine();
        }
    }
}
