using DAL.Repository;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBL : BaseBL, ICustomerBL
    {
        #region ctors
        #endregion

        #region properties
        protected ICustomerDal CustomerDal
        {
            get
            {
                return Dal.CustomerDal;
            }
        }
        #endregion

        #region publics
        //TODO  busins logic methods

        /// <summary>
        /// add customer
        /// </summary>
        /// <param name="customer">Customer class</param>
        public void AddCustomer(Customer customer)
        {
            CustomerDal.AddOrUpdateCustomer(new List<Customer> { customer });
        }
        /// <summary>
        /// pay bill for customer
        /// </summary>
        /// <param name="clientId"> id of employee</param>
        /// <param name="customerId"> id of customers</param>
        /// <param name="menuIds">all menu items of the customer</param>
        public Check PayBill(int customerId, int clientId, List<int> menuIds)
        {
            Check check = new Check();
            using( var bl = BLFactory.CreateMenuBL())
            {
                var totalPrice = bl.GetTotalPrice(menuIds);
                var newchek = new Check
                {
                    OrderDate = DateTime.Now,
                    TotalPrice = totalPrice,
                    CustomerId = customerId,
                    ClientId = clientId,
                };
                using (var checkbl = BLFactory.CreateCheckBL())
                {
                    check = checkbl.AddCheck(newchek);
                    //TODO update history check by using above info
                }
            }
            return check;
        }
        #endregion
    }
}
