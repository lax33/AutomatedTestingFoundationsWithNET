using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    [Serializable]
    public class EngineBusAndTruc
    {
        public string automobileModel;
        public string typeEngin;
        public double capacity;
        public long serialNumber;

        public EngineBusAndTruc(){}

       public EngineBusAndTruc(string automobileModel, string typeEngin, double capacity, long serialNumber)
       {
            this.automobileModel= automobileModel;
            this.typeEngin= typeEngin;
            this.capacity= capacity;
            this.serialNumber= serialNumber;
       }
    }
}
