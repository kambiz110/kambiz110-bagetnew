using Application.Users.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGetUsers getUsers;

        public UsersController(IGetUsers getUsers)
        {
            this.getUsers = getUsers;
        }
        public IActionResult Index(int pageIndex = 1, int pageSize = 10, string q = "", string search = "")
        {
            if (search == "clear")
            {
                return RedirectToAction("Index");
            }
            var model = getUsers.AllUser(pageIndex, pageSize, q);
            return View(model);


        }
    }
}
