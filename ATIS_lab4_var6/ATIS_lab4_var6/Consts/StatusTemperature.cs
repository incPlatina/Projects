using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6.Enums
{
 
    /// <summary>
    /// Статус температуры вольера
    /// </summary>
    public static class StatusTemperature
    {
        public static readonly string Cooling = "Охлаждение";
        public static readonly string Heating = "Обогрев";
        public static readonly string NotChange = "Нет изменения температуры"; 
    }
}
