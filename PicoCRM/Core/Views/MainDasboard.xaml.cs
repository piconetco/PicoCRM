﻿using System;
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
using PicoCRM.Modules.Contact;
namespace PicoCRM.Core.view
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void MainDashboard1_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            long contactid = contact.GetContactID("1400817");
            var contactde = contact.GetCustomerDetails(contactid);

            lblTotal.Content = contactde.properties.total_revenue.value.ToString();
        }
    }
}
