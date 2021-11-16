using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoCRM.Core.Modules.Deal
{
    public class Fields
    {
        public class ActionCreateDeal
        {
           public Properties properties { get; set; }
            public string? id { get; set; }
            
            public class Properties
            {
                public string? amount { get; set; }
                public DateTime closedate { get; set; }
                public string? dealname { get; set; }
                public string? dealstage { get; set; }
                public string hubspot_owner_id { get; set; }
                public string pipeline { get; set; }
            }
           
               
            

        }
    }
}
