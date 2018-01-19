using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NetBasic
{
    class Teste
    {
        static void Main(String[] args){
            var lines = ReadFrom("leiame.txt");
            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static IEnumerable<string> ReadFrom(string file)
        {
            using (var reader = File.Open(file, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding e = new UTF8Encoding(true); 
                
                while (reader.Read(b,0,b.Length) > 0)
                {
                    yield return e.GetString(b);
                }
            }
        }
    }
}
