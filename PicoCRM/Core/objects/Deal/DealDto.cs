using System;
using System.Runtime.Serialization;
using HubSpot.NET.Api.Deal.Dto;
namespace PicoCRM.Modules.Dto.Deal
{

    public class DealDto

    {



        public class Rootobject
        {
            public string id { get; set; }
            public Properties properties { get; set; }

            public string updatedAt { get; }
        }

        public class Properties
        {
            public string amount { get; set; }
            public string closedate { get; set; }
            public string createdate { get; set; }
            public string dealname { get; set; }
            public string dealstage { get; set; }
            public string hs_lastmodifieddate { get; set; }
            public string hubspot_owner_id { get; set; }
            public string pipeline { get; set; }


            public string deal_desc { get; set; }

      

          

        }

    }
}
