using DAL.Repository;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HistoryCheckBL : BaseBL, IHistoryCheckBL
    {
        #region ctors
        #endregion

        #region properties
        protected IHystoryCheckDal HistoryCheckDal
        {
            get
            {
                return Dal.HystoryCheckDal;
            }
        }
        #endregion

        #region publics
        public List<HistoryCheck> GetHistoryCheckByClientId(int clientId)
        {
           return  HistoryCheckDal.GetHystoryChecksByClientId(clientId);
        }
        #endregion

        #region privates
        #endregion
    }
}
