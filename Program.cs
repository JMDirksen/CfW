using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CfW
{
    class Program
    {
        static void Main(string[] args)
        {
            CfW cfw = new CfW("test.cfw");
            //cfw.Run();
            cfw.CheckForMatch(Convert.ToDateTime("2019-06-09 12:00"));

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
