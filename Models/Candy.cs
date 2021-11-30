using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStore.Models
{
    public class Candy
    {
        public int CandyId { get; set; }


        [Display(Name="Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }        
        public string ImageThumbnailURL { get; set; }        
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }

        
        public Category Category { get; set; }

    }
}
