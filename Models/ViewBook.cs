using System.ComponentModel.DataAnnotations;

namespace BooksApiMongoDb.Models
{
    public class ViewBook
    {
        [Required]
        public string BookName { get; set; }
        
        [Required]
        public string Author { get; set; }
        
        public string Editor { get; set; }
        
        public string Language { get; set; }

        [Required]
        // [Range(10, 13, ErrorMessage = "ISBN must be between 10 and 13")]
        [StringLength(14,MinimumLength=10, ErrorMessage = "ISBN must be between 10 and 13")]
        public string ISBN { get; set; }
        
        public string Dimensions { get; set; }
        
        [Required]
        public decimal Price { get; set; }
    }
}