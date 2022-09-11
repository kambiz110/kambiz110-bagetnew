using Application.Dtos;
using Application.PostalProducts;
using Application.PostalProducts.Dto;
using Application.Returneds.Query;
using Application.ReturnPaymentInvoice.Commend;
using Application.ReturnPaymentInvoice.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{
    [Authorize(Roles = "Administrator,Maneger")]
    public class ReturndsController : Controller
    {
        private readonly IReturnedForAdminService returnedForAdmin;
        private readonly IAddPostalProductService addPostalProduct;
        private readonly IAddReturnPaymentInvoice returnPaymentInvoice;
        private readonly IHostingEnvironment _hostingEnvironment;
        public ReturndsController(IReturnedForAdminService returnedForAdmin,
            IAddPostalProductService addPostalProduct,
            IAddReturnPaymentInvoice returnPaymentInvoice, IHostingEnvironment hostingEnvironment)
        {
            this.returnedForAdmin = returnedForAdmin;
            this.addPostalProduct = addPostalProduct;
            this.returnPaymentInvoice = returnPaymentInvoice;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index(int returnStatus = 0)
        {
            var model = returnedForAdmin.GetMyReturneds(returnStatus);
            return View(model);
        }
        [Route("Returnds/ReturndDetails/{returnedId}")]
        public IActionResult ReturndDetails(int returnedId)
        {
            var model = returnedForAdmin.GetAdminOrderDitales(returnedId);
            if ((int)model.ReturnedStatus == 1)
            {
                var rootPath = _hostingEnvironment.ContentRootPath;
                var fullPath = Path.Combine(rootPath, "wwwroot/Files/BankDate/UserBankData.json");
                var jsonData = System.IO.File.ReadAllText(fullPath);

                var item = JsonConvert.DeserializeObject<List<BankDitel>>(jsonData);
                ViewData["BankOrigins"] = new SelectList(item.Select(p => new { Id = p.BankOriginNumber, Text = p.UserName + "_" + p.BankOrigin }).ToList(), "Id", "Text");
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ReturndPostals(AddReturnedPostalProductDto dto)
        {
             await addPostalProduct.ReturnedPostal(dto);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> ReturnPayment(AddReturnPaymentInvoiceDto dto)
        {
            ModelState.Remove("BankOrigin");
            if (!ModelState.IsValid)
            {
                var query = from state in ModelState.Values
                            from error in state.Errors
                            select error.ErrorMessage;

                var errorList = query.ToList();
                TempData["error"] = errorList;
                var referer = HttpContext.Request.Headers["Referer"].ToString();
                return new JsonResult(new ResultDto { IsSuccess = false, Message = "false" });
            }
            
            var rootPath = _hostingEnvironment.ContentRootPath;
            var fullPath = Path.Combine(rootPath, "wwwroot/Files/BankDate/UserBankData.json");
            var jsonData = System.IO.File.ReadAllText(fullPath);
            var item = JsonConvert.DeserializeObject<List<BankDitel>>(jsonData);
            dto.BankOrigin = item.Where(p => p.BankOriginNumber == dto.BankOriginNumber).FirstOrDefault().BankOrigin;
            await returnPaymentInvoice.addDataToDb(dto);
            return new JsonResult(new ResultDto { IsSuccess = true, Message = "موفق" });
        }
    }
}
