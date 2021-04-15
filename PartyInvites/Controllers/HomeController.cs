using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Collections.Generic;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController 
        : Controller
    {
       //Fields

        // Constructors

        // Methods
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Index()
        {
            //GuestResponse paulsResponse = new GuestResponse();

            //paulsResponse.Email = " BantaP@ERAU.Edu";
            //string e = paulsResponse.Email;
            ////paulsResponse.SetName("Paul");
            //paulsResponse.Name = "Paula"; // "set" property
            //string paulsName = paulsResponse.Name; // "get" property


            return View();
        }
       
        public IActionResult ListResponses()
        {   // responses Type is List<GuestResponse>  = Repository is calling GetResponse Method

            List<GuestResponse> responses = Repository.GetResponses();
            List<GuestResponse> willAttend
                 = responses.Where(r => r.WillAttend == true).ToList(); // LINQ - Language Integrated Query. Also try (OrderBy(r=>r.Name).ToList();
            return View(responses);

        }

     

        
        [HttpGet]
        public IActionResult RsvpForm()
        {
            IActionResult answer = View();
            return answer;
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse gr)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(gr); // add response to the list
               
                return View("Thanks", gr); // display the thanks  view 
            }

            else
            {
                return View();
            }
        }





    }
}
