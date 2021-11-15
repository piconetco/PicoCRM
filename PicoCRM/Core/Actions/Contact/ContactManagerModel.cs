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

            public class Responce
            {
                public int? id { get; set; }

                public Properties? properties { get; set; }

                public class Properties
                {
                    public string? company { get; set; }
                    public DateTime? createdate { get; set; }
                    public string? email { get; set; }
                    public string? firstname { get; set; }
                    public string? lastname { get; set; }
                    public string? phone { get; set; }
                    public string? website { get; set; }
                    public string? hs_all_contact_vids { get; set; }
                    public string? hs_is_contact { get; set; }
                }
            }

        }

    }

}
