using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_TestTechnique.Context;
using Microsoft.EntityFrameworkCore;
using Project_TestTechnique.Models;
using System.IO;

namespace Project_TestTechnique.Controllers
{
    public class CandidatController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CandidatController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Result = _context.Candidats.OrderBy(x => x.CandidatId).ToList();
            return View(Result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Candidat model)
        {
            var file = HttpContext.Request.Form.Files;
            
            if(file.Count()>0)
            {
                string CvName = model.Firstname.ToString()
                    + "-" + model.Lastname.ToString()
                    + Path.GetExtension(file[0].FileName);
                var fileStream = new FileStream(Path.Combine(@"wwwroot/", "upload", CvName), FileMode.Create);
                file[0].CopyTo(fileStream);
                model.CandidatCv = CvName;
            }
            else if(model.CandidatCv == null)
            {
                model.CandidatCv = "DefultCv.pdf";
            }
            else
            {
                model.CandidatCv = model.CandidatCv;
            }
            if (ModelState.IsValid)
            {
                _context.Candidats.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index","Home", new { name = model.Firstname + model.Lastname, job = model.LastJob });
            }
            
            return View();
        }

        public IActionResult Delete(int? Id)
        {
            var result = _context.Candidats.Find(Id);
            if (result != null)
            {
                _context.Candidats.Remove(result);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }


    }
}
