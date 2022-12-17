using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _13
{
    public class Build
    {
        private Building[] buildings = new Building[10];
        public Building this[int index]
        {
            get
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new ArgumentOutOfRangeException($"Элемента с таким индексом не существует");
                }
                return buildings[index];
            }
            set
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new ArgumentOutOfRangeException($"Элемента с таким индексом не существует ");
                }
                buildings[index] = value;
            }
        }
    }
}
