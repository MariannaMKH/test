using DAL.Repository;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MenuBL : BaseBL, IMenuBL
    {

        #region ctors
        #endregion

        #region properties
        protected IMenuDal menuDal
        {
            get
            {
                return Dal.MenuDal;
            }
        }
        #endregion

        #region publics
        //TODO  busins logic methods from interface
        /// <summary>
        /// Get Menu list for specified time
        /// </summary>
        /// <param name="from"> From date DateTime</param>
        /// <param name="to">To date DateTime</param>
        /// <returns></returns>
        public List<Menu> GetMenues(DateTime from, DateTime to)
        {
            return menuDal.GetMenuList(from, to).ToList();
        }

        public decimal GetTotalPrice(List<int> menuIds)
        {
            return menuDal.GetTotalPrice(menuIds);
        }
        #endregion
    }
}
