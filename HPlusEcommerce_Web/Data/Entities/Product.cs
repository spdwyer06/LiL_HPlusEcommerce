using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HPlusEcommerce_Web.Data.Entities
{
    public partial class Product
    {
        public Product()
        {
            CartProducts = new HashSet<CartProduct>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal FullPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal CurrentPrice { get; set; }

        public int PercentOff { get; set; }

        [Required]
        [StringLength(300)]
        public string ImagePath { get; set; }

        public int StarRating { get; set; }

        public virtual ICollection<CartProduct> CartProducts { get; set; }
    }
}