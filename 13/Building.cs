using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    public class Building
    {
        public static int count = 0;
        public int id { get; set; } = 340001;
        private double height;
        private double h
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        public int cStoreys { get; set; }
        public int cFlats { get; set; }
        public int cEntrance { get; set; }
        public double GetHeightOfStory()
        {
            return h / cStoreys;
        }
        public double GetAverageCountFlatsInEntrance()
        {
            return (double)cFlats / cEntrance;
        }
        public double GetAverageCountFlatsOnStorey()
        {
            return (double)cFlats / cStoreys;
        }
        public Building()
        {
            id += count;
            count++;
        }
        internal Building(double height,int CStoryes, int CFlats,int CEntrance) : this()
        {
            h=height;
            cStoreys = CStoryes;
            cFlats = CFlats;  
            cEntrance = CEntrance;  

        }
        public override string ToString()
        {
            return $"высота: {h}, количество квартир: {cFlats}, количество этажей {cStoreys}, количество подъездов:{cEntrance}";
        }
    }
}
