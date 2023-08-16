using e_comm_mvc_cake.Data;
using e_comm_mvc_cake.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Controllers
{
    public class CookiesController : Controller
    {
        //private List<Cookie> _cookie = new List<Cookie>()
        //{
        //    new Cookie {Id=1, CookieImage="ButterCookie.jpg",CookieName="Butter",CookieFlavour=Flavour.Butter},
        //    new Cookie {Id=2, CookieImage="FruitCookie.jpg",CookieName="Fruit",CookieFlavour=Flavour.Fruit},
        //    new Cookie {Id=3, CookieImage="CashewCookie.jpg",CookieName="Cashew",CookieFlavour=Flavour.Cashew},
        //    new Cookie {Id=4, CookieImage="ChocoChipCookie.jpg",CookieName="ChocoChip",CookieFlavour=Flavour.ChocoChip}
        //};

        private readonly AppDbContext _dbContext;
        public CookiesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: CookiesController
        public async Task<ActionResult> Index()
        {
            var allCookies = await _dbContext.Cookies.ToListAsync();
            return View(allCookies);
        }

        // GET: CookiesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
			var cookieResult = await _dbContext.Cookies.FindAsync(id);
			if (cookieResult == null)
			{
				return View("NotFound");
			}
			return View(cookieResult);
        }

        // GET: CookiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("CookieImage,CookieName,CookieFlavour")]Cookie cookie)
        {
			if (!ModelState.IsValid)
			{
				return View(cookie);
			}
			await _dbContext.Cookies.AddAsync(cookie);
			await _dbContext.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

        // GET: CookiesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var cookieResult =await _dbContext.Cookies.FindAsync(id);
            if(cookieResult == null)
            {
                return View("NotFound");
            }
            return View(cookieResult);
        }

        // POST: CookiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Cookie cookie)
        {
            if(!ModelState.IsValid)
            {
                return View(cookie);
            }
            _dbContext.Update(cookie);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: CookiesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
			var cookieResult = await _dbContext.Cookies.FindAsync(id);
			if (cookieResult == null)
			{
				return View("NotFound");
			}
			return View(cookieResult);
        }

        // POST: CookiesController/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
			var cookieResult = await _dbContext.Cookies.FindAsync(id);
			if (cookieResult == null)
			{
				return View("NotFound");
			}
            _dbContext.Cookies.Remove(cookieResult);
            await _dbContext.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
        }
    }
}
