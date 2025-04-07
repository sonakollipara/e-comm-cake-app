using e_comm_mvc_cake.Data;
using e_comm_mvc_cake.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace e_comm_mvc_cake.Models
{
	public class JellyCake :IEntityBase
	{
        //WE CAN KEEP THIS ID PROPERTY OR EVEN DELETE IT FROM HERE
        //BECAUSE WE HAVE INHERITED THE INTERFACE
        //THIS INTERFACE WILL OVERRIDE THIS ID PROPERTY WITH THE
        //PROPERTY IN INTERFACE
        [Key]
        public int Id { get; set; }

        [Display(Name ="JellyCakeImagePreview")]
        [Required(ErrorMessage ="Image Is Required")]
        public string JellyCakeImage { get; set; }

        [Display(Name ="JellyCakeName")]
        [Required(ErrorMessage ="Name Is Required")]
        public string JellyCakeName { get; set; }

        [Display(Name ="JellyCakeFlavour")]
        [Required(ErrorMessage ="Flavour Is Required")]
        public Flavour JellyCakelavour { get; set; }

       
    }
}
