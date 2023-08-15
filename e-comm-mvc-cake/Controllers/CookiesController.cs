using e_comm_mvc_cake.Data;
using e_comm_mvc_cake.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_comm_mvc_cake.Controllers
{
    public class CookiesController : Controller
    {
        private List<Cookie> _cookie = new List<Cookie>()
        {
            new Cookie {Id=1, CookieImage="ButterCookie.jpg",CookieName="Butter",CookieFlavour=Flavour.Butter},
            new Cookie {Id=2, CookieImage="FruitCookie.jpg",CookieName="Fruit",CookieFlavour=Flavour.Fruit},
            new Cookie {Id=3, CookieImage="CashewCookie.jpg",CookieName="Cashew",CookieFlavour=Flavour.Cashew},
            new Cookie {Id=4, CookieImage="ChocoChipCookie.jpg",CookieName="ChocoChip",CookieFlavour=Flavour.ChocoChip}
        };
        // GET: CookiesController
        public async Task<ActionResult> Index()
        {
            return View(_cookie);
        }

        // GET: CookiesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CookiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookiesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookiesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
