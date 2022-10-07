using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Core
{
    public interface IBaseDal : IDisposable
    {
        void SetValues(object entity, object dbEntity);
        void SetUpdateVersion(object entity, byte[] updateVersion);
        IBaseDal GetBaseDal();

        IHystoryCheckDal HystoryCheckDal { get; set; }
        IMenuDal MenuDal { get; set; }
        ICheckDal CheckDal { get; set; }
        IClientsDal ClientsDal { get; set; }
        ICustomerDal CustomerDal { get; set; }
        IManagerDal ManagerDal { get; set; }

    }
}
