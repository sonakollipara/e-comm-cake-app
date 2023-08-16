using e_comm_mvc_cake.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Data.Base
{
	public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
	{
		private readonly AppDbContext _dbContext;
        public EntityBaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
		public async Task AddAsync(T entity)
		{
			await _dbContext.Set<T>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();
		}

		//HERE WE CAN WRITE THE BELOW CODE IN SINGLE LINE ALSO
		//public async Task AddAsync(T entity) => await _dbContext.Set<T>().AddAsync(entity);

        public async Task DeleteAsync(int id)
		{
			var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
			EntityEntry entityEntry = _dbContext.Entry<T>(entity);
			entityEntry.State = EntityState.Deleted;
			await _dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<T>> GetAllAsync() => await _dbContext.Set<T>().ToListAsync();
		//{
		//	var allCakeData = await _dbContext.Set<T>().ToListAsync();
		//	return allCakeData;
		//}

		//ABOVE WE HAVE WRITTEN THE CODE IN 4 LINE
		//BELOW WE HAVE WRITTEN THE CODE IN 1 LINE
		//BOTH ARE SAME

		public async Task<T> GetByIdAsync(int id) => await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
		//{
		//	var allCakeData = await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
		//	return allCakeData;
		//}	

		public async Task UpdateAsync(int id, T entity)
		{
			EntityEntry entityEntry = _dbContext.Entry<T>(entity);
			entityEntry.State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();
			
		}
	}
}
