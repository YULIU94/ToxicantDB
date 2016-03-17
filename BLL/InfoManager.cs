using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Models;


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

        public bool CasIdIsExisted(string casId)
        {
            int count = objInfoService.GetCountByCasId(casId);
            if (count == 1)
                return true;
            else
                return false;
        }
    }
}
