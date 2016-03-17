using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using Models;
using DBUtility;

namespace DAL
{
    public class InfoService
    {
        #region 添加信息

        //判断条码是否已经存在
        public int GetCountByCasId(string casId)
        {
            string sql = "select count(*) from Info where CasId=@CasId";
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@CasId", casId) };
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));
        }
        //添加信息对象
        public int AddInfo(Info objInfo)
        {
            //封装参数
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CasId",objInfo.CasId),
                new SqlParameter("@ChemicalName",objInfo.ChemicalName),
                new SqlParameter("@ChineseName",objInfo.ChineseName),
                new SqlParameter("@TraditionName",objInfo.TraditionName),
                new SqlParameter("@RtecsId",objInfo.RtecsId),
                new SqlParameter("@Element",objInfo.Element),
                new SqlParameter("@StateInfo",objInfo.StateInfo),
                new SqlParameter("@Odor",objInfo.Odor),
                new SqlParameter("@Color",objInfo.Color),
                new SqlParameter("@RelativeMolecularMass",objInfo.RelativeMolecularMass),
                new SqlParameter("@Solubility",objInfo.Solubility),
                new SqlParameter("@Density",objInfo.Density)
            };
            //调用通用数据访问方法提交对象
            return SQLHelper.UpdateByProcedure("usp_AddInfo", param);
        }

        #endregion

    }
}
