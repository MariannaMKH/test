using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManagerBL : BaseBL, IManagerBL
    {
        #region ctors
        #endregion

        #region properties
        protected IManagerDal managerDal
        {
            get
            {
                return Dal.ManagerDal;
            }
        }
        #endregion

        #region publics
        //TODO  busins logic methods from interface
        #endregion
    }
}
