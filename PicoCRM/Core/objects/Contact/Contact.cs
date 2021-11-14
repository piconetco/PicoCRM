
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PicoCRM.Modules.Contact
{
    class Contact
    {
        public   long Create(string cName, string cLast, string cPhone, string cEmail, [Optional] string dealerid)
        {
            try
            {
                var api = new HubSpotApi("e3484c9e-83da-486a-98fc-f1df51436abe");

                var result = api.Contact.Create(new ContactHubSpotModel { FirstName = cName, LastName = cLast, Phone = cPhone, Email = cPhone + "@gmail.com", Website = dealerid + ".com", OwnerId= 101018776 });

                return result.Id.Value;
            }
           
            catch (HubSpotException ex)
           
            {
                if (ex.ReturnedError.ErrorCode == "Conflict")
                {
                    return GetContactID(cPhone);
                }
              
                return -1;
            }
         
        }

        

        public long GetContactID(string phone)
        {
            try
            {
                var api = new HubSpotApi("e3484c9e-83da-486a-98fc-f1df51436abe");
                var FindContact = api.Contact.GetByEmail<ContactHubSpotModel>(phone + "@gmail.com");



                return FindContact.Id.Value;

            }
            catch (HubSpotException ex)
            {
                return 0;
            }


        }
        public Dto.Contact.Dto.CustomerData GetCustomerDetails(long vid)
        {
            var client = new RestClient($"https://api.hubapi.com/contacts/v1/contact/vid/{vid}/profile?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "application/json");
            IRestResponse response = client.Execute(request);

            var data = JsonConvert.DeserializeObject<Dto.Contact.Dto.CustomerData>(response.Content);

            return data;
        }

        public string SearchInContact()
        {
            return "";
        }

        public Dto.Request.Contact.Dto.ContactList.Rootobject  GetContactList()
        {

            
            var client = new RestClient("https://api.hubapi.com/crm/v3/objects/contacts?limit=100&&properties=phone&properties=total_revenue&properties=firstname&properties=lastname&archived=false&hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "application/json");
            var cancellationTokenSource = new CancellationTokenSource();

            IRestResponse response =  client.Execute(request);

            var json = JsonConvert.DeserializeObject<Dto.Request.Contact.Dto.ContactList.Rootobject>(response.Content);
            return json;
        }
    }
  
}
