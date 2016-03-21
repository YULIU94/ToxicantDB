using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //毒性实体类
    [Serializable]
    public class Toxic
    {
        public string CasId { set; get; }

        public string Ld50 { set; get; }

        public string ToxicDetail { set; get; }

        public string HealthHarzard { set; get; }

        public string EnvironmentHarzard { set; get; }

    }
}
