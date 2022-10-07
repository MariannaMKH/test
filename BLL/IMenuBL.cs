using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IMenuBL : IBaseBL
    {
        //TODO business logic method declarations
        List<Menu> GetMenues(DateTime from, DateTime to);
        decimal GetTotalPrice(List<int> menuIds);
    }
}
