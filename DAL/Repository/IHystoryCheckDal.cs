using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IHystoryCheckDal
    {
        void AddOrUpdateHystoryChecks(List<HistoryCheck> historyChecks);
        List<HistoryCheck> GetHystoryChecks();
        List<HistoryCheck> GetHystoryChecksByClientId(int clientId);

    }
}
