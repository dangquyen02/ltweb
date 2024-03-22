using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace SV20T1020237.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Create()
        {
            var model = new Models.Person()
            {
                Name = "Đặng Thị Quyên",
                BirthDate = new DateTime(2002, 03, 10),
                Salary = 10.25m
            };
            return View(model);
        }

        public IActionResult Save(Models.Person model, string BirthDateInput = "") 
        {
            //chuyển chuỗi BirthDateInput sang giá trị kiểu ngày
            DateTime? dValue = StringToDateTime(BirthDateInput);
            if (dValue.HasValue) 
            { 
                model.BirthDate = dValue.Value;
            }

            return Json(model);
        }

        private DateTime? StringToDateTime(string s, string formats = "d/M/yyyy;d-M-yyyy;d.M.yyyy")
        {
            try
            {
                return DateTime.ParseExact(s, formats.Split(';'), CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }
    }
}
