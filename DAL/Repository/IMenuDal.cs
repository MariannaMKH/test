using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IMenuDal
    {
        void AddOrUpdateMenu(List<Menu> menues);
        void DeleteMenu(List<int> ids);
        IEnumerable<Menu> GetMenuList(DateTime from, DateTime to);
        decimal GetTotalPrice(List<int> menuids);

    }
}
