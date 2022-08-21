using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.Drawing;
using ImageResizer;

namespace Admin.EndPoint.Helper.UploadFile
{
    public interface IUploadFile {
         UploadDto UploadFileToServers(List<IFormFile>  files);
         UploadDto UploadFileToServersResized(List<IFormFile>  files , int width , int height);
    }
   public class UploadFile : IUploadFile
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public UploadFile(IWebHostEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }

        public UploadDto UploadFileToServers(List<IFormFile>  files )
        {
            if (files != null && files.Count > 0)
            {

                string newName = Guid.NewGuid().ToString();
                var date = DateTime.Now;
                string folder = $@"Resources\images\{date.Year}\{date.Year}-{date.Month}\{date.Year}-{date.Month}-{date.Day}\";
                string folderDb = $@"Resources/images/{date.Year}/{date.Year}-{date.Month}/{date.Year}-{date.Month}-{date.Day}/";
                var uploadsRootFolder = Path.Combine(_hostingEnvironment.WebRootPath, folder);

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
            return null;
        }
      
        public UploadDto UploadFileToServersResized(List<IFormFile>  files , int width, int height)
        {
            if (files != null && files.Count > 0)
            {

                string newName = Guid.NewGuid().ToString();
                var date = DateTime.Now;
                string folder = $@"Resources\images\{date.Year}\{date.Year}-{date.Month}\{date.Year}-{date.Month}-{date.Day}\";
                string folderDb = $@"Resources/images/{date.Year}/{date.Year}-{date.Month}/{date.Year}-{date.Month}-{date.Day}/";
                var uploadsRootFolder = Path.Combine(_hostingEnvironment.WebRootPath, folder);

                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }
                List<string> address = new List<string>();
                foreach (var file in files)
                {
                    if (file != null && file.Length > 0)
                    {
                        var versions = new Dictionary<string, string>();

                        string fileName = newName + file.FileName;
                        var path = Path.Combine(uploadsRootFolder, fileName);

                         var image = SixLabors.ImageSharp.Image.Load(file.OpenReadStream());
                        //100: height
                        //100: width
                        image.Mutate(x => x.Resize(width, height));
                        image.Save(path);
                        address.Add(folderDb + fileName);
                    }
                }
                return new UploadDto()
                {
                    FileNameAddress = address,
                    Status = true,
                };
            }
            return null;
        }
      
    }
    public class UploadDto
    {
        public bool Status { get; set; }
        public List<string> FileNameAddress { get; set; }
    }
}
