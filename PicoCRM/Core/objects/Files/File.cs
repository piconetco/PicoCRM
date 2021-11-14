using HubSpot.NET.Api.Files.Dto;
using HubSpot.NET.Core;
using RestSharp;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PicoCRM.Modules.File
{
   public  class Files
    {
        public string UploadFile()
        {
            var options1 = new { access = "PUBLIC_INDEXABLE" };

            var properties1 = JsonConvert.SerializeObject(options1);
            var request1 = new RestRequest(Method.POST);
            var client = new RestClient("http://api.hubapi.com/files/v3/files?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
            request1.AddFile("file", "D:\\template.jpg");
            request1.AddParameter("folderPath", "/appindex");
            request1.AddParameter("options", properties1);
            IRestResponse response1 = client.Execute(request1);
            return response1.Content;
        }
    }
}
