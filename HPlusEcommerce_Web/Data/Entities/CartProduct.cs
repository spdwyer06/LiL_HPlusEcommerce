using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPlusEcommerce_Web.Data.Entities
{
    public partial class CartProduct
    {
        public int Id { get; set; }

        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}