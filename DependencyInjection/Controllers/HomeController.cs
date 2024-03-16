using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjection.Controllers
{


    // Consturtor Injection yap�s� : Parametre olarak s�n�fa ait interface'i, parametre olarak almak demektir.
    // Ctor i�erisinden gelen interface de�eri �zerinden o s�n�fa ait metotlara eri�ebilirsiniz.
    public class HomeController : Controller
    {
        public IFileService _fileService;
        public Person _person;

        public HomeController(IFileService fileService, Person person)
        {
            _fileService = fileService;
            _person = person;
        }

        public IActionResult Index()
        {
           var files= _fileService.GetFileName();
            _person.Ad = "Hamdi";
            
            // FileServices isimli s�n�f�n i�erisindeki GetFileName metodunu �a��r�n�z.
           
            
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}