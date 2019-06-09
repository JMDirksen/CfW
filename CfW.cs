using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace CfW
{
    class CfW
    {
        public string Filename;

        public CfW(string filename)
        {
            Filename = filename;
        }

        public void Run()
        {
            int lastCheckMin = DateTime.Now.Minute;
            while (true)
            {
                if (DateTime.Now.Minute != lastCheckMin)
                {
                    lastCheckMin = DateTime.Now.Minute;
                    Console.WriteLine(lastCheckMin);
                    CheckForMatch(DateTime.Now);
                }
                Thread.Sleep(1000);
            }
        }

        public void CheckForMatch(DateTime dt)
        {
            using(StreamReader file = new StreamReader(Filename))
            {
                string line;
                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    Console.WriteLine(String.Format("{0} {1}", dt.ToString(), line));
                }
            }
        }

    }
}
