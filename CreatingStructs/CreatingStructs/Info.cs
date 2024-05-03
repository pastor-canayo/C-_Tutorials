using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingStructs
{
    struct Info
    {
        public string Description;
        public int Hours;

        public void PerformedTask()
        {
            Console.WriteLine($"I love this delicoius {Description} and only took me {Hours} hours to make it succesfully");
        }
    }
}
