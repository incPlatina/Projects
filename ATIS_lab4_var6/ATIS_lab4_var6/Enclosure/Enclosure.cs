using ATIS_lab4_var6.Enums;
using System;
using System.Collections.Generic;

namespace ATIS_lab4_var6
{
    internal class Enclosure
    {

        public string Type { get; set; }
        public string StatusDes { get; set; }
        public string StatusClean { get; set; }
        public string Temperature { get; set; }

        public  string _StatusTemperature { get; set; }

        public static List<Enclosure> enclosures = new List<Enclosure>();
        public Enclosure(string type, string statusDes, string statusClean, string temperature, string statusTemperature)
        {
            Type = type;
            StatusDes = statusDes;
            StatusClean = statusClean;
            Temperature = temperature;
            _StatusTemperature = statusTemperature;
        }
        public static void SetEnclosures()
        {
            Random rnd = new Random();
            Enclosure enclosure = new OpenEnclosure("Нет", CleanStatus.Unclean, rnd.Next(-5, 30).ToString());
            enclosures.Add(enclosure);

            enclosure = new CloseEnclosure("Нет", CleanStatus.Unclean, rnd.Next(0, 30).ToString(), StatusTemperature.Cooling);
            enclosures.Add(enclosure);

            enclosure = new CloseEnclosure("Нет", CleanStatus.Clean, rnd.Next(0, 30).ToString(), StatusTemperature.NotChange);
            enclosures.Add(enclosure);

            enclosure = new CloseEnclosure("Нет", CleanStatus.Clean, rnd.Next(0, 30).ToString(), StatusTemperature.Heating);
            enclosures.Add(enclosure); 

            enclosure = new CloseEnclosure("Нет", CleanStatus.Clean, rnd.Next(0, 30).ToString(), StatusTemperature.Cooling);
            enclosures.Add(enclosure);

            enclosure = new OpenEnclosure("Нет", CleanStatus.Unclean, rnd.Next(-5, 30).ToString());
            enclosures.Add(enclosure);

            enclosure = new OpenEnclosure("Нет", CleanStatus.Unclean, rnd.Next(-5, 30).ToString());
            enclosures.Add(enclosure);

            enclosure = new OpenEnclosure("Нет", CleanStatus.Clean, rnd.Next(-5, 30).ToString());
            enclosures.Add(enclosure);
           
        }
    }
}
