using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class Check
    {
        public int Id { get; set; }

        public int MenuId { get; set; }
        public int CustomerId { get; set; }
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }



        public Menu Menu { get; set; }
        public Customer Customer { get; set; }
        public Client Client { get; set; }
    }
}
