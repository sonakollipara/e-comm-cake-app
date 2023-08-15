using e_comm_mvc_cake.Data;
using System.ComponentModel.DataAnnotations;

namespace e_comm_mvc_cake.Models
{
	public class Cookie
	{
        [Key]
        public int Id { get; set; }

        [Display(Name = "CookieImage")]
        public string CookieImage { get; set; }
        
        [Display(Name = "CookieName")]
        public string CookieName { get; set; }
        
        [Display(Name = "CookieFlavour")]
        public Flavour  CookieFlavour { get; set; }
        
    }
}
