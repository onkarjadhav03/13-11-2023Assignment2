using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Salarycal
    {

            public void salcal(int wHours,int nWDays,int projectHandles,int extras)
        {
            double result = wHours * nWDays * 100 + projectHandles * 3000 + extras * 2000;
            Console.WriteLine("salary ="+result);
        }
    
    }
}
