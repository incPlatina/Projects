using ATIS_lab4_var6.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class OpenEnclosure : Enclosure
    {
        public OpenEnclosure(string statusDes, string statusClean, string temperature) 
            : base(EnclosureType.Open, statusDes, statusClean, temperature, "") {}
    }
}
