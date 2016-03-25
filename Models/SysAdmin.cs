using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //管理员实体类
    [Serializable]
    public class SysAdmin
    {
        public int AdminId { set; get; }

        public string AdminName { set; get; }

        public string LoginPwd { set; get; }

        public int StatusId { set; get; }

        public int RoleId { set; get; }

        public string IdCard { set; get; }

        public string Gender { set; get; }

        public string AdminRole { set; get; }

        public string PhoneNumber { set; get; }

        public string Location { set; get; }
    }
}
