using System.ComponentModel.DataAnnotations;

namespace ShoppingCartAPI.Models
{
    /// <summary>
    /// Holds a specified item added to shopping list
    /// </summary>
    public class Item
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public int CartID { get; set; }

        


    }
}