using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //用户实体类
    [Serializable]
    public class UserRole
    {
        public int RoleId { set; get; }

        public string RoleName { set; get; }
    }
}
