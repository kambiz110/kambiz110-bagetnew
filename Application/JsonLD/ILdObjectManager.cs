using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalohItems.AddNewCatalogItem;
using Application.Interfaces.Contexts;
using Domain.JsonLD;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JsonLD
{
    public interface ILdObjectManager
    {
        string GetArticleLdObject(CatalogItemPDPDto post);
        string GetOrganizationLdObject();
        string GetBreadcrumLdObject(List<string> names, List<string> urls);
        string GetCarouselLdObject(List<CatalogItemPDPDto> posts);
    }
    public class LdObjectManager : ILdObjectManager
    {
        private readonly string contentRootPath = Directory.GetCurrentDirectory();
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHostingEnvironment _hostingEnvironment;

        public LdObjectManager(IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment)
        {
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
        }

        public string GetArticleLdObject(CatalogItemPDPDto post)
        {
            List<string> imgList = new List<string>();
            imgList.Add($"https://{_httpContextAccessor.HttpContext.Request.Host.Value}/Uploads/BlogImages/" + post.Images.FirstOrDefault());
            ArticleLdJson article = new ArticleLdJson()
            {
                mainEntityOfPage = new MainEntityOfPage()
                {
                    id = $"https://{_httpContextAccessor.HttpContext.Request.Host.Value}/?url=" + post.Description
                },
                headline = post.Name,
                image = imgList,
               // datePublished = post..ToString("yyyy-MM-dd"),
              //  dateModified = post.UpdatedOn.ToString("yyyy-MM-dd"),
                author = new Author()
                {
                    name = "https://yadakcarshop.com/"//post.c
                },
                publisher = new Publisher()
                {
                    logo = new Logo()
                    {
                        url = $"https://{_httpContextAccessor.HttpContext.Request.Host.Value}/Uploads/UserImages/blog-icon_269d.jpg"
                    }
                }
            };

            return article.ToString();
        }

        public string GetBreadcrumLdObject(List<string> names, List<string> urls)
        {
            throw new NotImplementedException();
        }

        public string GetCarouselLdObject(List<CatalogItemPDPDto> posts)
        {
            throw new NotImplementedException();
        }

        public string GetOrganizationLdObject()
        {
            throw new NotImplementedException();
        }
    }
}
