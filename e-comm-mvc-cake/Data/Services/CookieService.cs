using e_comm_mvc_cake.Data.Base;
using e_comm_mvc_cake.Models;

namespace e_comm_mvc_cake.Data.Services
{
	public class CookieService : EntityBaseRepository<Cookie>, ICookieService
	{
        public CookieService(AppDbContext dbContext) : base(dbContext) { }
    }
}
