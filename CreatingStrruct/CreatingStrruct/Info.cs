using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingStrruct
{
    struct Info
    {
        public string Description;
        public int Hours;

        public void PerformedTask()
        {
            Console.WriteLine($"We prepared this {Description} and it only took us {Hours} hours to do it succesfully");
        }
    }
}
