namespace PicoCRM.Modules.Dto.Contact
{

    public class Dto
    {
        #region ContactData


        public class CustomerData
        {
            public int vid { get; set; }
            public int canonicalvid { get; set; }
            public object[] mergedvids { get; set; }
            public int portalid { get; set; }
            public bool iscontact { get; set; }
            public Properties properties { get; set; }
            public object[] formsubmissions { get; set; }
            public object[] listmemberships { get; set; }
            public IdentityProfiles[] identityprofiles { get; set; }
            public object[] mergeaudits { get; set; }
        }

        public class Properties
        {
            public Hs_Is_Unworked hs_is_unworked { get; set; }
            public Firstname firstname { get; set; }
            public Num_Unique_Conversion_Events num_unique_conversion_events { get; set; }
            public Hs_Pipeline hs_pipeline { get; set; }
            public Hs_Analytics_Revenue hs_analytics_revenue { get; set; }
            public Hs_Social_Num_Broadcast_Clicks hs_social_num_broadcast_clicks { get; set; }
            public Createdate createdate { get; set; }
            public Hs_Lifecyclestage_Opportunity_Date hs_lifecyclestage_opportunity_date { get; set; }
            public Hs_Analytics_Num_Visits hs_analytics_num_visits { get; set; }
            public Hs_Social_Linkedin_Clicks hs_social_linkedin_clicks { get; set; }
            public Hs_Analytics_Source hs_analytics_source { get; set; }
            public First_Deal_Created_Date first_deal_created_date { get; set; }
            public Hs_Searchable_Calculated_Phone_Number hs_searchable_calculated_phone_number { get; set; }
            public Num_Associated_Deals num_associated_deals { get; set; }
            public Hs_Email_Domain hs_email_domain { get; set; }
            public Hs_Analytics_Num_Page_Views hs_analytics_num_page_views { get; set; }
            public Company company { get; set; }
            public Hs_Time_Between_Contact_Creation_And_Deal_Creation hs_time_between_contact_creation_and_deal_creation { get; set; }
            public Email email { get; set; }
            public Lastmodifieddate lastmodifieddate { get; set; }
            public Hs_Analytics_First_Timestamp hs_analytics_first_timestamp { get; set; }
            public Hs_Social_Google_Plus_Clicks hs_social_google_plus_clicks { get; set; }
            public Hs_Lifecyclestage_Subscriber_Date hs_lifecyclestage_subscriber_date { get; set; }
            public Hs_Analytics_Average_Page_Views hs_analytics_average_page_views { get; set; }
            public Hs_All_Contact_Vids hs_all_contact_vids { get; set; }
            public Lastname lastname { get; set; }
            public Hs_Social_Facebook_Clicks hs_social_facebook_clicks { get; set; }
            public Hs_Is_Contact hs_is_contact { get; set; }
            public Phone phone { get; set; }
            public Num_Conversion_Events num_conversion_events { get; set; }
            public Hs_Object_Id hs_object_id { get; set; }
            public Hs_Analytics_Num_Event_Completions hs_analytics_num_event_completions { get; set; }
            public Hs_Social_Twitter_Clicks hs_social_twitter_clicks { get; set; }
            public Hs_Analytics_Source_Data_1 hs_analytics_source_data_1 { get; set; }
            public Lifecyclestage lifecyclestage { get; set; }
            public Total_Revenue total_revenue { get; set; }
        }

        public class Hs_Is_Unworked
        {
            public string value { get; set; }
            public Version[] versions { get; set; }
        }

        public class Version
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Firstname
        {
            public string value { get; set; }
            public Version1[] versions { get; set; }
        }

        public class Version1
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Num_Unique_Conversion_Events
        {
            public string value { get; set; }
            public Version2[] versions { get; set; }
        }

        public class Version2
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Pipeline
        {
            public string value { get; set; }
            public Version3[] versions { get; set; }
        }

        public class Version3
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Analytics_Revenue
        {
            public string value { get; set; }
            public Version4[] versions { get; set; }
        }

        public class Version4
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Social_Num_Broadcast_Clicks
        {
            public string value { get; set; }
            public Version5[] versions { get; set; }
        }

        public class Version5
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Createdate
        {
            public string value { get; set; }
            public Version6[] versions { get; set; }
        }

        public class Version6
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Lifecyclestage_Opportunity_Date
        {
            public string value { get; set; }
            public Version7[] versions { get; set; }
        }

