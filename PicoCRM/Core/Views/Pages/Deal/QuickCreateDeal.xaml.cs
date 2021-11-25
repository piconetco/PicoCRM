using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PicoCRM.Core.Views.Pages.Deal
{
    /// <summary>
    /// Interaction logic for QuickCreateDeal.xaml
    /// </summary>
    public partial class QuickCreateDeal : Page
    {
        public static string?  ContactId { get; set; }
        public static string?  DealId { get; set; }
        public static string? TodayId { get; set; }
        public static string? TodayDate = DateTime.UtcNow.Date.Year.ToString() + DateTime.UtcNow.Month + DateTime.UtcNow.Day;
        public QuickCreateDeal()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
         
            
            try
            {
                ContactManager.ActionCreateContact DayManager = new ContactManager.ActionCreateContact("Day:", TodayDate, TodayDate);
                
                TodayId = DayManager.GetContactID();

                
                ContactManager.ActionCreateContact contactManager = new ContactManager.ActionCreateContact(cFName.Text, cLName.Text, cPhone.Text);
                ContactId = contactManager.GetContactID();

                DealManager.ActionCreateDeal DealManager = new DealManager.ActionCreateDeal(cTitle.Text, cPrice.Text ,cAbout.Text);
                DealId = DealManager.GetResult();
              
                ContactManager.ActionAssociateContactToDeal DealerAssign = new ContactManager.ActionAssociateContactToDeal(TodayId, DealId);

                ContactManager.ActionAssociateContactToDeal ContactAssign = new ContactManager.ActionAssociateContactToDeal(ContactId, DealId);

                Modules.SMSProvider.Handler.Send handler = new Modules.SMSProvider.Handler.Send();

                ContactManager.ActionGetContact ReportData = new ContactManager.ActionGetContact(int.Parse(TodayId));
               
                ContactManager.ActionGetContact ContactData = new ContactManager.ActionGetContact(int.Parse(ContactId));
              
                string CustomerRevenue =   ContactData.GetData().properties.total_revenue;

                string? ReportRevenue = ReportData.GetData().properties.total_revenue;



                handler.SendTranaction(cPhone.Text, cPrice.Text,CustomerRevenue, cFName.Text, cLName.Text, DealManager.GetResult());


                /*  handler.SendReportToAdmin("09150089472", cPrice.Text, cTitle.Text, "", DealId);*/

            
                string result =   handler.SendReportToAdmin("09109740017", cPrice.Text, cTitle.Text,ReportRevenue,cAbout.Text,  DealId);
                MessageBox.Show(result);
                /*
                  #region



                

                  lblStatus.Content = $"COntact Created With ID:{ContactId}";


                  
                  lblStatus.Content = $"Deal  Created With ID:{DealId}";

                


                  #endregion



                  /*lblStatus.Content = "Balance Increased";
                  ContactManager.ActionAssociateContactToDeal AssignDayToContact = new ContactManager.ActionAssociateContactToDeal(TodayId, DealId);
                  lblStatus.Content = AssignDayToContact.GetResult();





                 
                  */
            }






            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void CardViewItem_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
        }
    }
}
