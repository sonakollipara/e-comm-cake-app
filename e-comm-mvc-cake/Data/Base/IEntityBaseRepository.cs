using e_comm_mvc_cake.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Data.Base
{
	public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
	{
		//for fetching total data
		Task<IEnumerable<T>> GetAllAsync();

		//for fetching data by id
		Task<T> GetByIdAsync(int id);
		
		//for Adding data to database
		Task AddAsync(T entity);

		//for Updating data at a particular id
		Task UpdateAsync(int id, T entity);

		//for Deleting data from database
		Task DeleteAsync(int id);
	}
}
