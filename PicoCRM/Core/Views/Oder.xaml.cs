﻿

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

            Modules.Contact.ContactManager.ActionGetContact contactManager = new Modules.Contact.ContactManager.ActionGetContact(42002);

           
         
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
