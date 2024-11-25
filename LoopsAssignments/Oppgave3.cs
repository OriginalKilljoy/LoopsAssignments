using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignments
{
    internal class Oppgave3
    {
        int number = 1;
        public void Run()
        {
            while(number <= 10)
            {
                Console.WriteLine($"Runde nummer {number}");
                number++;
            }
        }
    }
}
