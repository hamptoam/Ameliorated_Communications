﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ameliorated_Communications.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public List<Employee> Employees { get; set; }

        public List<Callee> Leads { get; set; }

        public List<Campaign> Campaigns { get; set; }
    }
}