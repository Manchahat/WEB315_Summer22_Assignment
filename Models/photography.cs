
using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Summer22_Assignment .Models
{
    public class photography
    {
        public int ID { get; set; }

        [Display(Name = "Image Name")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$",ErrorMessage="Start with a Capital Letter")]
         [StringLength(100, MinimumLength = 2)]
        public string Name{ get; set; } 

        [DataType(DataType.Date)]
        [Required]
        public DateTime Visited  { get; set; }

        [Required]
         [StringLength(100, MinimumLength = 4)]
        public string Location{ get; set; }

        [Display(Name = "Image Type")]
        [Required]
        public string Type{ get; set; }

        public string Rating { get; set; }
    }
}