using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IClientsDal
    {
        void AddOrUpdateClients(List<Client> clients);
        void DeleteClients(List<int> clientIds);
        IEnumerable<HistoryCheck> getHistoryForClient(int clientId, DateTime fromdate, DateTime to);
    }
}
