using System;
using System.ComponentModel.DataAnnotations;

namespace ShopBridge.Models
{
    /// <summary>
    /// Item
    /// </summary>
    public class Item
    {
        #region Public Property

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The Price field must be greater than 0")]
        public decimal Price { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The Quantity field must be greater than 0")]
        public decimal Quantity { get; set; }

        #endregion
    }
}
