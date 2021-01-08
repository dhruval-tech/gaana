using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gaana.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using gaana.Data;
using System.Net.Mail;
using System.Net;
using WebMatrix.WebData;

namespace gaana.Controllers 
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context ;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact() {
            return View();
        }

        public IActionResult Music1()
        {
            return View();
        }
        public IActionResult Music2()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgotPassword(string Email)
        {
            if (ModelState.IsValid)
            {

                
                    //string To = Email, UserID, Password, SMTPPort, Host;
                    //string token = WebSecurity.GeneratePasswordResetToken(Email);
                    //if (token == null)
                    //{
                    // If user does not exist or is not confirmed.  

                    //  return View("Index");

                    //}


                    //Create URL with above token  



                    //EmailManager.SendEmail(UserID, subject, body, To, UserID, Password, SMTPPort, Host);

                    var senderEmail = new MailAddress("dhruval.gaana@gmail.com", "Dhruval");
                    var receiverEmail = new MailAddress(Email, "Receiver");
                    var password = "";
                    var subject = "Get Your password";
                    var body = "Your password is Admin@123";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("login", "account");


                

            }
            return View();
        }

        [Authorize]
        public IActionResult Albums()
        {
            var albums = _context.Albums.ToList();
            return View(albums);
        }

        [Authorize]
        public IActionResult Events()
        {
            var events = _context.Events.ToList();
            return View(events);
   
        }
        [HttpGet]
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEvent(Event events)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(events);
                _context.SaveChanges();

                return RedirectToAction("events","home");
            }
            return View(events);
        }

        [HttpPost]
        public IActionResult Book(string UserName, string Email , string TotalPersons)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Events.Add(events);
            //    _context.SaveChanges();

            //    return RedirectToAction("events", "home");
            //}
            //return View(events);
            try
            {
                if (ModelState.IsValid)
                {
                    
                    var senderEmail = new MailAddress("dhruval.gaana@gmail.com", "Dhruval");
                    var receiverEmail = new MailAddress(Email, "Receiver");
                    var password = "Dhruv@l123";
                    var subject = "You have successfully booked";
                    var body = "Thank you for booking :)";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("events","home");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddAlbum()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAlbum(Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Albums.Add(album);
                _context.SaveChanges();

                return RedirectToAction("albums", "home");
            }
            return View(album);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
