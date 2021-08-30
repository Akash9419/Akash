using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Akash.Models
{
    public class Order
    {
        public int BrandID { get; set; }//customer id
        public Brand Brand { get; set; }//add relation of customer table


        public int CategoryID { get; set; }//add menu id
        public Category Category { get; set; }//add relation of menu table
        public int ID { get; set; }



        public string Name { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }

        
    }

}
