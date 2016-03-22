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
    public class InfoManager
    {

        //添加信息对象
        private InfoService objInfoService = new InfoService();

        public int AddInfo(Info objInfo)
        {
            return objInfoService.AddInfo(objInfo);
        }

        //获取全部的毒物等级分类
        public List<Info> GetAllToxicDegree()
        {
            return objInfoService.GetAllToxicDegree();
        }
         //获取全部的毒性等级分类
        public List<Aid> GetAllAidCategory()
        {
            return objInfoService.GetAllAidCategory();
        }
        //查询方法(五种)
        public Info GetInfoByCasId(string casId)
        {
            return objInfoService.GetInfoByCasId(casId);
        }
        public Info GetInfoByChemicalName(string chemicalName)
        {
            return objInfoService.GetInfoByChemicalName(chemicalName);
        }
         public Info GetInfoByChineseName(string chineseName)
        {
            return objInfoService.GetInfoByChineseName(chineseName);
        }
        public Info GetInfoByRtecsId(string rtecsId)
        {
             return objInfoService.GetInfoByRtecsId(rtecsId);
        }
        public Info GetInfoByTraditionName(string traditionName)
        {
            return objInfoService.GetInfoByTraditionName(traditionName);
        }

        //获取信息对象
        public List<Info> GetInfos(string casId, string chemicalName, string chineseName, string rtecsId, string traditionName)
        {
            return objInfoService.GetInfos(casId, chemicalName, chineseName, rtecsId, traditionName);
        }

        //修改详细信息(文本)
        public int EditInfo(Info objInfo)
        {
            return objInfoService.EditInfo(objInfo);
        }

        //修改详细信息(文本)
        public int EditOtherInfo(Info objInfo)
        {
            return objInfoService.EditOtherInfo(objInfo);
        }


        #region 数据验证方法
        public bool CasIdIsExisted(string casId)
        {
            int count = objInfoService.GetCountByCasId(casId);
            if (count == 1)
                return true;
            else
                return false;
        }

        public bool IsNonNegativeFloat(string str)
        {
            return (DataValidate.IsNonNegativeFloat(str));
        }
        #endregion








    }
}
