using ATIS_lab4_var6.Enums;
using System;

namespace ATIS_lab4_var6
{
    internal class Reptilies : Animals 
    {
        public Reptilies(Guid ID, string condition, string type, string enclosure, string diet, string therapy) 
            : base(ID, condition, type, enclosure, diet, therapy) { }
    }
}
