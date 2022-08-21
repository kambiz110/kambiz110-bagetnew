using Application.Interfaces.Contexts;
using Domain.Users;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFile.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {

        private readonly IHostingEnvironment _environment;
        private readonly IIdentityDatabaseContext context;

        public ImagesController(IHostingEnvironment hostingEnvironment , IIdentityDatabaseContext context)
        {
            _environment = hostingEnvironment;
            this.context = context;
        }

     

        public IActionResult Post(string apiKey ,string token)
        {
            var user = context.Users.Include(p => p.UserTokens).FirstOrDefault(p=>p.Id== apiKey);
            if (user.UserTokens == null && user.UserTokens.Value!= token)
            {
                return BadRequest();
            }
            try
            {
                var files = Request.Form.Files;
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (files != null)
                {
                    var uploadresult = UploadFile(files);
                    return Ok(uploadresult);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal server error");
                throw new Exception("upload image error", ex);
            }


        }
        private UploadDto UploadFile(IFormFileCollection files)
        {
            string newName = Guid.NewGuid().ToString();
            var date = DateTime.Now;
            string folder = $@"Resources\images\{date.Year}\{date.Year}-{date.Month}\{date.Year}-{date.Month}-{date.Day}\";
            string folderDb = $@"Resources/images/{date.Year}/{date.Year}-{date.Month}/{date.Year}-{date.Month}-{date.Day}/";
            var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
            if (!Directory.Exists(uploadsRootFolder))
            {
                Directory.CreateDirectory(uploadsRootFolder);
            }
            List<string> address = new List<string>();
            foreach (var file in files)
            {
                if (file != null && file.Length > 0)
                {
                    string fileName = newName + file.FileName;
                    var filePath = Path.Combine(uploadsRootFolder, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    address.Add(folderDb + fileName);
                }
            }
            return new UploadDto()
            {
                FileNameAddress = address,
                Status = true,
            };
        }
       
    }

    public class UploadDto
    {
        public bool Status { get; set; }
        public List<string> FileNameAddress { get; set; }
    }
}

