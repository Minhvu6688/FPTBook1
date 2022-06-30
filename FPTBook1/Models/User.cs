using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FPTBook1.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "This field cannot be empty!")]
        [MinLength(2, ErrorMessage = "The name length must be longer than 2!")]
        [MaxLength(50, ErrorMessage = "The name length exceed maximum required characters!")]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Roles { get; set; }

        public ICollection<Cart> Carts { get; set; }


    }
}
