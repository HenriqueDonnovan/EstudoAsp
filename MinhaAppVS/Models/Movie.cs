using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaAppVS.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
      
        [Required(ErrorMessage = "This field must be filled")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "The title must have between 3 and 60 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage ="The field date must be filled")]
        [DataType("dd/MM/yyyy", ErrorMessage = "Incorrect format date")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Invalid format")]
        [StringLength(60, ErrorMessage = "Max is 60 characters"), Required(ErrorMessage = "This field is required")]
        public string Genre { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Between 1 and 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Avaliation")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Just numbers")]
        public int Avaliation { get; set; }
    }
}
