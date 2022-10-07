using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IManagerDal
    {
        void AddOrUpdateManager(List<Manager> managers);
        void DeleteManager(List<int> ids);

    }
}
