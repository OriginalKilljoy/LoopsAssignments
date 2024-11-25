using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignments
{
    internal class Oppgave1
    {
        private string navn = "Terje er kul";
        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(navn);
            }
        }
    }
}
