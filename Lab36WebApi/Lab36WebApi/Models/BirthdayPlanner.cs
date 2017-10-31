using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab36WebApi.Models
{
    public class BirthdayPlanner
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public bool IsComplete { get; set; }
    }
}
