using Microsoft.AspNetCore.Mvc;
using BP_Diary_1.Data;
using BP_Diary_1.Models;

namespace BP_Diary_1.Controllers
{
    public class BPView : Controller
    {
        readonly ApplicationDbContext _db;

        public BPView(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<bp_diary_records> objPriceList;

            objPriceList = _db.bp_diary_records.ToList();

            return View(objPriceList);
        }
    }
 }
