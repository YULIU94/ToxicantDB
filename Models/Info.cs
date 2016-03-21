using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //信息实体类
    [Serializable]
    public class Info
    {
        //Info
        public string CasId { set; get; }

        public string ChemicalName { set; get; }

        public string ChineseName { set; get; }

        public string TraditionName { set; get; }

        public string RtecsId { set; get; }
        
        //Property
        public string Element { set; get; }

        public string StateInfo { set; get; }

        public string Odor { set; get; }

        public string Color { set; get; }

        public double RelativeMolecularMass { set; get; }

        public double Solubility { set; get; }

        public double Density { set; get; }

        //Toxic
        public string Ld50 { set; get; }

        public string ToxicDetail { set; get; }

        public string HealthHarzard { set; get; }

        public string EnvironmentHarzard { set; get; }

        public string ToxicDegree { set; get; }

        //Aid
        public string AidSkin { set; get; }

        public string AidEye { set; get; }

        public string AidInhalation { set; get; }

        public string AidIngestion { set; get; }
    }
}
