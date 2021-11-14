

using System.Windows.Controls.Primitives;

namespace PicoCRM.Core.Views
{
    /// <summary>
    /// Interaction logic for Oder.xaml
    /// </summary>



    public partial class Oder : Page
    {
        public Oder()
        {
            InitializeComponent();
        }
        public string dealid { get; set; }
        public long contactid { get; set; }
        public long  checkid {get;set;}
        Contact DailyForecast { get;set; }
        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
           
    
            #region AutoCreateAndAssignDealToContact
            
            Contact ContactManager = new Contact();
           
            Contact DailyCheckout = new Contact();
           
            Handler.Send SmsProvider = new Handler.Send();
          
            Deal DealManager = new Deal();
   
            Create Assoc = new Create();
  
            DateTime thisDate = DateTime.Now;

            PersianCalendar pc = new PersianCalendar();

            try
            {
                string PersianDateConverter = pc.GetYear(thisDate).ToString() + pc.GetMonth(thisDate).ToString() + pc.GetDayOfMonth(thisDate).ToString();
            

                string current = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            



                 contactid = ContactManager.Create(cFName.Text, cLName.Text, cPhone.Text, cPhone.Text + "@gmail.com");
      


                long checkid = DailyCheckout.Create("Day:", PersianDateConverter, PersianDateConverter, PersianDateConverter + "@gmail.com");
          


                dealid = DealManager.CreateDeal(cTitle.Text, cPrice.Text, cAbout.Text, "closedwon");
            



                Assoc.AssiciateContactToDeal(checkid, long.Parse(dealid));
              


                Assoc.AssiciateContactToDeal(contactid, long.Parse(dealid));
            



                var ContactInfo = ContactManager.GetCustomerDetails(contactid);
                MessageBox.Show("8");
               

                string TotalRevenue = ContactInfo.properties.total_revenue.value;




                MessageBox.Show("9");
                var DailyForcast = DailyCheckout.GetCustomerDetails(checkid).properties.total_revenue.value;
                

        

                string Report = SmsProvider.SendReportToAdmin("09109740017", cPrice.Text, cTitle.Text, DailyForcast, dealid);


                string Report1 = SmsProvider.SendReportToAdmin("09150089472", cPrice.Text, cTitle.Text, DailyForcast, dealid);


                string red = SmsProvider.SendTranaction(cPhone.Text, cPrice.Text, (int.Parse(TotalRevenue) / 100 * 15).ToString(), cFName.Text, cLName.Text, dealid);
             
                MessageBox.Show("ثبت اطلاعات با موفقی انجام شد");


            }
            catch (Exception ex)
            {
               try
                {
                    MessageBox.Show(ex.Data.ToString());
                    DealManager.DeleteDeal(dealid);
                    
                    dealid = DealManager.CreateDeal(cTitle.Text, cPrice.Text, cAbout.Text, "closedwon");

                    Assoc.AssiciateContactToDeal(checkid, long.Parse(dealid));


                    Assoc.AssiciateContactToDeal(contactid, long.Parse(dealid));

                    var ContactInfo = ContactManager.GetCustomerDetails(contactid);
                    MessageBox.Show("18");


                    string TotalRevenue = ContactInfo.properties.total_revenue.value;
                    MessageBox.Show(TotalRevenue);

                    var DailyForcast = DailyCheckout.GetCustomerDetails(checkid).properties.total_revenue.value;

                    string Report = SmsProvider.SendReportToAdmin("09109740017", cPrice.Text, cTitle.Text, DailyForcast, dealid);

                    string Report1 = SmsProvider.SendReportToAdmin("09150089472", cPrice.Text, cTitle.Text, DailyForcast, dealid);

                    string red = SmsProvider.SendTranaction(cPhone.Text, cPrice.Text, (int.Parse(TotalRevenue) / 100 * 15).ToString(), cFName.Text, cLName.Text, dealid);

                    MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد");
                }
              
                catch( Exception exx )
                
                {
                    MessageBox.Show(exx.Message);
                   
                }
            }


            #endregion
        }

        private void Progress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
        }

        private void cPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cPrice_LostFocus(object sender, RoutedEventArgs e)
        {
            if(cPrice.Text == null)
            {
                cPrice.Text = "مبلغ";
            }
        }

        private void cPrice_GotFocus(object sender, RoutedEventArgs e)
        {
            cPrice.Text = "";
        }

     

        private void cTitle_LostFocus(object sender, RoutedEventArgs e)
        {
            if (cPrice.Text == null)
            {
                cPrice.Text = "مبلغ";
            }
        }

        private void cTitle_GotFocus(object sender, RoutedEventArgs e)
        {
            cTitle.Text = "";
        }
    }
}
