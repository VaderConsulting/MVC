using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Savemor.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        public int ParentID { get; set; }
        public string Headline { get; set; }
        public string Image { get; set; }
        public int Saving { get; set; }
        public int SortOrder { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
    }
}