using e_comm_mvc_cake.Data;
using e_comm_mvc_cake.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace e_comm_mvc_cake.Models
{
	public class Cookie :IEntityBase
	{
		//WE CAN KEEP THIS ID PROPERTY OR EVEN DELETE IT FROM HERE
		//BECAUSE WE HAVE INHERITED THE INTERFACE
		//THIS INTERFACE WILL OVERRIDE THIS ID PROPERTY WITH THE
		//PROPERTY IN INTERFACE

		[Key]
        public int Id { get; set; }

        [Display(Name = "CookieImage")]
		[Required(ErrorMessage = "Image Is Required")]
		public string CookieImage { get; set; }
        
        [Display(Name = "CookieName")]
		[Required(ErrorMessage = "Name Is Required")]
		public string CookieName { get; set; }
        
        [Display(Name = "CookieFlavour")]
		[Required(ErrorMessage = "Flavour Is Required")]
		public Flavour  CookieFlavour { get; set; }
        
    }
}
