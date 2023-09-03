using ATIS_lab4_var6.Enums;
using System;

namespace ATIS_lab4_var6
{
    internal class Mammals : Animals
    {
        public Mammals(Guid ID, string condition, string type, string enclosure, string diet, string therapy)
            : base(ID, condition, type, enclosure, diet, therapy) { }
    }
}
