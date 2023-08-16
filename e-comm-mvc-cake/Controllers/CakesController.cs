using e_comm_mvc_cake.Data;
using e_comm_mvc_cake.Data.Services;
using e_comm_mvc_cake.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Controllers
{
	public class CakesController : Controller
	{
		//private List<Cake> _cakes = new List<Cake>()
		//{
		//	new Cake {Id=1, CakeImage="ButterScotchCake.png",CakeName="Butter Scotch",CakeFlavour=Flavour.ButterScotch},
		//	new Cake {Id=2, CakeImage="VanillaCake.webp",CakeName="Vanilla",CakeFlavour = Flavour.Vanilla},
		//	new Cake {Id=3, CakeImage="StrawberryCake.jpeg",CakeName = "Strawberry",CakeFlavour=Flavour.Strawberry},
		//	new Cake {Id=4, CakeImage="BlackCurrentCake.png",CakeName="BlackCurrent",CakeFlavour=Flavour.BlackCurrent }
		//};

		//private readonly AppDbContext _dbContext;
		//      public CakesController(AppDbContext dbContext)
		//      {
		//          _dbContext = dbContext;
		//      }
		private readonly ICakeService _service;
        public CakesController(ICakeService service)
        {
			_service = service;
        }

        // GET: CakesController
        public async Task<ActionResult> Index()
		{
			//var allCakes =await _dbContext.Cakes.ToListAsync();
			var allCakes =await _service.GetAllAsync();
			return View(allCakes);

		}

		// GET: CakesController/Details/5
		public async Task<ActionResult> Details(int id)
		{
			//var cakeResult = await _dbContext.Cakes.FindAsync(id);
			var cakeResult = await _service.GetByIdAsync(id);
			if (cakeResult == null)
			{
				return View("NotFound");
			}
			return View(cakeResult);
		}

		// GET: CakesController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: CakesController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create([Bind("CakeImage,CakeName,CakeFlavour")] Cake cake)
		{
			if (!ModelState.IsValid)
			{
				return View(cake);
			}
			//await _dbContext.Cakes.AddAsync(cake);
			await _service.AddAsync(cake);
			//await _dbContext.SaveChangesAsync();
			return RedirectToAction(nameof(Index));

		}

		// GET: CakesController/Edit/5
		public async Task<ActionResult> Edit(int id)
		{
			var cakeResult = await _service.GetByIdAsync(id);
			if (cakeResult == null)
			{
				return View("NotFound");
			}
			return View(cakeResult);
		}

		// POST: CakesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(int id, [Bind("Id,CakeImage,CakeName,CakeFlavour")] Cake cake)
		{
			if (!ModelState.IsValid)
			{
				return View(cake);
			}
			//_dbContext.Update(cake);
			await _service.UpdateAsync(id, cake);
			//await _dbContext.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		// GET: CakesController/Delete/5
		public async Task<ActionResult> Delete(int id)
		{
			//var cakeResult = await _dbContext.Cakes.FindAsync(id);
			var cakeResult = await _service.GetByIdAsync(id);
			if (cakeResult == null) 
			{ 
				return View("NotFound"); 
			}
			return View(cakeResult);
		}

		// POST: CakesController/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(int id)
		{
			//var cakeResult = await _dbContext.Cakes.FindAsync(id);
			var cakeResult = await _service.GetByIdAsync(id);
			if (cakeResult == null) { return View("NotFound"); }
			//_dbContext.Cakes.Remove(cakeResult);
			await _service.DeleteAsync(id);
			//await _dbContext.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}
	}
}
