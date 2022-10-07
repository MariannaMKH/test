using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IHistoryCheckBL :IBaseBL
    {
        List<HistoryCheck> GetHistoryCheckByClientId(int clientId);
    }
}
