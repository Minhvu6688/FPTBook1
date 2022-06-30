using System;
using System.ComponentModel.DataAnnotations;

namespace FPTBook1.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "Book Name can not be empty")]
        public string Name { get; set; }

        [Required]
        [Range(15000, 100000, ErrorMessage = "Price must be between 15000VND and 100000VND")]
        public double Price { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Quantity must be between 0 and 100")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Book Image")]
        [Url]
        public string Image { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Categories { get; set; }

 
    }
}
