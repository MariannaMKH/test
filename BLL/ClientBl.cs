using DAL.Repository;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientBl : BaseBL, IClientsBL
    {
        #region ctors
        #endregion

        #region properties
        protected IClientsDal ClientsDal
        {
            get
            {
                return Dal.ClientsDal;
            }
        }
        #endregion

        #region publics
        //TODO clients busins logic
        /// <summary>
        /// get history for client between given dates
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="from">date start from</param>
        /// <param name="to">to which date</param>
        /// <returns></returns>
        public List<HistoryCheck> GetHistoryForClient(int clientId, DateTime from, DateTime to)
        {
            //TODO add scpecific details for serving history
           return  ClientsDal.getHistoryForClient(clientId, from, to).ToList();
        }
        #endregion

    }
}
