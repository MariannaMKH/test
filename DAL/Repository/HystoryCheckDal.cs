using DAL.Repository.Core;
using DTO.Data;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class HystoryCheckDal : BaseDal, IHystoryCheckDal
    {
        #region ctors
        public HystoryCheckDal(string connectionString, DataContext db = null) : base(connectionString, db)
        {
        }
        #endregion

        #region publics
        /// <summary>
        /// add or update history
        /// </summary>
        /// <param name="historyChecks"></param>
        public void AddOrUpdateHystoryChecks(List<HistoryCheck> historyChecks)
        {
            foreach (var hist in historyChecks)
            {
                var dbHistory = db.HistoryChecks.FirstOrDefault(h => h.ClientId == hist.ClientId
                                                                && h.CustomerId == hist.CustomerId && h.CheckId == hist.CheckId);
                if (dbHistory == null)
                    db.HistoryChecks.Add(hist);
                else
                    db.SetValues(hist, dbHistory);
            }
            db.SaveChanges();
        }
        /// <summary>
        /// Get all history checks
        /// </summary>
        /// <param name="ids"></param>
        public List<HistoryCheck> GetHystoryChecks()
        {
            return db.HistoryChecks.ToList();
        }

        /// <summary>
        /// Get all history checks for the client by giving id
        /// </summary>
        /// <param name="ids"></param>
        public List<HistoryCheck> GetHystoryChecksByClientId(int clientId)
        {
            return db.HistoryChecks.Where(x => x.ClientId == clientId).ToList();
        }
        #endregion
    }
}
