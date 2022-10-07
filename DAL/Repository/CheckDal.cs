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
    public class CheckDal : BaseDal, ICheckDal
    {
        #region ctors
        public CheckDal(string connectionString, DataContext db = null) : base(connectionString, db)
        {
        }
        #endregion

        #region publics
        /// <summary>
        /// add or update check and return ids
        /// </summary>
        /// <param name="checks"></param>
        public List<int> AddOrUpdateCheck(List<Check> checks)
        {
            var returnValues = new List<int>();
            //TODO implement add or update with the same logic as in other dals
            //TODO get updated ids and return
            return returnValues;
        }
        /// <summary>
        /// delete check
        /// </summary>
        /// <param name="ids"></param>
        public void DeleteCheck(List<int> ids)
        {
            //TODO implement delete with the same logic as in other dals
        }
        /// <summary>
        /// GetCheckById
        /// </summary>
        /// <param name="id">check id</param>
        /// <returns>Check </returns>
        public Check GetCheckById( int id)
        {
            return db.Checks.FirstOrDefault(x => x.Id == id);
        }
       
        #endregion
    }
}
