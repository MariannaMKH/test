using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FactoryBL
    {
        public IMenuBL MenuBL { get; set; }
        public IMenuBL CreateMenuBL()
        {
            return MenuBL ?? new MenuBL();
        }

        public ICheckBL CheckBL { get; set; }
        public ICheckBL CreateCheckBL()
        {
            return CheckBL ?? new CheckBL();
        }

        public IManagerBL ManagerBL { get; set; }
        public IManagerBL CreateManagerBL()
        {
            return ManagerBL ?? new ManagerBL();
        }

        public IHistoryCheckBL HistoryCheckBL { get; set; }
        public IHistoryCheckBL CreateHistoryCheckBL()
        {
            return HistoryCheckBL ?? new HistoryCheckBL();
        }

        public ICustomerBL CustomerBl { get; set; }
        public ICustomerBL CreateCustomerB()
        {
            return CustomerBl ?? new CustomerBL();
        }

        public IClientsBL ClientBl { get; set; }
        public IClientsBL CreateIClientsBL()
        {
            return ClientBl ?? new ClientBl();
        }
    }
}
