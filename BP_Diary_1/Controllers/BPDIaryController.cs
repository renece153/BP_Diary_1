using BP_Diary_1.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace BP_Diary_1.Controllers
{

    public class BPDIaryController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RecordBP()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecordBP(bp_diary bp)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    if (AddBP(bp))
                    {
                        ViewBag.Message = "BP successfully Recorded";
                    }
                    else
                    {
                        ViewBag.Message = "BP not successfully Recorded";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }



            public bool AddBP(bp_diary bp_Diary)
         {
            string connection_string = "Server=127.0.0.1;Port=5432;Userid=postgres;Password=password;Protocol=3;SSL=false;Pooling=false;MinPoolSize=1;MaxPoolSize=20;Timeout=15;SslMode=Disable;Database=postgres";
            string insertQuery = "INSERT INTO bp_diary(systolic, diastolic) VALUES(:systolic, :diastolic)";

            using (NpgsqlConnection cn = new NpgsqlConnection(connection_string))

            {
                NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, cn);
                cmd.Parameters.AddWithValue(new NpgsqlParameter("systolic", bp_Diary.systolic));
                cmd.Parameters.AddWithValue(new NpgsqlParameter("diastolic", bp_Diary.diastolic));

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        }
}