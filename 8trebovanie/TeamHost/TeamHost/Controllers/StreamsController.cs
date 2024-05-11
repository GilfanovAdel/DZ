using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers
{
    public class StreamsController : Controller
    {
        // GET: StreamsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StreamsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StreamsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StreamsController/Create
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

        // GET: StreamsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StreamsController/Edit/5
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

        // GET: StreamsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StreamsController/Delete/5
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
