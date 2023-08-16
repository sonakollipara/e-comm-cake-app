using e_comm_mvc_cake.Data;
using e_comm_mvc_cake.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace e_comm_mvc_cake.Models
{
    public class Pastry : IEntityBase
    {

        //WE CAN KEEP THIS ID PROPERTY OR EVEN DELETE IT FROM HERE
        //BECAUSE WE HAVE INHERITED THE INTERFACE
        //THIS INTERFACE WILL OVERRIDE THIS ID PROPERTY WITH THE
        //PROPERTY IN INTERFACE
        [Key]
        public int Id { get; set; }

        [Display(Name = "PastryImagePreview")]
        [Required(ErrorMessage = "Image Is Required")]
        public string PastryImage { get; set; }

        [Display(Name = "PastryName")]
        [Required(ErrorMessage = "Name Is Required")]
        public string PastryName { get; set; }

        [Display(Name = "PastryFlavour")]
        [Required(ErrorMessage = "Flavour Is Required")]
        public Flavour PastryFlavour { get; set; }
    }
}
