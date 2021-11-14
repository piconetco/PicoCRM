
using HubSpot.NET.Core;
using System;
using PicoCRM.Modules.Dto.Deal;
using HubSpot.NET.Api.Deal.Dto;

using RestSharp;
using Newtonsoft.Json;

namespace PicoCRM.Modules.Deal
{
    class Deal
    {
        public string CreateDeal(string cDealName, string cDealAmountt, string aboutdeal , string dealstage)
        {
            var client = new RestClient("https://api.hubapi.com/crm/v3/objects/deals/?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
            var request = new RestRequest(Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");

            DealDto.Rootobject deal = new DealDto.Rootobject
            {
             
               
             
                properties = new DealDto.Properties
                {
                    amount = cDealAmountt,
                    dealname = cDealName,
                    deal_desc = aboutdeal,
                    dealstage = dealstage,
                    
                }
            };

            string json = JsonConvert.SerializeObject(deal);
            request.AddParameter("application/json", json, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DealDto.Rootobject>(response.Content);
            return result.id;

        }
     
        
        
        /* public Dto.Deal.DealDto.Rootobject GetDeal(string cDealId)
        {
            var client = new RestClient($"https://api.hubapi.com/crm/v3/objects/deals/{cDealId}?archived=false&hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");


            IRestResponse response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DealDto.Rootobject>(response.Content);
            
            return result.properties.dealstage;
        }*/


        public string UpdateDeal(string dealid , string DealTitle,string DealAmount , string DealStage, string DealAbout)
        {

            var client = new RestClient($"https://api.hubapi.com/crm/v3/objects/deals/{dealid}?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");

            DealDto.Rootobject deal = new DealDto.Rootobject
            {

               

                properties = new DealDto.Properties
                {
                    amount = DealAmount,
                    dealname = DealTitle,
                    deal_desc = DealAbout,
                    dealstage = DealStage,

                }

            };

            string json = JsonConvert.SerializeObject(deal);
            request.AddParameter("application/json", json, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DealDto.Rootobject>(response.Content);
            return result.updatedAt;

        }

        public string DeleteDeal (string dealid)
        {
            var client = new RestClient($"https://api.hubapi.com/crm/v3/objects/deals/{dealid}?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("accept", "application/json");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
