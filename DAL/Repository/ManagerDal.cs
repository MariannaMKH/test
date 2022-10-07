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
    public class ManagerDal : BaseDal, IManagerDal
    {
        #region ctors
        public ManagerDal(string connectionString, DataContext db = null) : base(connectionString, db)
        {
        }
        #endregion

        #region publics
        /// <summary>
        /// add or update
        /// </summary>
        /// <param name="managers"></param>
        public void AddOrUpdateManager(List<Manager> managers)
        {
            //TODO implement add or update with the same logic as in other dals
        }
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="ids"></param>
        public void DeleteManager(List<int> ids)
        {
            //TODO implement delete with the same logic as in other dals
        }
        #endregion
    }
}
