using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PicoCRM.Core.Modules.Contact.Fields;

namespace PicoCRM.Core.Modules.Contact
{
   
    public class ContactManager
    {
        
        public class ActionCreateContact

        {
            public static  string? BuildData { get; set; }

            public static string? ProccessOutput { get; set; }

            public ActionCreateContact(string contactid)
            {
                

                ActionCreate.Request.Properties FieldData = new ActionCreate.Request.Properties

                {
                  
                    
                     
                };
                string json = JsonConvert.SerializeObject(FieldData);
                
                BuildData = "{\"properties\":"+json+"}";
               
                ProccessOutput =  DoCreate();
            }

            private string DoCreate()
            {
                var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
                var request = new RestRequest(Method.POST);
                request.AddHeader("accept", "application/json");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json",BuildData, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                var result = JsonConvert.DeserializeObject<ActionCreate.Responce>(response.Content);
                
                return result.id.Value.ToString();
            }
            public string GetContactInfo()
            {
                return ProccessOutput;
            }


        }
        public class ActionDeleteContact
        {
          
        }

        public class ActionUpdateContact

        {
            public ActionUpdateContact()
            {

            }
        }
    }
    
}
