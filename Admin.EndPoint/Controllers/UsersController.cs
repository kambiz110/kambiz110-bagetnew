using Application.Orders.CustomerOrdersServices;
using Application.Users.Dto;
using Application.Users.Query;
using Domain.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
   
    [Authorize(Roles = "Administrator,Maneger")]
    public class UsersController : Controller
    {
        private readonly IGetUsers getUsers;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly ICustomerOrdersService customerOrdersService;
        public UsersController(IGetUsers getUsers, UserManager<User> userManager, RoleManager<Role> roleManager, ICustomerOrdersService customerOrdersService)
        {
            this.getUsers = getUsers;
            _userManager = userManager;
            _roleManager = roleManager;
            this.customerOrdersService = customerOrdersService;
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
        [Authorize(Roles = "Administrator")]
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
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult AddRoleToUser(string userId)
        {

            var user = _userManager.FindByIdAsync(userId).Result;
            var roles = _roleManager.Roles.ToList();
           var RolesSelectListItem = roles.Select(p => new SelectListItem { Value = p.Name, Text = p.Name }).ToList();
           ViewData["Roles"] = RolesSelectListItem;
            return View(new AddRoleToUserDto() {Id= userId  , FullName=user.FullName});
        }
        [Authorize(Roles = "Administrator")]
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
        [HttpGet]
        [Route("users/ResetPassword/{id}")]
        public IActionResult ResetPassword(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            if (user != null)
            {
                ResetPasswordDto dto = new ResetPasswordDto
                {
                    Id = user.Id,
                    FullName = user.FullName
                };
                return View(dto);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("users/historyBuy/{id}")]
        public IActionResult HistoryBuy(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            if (user != null)
            {
                ViewBag.PhoneNumber = user.PhoneNumber;
                ViewBag.username = user.FullName;
            

                var orders = customerOrdersService.GetMyOrder(user.Id);
                return View(orders);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var user = _userManager.FindByIdAsync(dto.Id).Result;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, dto.Password);
            var result = _userManager.UpdateAsync(user).Result;
            if (result.Succeeded != true)
            {
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
