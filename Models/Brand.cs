using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Akash.Models
{
    public class Brand
    {
        [Key]
        public int LabelID { get; set; }

        public string Name { get; set; }


        public int size { get; set; }

        public decimal Price { get; set; }

        public decimal Rating { get; set; }
        public int Instock { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
