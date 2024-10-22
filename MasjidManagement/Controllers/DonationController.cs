using MasjidManagement.DB;
using MasjidManagement.Models;
using Microsoft.AspNetCore.Mvc;
using MasjidManagement.Helper;
using System.IO;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace MasjidManagement.Controllers
{
    public class DonationController : Controller
    {
        private readonly MasjidDbContext _context;

        public string UploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

        public DonationController(MasjidDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var DonorList = _context.Donors.ToList();
            return View(DonorList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Donation donation)
        {
            var result = FileHelper.SaveFile(donation.Uploaded_File, UploadPath);

            if (result)
            {
                donation.FileName = donation.Uploaded_File.FileName;
            }

            _context.Donors.Add(donation);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int id)
        {
            Donation? donation = _context.Donors.ToList().FirstOrDefault(x => x.Id == id);
            return View(donation);
        }


        [HttpPost]
        public IActionResult Update(Donation donation)
        {
            if(donation.Id> 0 )
            {
                _context.Donors.Update(donation);
                _context.SaveChanges();               
            }         
                return RedirectToAction("Index");           
        }


        public IActionResult Details(int Id)
        {
            var obj = _context.Donors.FirstOrDefault(x=>x.Id == Id);
            return View(obj);
        }


		public IActionResult Delete(int Id)
		{
			var obj = _context.Donors.FirstOrDefault(x => x.Id == Id);
	        if(obj!= null)
            {
                _context.Donors.Remove(obj);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
		}




	}
}
