using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Models;
using Common;

namespace BLL
{
    
    public class SysAdminManager
    {
        //创建数据访问对象
        private SysAdminService objSysAdminService = new SysAdminService();

        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            return objSysAdminService.AdminLogin(objAdmin);
        }

        public SysAdmin GetInfoByAdminId(string adminId)
        {
            return objSysAdminService.GetInfoByAdminId(adminId);
        }
        public SysAdmin GetInfoByIDCard(string idCard)
        {
            return objSysAdminService.GetInfoByIDCard(idCard);
        }
        public int EditAdmin(SysAdmin objAdmin)
        {
            return objSysAdminService.EditAdmin(objAdmin);
        }

        //删除用户
        public int DeleteAdmin(string adminId)
        {
            return objSysAdminService.DeleteAdmin(adminId);
        }

        //新增用户
        public int AddAdmin(SysAdmin objAdmin)
        {
            return objSysAdminService.AddAdmin(objAdmin);
        }

        //检测用户是否已经存在
        public bool GetAdminByAdminId(string adminId)
        {
            int count = objSysAdminService.GetCountByAdminId(adminId);
            if (count == 1)
                return true;
            else
                return false;
        }
        public bool GetAdminByIdCard(string idCard)
        {
            int count = objSysAdminService.GetCountByIdCard(idCard);
            if (count == 1)
                return true;
            else
                return false;
        }

        //检测身份证号码格式是否正确
        public bool IsIdCard(string idCard)
        {
            return DataValidate.IsIdentityCard(idCard);
        }
    }
}
