using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoCRM.Core.Modules.Deal
{
   
    public  class DealManager
   
    {
    
    
        public class ActionCreateDeal
        {
            public static string? BuildData { get; set; }
            public static Fields.ActionCreateDeal? result1 { get; set; }
            public ActionCreateDeal(string DealTitle , string DealAmount)
            {
                var client = new RestClient("https://api.hubapi.com/crm/v3/objects/deals");
                var request = new RestRequest(Method.POST);
                request.AddHeader("accept", "application/json");
                request.AddHeader("content-type", "application/json");
                request.AddQueryParameter("hapikey", "e3484c9e-83da-486a-98fc-f1df51436abe");

                var FieldData = new Fields.ActionCreateDeal.Properties
                {
                    amount= DealAmount,
                    dealname= DealTitle,
                    dealstage= "closedwon",
                    closedate=  DateTime.UtcNow,
                    hubspot_owner_id= "57458593",
                    pipeline="default"

                };
                string json = JsonConvert.SerializeObject(FieldData);
                BuildData = "{\"properties\":" + json + "}";
                request.AddParameter("application/json", BuildData, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
               
                var result = JsonConvert.DeserializeObject<Fields.ActionCreateDeal>(response.Content);
                result1= result;
               

            }

            public string GetResult()
            {
                return result1.id.ToString();
            }
        }
    
    
    }
}
