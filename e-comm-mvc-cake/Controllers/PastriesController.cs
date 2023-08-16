using e_comm_mvc_cake.Data.Services;
using e_comm_mvc_cake.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Controllers
{
    public class PastriesController : Controller
    {
        private readonly IPastryService _service;
        public PastriesController(IPastryService service)
        {
            _service = service;
        }
        // GET: PastriesController
        public async Task<ActionResult> Index()
        {
            var allPastries = await _service.GetAllAsync();
            return View(allPastries);
        }

        // GET: PastriesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var pastryResult = await _service.GetByIdAsync(id);
            if(pastryResult == null)
            {
                return View("NotFound");
            }
            return View(pastryResult);
        }

        // GET: PastriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PastriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("PastryImage,PastryName,PastryFlavour")]Pastry pastry)
        {
                if(!ModelState.IsValid)
                {
                    return View(pastry);                    
                }
                await _service.AddAsync(pastry);
                return RedirectToAction(nameof(Index));          
        }

        // GET: PastriesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var pastryResult = await _service.GetByIdAsync(id);
            if(pastryResult == null)
            {
                return View("NotFound");
            }
            return View(pastryResult);
        }

        // POST: PastriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind("Id,PastryImage,PastryName,PastryFlavour")] Pastry pastry)
        {
            if(!ModelState.IsValid)
            {
                return View(pastry);
            }
            await _service.UpdateAsync(id, pastry);
            return RedirectToAction(nameof(Index));
        }

        // GET: PastriesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var pastryResult = await _service.GetByIdAsync(id);
            if (pastryResult == null)
            {
                return View("NotFound");
            }
            return View(pastryResult);
        }

        // POST: PastriesController/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var pastryResult = await _service.GetByIdAsync(id);
            if (pastryResult == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
