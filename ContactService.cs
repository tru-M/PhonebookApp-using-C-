using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebookapp1
{
    public class ContactService : Contacts
    {
        public Contacts[] SIM = new Contacts[10];
        public Contacts[] Phone = new Contacts[10];
        //method to initialize array of memories to avoid nullreference exception at runtime.
        public void intializer()
        {
            for (int i = 0; i < SIM.Length; i++)
            {
                SIM[i] = new Contacts();
            }
            for (int i = 0; i < Phone.Length; i++)
            {
                Phone[i] = new Contacts();
            }
        }
        //method to copy single contact to memory (sim/phone)
        public void Copy(Contacts contact, string memory)
        {
            if (memory.ToUpper() == "SIM")
            {
                for (int i = 0; i <= SIM.Length; i++)
                {
                    if(SIM[i].getcontactname()== "abc" && SIM[i].getnumber() == 1111111111 && SIM[i].getid() == "abc@gmail.com")
                    {
                        SIM[i].setcontactname(contact.getcontactname());
                        SIM[i].setnumber(contact.getnumber());
                        SIM[i].setid(contact.getid());
                        break;

                    }
                }

            }
            else if (memory.ToUpper() == "PHONE")
            {
                for (int i = 0; i <= Phone.Length; i++)
                {
                    if (Phone[i].getcontactname() == "abc" && Phone[i].getnumber() == 1111111111 && Phone[i].getid() == "abc@gmail.com")
                    {
                        Phone[i].setcontactname(contact.getcontactname());
                        Phone[i].setnumber(contact.getnumber());
                        Phone[i].setid(contact.getid());
                        break;
                    }
                }
            }
            else
                Console.WriteLine("Invalid memory type cannot update the contact");
        }
        //method to copy all contacts from memory (sim/phone) to memory (sim/phone)
        public void CopyAll(string memory1,string memory2)
        {
            if (memory1.ToUpper() == "PHONE" && memory2.ToUpper() == "SIM")
            {
                Array.Clear(SIM, 0, SIM.Length);
                Array.Copy(Phone, SIM, SIM.Length);
                Console.WriteLine("All contacts successfully copied from phone to sim.");
            }
            else if (memory1.ToUpper() == "SIM" && memory2.ToUpper() == "PHONE")
            {
                Array.Clear(Phone, 0, Phone.Length);
                Array.Copy(SIM, Phone, Phone.Length);
                Console.WriteLine("All contacts successfully copied from sim to phone.");
            }
            else
                Console.WriteLine("No such memory available for copy operation");
        }
        //method to diplay all contacts currently present in contact
        public void Display()
        {
            Array.Sort(SIM, delegate (Contacts c1, Contacts c2)
            {
                return c1.getcontactname().CompareTo(c2.getcontactname());
            });
            Array.Sort(Phone, delegate (Contacts c1, Contacts c2)
            {
                return c1.getcontactname().CompareTo(c2.getcontactname());
            });

            Console.WriteLine("Contact list from SIM memory: ");
            Console.WriteLine();

            for (int s = 0; s < SIM.Length; s++)
            {
                if (SIM[s].getcontactname() != "abc" && SIM[s].getnumber() != 1111111111 && SIM[s].getid() != "abc@gmail.com")
                    Console.WriteLine(SIM[s]);
            }
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("Contact list from Phone memory: ");
            Console.WriteLine();
            for (int s = 0; s < Phone.Length; s++)
            {
                if (Phone[s].getcontactname() != "abc" && Phone[s].getnumber() != 1111111111 && Phone[s].getid() != "abc@gmail.com")
                    Console.WriteLine(Phone[s]);
            }
        }

    }
}
