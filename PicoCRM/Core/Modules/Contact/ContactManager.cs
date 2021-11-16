﻿using System;
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

                var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
                var request = new RestRequest(Method.POST);
                request.AddHeader("accept", "application/json");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", BuildData, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {

                    var resultOk = JsonConvert.DeserializeObject<ActionCreate.Response>(response.Content);
                    ContactId = resultOk.id.ToString();
                   
                    return  ContactId;
                }

                else
                {
                    var resultError = JsonConvert.DeserializeObject<ActionCreate.Response.Error>(response.Content);

                    if (resultError.category == "CONFLICT")
                    {
                        string ContactId = new String(resultError.message.Where(Char.IsDigit).ToArray());
                        return ContactId;
                    }
                    else
                    {
                        return "UNKNOWN_ERROR";
                    }

                }



            }
            public string GetContactInfo()
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
                request.AddQueryParameter("hapikey", "e3484c9e-83da-486a-98fc-f1df51436abe");
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
            public ActionAssociateContactToDeal(string contactid , string dealid)
            {
                var client = new RestClient($"https://api.hubapi.com/crm/v3/objects/contacts/{contactid}/associations/deals/{dealid}/contact_to_deal?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
                var request = new RestRequest(Method.PUT);
                request.AddHeader("accept", "application/json");
                IRestResponse response = client.Execute(request);

             
            }

        }
    }
    
}
