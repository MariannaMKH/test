﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string City { get; set; }
        public int? ManagerId { get; set; }
    }
}