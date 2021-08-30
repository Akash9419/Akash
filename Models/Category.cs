using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Akash.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public int Age { get; set; }


        public string Categories { get; set; }


        public ICollection<Order> Order { get; set; }
    }
}
