using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoStoreWebCore.UI.Models;

namespace VideoStoreWebCore.UI.Controllers
{
    public class MoviesController : Controller
    {
        // GET: MoviesController
        public IActionResult Index()
        {
            var movieList = new List<MovieViewModel>();
            movieList.Add(new MovieViewModel { Title = "La Momia", Genre = "Accion", Id = 1, ReleaseDate = DateTime.Now.AddYears(-1) });
            movieList.Add(new MovieViewModel { Title = "Titanic", Genre = "Romance", Id = 2, ReleaseDate = DateTime.Now.AddYears(-4) });
            movieList.Add(new MovieViewModel { Title = "El Exorcista", Genre = "Terror", Id = 3, ReleaseDate = DateTime.Now.AddYears(-8) });
            return View(movieList);
        }

        // GET: MoviesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MoviesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoviesController/Create
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

        // GET: MoviesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MoviesController/Edit/5
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

        // GET: MoviesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MoviesController/Delete/5
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
