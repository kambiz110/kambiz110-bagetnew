using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ExternalApi.ImageServer
{
    public interface IImageUploadService
    {
        List<string> Upload(List<IFormFile> files, string apiKey, string token);
    }
    public class ImageUploadService : IImageUploadService
    {
        public List<string> Upload(List<IFormFile> files, string apiKey, string token)
        {
            var client = new RestClient($"https://localhost:44327/api/Images?apikey={apiKey}&token={token}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            if (files.Count()>0)
            {
            foreach (var item in files)
            {
                if (item!=null)
                {
                byte[] bytes;
                using (var ms = new MemoryStream())
                {
                    item.CopyToAsync(ms);
                    bytes = ms.ToArray();
                }
                request.AddFile(item.FileName, bytes, item.FileName, item.ContentType);
                }

            }


            IRestResponse response = client.Execute(request);
            UploadDto  upload = JsonConvert.DeserializeObject<UploadDto>(response.Content);
            return upload.FileNameAddress;
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
