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

        //根据CAS ID查询
        public Info GetInfoByCasId(string casId)
        {
            return objInfoService.GetInfoByCasId(casId);
        }

        //获取信息对象
        public List<Info> GetInfos(string casId, string chemicalName, string chineseName, string rtecsId, string traditionName)
        {
            return objInfoService.GetInfos(casId, chemicalName, chineseName, rtecsId, traditionName);
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
            if (DataValidate.IsNonNegativeFloat(str))
                return true;
            else
                return false;
        }
        #endregion

        public int EditInfo(Info objInfo)
        {
            return objInfoService.EditInfo(objInfo);
        }






    }
}
