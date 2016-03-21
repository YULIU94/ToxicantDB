using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //理化性质实体类
    [Serializable]
    public class Property
    {
        public string CasId { set; get; }

        public string Element { set; get; }

        public string State { set; get; }

        public string Odor { set; get; }

        public string Color { set; get; }

        public double RelativeMolecularMass { set; get; }

        public double Solubility { set; get; }

        public double Density { set; get; }
    }
}
