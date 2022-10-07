using DAL.Repository;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CheckBL : BaseBL, ICheckBL
    {
        #region ctors
        #endregion

        #region properties
        protected ICheckDal checkDal
        {
            get
            {
                return Dal.CheckDal;
            }
        }
        #endregion

        #region publics
        //TODO  busins logic methods from interface

        public Check AddCheck(Check check)
        {
            var list = checkDal.AddOrUpdateCheck(new List<Check> { check });
            if (list != null && list.Any())
            {
                return checkDal.GetCheckById(list.First());
            }
            else
                throw new Exception();
        }
        
        #endregion
    }
}