        public class Version7
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Analytics_Num_Visits
        {
            public string value { get; set; }
            public Version8[] versions { get; set; }
        }

        public class Version8
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Social_Linkedin_Clicks
        {
            public string value { get; set; }
            public Version9[] versions { get; set; }
        }

        public class Version9
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Analytics_Source
        {
            public string value { get; set; }
            public Version10[] versions { get; set; }
        }

        public class Version10
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class First_Deal_Created_Date
        {
            public string value { get; set; }
            public Version11[] versions { get; set; }
        }

        public class Version11
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Searchable_Calculated_Phone_Number
        {
            public string value { get; set; }
            public Version12[] versions { get; set; }
        }

        public class Version12
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Num_Associated_Deals
        {
            public string value { get; set; }
            public Version13[] versions { get; set; }
        }

        public class Version13
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Email_Domain
        {
            public string value { get; set; }
            public Version14[] versions { get; set; }
        }

        public class Version14
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Analytics_Num_Page_Views
        {
            public string value { get; set; }
            public Version15[] versions { get; set; }
        }

        public class Version15
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Company
        {
            public string value { get; set; }
            public Version16[] versions { get; set; }
        }

        public class Version16
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Time_Between_Contact_Creation_And_Deal_Creation
        {
            public string value { get; set; }
            public Version17[] versions { get; set; }
        }

        public class Version17
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Email
        {
            public string value { get; set; }
            public Version18[] versions { get; set; }
        }

        public class Version18
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Lastmodifieddate
        {
            public string value { get; set; }
            public Version19[] versions { get; set; }
        }

        public class Version19
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Analytics_First_Timestamp
        {
            public string value { get; set; }
            public Version20[] versions { get; set; }
        }

        public class Version20
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Social_Google_Plus_Clicks
        {
            public string value { get; set; }
            public Version21[] versions { get; set; }
        }

        public class Version21
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Lifecyclestage_Subscriber_Date
        {
            public string value { get; set; }
            public Version22[] versions { get; set; }
        }

        public class Version22
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Analytics_Average_Page_Views
        {
            public string value { get; set; }
            public Version23[] versions { get; set; }
        }

        public class Version23
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_All_Contact_Vids
        {
            public string value { get; set; }
            public Version24[] versions { get; set; }
        }

        public class Version24
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Lastname
        {
            public string value { get; set; }
            public Version25[] versions { get; set; }
        }

        public class Version25
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Social_Facebook_Clicks
        {
            public string value { get; set; }
            public Version26[] versions { get; set; }
        }

        public class Version26
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Is_Contact
        {
            public string value { get; set; }
            public Version27[] versions { get; set; }
        }

        public class Version27
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Phone
        {
            public string value { get; set; }
            public Version28[] versions { get; set; }
        }

        public class Version28
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Num_Conversion_Events
        {
            public string value { get; set; }
            public Version29[] versions { get; set; }
        }

        public class Version29
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Object_Id
        {
            public string value { get; set; }
            public Version30[] versions { get; set; }
        }

        public class Version30
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Analytics_Num_Event_Completions
        {
            public string value { get; set; }
            public Version31[] versions { get; set; }
        }

        public class Version31
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Social_Twitter_Clicks
        {
            public string value { get; set; }
            public Version32[] versions { get; set; }
        }

        public class Version32
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Hs_Analytics_Source_Data_1
        {
            public string value { get; set; }
            public Version33[] versions { get; set; }
        }

        public class Version33
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class Lifecyclestage
        {
            public string value { get; set; }
            public Version34[] versions { get; set; }
        }

        public class Version34
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public object sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        public class IdentityProfiles
        {
            public int vid { get; set; }
            public long savedattimestamp { get; set; }
            public int deletedchangedtimestamp { get; set; }
            public Identity[] identities { get; set; }
        }

        public class Identity
        {
            public string type { get; set; }
            public string value { get; set; }
            public long timestamp { get; set; }
            public bool isprimary { get; set; }
        }

        public class Total_Revenue
        {
            public string value { get; set; }
            public Version35[] versions { get; set; }
        }

        public class Version35
        {
            public string value { get; set; }
            public string sourcetype { get; set; }
            public string sourceid { get; set; }
            public object sourcelabel { get; set; }
            public object updatedbyuserid { get; set; }
            public long timestamp { get; set; }
            public bool selected { get; set; }
        }

        #endregion CustomerData
    }
}
