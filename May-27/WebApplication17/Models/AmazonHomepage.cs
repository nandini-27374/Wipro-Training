using System.ComponentModel.DataAnnotations;

namespace WebApplication17.Models
{
    public class AmazonHomepage
    {
        public int Id { get; set; }

        public string Title { get; set; }  
        
        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; } 
    }
}
