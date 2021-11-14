using System.Data;

namespace PicoCRM.Core.Views
{
    /// <summary>
    /// Interaction logic for ContactList.xaml
    /// </summary>
    public partial class ContactList : Page
    {
        public ContactList()
        {

            InitializeComponent();
           Contact contacs = new Contact();



            DataTable dt = new DataTable("CustomerData");


            #region DataTableColumnDef
            DataColumn dtCustomerID;
            DataColumn dtCustomerFName;
            DataColumn dtCustomerLName;
            DataColumn dtCustomerPhone;
            DataColumn dtCustomerRevenue;
            #endregion
            DataRow dtCustomerIDRow;
            /*Loads Customer ID */
            dtCustomerID = new DataColumn();
            dtCustomerID.DataType = typeof(Int32);
            dtCustomerID.ColumnName = "شناسه مشتری";
          
            dtCustomerID.ReadOnly = false;

            /*Loaads Custmer FirstName*/ 
            dtCustomerFName = new DataColumn();
            dtCustomerFName.DataType = typeof(string);
            dtCustomerFName.ColumnName = "نام";

            dtCustomerFName.ReadOnly = false;

            /* loads LastName into Table */
            dtCustomerLName = new DataColumn();
            dtCustomerLName.DataType = typeof(string);
            dtCustomerLName.ColumnName = "نام خانوادگی";

            dtCustomerFName.ReadOnly = false;

            /* loads phone into Table */
            dtCustomerPhone = new DataColumn();
            dtCustomerPhone.DataType = typeof(string);
            dtCustomerPhone.ColumnName = "تلفن همراه";

            dtCustomerFName.ReadOnly = false;
           
            /* loads Total Revenue into Table */
            dtCustomerRevenue= new DataColumn();
            dtCustomerRevenue.DataType = typeof(string);
            dtCustomerRevenue.ColumnName = "مجموع خرید";

            dtCustomerFName.ReadOnly = false;

            // Add column to the DataColumnCollection.
            dt.Columns.Add(dtCustomerID);
            dt.Columns.Add(dtCustomerFName);
            dt.Columns.Add(dtCustomerLName);
            dt.Columns.Add(dtCustomerPhone);
            dt.Columns.Add(dtCustomerRevenue);
            // Create a new DataSet
            DataSet dtSet = new DataSet();

            // Add custTable to the DataSet.
            dtSet.Tables.Add(dt);


            foreach (var t in contacs.GetContactList().results)
            {

                dtCustomerIDRow = dt.NewRow();
                
                dtCustomerIDRow["شناسه مشتری"] = t.properties.hs_object_id;
                dtCustomerIDRow["نام"] = t.properties.firstname;
                dtCustomerIDRow["نام خانوادگی"] = t.properties.lastname;
                dtCustomerIDRow["تلفن همراه"] = t.properties.phone;
                dtCustomerIDRow["مجموع خرید"] = t.properties.total_revenue;

                dt.Rows.Add(dtCustomerIDRow);


                dg_ContactList.ItemsSource = dt;

            }
        }
    }
}
