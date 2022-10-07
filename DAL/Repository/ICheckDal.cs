using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICheckDal
    {
        List<int> AddOrUpdateCheck(List<Check> checks);
        void DeleteCheck(List<int> ids);
        Check GetCheckById(int id);

    }
}
