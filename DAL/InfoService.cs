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

        //获取全部的毒性等级分类
        public List<Info> GetAllToxicDegree()
        {
            string sql = "select ToxicDegree, ToxicId from Toxic";
            List<Info> list = new List<Info>();
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            //循环读取并封装对象
            while (objReader.Read())
            {
                list.Add(new Info()
                {
                    ToxicDegree = Convert.ToString(objReader["ToxicDegree"]),
                    CasId = Convert.ToString(objReader["ToxicId"])
                });
            }
            objReader.Close();
            return list;
        }
         //获取全部的毒性等级分类
        public List<Aid> GetAllAidCategory()
        {
            string sql = "select AidCategory from AidCategory";
            List<Aid> list = new List<Aid>();
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            //循环读取并封装对象
            while (objReader.Read())
            {
                list.Add(new Aid()
                {
                    AidCategory = Convert.ToString(objReader["AidCategory"])
                });
            }
            objReader.Close();
            return list;
        }

        #region 执行查询
        public List<Info> GetInfos(string casId, string chemicalName, string chineseName, string rtecsId, string traditionName)
        {
            //定义参数集合
            List<SqlParameter> paramList = new List<SqlParameter>();
            //定义查询SQL语句
            string sql = "select CasId, ChemicalName, ChineseName, TraditionName, RtecsId, Element, StateInfo, Odor, Color, RelativeMolecularMass, Solubility, Density, Ld50, ToxicDetail, HealthHarzard, EnvironmentHarzard, AidSkin, AidEye, AidInhalation, AidIngestion, ToxicDegree from Info ";
            sql += "where 1=1";
            //根据条件添加查询参数(根据输入的参数)
            if (casId != null && casId.Length > 0)
            {
                sql += " and CasId=@CasId ";
                paramList.Add(new SqlParameter("@CasId", casId));
            }
            else if (rtecsId != null && rtecsId.Length > 0)
            {
                sql += " and RtecsId=@RtecsId ";
                paramList.Add(new SqlParameter("@RtecsId", rtecsId));
            }
            else
            {
                if (chemicalName != null && chemicalName.Length > 0)
                {
                    sql += "and ChemicalName like '%'+@ChemicalName+'%'";
                    paramList.Add(new SqlParameter("@ChemicalName", chemicalName));
                }
                if (chineseName != null && chineseName.Length > 0)
                {
                    sql += "and ChineseName like '%'+@ChineseName+'%'";
                    paramList.Add(new SqlParameter("@ChineseName", chineseName));
                }
                if (traditionName != null && traditionName.Length > 0)
                {
                    sql += "and TraditionName like '%'+@TraditionName+'%'";
                    paramList.Add(new SqlParameter("@TraditionName", traditionName));
                }
            }

            //执行查询
            SqlDataReader objReader = SQLHelper.GetReader(sql, paramList.ToArray());
            List<Info> InfoList = new List<Info>();
            while (objReader.Read())
            {
                InfoList.Add( new Info()
                {
                    CasId = Convert.ToString(objReader["CasId"]),
                    ChemicalName = Convert.ToString(objReader["ChemicalName"]),
                    ChineseName = Convert.ToString(objReader["ChineseName"]),
                    TraditionName = Convert.ToString(objReader["TraditionName"]),
                    RtecsId = Convert.ToString(objReader["RtecsId"]),
                    Element = Convert.ToString(objReader["Element"]),
                    StateInfo = Convert.ToString(objReader["StateInfo"]),
                    Odor = Convert.ToString(objReader["Odor"]),
                    Color = Convert.ToString(objReader["Color"]),
                    RelativeMolecularMass = Convert.ToDouble(objReader["RelativeMolecularMass"]),
                    Solubility = Convert.ToDouble(objReader["Solubility"]),
                    Density = Convert.ToDouble(objReader["Density"]),
                    Ld50 = Convert.ToString(objReader["Ld50"]),
                    ToxicDetail = Convert.ToString(objReader["ToxicDetail"]),
                    HealthHarzard = Convert.ToString(objReader["HealthHarzard"]),
                    EnvironmentHarzard = Convert.ToString(objReader["EnvironmentHarzard"]),
                    AidSkin = Convert.ToString(objReader["AidSkin"]),
                    AidEye = Convert.ToString(objReader["AidEye"]),
                    AidInhalation = Convert.ToString(objReader["AidInhalation"]),
                    AidIngestion = Convert.ToString(objReader["AidIngestion"]),
                    ToxicDegree = Convert.ToString(objReader["ToxicDegree"])
                });
            }
            objReader.Close();
            return InfoList;
        }

        ////根据借阅证号查询读者信息
        //public Reader GetReaderByReadingCard(string readingCard)
        //{
        //    return GetReaderBySQL(" where ReadingCard=@ReadingCard", new SqlParameter[] { new SqlParameter("@ReadingCard", readingCard) });
        //}
        ////根据身份证号查询读者信息
        //public Reader GetReaderByIDCard(string IDCard)
        //{
        //    return GetReaderBySQL(" where IDCard=@IDCard ", new SqlParameter[] { new SqlParameter("@IDCard", IDCard) });
        //}

        ////复用方法
        //private Reader GetReaderBySQL(string whereSql, SqlParameter[] param)
        //{
        //    string sql = "select ReaderId, ReadingCard, ReaderName, Gender, IDCard, ReaderAddress, PostCode, PhoneNumber, Readers.RoleId, ReaderImage, StatusId, RoleName from Readers ";
        //    sql += " inner join ReaderRoles on ReaderRoles.RoleId=Readers.RoleId ";
        //    sql += whereSql;

        //    //执行查询
        //    SqlDataReader objReader = SQLHelper.GetReader(sql, param);
        //    Reader reader = null;
        //    if (objReader.Read())
        //    {
        //        reader = new Reader()
        //        {
        //            ReadingCard = objReader["ReadingCard"].ToString(),
        //            ReaderName = objReader["ReaderName"].ToString(),
        //            RoleId = Convert.ToInt32(objReader["RoleId"]),
        //            RoleName = objReader["RoleName"].ToString(),
        //            ReaderImage = objReader["ReaderImage"] is DBNull ? "" : objReader["ReaderImage"].ToString(),
        //            ReaderId = Convert.ToInt32(objReader["ReaderId"]),
        //            StatusId = Convert.ToInt32(objReader["StatusId"]),
        //            PhoneNumber = objReader["PhoneNumber"].ToString(),
        //            ReaderAddress = objReader["ReaderAddress"].ToString(),
        //            PostCode = objReader["PostCode"].ToString(),
        //            Gender = objReader["Gender"].ToString()
        //        };
        //    }
        //    objReader.Close();
        //    return reader;
        //}

        //复用方法
        private Info GetInfoBySQL(string whereSql, SqlParameter[] param)
        {
            string sql = "select CasId, ChemicalName, ChineseName, TraditionName, RtecsId, Element, StateInfo, Odor, Color, RelativeMolecularMass, Solubility, Density, Ld50, ToxicDetail, HealthHarzard, EnvironmentHarzard, AidSkin, AidEye, AidInhalation, AidIngestion, ToxicDegree from Info ";
            sql += whereSql;

            //执行查询
            SqlDataReader objReader = SQLHelper.GetReader(sql, param);
            Info objInfo = null;
            if (objReader.Read())
            {
                objInfo = new Info()
                {
                    CasId = Convert.ToString(objReader["CasId"]),
                    ChemicalName = Convert.ToString(objReader["ChemicalName"]),
                    ChineseName = Convert.ToString(objReader["ChineseName"]),
                    TraditionName = Convert.ToString(objReader["TraditionName"]),
                    RtecsId = Convert.ToString(objReader["RtecsId"]),
                    Ld50 = Convert.ToString(objReader["Ld50"]),
                    ToxicDetail = Convert.ToString(objReader["ToxicDetail"]),
                    HealthHarzard = Convert.ToString(objReader["HealthHarzard"]),
                    EnvironmentHarzard = Convert.ToString(objReader["EnvironmentHarzard"]),
                    AidSkin = Convert.ToString(objReader["AidSkin"]),
                    AidEye = Convert.ToString(objReader["AidEye"]),
                    AidInhalation = Convert.ToString(objReader["AidInhalation"]),
                    AidIngestion = Convert.ToString(objReader["AidIngestion"]),
                    ToxicDegree = Convert.ToString(objReader["ToxicDegree"])
                };
            }
            objReader.Close();
            return objInfo;
        }
        //五种查询方法
        public Info GetInfoByCasId(string casId)
        {
            return GetInfoBySQL(" where CasId=@CasId", new SqlParameter[] { new SqlParameter("@CasId", casId) });
        }
        public Info GetInfoByChemicalName(string chemicalName)
        {
            return GetInfoBySQL(" where ChemicalName like '%'+@ChemicalName+'%' ", new SqlParameter[] { new SqlParameter("@ChemicalName", chemicalName) });
        }
        public Info GetInfoByChineseName(string chineseName)
        {
            return GetInfoBySQL(" where ChineseName like '%'+@ChineseName+'%' ", new SqlParameter[] { new SqlParameter("@ChineseName", chineseName) });
        }
        public Info GetInfoByRtecsId(string rtecsId)
        {
            return GetInfoBySQL(" where RtecsId = @RtecsId ", new SqlParameter[] { new SqlParameter("@RtecsId", rtecsId) });
        }
        public Info GetInfoByTraditionName(string traditionName)
        {
            return GetInfoBySQL(" where TraditionName like '%'+@TraditionName+'%' ", new SqlParameter[] { new SqlParameter("@TraditionName", traditionName) });
        }
        #endregion


        

        //修改详细信息(文本)
        public int EditInfo(Info objInfo)
        {
            string sql = " update Info set ToxicDetail=@ToxicDetail, HealthHarzard=@HealthHarzard, EnvironmentHarzard=@EnvironmentHarzard, AidSkin=@AidSkin, AidEye=@AidEye, AidInhalation=@AidInhalation, AidIngestion=@AidIngestion  where CasId = @CasId ";
            //封装参数
            SqlParameter[] param = new SqlParameter[]
            {

                new SqlParameter("@CasId",objInfo.CasId),
                //new SqlParameter("@ChemicalName",objInfo.ChemicalName),
                //new SqlParameter("@ChineseName",objInfo.ChineseName),
                //new SqlParameter("@TraditionName",objInfo.TraditionName),
                //new SqlParameter("@RtecsId",objInfo.RtecsId),
                //new SqlParameter("@Element",objInfo.Element),
                //new SqlParameter("@StateInfo",objInfo.StateInfo),
                //new SqlParameter("@Odor",objInfo.Odor),
                //new SqlParameter("@Color",objInfo.Color),
                //new SqlParameter("@RelativeMolecularMass",objInfo.RelativeMolecularMass),
                //new SqlParameter("@Solubility",objInfo.Solubility),
                //new SqlParameter("@Density",objInfo.Density),
                //new SqlParameter("@Ld50",objInfo.Ld50),
                //new SqlParameter("@ToxicDegree",objInfo.ToxicDegree),
                new SqlParameter("@ToxicDetail",objInfo.ToxicDetail),
                new SqlParameter("@HealthHarzard",objInfo.HealthHarzard),
                new SqlParameter("@EnvironmentHarzard",objInfo.EnvironmentHarzard),
                new SqlParameter("@AidSkin",objInfo.AidSkin),
                new SqlParameter("@AidEye",objInfo.AidEye),
                new SqlParameter("@AidInhalation",objInfo.AidInhalation),
                new SqlParameter("@AidIngestion",objInfo.AidIngestion)
            };
            //调用EditBook存储过程
            //return SQLHelper.UpdateByProcedure("usp_EditBook", param);
            return SQLHelper.Update(sql, param);
        }

        //修改详细信息（其他）
        public int EditOtherInfo(Info objInfo)
        {
            string sql = " update Info set Ld50=@Ld50, ToxicDegree=@ToxicDegree where CasId=@CasId ";
            //封装参数
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CasId",objInfo.CasId),
                new SqlParameter("@Ld50",objInfo.Ld50),
                new SqlParameter("@ToxicDegree",objInfo.ToxicDegree)
            };
            //调用Update方法
            return SQLHelper.Update(sql, param);
        }

    }
}
