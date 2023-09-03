using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class MenuKod
    {
        public static List<Command> vCom = new List<Command>();  //Инициатор
        

        public static void menuKod()
        {
            Editor ed = new Editor();
            vCom.Add(new AddAnimal(ed));
            vCom.Add(new RemoveAnimal(ed));
            vCom.Add(new Desinfection(ed));
            vCom.Add(new Cleaning(ed));
            vCom.Add(new Feed(ed));
            vCom.Add(new Treatment(ed));
            vCom.Add(new Cooling(ed));
            vCom.Add(new Heating(ed));
            vCom.Add(new ChangeState(ed));
            vCom.Add(new Move(ed));
        }
        public static void menuReal(int i)
        {
            vCom[i].execute();
        }

        public void Close()
        {
            vCom.Clear();
        }

    }
}
