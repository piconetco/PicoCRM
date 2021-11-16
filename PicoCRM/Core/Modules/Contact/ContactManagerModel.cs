using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoCRM.Core.Modules.Contact
{



    public class Fields
    {
        public class ActionCreate 
        
        {

            public class Request
            {

                public Properties? properties { get; set; }
                
                public class Properties
                {
                    public string? company { get; set; }
                    public string? email { get; set; }
                    public string? firstname { get; set; }
                    public string? lastname { get; set; }
                    public string? phone { get; set; }
                    public string? website { get; set; }

                }
            }

            public class Response
            {
                public int id { get; set; }

                public Properties? properties { get; set; }

                public class Properties
                {
                    public string? company { get; set; }
                    public DateTime createdate { get; set; }
                    public string? email { get; set; }
                    public string? firstname { get; set; }
                    public string? lastname { get; set; }
                    public string? phone { get; set; }
                    public string? website { get; set; }
                    public string? hs_all_contact_vids { get; set; }
                    public string? hs_is_contact { get; set; }
                    public string? total_revenue { get; set; }
                }

                public class Error
                {
                    public string? status { get; set; }
                    public string? message { get; set; }

                    public string? correlationId { get; set; }
                    public string? category { get; set; }
                }
            }

        }

        public class ActionGet
        {
            public class Response
            {
                public int? id { get; set; }
                public Properties? properties { get; set; }

                public class Properties
                {
                    public DateTime createdate { get; set; }
                    public string? email { get; set; }
                    public string? firstname { get; set; }
                    public string? phone { get; set; }
                    public string? lastname { get; set; }
                    public string? total_revenue { get; set; }

                }
                public DateTime createdAt { get; set; }
                public DateTime updatedAt { get; set; }
                public bool archived { get; set; }
                public  string? archivedAt { get; set; }
            }
        }

        public class ActionAssocContact
        {

        }
    }

}
