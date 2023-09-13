using Microsoft.AspNetCore.Mvc;
using Mindbox1.Models;



namespace Mindbox1.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Triangle(IndexModel model)
        {
            double TrS1 = Convert.ToDouble(model.TriangleSide1);
            double TrS2 = Convert.ToDouble(model.TriangleSide2);
            double TrS3 = Convert.ToDouble(model.TriangleSide3);
            double p = 0.5 * (TrS1 + TrS2 + TrS3);  //semiperimeter
            double TriangleArea = Math.Round(Math.Sqrt(p * (p - TrS1) * (p - TrS2) * (p - TrS3)), 3);
            string SessionValue;
            if (TriangleArea == 0 | double.IsNaN(TriangleArea))
            {
                SessionValue = "Треугольник с такими сторонами невозможен";
            }
            else
            {
                if (Math.Round((TrS1 * TrS1),3) + Math.Round((TrS2 * TrS2), 3) == Math.Round((TrS3 * TrS3), 3) || Math.Round((TrS3 * TrS3), 3) + Math.Round((TrS2 * TrS2), 3) == Math.Round((TrS1 * TrS1), 3) || Math.Round((TrS1 * TrS1), 3) + Math.Round((TrS3 * TrS3), 3) == Math.Round((TrS2 * TrS2), 3))
                {
                    SessionValue = String.Format("Сторона 1 = {0}, Сторона 2 = {1}, Сторона 3 = {2}, Площадь треугольника = {3} ... и это прямоугольный треугольник!", TrS1, TrS2, TrS3, TriangleArea);
                }
                else
                {
                    SessionValue = String.Format("Сторона 1 = {0}, Сторона 2 = {1}, Сторона 3 = {2}, Площадь треугольника = {3}", TrS1, TrS2, TrS3, TriangleArea);
                }
            }
            HttpContext.Session.SetString("Triangle", SessionValue);
            return RedirectToAction("Index");
        }


        public IActionResult Circle(IndexModel model)
        {
            double Radious = Convert.ToDouble(model.CircleRadius);
            double CircleArea = Math.Round((Math.PI * Radious * Radious), 4);
            string SessionValue = String.Format("Радиус = {0}, Площадь круга = {1}", Radious, CircleArea);
            HttpContext.Session.SetString("Circle", SessionValue);
            return RedirectToAction("Index");
        }

    }
}