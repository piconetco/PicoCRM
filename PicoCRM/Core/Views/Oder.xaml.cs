

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
        
        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {

            ContactManager.ActionCreateContact contactManager = new ContactManager.ActionCreateContact(cFName.Text,cLName.Text,cPhone.Text);
           
            MessageBox.Show(contactManager.GetContactInfo());

            DealManager.ActionCreateDeal DealManager = new DealManager.ActionCreateDeal(cTitle.Text, cPrice.Text);

            MessageBox.Show( DealManager.GetResult());
            
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
