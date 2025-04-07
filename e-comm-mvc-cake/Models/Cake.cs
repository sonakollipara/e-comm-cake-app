using e_comm_mvc_cake.Data;
using e_comm_mvc_cake.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace e_comm_mvc_cake.Models
{
	public class Cake :IEntityBase
	{
        //WE CAN KEEP THIS ID PROPERTY OR EVEN DELETE IT FROM HERE
        //BECAUSE WE HAVE INHERITED THE INTERFACE
        //THIS INTERFACE WILL OVERRIDE THIS ID PROPERTY WITH THE
        //PROPERTY IN INTERFACE
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
