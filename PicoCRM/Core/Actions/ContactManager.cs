using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoCRM.Core.Actions.Contact
{
   
    public class ContactManager
    {
        public static  string? ContactId = null;
        public static  string? ContactName = null;

        public class ActionCreateContact

        {
            

            public ActionCreateContact(string contactid)
            {
                ContactId = contactid;
                 
                MessageBox.Show(ContactId);
            }
        }
        public class ActionDeleteContact
        {
            public ActionDeleteContact()
            {
                MessageBox.Show(ContactId);
            }
        }

        public class ActionUpdateContact

        {
            public ActionUpdateContact()
            {

            }
        }
    }
    
}
