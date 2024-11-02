using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [Flags]
    public enum Security
    {
        Guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8,
    }
}
