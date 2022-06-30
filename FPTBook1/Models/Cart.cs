using System;
using System.ComponentModel.DataAnnotations;

namespace FPTBook1.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime Cart_Date { get; set; }
        [Required]
        public int Quantity { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }

    }
}

