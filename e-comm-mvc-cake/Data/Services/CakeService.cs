using e_comm_mvc_cake.Data.Base;
using e_comm_mvc_cake.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Data.Services
{
	public class CakeService : EntityBaseRepository<Cake>, ICakeService 
	{

        public CakeService(AppDbContext context) : base(context) { }

        //private readonly AppDbContext _dbContext;
        //      public CakeService(AppDbContext dbContext)
        //      {
        //          _dbContext = dbContext;
        //      }
        //      public async Task AddAsync(Cake Cake)
        //{
        //	await _dbContext.Cakes.AddAsync(Cake);
        //	await _dbContext.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //	var allCakeData = await _dbContext.Cakes.FirstOrDefaultAsync(x => x.Id == id);
        //	_dbContext.Cakes.Remove(allCakeData);
        //	await _dbContext.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Cake>> GetAllAsync()
        //{
        //	var allCakeData =await _dbContext.Cakes.ToListAsync();
        //	return allCakeData;
        //}

        //public async Task<Cake> GetByIdAsync(int id)
        //{
        //	var allCakeData = await _dbContext.Cakes.FirstOrDefaultAsync(x => x.Id == id);
        //	return allCakeData;
        //}

        //public async Task<Cake> UpdateAsync(int id, Cake cake)
        //{
        //	_dbContext.Update(cake);
        //	await _dbContext.SaveChangesAsync();
        //	return cake;
        //}
    }
}
