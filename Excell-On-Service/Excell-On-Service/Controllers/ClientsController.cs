using Excell_On_Service.ContextFolder;
using Excell_On_Service.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Excell_On_Service.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ProjectDbContext context;
        private readonly IWebHostEnvironment env;

        public ClientsController(ProjectDbContext context , IWebHostEnvironment env)
        {
            this.context = context;
            this.env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Index(Client client)
        {
            var data = context.TblClient.FirstOrDefault(p=> p.ClientEmail == client.ClientEmail);
            var clnt = from a in context.TblClient.Where(p=> p.ClientEmail == client.ClientEmail && p.ClientPassword == client.ClientPassword )
                       select a;
            if (clnt.Any())
            {
                if(data != null)
                {
                    HttpContext.Session.SetInt32("ClientId" , data.ClientId);
                    HttpContext.Session.SetString("ClientName" , data.ClientName);
                }
                return RedirectToAction("Index" , "Home");
            }
            else
            {
                TempData["Login_Error"] = "Email or password not Correct";
            }

            return View(client);
        }

        public IActionResult CreateClient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateClient(Client client , IFormFile img)
        {
            if (client == null) return NotFound();

            var data = context.TblClient.Where(p=>p.ClientEmail == client.ClientEmail);
            if(data.Any())
            {
                TempData["Creating_Error"] = "Email Already Exists";
            }
            else
            {
                if (ModelState.IsValid)
                {
                    if (img != null)
                    {
                        var imgPath = Path.Combine(env.WebRootPath, "ClientImage");
                        var fileName = Guid.NewGuid().ToString() + "_" + img.FileName;
                        var folderPath = Path.Combine(imgPath, fileName);
                        using (var fs = new FileStream(folderPath, FileMode.Create))
                        {
                            img.CopyTo(fs);
                            client.ClientPhoto = fileName;
                            context.TblClient.Add(client);
                            context.SaveChanges();
                            return RedirectToAction("Index", "Clients");
                        }
                    }
                }
            }
            return View(client);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("ClientName");
            HttpContext.Session.Remove("ClientId");
            HttpContext.Session.Remove("Admin");
            HttpContext.Session.Remove("Employee");
            return RedirectToAction("Index" , "Home");
        }
    }
}
