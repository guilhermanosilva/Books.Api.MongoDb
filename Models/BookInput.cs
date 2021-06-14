using System.ComponentModel.DataAnnotations;

namespace BooksApiMongoDb.Models
{
    public class BookInput
    {
        [Required]
        public string BookName { get; set; }
        
        [Required]
        public string Author { get; set; }
        
        public string Editor { get; set; }
        
        public string Language { get; set; }

        [Required]
        [Range(10, 13, ErrorMessage = "ISBN must be between 10 and 13")]
        public string ISBN { get; set; }
        
        public string Dimensions { get; set; }
        
        [Required]
        public decimal Price { get; set; }
    }
}