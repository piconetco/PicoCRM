using RestSharp;
using System;
using System.Globalization;
namespace PicoCRM.Core.Modules.SMSProvider
{

    public class Handler
    {

        public class Config
        {
            public string op { get; set; }
            public string uname { get; set; }
            public string pass { get; set; }
            public string message { get; set; }
            public string from { get; set; }
            public string[] to { get; set; }
            public string time { get; set; }
        }

        public class Send
        {
            public string SendWelcome(string name, string lastname, string phone, string customercode)
            {
                var client = new RestClient("http://ippanel.com:8080/");
                var request = new RestRequest(Method.GET);
                request.AddQueryParameter("apikey", "yGSsWR4YZzwnE1gikCr6g6WrOQ0Fe0NJ3Kk494ZtHkI=");
                request.AddQueryParameter("pid", "i43ttk2g8n");
                request.AddQueryParameter("fnum", "3000505");
                request.AddQueryParameter("tnum", phone);
                request.AddQueryParameter("p1", "name");
                request.AddQueryParameter("p2", "lastname");
                request.AddQueryParameter("p3", "customerid");

                request.AddQueryParameter("v1", name);
                request.AddQueryParameter("v2", lastname);
                request.AddQueryParameter("v3", customercode);


                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                var response = client.Execute(request);



                return response.Content;
            }


            public string SendTranaction(string phone, string DealAmount, string CustomerRevenue, string name, string lastname, string trackingcode)
            {

                var client = new RestClient("http://ippanel.com:8080/");

                var request = new RestRequest(Method.GET);

                request.AddQueryParameter("apikey", "yGSsWR4YZzwnE1gikCr6g6WrOQ0Fe0NJ3Kk494ZtHkI=");

                request.AddQueryParameter("pid", "pue302v18l");

                request.AddQueryParameter("fnum", "3000505");
                request.AddQueryParameter("tnum", phone);
                request.AddQueryParameter("p1", "name");
                request.AddQueryParameter("p2", "lastname");
                request.AddQueryParameter("p3", "score");
                request.AddQueryParameter("p4", "totalscores");
                request.AddQueryParameter("p5", "trackingcode");
                request.AddQueryParameter("v1", name);
                request.AddQueryParameter("v2", lastname);
                request.AddQueryParameter("v3", DealAmount);
                request.AddQueryParameter("v4", CustomerRevenue);
                request.AddQueryParameter("v5", trackingcode);

                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                var response = client.Execute(request);



                return response.Content;



            }

            public string SendReportToAdmin(string AdminPhone, string DealAmount, string DealTitle, string TotalRevenue,string about, string trackingcode)
            {
                DateTime thisDate = DateTime.Now;
                PersianCalendar pc = new PersianCalendar();
                string PersianDateConverter = "" + pc.GetYear(thisDate) + "/"
                    + pc.GetMonth(thisDate)+"/"
                      
                    + pc.GetDayOfMonth(thisDate);



                var client = new RestClient("http://ippanel.com:8080/");

                var request = new RestRequest(Method.GET);

                request.AddQueryParameter("apikey", "yGSsWR4YZzwnE1gikCr6g6WrOQ0Fe0NJ3Kk494ZtHkI=");

                request.AddQueryParameter("pid", "hys7gcbv0e");

                request.AddQueryParameter("fnum", "3000505");
                request.AddQueryParameter("tnum", AdminPhone);
                request.AddQueryParameter("p1", "title");
                request.AddQueryParameter("p2", "time");
                request.AddQueryParameter("p3", "amount");
                request.AddQueryParameter("p4", "totals");
                request.AddQueryParameter("p5", "about");
                request.AddQueryParameter("p6", "trackingcode");
                request.AddQueryParameter("v1", DealTitle);
                request.AddQueryParameter("v2", PersianDateConverter + " "+ DateTime.Now.Hour+":"+ DateTime.Now.Minute+":"+ DateTime.Now.Second);
                request.AddQueryParameter("v3", DealAmount);
                request.AddQueryParameter("v4", TotalRevenue);
                request.AddQueryParameter("v5", about);
                request.AddQueryParameter("v6", trackingcode);

                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                var response = client.Execute(request);



                return response.Content;



            }
        }

    }


}

