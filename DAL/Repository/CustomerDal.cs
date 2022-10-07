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
    public class CustomerDal : BaseDal, ICustomerDal
    {
        #region Ctors
        public CustomerDal(string connectionString, DataContext db = null) : base(connectionString, db)
        {
        }
        #endregion

        #region Publics
        /// <summary>
        /// Add customers or update existing ones by providing list of them
        /// </summary>
        /// <param name="cstomers"></param>
        public void AddOrUpdateCustomer(List<Customer> cstomers)
        {
            foreach (var cust in cstomers)
            {
                var dbCustomer = db.Customers.FirstOrDefault(c => c.Id == cust.Id);
                if (dbCustomer == null)
                    db.Customers.Add(cust);
                else
                    db.SetValues(cust, dbCustomer);
            }
            db.SaveChanges();
        }
        /// <summary>
        /// delete customers by providing their ids
        /// </summary>
        /// <param name="ids"></param>
        public void DeleteCustomers(List<int> ids)
        {
            foreach (var id in ids)
            {
                var dbCustomer = db.Customers.FirstOrDefault(c => c.Id == id);
                if (dbCustomer != null)
                    db.Remove(dbCustomer);
            }
        }
        #endregion
    }
}
