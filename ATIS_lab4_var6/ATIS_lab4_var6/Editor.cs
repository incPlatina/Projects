using ATIS_lab4_var6.Enums;
using System;

namespace ATIS_lab4_var6
{
    internal class Editor
    {
        public void addAnimal(FactoryAnimals.IDAnimals id, string condition, string type, string enclosure, string diet, string therapy) 
        {
            FactoryAnimals.createAnimal(id, condition, type, enclosure, diet, therapy);
        }

        public void removeAnimal(int i)
        {
            FactoryAnimals.animals.RemoveAt(i);
        }

       

        public void desinfection(int i)
        {
            Enclosure.enclosures[i].StatusDes = "Да";
        }

        public void cleaning(int i)
        {
            Enclosure.enclosures[i].StatusClean = CleanStatus.Clean;
        }

        public void feeding(int i)
        {
            FactoryAnimals.animals[i].Diet = "Да";
        }

        public void treatment(string therapy, int i)
        {
            FactoryAnimals.animals[i].Therapy = therapy;
        }

        public void cooling(int i)
        {
            Random rnd = new Random();
            int temp = int.Parse(Enclosure.enclosures[i].Temperature) - rnd.Next(2, 6);
            Enclosure.enclosures[i]._StatusTemperature = Enums.StatusTemperature.Cooling;
            Enclosure.enclosures[i].Temperature = temp.ToString();
        }

        public void heating(int i)
        {
            Random rnd = new Random();
            int temp = int.Parse(Enclosure.enclosures[i].Temperature) + rnd.Next(2, 6);
            Enclosure.enclosures[i]._StatusTemperature = Enums.StatusTemperature.Heating;
            Enclosure.enclosures[i].Temperature = temp.ToString();
        }

        public void changeState(int i, string state)
        {
            FactoryAnimals.animals[i].Сondition = state;
        }

        public void move(int i, string enclosure)
        {
            FactoryAnimals.animals[i].Enclosure = enclosure;
        }
    }
}
