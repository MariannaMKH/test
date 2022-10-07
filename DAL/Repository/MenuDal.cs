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
    public class MenuDal : BaseDal, IMenuDal
    {
        #region ctors
        public MenuDal(string connectionString, DataContext db = null) : base(connectionString, db)
        {
        }
        #endregion

        #region publics
        /// <summary>
        /// add or update menu
        /// </summary>
        /// <param name="menues"></param>
        public void AddOrUpdateMenu(List<Menu> menues)
        {
            //TODO implement add or update with the same logic as in other dals
        }
        /// <summary>
        /// delete menu
        /// </summary>
        /// <param name="ids"></param>
        public void DeleteMenu(List<int> ids)
        {
            //TODO implement delete with the same logic as in other dals
        }
        /// <summary>
        /// Get Menu list
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public IEnumerable<Menu> GetMenuList(DateTime from, DateTime to)
        {
            return db.Menus.Where(x => x.DateCreated >= from && x.DateCreated < to);
        }

        public decimal GetTotalPrice(List<int> menuids)
        {
            return db.Menus.Where(x => menuids.Contains(x.Id)).Sum(p => p.Price);
        }
        #endregion
    }
}
