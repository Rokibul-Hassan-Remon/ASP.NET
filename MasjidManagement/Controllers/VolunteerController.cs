using MasjidManagement.DB;
using MasjidManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagement.Controllers
{
	public class VolunteerController : Controller
	{
		private readonly MasjidDbContext _context;

        public VolunteerController(MasjidDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{
			var VolunteerList = _context.Volunteers.ToList();
			return View(VolunteerList);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Volunteer volunteer)
		{
			_context.Volunteers.Add(volunteer);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult Update(int id)
		{
			Volunteer? volunteer = _context.Volunteers.ToList().FirstOrDefault(x => x.Id == id);
			return View(volunteer);
		}

		[HttpPost]
		public IActionResult Update(Volunteer volunteer)
		{
			if(volunteer.Id >0)
			{
				_context.Volunteers.Update(volunteer);
				_context.SaveChanges();

				return RedirectToAction("Index");
			}
			else
			{
				return RedirectToAction("Index");
			}
		}

		public IActionResult Details(int Id)
		{
			var obj = _context.Volunteers.FirstOrDefault(x => x.Id == Id);
			return View(obj);
		}


		public IActionResult Delete(int Id)
		{
			var obj = _context.Volunteers.FirstOrDefault(x => x.Id == Id);
			if (obj != null)
			{
				_context.Volunteers.Remove(obj);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}
