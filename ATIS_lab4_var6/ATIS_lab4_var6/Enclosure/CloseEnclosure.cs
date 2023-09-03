using ATIS_lab4_var6.Enums;

namespace ATIS_lab4_var6
{
    internal class CloseEnclosure : Enclosure
    {
        public CloseEnclosure(string statusDes, string statusClean, string temperature, string statusTemperature) 
            : base(EnclosureType.Close, statusDes, statusClean, temperature, statusTemperature ) {}
    }
}
