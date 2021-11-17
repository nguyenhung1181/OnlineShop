using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Product
    {
        public int ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Unit { get; set; }
    }
}
