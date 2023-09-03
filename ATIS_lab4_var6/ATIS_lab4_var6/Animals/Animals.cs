using ATIS_lab4_var6.Enums;
using System;

namespace ATIS_lab4_var6
{
    internal class Animals
    {
      
        public Guid ID { get; set; }
        public string Сondition { get; set; }
        public string Type { get; set; }
        public string Enclosure { get; set; } // номер вольера
        public string Diet { get; set; }
        public string Therapy { get; set; } // изменение температуры, еды, инфекция


        public virtual void Function1() { }
        public Animals(Guid id, string condition, string type, string enclosure, string diet, string therapy)
        {
            ID = id;
            Сondition = condition;
            Type = type;
            Enclosure = enclosure;
            Diet = diet;
            Therapy = therapy;
        }
    }
}