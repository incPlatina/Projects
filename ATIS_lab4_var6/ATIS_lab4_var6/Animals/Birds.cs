using ATIS_lab4_var6.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class Birds : Animals
    {
        public Birds(Guid ID, string condition, string type, string enclosure, string diet, string therapy) 
            : base(ID, condition, type, enclosure, diet, therapy) { }
    }
}
