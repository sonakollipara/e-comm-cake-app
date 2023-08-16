using e_comm_mvc_cake.Data.Base;
using e_comm_mvc_cake.Models;

namespace e_comm_mvc_cake.Data.Services
{
    public class PastryService : EntityBaseRepository<Pastry>, IPastryService
    {
        public PastryService(AppDbContext context) : base(context) { }
    }
}
