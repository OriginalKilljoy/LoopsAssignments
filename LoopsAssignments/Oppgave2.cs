using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignments
{
    internal class Oppgave2
    {
        Oppgave1 oppgave = new Oppgave1();
        public void Run()
        {
            string myString = UserInput();
            foreach (var letter in myString)
            {
                Console.WriteLine(letter);
            }
            oppgave.Run();
        }

        private string UserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
