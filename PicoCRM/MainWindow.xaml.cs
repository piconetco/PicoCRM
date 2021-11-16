


namespace PicoCRM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzUzMkAzMTM5MmUzMzJlMzBGM3NvdU9HbWduN2c2S3NDSmlaTU9kQ0E5R1BlejhLUG1PQkd4TnE1cm5rPQ==");

            SfSkinManager.SetTheme(this, new Theme("MaterialDark"));
           

        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {


        }

        private void navigationDrawer_ItemClicked(object sender, Syncfusion.UI.Xaml.NavigationDrawer.NavigationItemClickedEventArgs e)
        {

            Page1 page = new Page1();

            Oder Order = new Oder();
            ContactList contactlist = new ContactList();
            if (e.Item == TabDashboard)
            {
                navigationDrawer.ContentView = Order.Su;
            }
            if (e.Item == TabContacts )
            {
               
            }
           
        }
    }
}
