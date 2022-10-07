using DTO.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Core
{
    public class BaseDal : IBaseDal
    {
        private DataContext _db;
        private DbContextOptionsBuilder optionsBuilder;
        private string connectionString;
        private IBaseDal _baseDal;
        public BaseDal(string connectionString, DataContext db = null)
        {
            if (db is null)
            {
                
                var _context = new DbContextOptions<DataContext>();
                db = new DataContext(_context);
            }
            _db = db;
        }

        protected internal DataContext db
        {
            get { return _db; }
        }

        public IHystoryCheckDal HystoryCheckDal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMenuDal MenuDal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICheckDal CheckDal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IClientsDal ClientsDal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICustomerDal CustomerDal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IManagerDal ManagerDal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetValues(object entity, object dbEntity)
        {
            _db.SetValues(entity, dbEntity);
            //TODO implement logic for cuncurency using update version
        }

        public void  SetUpdateVersion(object entity, byte[] updateVersion)
        {
            //TODO set update version for entities
        }
        public IBaseDal GetBaseDal()
        {
            return _baseDal ?? (_baseDal = new BaseDal(connectionString));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
