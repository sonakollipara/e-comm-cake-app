using e_comm_mvc_cake.Data;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace e_comm_mvc_cake.Models
{
	public class Cake
	{
        [Key]
        public int Id { get; set; }

        [Display(Name ="CakeImagePreview")]
        [Required(ErrorMessage ="Image Is Required")]
        public string CakeImage { get; set; }

        [Display(Name ="CakeName")]
        [Required(ErrorMessage ="Name Is Required")]
        public string CakeName { get; set; }

        [Display(Name ="CakeFlavour")]
        [Required(ErrorMessage ="Flavour Is Required")]
        public Flavour CakeFlavour { get; set; }
    }
}
