using Application.Users.Dto;
using Application.Users.Query;
using Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGetUsers getUsers;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public UsersController(IGetUsers getUsers, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            this.getUsers = getUsers;
            _userManager = userManager;
            _roleManager = roleManager;
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
        public IActionResult AllRoleInUser(string id)
        {
            ViewBag.UserId = id;
            var user = _userManager.FindByIdAsync(id).Result;
            var userRoles =  _userManager.GetRolesAsync(user).Result;
            RolesInUserDto rolesInUser = new RolesInUserDto { 
            FullName=user.FullName,
            UserId=user.Id,
            getShortRoles= new GetShortRolesForShowAdmin() { 
             RolesName= userRoles.Select(p=>p.Trim()).ToList()
            }
            };
            return View(rolesInUser);
        }
        [HttpGet]
        public IActionResult AddRoleToUser(string userId)
        {

            var user = _userManager.FindByIdAsync(userId).Result;
            var roles = _roleManager.Roles.ToList();
           var RolesSelectListItem = roles.Select(p => new SelectListItem { Value = p.Name, Text = p.Name }).ToList();
           ViewData["Roles"] = RolesSelectListItem;
            return View(new AddRoleToUserDto() {Id= userId  , FullName=user.FullName});
        }
        [HttpPost]
        public IActionResult AddRoleToUser([Bind("Id,Role")] AddRoleToUserDto dto)
        {
            var user = _userManager.FindByIdAsync(dto.Id).Result;
            var Existrole = _userManager.IsInRoleAsync(user, dto.Role).Result;
            if (!Existrole)
            {
              var result =  _userManager.AddToRoleAsync(user, dto.Role).Result;
            }
            return RedirectToAction("AllRoleInUser", new { id = dto.Id });
        }
        [HttpGet]
        [Route("Users/DeleteRoleInUser/{UserId}/{RolesName}")]
        public IActionResult DeleteRoleInUser(string UserId, string RolesName)
        {
            var user = _userManager.FindByIdAsync(UserId).Result;
            var result = _userManager.RemoveFromRoleAsync(user, RolesName).Result;
     
            var referer = HttpContext.Request.Headers["Referer"].ToString();
            return Redirect(referer);
        }

        [HttpGet]
        public IActionResult ChengeLockAccunt(string userName)
        {
            var user = _userManager.FindByNameAsync(userName).Result;
            if (user != null)
            {
                bool locked = _userManager.GetLockoutEnabledAsync(user).Result;
                var result = _userManager.SetLockoutEnabledAsync(user, !locked).Result;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
