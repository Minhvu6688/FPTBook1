using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook1.Models
{
    public class Category
    {
        //primary key (auto-increment)
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [MinLength(3, ErrorMessage = "Category Name must be at least 3 characters")]
        [MaxLength(30, ErrorMessage = "Category Name cannot be more than 30 characters")]
        public string Name { get; set; }




        //relational attribute (One to Many)
        public ICollection<Category> Categories { get; set; }
    }
}
