using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Savemor.Models
{
    public class ProductsPageViewModel
    {
        public IEnumerable<zzzShortProductInfo> ShortProductInfo { get; set; }
        public IEnumerable<zzzProductInfo> ProductInfo { get; set; }
        public IEnumerable<Category> Category { get; set; }

    }
}