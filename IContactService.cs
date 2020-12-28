using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebookapp1
{
    interface IContactService
    {
       //method declaration for various sevices
        void insertContact(Contacts contact, string memory);
        void updateContact(Contacts contact, string memory);
        void searchContact(string name, string memory);
        void searchContact(long mobileNumber, string memory);
    }
}
