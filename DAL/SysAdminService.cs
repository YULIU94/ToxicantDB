using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using DBUtility;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class SysAdminService
    {
        /// <summary>
        /// 根据登录账号和密码从数据库比对
        /// </summary>
        /// <param name="objAdmin">包含账号和密码的管理员对象</param>
        /// <returns>返回管理员对象信息</returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            //定义登录的SQL语句
            string sql = "select AdminName, StatusId, RoleId from SysAdmins where ";
            sql += " AdminId = @AdminId and LoginPwd = @LoginPwd ";
            //封装参数
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@AdminId",objAdmin.AdminId),
                new SqlParameter("@LoginPwd",objAdmin.IdCard)
            };
            //执行查询
            SqlDataReader objReader = SQLHelper.GetReader(sql, param);
            //处理查询结果
            if (objReader.Read())
            {
                objAdmin.AdminName = objReader["AdminName"].ToString();
                objAdmin.StatusId = Convert.ToInt32(objReader["StatusId"]);
                objAdmin.RoleId = Convert.ToInt32(objReader["RoleId"]);
            }
            else
            {
                objAdmin = null;//如果账号或密码不正确，则清空当前对象
            }
            objReader.Close();

            return objAdmin;
        }

        private SysAdmin GetInfoBySQL(string whereSql, SqlParameter[] param)
        {
            string sql = "select AdminId, AdminName, IdCard, Gender, AdminRole, PhoneNumber, Location from SysAdmins ";
            sql += whereSql;
            //执行查询
            SqlDataReader objReader = SQLHelper.GetReader(sql, param);
            SysAdmin sysAdmin = null;
            if (objReader.Read())
            {
                sysAdmin = new SysAdmin()
                {
                    AdminId = (Int32)objReader["AdminId"],
                    AdminName = objReader["AdminName"].ToString(),
                    IdCard = objReader["IdCard"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    AdminRole = objReader["AdminRole"].ToString(),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    Location = objReader["Location"].ToString()
                };

            }
            objReader.Close();
            return sysAdmin;
        }
        //通过用户ID查找信息
        public SysAdmin GetInfoByAdminId(string adminId)
        {
            return GetInfoBySQL(" where AdminId=@AdminId ", new SqlParameter[] { new SqlParameter("@AdminId", adminId) });
        }
        public SysAdmin GetInfoByIDCard(string idCard)
        {
            return GetInfoBySQL(" where IdCard=@IdCard ", new SqlParameter[] { new SqlParameter("@IdCard", idCard) });
        }

        public int EditAdmin(SysAdmin objAdmin)
        {
            string sql = " update SysAdmins set AdminName=@AdminName, Gender=@Gender, AdminRole=@AdminRole, PhoneNumber=@PhoneNumber,  IdCard=@IdCard, Location=@Location where AdminId=@AdminId ";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@AdminName",objAdmin.AdminName),
                new SqlParameter("@AdminId",objAdmin.AdminId),
                new SqlParameter("@Gender",objAdmin.Gender),
                new SqlParameter("@AdminRole",objAdmin.AdminRole),
                new SqlParameter("@PhoneNumber",objAdmin.PhoneNumber),
                new SqlParameter("@IdCard",objAdmin.IdCard),
                new SqlParameter("@Location",objAdmin.Location)
            };
            return SQLHelper.Update(sql, param);
        }

    }
}
