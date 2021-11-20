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
        public static string? TodayDate { get; set; }
        public QuickCreateDeal()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
         
            
            try
            {

                #region
             
                TodayDate = (DateTime.Today.Year + DateTime.Today.Month + DateTime.Today.Day).ToString();

                ContactManager.ActionCreateContact contactManager = new ContactManager.ActionCreateContact(cFName.Text, cLName.Text, cPhone.Text);

                ContactId = contactManager.GetContactInfo();

                lblStatus.Content = $"COntact Created With ID:{ContactId}";

                DealManager.ActionCreateDeal DealManager = new DealManager.ActionCreateDeal(cTitle.Text, cPrice.Text);

                DealId = DealManager.GetResult();
                lblStatus.Content = $"Deal  Created With ID:{DealId}";
                ContactManager.ActionAssociateContactToDeal DealerAssign = new ContactManager.ActionAssociateContactToDeal(ContactId, DealId);

                Modules.SMSProvider.Handler.Send handler = new Modules.SMSProvider.Handler.Send();

               
                #endregion
               
                
                ContactManager.ActionCreateContact DayManager = new ContactManager.ActionCreateContact(cFName.Text, cLName.Text, cPhone.Text);
                TodayId = DayManager.GetContactInfo();
                MessageBox.Show(TodayId);
                ContactManager.ActionAssociateContactToDeal AssignDayToContact = new ContactManager.ActionAssociateContactToDeal(TodayId, DealId);
                var result = AssignDayToContact.GetResult();
           
                lblStatus.Content = "عملیات با موفقیت انجام شد";

  
                handler.SendTranaction(cPhone.Text, cPrice.Text, "".ToString(), cFName.Text, cLName.Text, DealManager.GetResult());

                handler.SendReportToAdmin("09150089472", cPrice.Text, cTitle.Text, "", DealId);
                handler.SendReportToAdmin("09109740017", cPrice.Text, cTitle.Text, "", DealId);
            }


         

          

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

       
    }
}
