using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonsAPI.Models
{
    public class Dragon
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }

        public Dragon(string species, string description)
        {
            Species = species;
            Description = description;
        }
    }
}
