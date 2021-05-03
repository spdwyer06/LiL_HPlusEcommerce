using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPlusEcommerce_Web.Data.Entities
{
    public partial class Cart
    {
        public Cart()
        {
            CartProducts = new HashSet<CartProduct>();
        }


        public int Id { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<CartProduct> CartProducts { get; set; }
    }
}