using NewLife.Log;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeleteFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            XTrace.UseConsole();
            SMTS.ServiceMain();
            Console.ReadKey();
        }
    }
}
