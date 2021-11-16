

using PicoCRM.Modules.Dto.Request.Assoc;

namespace PicoCRM.Modules.Assoc
{

    public class Create

    {
        public string AssiciateContactToDeal(long contactid, long dealid)
        {

            var client = new RestClient("https://api.hubapi.com/crm/v3/associations/contact/deal/batch/create?hapikey=e3484c9e-83da-486a-98fc-f1df51436abe");
            var request = new RestRequest(Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            var res = new Dto.Request.Assoc.Assoc
            {
                inputs = new List<Input>
                {
                    new Input
                    {
                        from = new From
                        {
                            id= contactid.ToString()
                        },

                        to= new To
                        {
                            id= dealid.ToString()
                        },

                        type="contact_to_deal"




                    }
                }

            };


            var json = JsonConvert.SerializeObject(res);

            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
