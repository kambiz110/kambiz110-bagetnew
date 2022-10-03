using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Ticket.ElFinder;
using Ticket.ElFinder.Drivers.FileSystem;
using Admin.EndPoint.Helper;
namespace Admin.EndPoint.Controllers
{
    [Route("el-finder/file-system")]
    [Authorize(Roles = "Administrator,Maneger")]
    public class FileSystemController : Controller
    {
        [Route("connector")]
        public async Task<IActionResult> Connector()
        {
            var IsAdmin = User.IsInRole("Administrator");
            var connector = GetConnector(IsAdmin);
            return await connector.ProcessAsync(Request);
        }

        [Route("thumb/{hash}")]
        public async Task<IActionResult> Thumbs(string hash)
        {
            var IsAdmin = User.IsInRole("Administrator");
            var connector = GetConnector(IsAdmin);
            return await connector.GetThumbnailAsync(HttpContext.Request, HttpContext.Response, hash);
        }

        private Connector GetConnector(bool isadmin)
        {
            var driver = new FileSystemDriver();

            string absoluteUrl = UriHelper.BuildAbsolute(Request.Scheme, Request.Host);
            var uri = new Uri(absoluteUrl);

            var root = new RootVolume(
                Helper.PathHelper.MapPath("~/Files/"),
                $"{uri.Scheme}://{uri.Authority}/Files/",
                $"{uri.Scheme}://{uri.Authority}/el-finder/file-system/thumb/")
            {
                //IsReadOnly = !User.IsInRole("Administrators")
                IsReadOnly = false, // Can be readonly according to user's membership permission
                IsLocked = !isadmin, 
                Alias = "مدیریت_فایل_فروشگاه_زنجانی", // Beautiful name given to the root/home folder
                                                       //MaxUploadSizeInKb = 2048, // Limit imposed to user uploaded file <= 2048 KB
                AccessControlAttributes = new HashSet<NamedAccessControlAttributeSet>()
                {
                    new NamedAccessControlAttributeSet(Helper.PathHelper.MapPath("~/Files/readonly.txt"))
                    {
                        Write = false,
                        Locked = true
                    },
                    new NamedAccessControlAttributeSet(Helper.PathHelper.MapPath("~/Files/Prohibited"))
                    {
                        Read = false,
                        Write = false,
                        Locked = true
                    },
                    new NamedAccessControlAttributeSet(Helper.PathHelper.MapPath("~/Files/Parent/Children"))
                    {
                        Read = true,
                        Write = false,
                        Locked = true
                    }
                }
            };

            driver.AddRoot(root);

            return new Connector(driver)
            {
                // This allows support for the "onlyMimes" option on the client.
                MimeDetect = MimeDetectOption.Internal
            };
        }
    }
}
