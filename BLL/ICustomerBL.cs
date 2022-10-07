using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICustomerBL :IBaseBL
    {
        //TODO business methods declarations
        void AddCustomer(Customer customer);

        Check PayBill(int customerId, int clientId, List<int> menuIds);
    }
}
