namespace PicoCRM.Modules.Dto.Request.Contact
{

    public class Dto
    {
        #region ContactData


        public class CustomerData
        {

            public Properties properties { get; set; }

        }

        public class Properties
        {

            public string firstname { get; set; }

            public string lastname { get; set; }

            public string company { get; set; }

            public string email { get; set; }

            public string phone { get; set; }

        }



        #endregion CustomerData




        #region GetlistOfContacts

        public class ContactList
        {
            public class Rootobject
            {
                public Result[] results { get; set; }
                public Paging paging { get; set; }
            }

            public class Paging
            {
                public Next next { get; set; }
            }

            public class Next
            {
                public string after { get; set; }
                public string link { get; set; }
            }

            public class Result
            {
                public string id { get; set; }
                public Properties properties { get; set; }
                public DateTime createdAt { get; set; }
                public DateTime updatedAt { get; set; }
                public bool archived { get; set; }
            }

            public class Properties
            {
                public DateTime createdate { get; set; }
                public string email { get; set; }
                public string firstname { get; set; }
                public string hs_object_id { get; set; }
                public DateTime lastmodifieddate { get; set; }
                public string lastname { get; set; }
                public string phone { get;set; }
                public string total_revenue { get; set; }
            }
        }

        #endregion

    }
}
