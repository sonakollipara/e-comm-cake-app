using e_comm_mvc_cake.Data.Base;
using e_comm_mvc_cake.Models;

namespace e_comm_mvc_cake.Data.Services
{
	public class CupCakeService : EntityBaseRepository<CupCake>, ICupCakeService
	{
        public CupCakeService(AppDbContext dbContext) : base(dbContext) { }
        
    }
}
