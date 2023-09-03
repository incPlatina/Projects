using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class Worker : Person
    {
        public Worker(Guid ID, string position, string name) : base(ID, position, name) { }
    }
}
