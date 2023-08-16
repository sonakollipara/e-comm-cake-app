using e_comm_mvc_cake.Data.Base;
using e_comm_mvc_cake.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Data.Services
{
	public interface ICakeService : IEntityBaseRepository<Cake>
	{
		//WE DELETED THE TOTAL CODE HERE
		//WE GET THE TOTAL CODE FROM IENEITYBASEREPOSITORY
		//BY IMPLEMENTING IN THIS CLASS


		////for fetching total data
		//Task<IEnumerable<Cake>> GetAllAsync();

		////for fetching data by id
		//Task<Cake> GetByIdAsync(int id);
		
		////for Adding data to database
		//Task AddAsync(Cake Cake);

		////for Updating data at a particular id
		//Task<Cake> UpdateAsync(int id, Cake cake);

		////for Deleting data from database
		//Task DeleteAsync(int id);
	}
}
