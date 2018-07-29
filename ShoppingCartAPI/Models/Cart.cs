using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartAPI.Models
{
    /// <summary>
    /// handles specific data for a specific cart
    /// </summary>
    public class Cart
    {
        [Key]
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public string Date { get; set; }

        public ICollection<Item> Items { get; set; }

        public bool Completed { get; set; }
    }

    
}
