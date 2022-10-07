using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICheckBL : IBaseBL
    {
        //TODO business logic method declarations
        public Check AddCheck(Check check);
    }
}
