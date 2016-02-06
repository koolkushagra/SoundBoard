using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SoundBoard.Controllers
{
    public class MessageController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // /message/create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string messageTitle, string messageContent) {

            //todo: validate

            //todo: store

            return View();
        }
    }
}
