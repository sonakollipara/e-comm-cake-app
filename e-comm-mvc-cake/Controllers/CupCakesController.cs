using e_comm_mvc_cake.Data.Services;
using e_comm_mvc_cake.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Controllers
{
	public class CupCakesController : Controller
	{
		private readonly ICupCakeService _service;
        public CupCakesController(ICupCakeService service)
        {
            _service = service;
        }
        // GET: CupCakesController
        public async Task<ActionResult> Index()
		{
			var allCupCakes = await _service.GetAllAsync();
			return View(allCupCakes);
		}

		// GET: CupCakesController/Details/5
		public async Task<ActionResult> Details(int id)
		{
			var cupCakeResult = await _service.GetByIdAsync(id);
			if (cupCakeResult == null)
			{
				return View("NotFound");
			}
			return View(cupCakeResult);
		}

		// GET: CupCakesController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: CupCakesController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create([Bind("CupCakeImage,CupCakeName,CupCakeFlavour")] CupCake cupcake)
		{
			if (!ModelState.IsValid)
			{
				return View(cupcake);
			}
			await _service.AddAsync(cupcake);
			return RedirectToAction(nameof(Index));
		}

		// GET: CupCakesController/Edit/5
		public async Task<ActionResult> Edit(int id)
		{
			var cupCakeResult = await _service.GetByIdAsync(id);
			if (cupCakeResult == null)
			{
				return View("NotFound");
			}
			return View(cupCakeResult);
		}

		// POST: CupCakesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(int id, [Bind("Id,CupCakeImage,CupCakeName,CupCakeFlavour")] CupCake cupcake)
		{
			if (!ModelState.IsValid)
			{
				return View(cupcake);
			}
			await _service.UpdateAsync(id, cupcake);
			return RedirectToAction(nameof(Index));
		}

		// GET: CupCakesController/Delete/5
		public async Task<ActionResult> Delete(int id)
		{
			var cupCakeResult = await _service.GetByIdAsync(id);
			if (cupCakeResult == null)
			{
				return View("NotFound");
			}
			return View(cupCakeResult);
		}

		// POST: CupCakesController/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeleteConfirmed(int id)
		{
			var cupCakeResult = await _service.GetByIdAsync(id);
			if (cupCakeResult == null)
			{
				return View("NotFound");
			}
			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
