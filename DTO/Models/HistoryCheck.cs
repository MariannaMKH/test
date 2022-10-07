using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class HistoryCheck
    {
        public int CustomerId { get; set; }

        public int ClientId { get; set; }
        public int CheckId { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public Client Client { get; set; }

        public Check Check { get; set; }
    }
}
