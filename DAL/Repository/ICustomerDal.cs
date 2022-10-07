using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICustomerDal
    {
        void AddOrUpdateCustomer(List<Customer> cstomers);
        void DeleteCustomers(List<int> ids);
    }
}
