using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using namespace std 

namespace ATIS_lab4_var6
{
    internal class Person
    {
        public Guid ID;
        public string position;
        public string name;
        
        public Person(Guid ID1, string position1, string name1)
        {
            ID = ID1;
            position = position1;
            name = name1;   
        }
    }
}
