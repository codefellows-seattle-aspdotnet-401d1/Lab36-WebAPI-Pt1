using System.ComponentModel.DataAnnotations;

namespace Lab36George.Models
{
    public class Parts
    {
        // I set the key here in case other tables are added
        [Key]
        public int PartID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Quantity { get; set; }
    }
}
