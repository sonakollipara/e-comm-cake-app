using e_comm_mvc_cake.Data;
using e_comm_mvc_cake.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace e_comm_mvc_cake.Models
{
	public class CupCake : IEntityBase
	{
		//WE CAN KEEP THIS ID PROPERTY OR EVEN DELETE IT FROM HERE
		//BECAUSE WE HAVE INHERITED THE INTERFACE
		//THIS INTERFACE WILL OVERRIDE THIS ID PROPERTY WITH THE
		//PROPERTY IN INTERFACE
		[Key]
		public int Id { get; set; }

		[Display(Name = "CupCakeImagePreview")]
		[Required(ErrorMessage = "Image Is Required")]
		public string CupCakeImage { get; set; }

		[Display(Name = "CupCakeName")]
		[Required(ErrorMessage = "Name Is Required")]
		public string CupCakeName { get; set; }

		[Display(Name = "CupCakeFlavour")]
		[Required(ErrorMessage = "Flavour Is Required")]
		public Flavour CupCakeFlavour { get; set; }
	}
}
