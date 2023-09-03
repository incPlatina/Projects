using ATIS_lab4_var6.Enums;
using System;
using System.Collections.Generic;

namespace ATIS_lab4_var6
{
    internal class FactoryAnimals
    {
        public static List <Animals> animals = new List<Animals>();
      
        public enum IDAnimals { Mammals_Id, Birds_Id, Reptilies_Id };
        //Набор животных
        public static void SetAnimals()
        {
            
            Animals animal = new Mammals(Guid.NewGuid(), ConditionTypes.Healthy, AnimalTypes.Mammals, "1", "нет", "нет");
            animals.Add(animal);
            animal = new Mammals(Guid.NewGuid(), ConditionTypes.Healthy, AnimalTypes.Mammals, "1", "нет", "нет");
            animals.Add(animal);
            animal = new Mammals(Guid.NewGuid(), ConditionTypes.Sick, AnimalTypes.Mammals, "1", "нет", "улучшить рацион");
            animals.Add(animal);



            animal = new Birds(Guid.NewGuid(), ConditionTypes.Sick, AnimalTypes.Bird, "2", "нет", "лекарства от обезвоживания");
            animals.Add(animal);
            animal = new Birds(Guid.NewGuid(), ConditionTypes.Healthy, AnimalTypes.Bird, "2", "нет", "нет");
            animals.Add(animal);
            animal = new Birds(Guid.NewGuid(), ConditionTypes.Healthy, AnimalTypes.Bird, "2", "нет", "нет");
            animals.Add(animal);
            animal = new Birds(Guid.NewGuid(), ConditionTypes.Died, AnimalTypes.Bird, "2", "нет", "нет");
            animals.Add(animal);



            animal = new Reptilies(Guid.NewGuid(), ConditionTypes.Died, AnimalTypes.Reptile, "3", "нет", "нет");
            animals.Add(animal);
            animal = new Reptilies(Guid.NewGuid(), ConditionTypes.Healthy, AnimalTypes.Reptile, "3", "нет", "нет");
            animals.Add(animal);
            animal = new Reptilies(Guid.NewGuid(), ConditionTypes.Sick, AnimalTypes.Reptile, "3", "нет", "Улучшить питание");
            animals.Add(animal);
            animal = new Reptilies(Guid.NewGuid(), ConditionTypes.Healthy, AnimalTypes.Reptile, "3", "нет", "нет");
            animals.Add(animal);
        }


        public static Animals createAnimal(IDAnimals id, string condition, string type, string enclosure, string diet, string therapy)
        {
            switch (id)
            {
                case IDAnimals.Mammals_Id:
                    {
                        Animals animal = new Mammals(Guid.NewGuid(), condition, type, enclosure, diet, therapy);
                        animals.Add(animal);
                        return animal;
                    }
                case IDAnimals.Birds_Id:
                    {
                        Animals animal = new Birds(Guid.NewGuid(), condition, type, enclosure, diet, therapy);
                        animals.Add(animal);
                        return animal;
                    }
                case IDAnimals.Reptilies_Id:
                    {
                        Animals animal = new Reptilies(Guid.NewGuid(), condition, type, enclosure, diet, therapy);
                        animals.Add(animal);
                        return animal;
                    }
                default:
                    return null;

            }
        }

    }
}
