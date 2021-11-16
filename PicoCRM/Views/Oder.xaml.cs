

using System.Windows.Controls.Primitives;

namespace PicoCRM.Core.Views
{
    /// <summary>
    /// Interaction logic for Oder.xaml
    /// </summary>



    public partial class Oder : Page
    {
        public static  string? ContactId { get; set; }
        public Oder()
        {
            InitializeComponent();
        }
        
        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            string DateBuilder = (DateTime.Today.Year + DateTime.Today.Month + DateTime.Today.Day).ToString();


            lblStatus.Content = "در حال ایجاد مخاطب...";
            ContactManager.ActionCreateContact contactManager = new ContactManager.ActionCreateContact(cFName.Text,cLName.Text,cPhone.Text);


            ContactId = contactManager.GetContactInfo();
         
            lblStatus.Content = $"مخاطب با موفقیت  با شناسه{ContactId}ایجاد  شد";

            DealManager.ActionCreateDeal DealManager = new DealManager.ActionCreateDeal(cTitle.Text, cPrice.Text);

            lblStatus.Content =  $"سفارش با موفقیت  با شناسه{DealManager.GetResult()}ایجاد  شد";

            ContactManager.ActionAssociateContactToDeal DealerAssign = new ContactManager.ActionAssociateContactToDeal(ContactId, DealManager.GetResult());

            ContactManager.ActionCreateContact CheckCurrentDate = new ContactManager.ActionCreateContact("Day:", DateBuilder, DateBuilder + "@picocrm.com");

         
            string toadyid =  CheckCurrentDate.GetContactInfo();

            ContactManager.ActionAssociateContactToDeal AddBalance = new ContactManager.ActionAssociateContactToDeal(toadyid, DealManager.GetResult());
          
            ContactManager.ActionGetContact CustomerScore = new ContactManager.ActionGetContact(int.Parse(ContactId));

           
            var CustomerBalance = CustomerScore.GetData();

          
            string? CustomerScore1=  CustomerBalance?.properties?.total_revenue;

            MessageBox.Show(CustomerScore1);
            ContactManager.ActionGetContact DailyBalance = new ContactManager.ActionGetContact(int.Parse(toadyid));

          
            var  DailySandogh = DailyBalance.GetData();
            string? ValueOfSandigh = DailySandogh?.properties?.total_revenue;


            MessageBox.Show(ValueOfSandigh);
            Modules.SMSProvider.Handler.Send handler = new Modules.SMSProvider.Handler.Send();

            handler.SendTranaction(cPhone.Text, cPrice.Text, ((int.Parse(CustomerScore1)) * 15 / 100).ToString(), cFName.Text, cLName.Text  , DealManager.GetResult());
            handler.SendReportToAdmin("09150089472", cPrice.Text, cTitle.Text, ValueOfSandigh, DealManager.GetResult());
            handler.SendReportToAdmin("09109740017", cPrice.Text, cTitle.Text, ValueOfSandigh, DealManager.GetResult());

            lblStatus.Content = "عملیات با موفقیت انجام شد";

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
