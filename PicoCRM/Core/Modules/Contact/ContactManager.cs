using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static PicoCRM.Core.Modules.Contact.Fields;

namespace PicoCRM.Core.Modules.Contact
{

    public class ContactManager
    {

        public class ActionCreateContact

        {
            public static string? BuildData { get; set; }

            public static string? ProccessOutput { get; set; }

            public static string? ContactId { get; set; }
            public static string? ContactTotalRevenue { get; set; }

            public ActionCreateContact(string firstname, string lastname, string phone)
            {


                ActionCreate.Request.Properties FieldData = new ActionCreate.Request.Properties

                {
                    firstname = firstname,
                    lastname = lastname,
                    phone = phone,
                    email = phone + "@PicoCRM.ir"


                };
                string? json = JsonConvert.SerializeObject(FieldData);

                BuildData = "{\"properties\":" + json + "}";

                ProccessOutput = DoCreate();
            }

            private string DoCreate()
            {
                ActionCreate.Response.Error ErrorData = new ActionCreate.Response.Error();
                ActionCreate.Response.Properties ContactProp = new ActionCreate.Response.Properties();

                var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts");
                var request = new RestRequest(Method.POST);
                request.AddHeader("accept", "application/json");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", BuildData, ParameterType.RequestBody);

                request.AddQueryParameter("hapikey", "3ad5de2d-b2b7-450f-9396-8039cf878077");
                IRestResponse response = client.Execute(request);
                ContactId = response.Content;
               

                var resp = JsonConvert.DeserializeObject<ActionCreate.Response>(response.Content);


                 if (resp.category == "CONFLICT")
                  { 
                    string ExtractedContactID =Regex.Match(resp.message, @"\d+").Value;
                    
                    ContactId = ExtractedContactID;
                  }
                  else
                  {
                      ContactId = resp.id.ToString();
                  }

                return "";

            }
            public string GetContactID()
            {
                return ContactId;
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

        public class ActionGetContact
        {
            public static ActionGet.Response? ContactData { get; set; }
            public ActionGetContact(int contactId)
            {
                
                var client = new RestClient($"https://api.hubapi.com/crm/v3/objects/contacts/{contactId}?");
                var request = new RestRequest(Method.GET);
                request.AddHeader("accept", "application/json");
                request.AddQueryParameter("properties", "phone");
                request.AddQueryParameter("properties", "total_revenue");
                request.AddQueryParameter("properties", "firstname");
                request.AddQueryParameter("properties", "lastname");
                request.AddQueryParameter("archived","false");
                request.AddQueryParameter("hapikey", "3ad5de2d-b2b7-450f-9396-8039cf878077");
                IRestResponse response = client.Execute(request);
                var result =  JsonConvert.DeserializeObject<ActionGet.Response>(response.Content);
           
                ContactData = result;
            }
            public ActionGet.Response GetData()
            {
                return ContactData;
            }
        }

        public class ActionAssociateContactToDeal
        {
          public static string Result { get; set; }
            
            public ActionAssociateContactToDeal(string contactid , string dealid)
            {
                var client = new RestClient($"https://api.hubapi.com/crm/v3/objects/contacts/{contactid}/associations/deals/{dealid}/contact_to_deal");
                var request = new RestRequest(Method.PUT);
                request.AddHeader("accept", "application/json");
                request.AddQueryParameter("hapikey", "3ad5de2d-b2b7-450f-9396-8039cf878077");

                IRestResponse response = client.Execute(request);

                Result = response.Content;

             
            }

            public string GetResult ()
            {
                return Result;
            }

        }
    }
    
}
