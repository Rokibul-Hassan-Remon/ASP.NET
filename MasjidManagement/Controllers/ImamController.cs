using MasjidManagement.DB;
using MasjidManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MasjidManagement.Controllers
{
	public class ImamController : Controller
	{
		private readonly MasjidDbContext _context;

		public ImamController(MasjidDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var ImamList = _context.Imams.ToList();
			return View(ImamList);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Imam imam)
		{
			_context.Imams.Add(imam);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult Update(int id)
		{
			Imam? imam = _context.Imams.ToList().FirstOrDefault(x => x.Id == id);

			return View(imam);
		}

		[HttpPost]
		public IActionResult Update(Imam imam) 
		{
			if(imam.Id >0)
			{
				_context.Imams.Update(imam);
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
			var obj = _context.Imams.FirstOrDefault(x => x.Id == Id);
			return View(obj);
		}


		public IActionResult Delete(int Id)
		{
			var obj = _context.Imams.FirstOrDefault(x => x.Id == Id);
			if (obj != null)
			{
				_context.Imams.Remove(obj);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}
