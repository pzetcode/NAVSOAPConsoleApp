using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAVSOAPConsoleApp.NAVService;

namespace NAVSOAPConsoleApp
{
    class Program
    {                       

        static void Main(string[] args)
        {
            Letters_Binding letters = new Letters_Binding();
            letters.UseDefaultCredentials = true;
            letters.Url = "http://localhost:7047/DynamicsNAV100/WS/CRONUS%20CZ%20s.r.o./Codeunit/Letters";
            
            string inputstring = "nav soap web services";
            string outputstring = letters.CapitalizeName(inputstring);
            Console.WriteLine(outputstring);

            Console.ReadKey();
        }
    }
}