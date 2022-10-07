using DAL.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BaseBL : IBaseBL
    {
        private IBaseDal db;
        private FactoryBL _blFactory;

        // TODO add all common logic here
        protected IBaseDal Dal
        {
            get { return db.GetBaseDal(); }
        }

        public FactoryBL BLFactory
        {
            get { return  _blFactory; }
            private set
            {
                _blFactory = value;
            }
        }

        public void Dispose()
        {
            //TODO implement disposable logic here
        }
    }
}
