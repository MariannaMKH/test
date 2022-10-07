using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IClientsBL : IBaseBL
    {
        //TODO clients busins logic
        List<HistoryCheck> GetHistoryForClient(int clientId, DateTime from, DateTime to);
    }
}
