using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Savemor.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int UPI { get; set; }
        public int PrivateLabelUPI { get; set; }
        public string Name { get; set; }
        public int BrandID { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        public int Measure { get; set; }
        public string Units { get; set; }
        public decimal Price { get; set; }
        public decimal OppositionPrice { get; set; }
        public decimal RecommendedPrice { get; set; }
        public decimal SpecialPrice { get; set; }
        public bool Active { get; set; }
        public int SUSMP { get; set; }
        public int Rank { get; set; }
        public int Limit { get; set; }
        public bool InStoreOnly { get; set; }
        public string Description { get; set; }
        public bool ShelfTalker { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
    }
}