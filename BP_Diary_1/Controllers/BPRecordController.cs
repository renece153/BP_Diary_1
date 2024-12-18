using BP_Diary_1.Data;
using BP_Diary_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System;

namespace BP_Diary_1.Controllers
{
    public class BPRecordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private ApplicationDbContext Context { get; }

        public BPRecordController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }


		[HttpPost]
        public IActionResult Index(bp_diary_records bp_diary)
        {
            this.Context.bp_diary.Add(bp_diary);
            this.Context.SaveChanges();

            //Fetch the CustomerId returned via SCOPE IDENTITY.
            int bp_diary_id = bp_diary.bp_diary_id;

            return View(bp_diary);
        }

	}

}

