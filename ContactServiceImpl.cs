using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebookapp1
{
    public class ContactServiceImpl:ContactService,IContactService
    {
        //dummy vars to keep the track of arrays for memory
        int cntS = 0;
        int cntP = 0;
        
        //to insert new contact
        public void insertContact(Contacts contact, string memory)
        {

            
            if (memory.ToUpper() == "SIM")
            {
                for(int i=cntS;i< SIM.Length;i++)
                {
                    if (SIM[i].getcontactname()== "abc" && SIM[i].getnumber()== 1111111111 && SIM[i].getid()== "abc@gmail.com")
                    {
                        SIM[i].setcontactname(contact.getcontactname());
                        SIM[i].setnumber(contact.getnumber());
                        SIM[i].setid(contact.getid());
                        cntS = i;
                        break;
                    
                    }

                }
            }
            else if (memory.ToUpper() == "PHONE")
            {
                for (int j = cntP; j < Phone.Length; j++)
                {
                    if (Phone[j].getcontactname()== "abc" && Phone[j].getnumber()== 1111111111 && Phone[j].getid()== "abc@gmail.com")
                    {
                        Phone[j].setcontactname(contact.getcontactname());
                        Phone[j].setnumber(contact.getnumber());
                        Phone[j].setid(contact.getid());
                        cntP = j;
                        break;
                    }
                }
            }
            else
                Console.WriteLine("Invalid memory type cannot store the contact");
        }
        //to update contact 
        public void updateContact(Contacts contact, string memory) {
            if (memory.ToUpper() == "SIM")
            {
                for (int s = 0; s < SIM.GetUpperBound(0); s++)
                {
                    if (SIM[s].getcontactname() == contact.getcontactname() ||
                    SIM[s].getnumber() == contact.getnumber() ||
                    SIM[s].getid() == contact.getid())
                    {
                        SIM[s].setcontactname(contact.getcontactname());
                        SIM[s].setnumber(contact.getnumber());
                        SIM[s].setid(contact.getid());
                        Console.WriteLine("Contact succesfully updated");
                        
                    }

                    else if(s==SIM.Length)
                    {
                        Console.WriteLine("No such contact available hence cannot update");
                        break;
                    }
                }
                

            }

            else if (memory.ToUpper() == "PHONE")
            {
                for (int s = 0; s < Phone.GetUpperBound(0); s++)
                {

                   if (Phone[s].getcontactname() == contact.getcontactname() ||
                        Phone[s].getnumber() == contact.getnumber() ||
                        Phone[s].getid() == contact.getid())
                        {
                            Phone[s].setcontactname(contact.getcontactname());
                            Phone[s].setnumber(contact.getnumber());
                            Phone[s].setid(contact.getid());
                            Console.WriteLine("Contact succesfully updated");
                         
                        }
                    
                    else if (s == SIM.Length)
                    {
                        Console.WriteLine("No such contact available hence cannot update");
                        

                    }

                }

            }
            else
                Console.WriteLine("Invalid memory type cannot update the contact");
        }
        //to search contact using name
        public void searchContact(string name, string memory)
        {
            if (memory.ToUpper() == "SIM")
            {
                for (int s = 0; s < SIM.Length; s++)
                {
                    if (SIM[s].getcontactname() == name)
                    {
                        Console.WriteLine(SIM[s].ToString());
                        break;
                    }
                    else if (SIM[s].getcontactname() != name && s == SIM.Length - 1)
                        Console.WriteLine("No such contact available.");
                }

            }
            else if (memory.ToUpper() == "PHONE")
            {
                for (int s = 0; s < Phone.Length; s++)
                {
                    if (Phone[s].getcontactname() == name)
                    {
                        Console.WriteLine(Phone[s].ToString());
                        break;
                    }
                    else if(Phone[s].getcontactname()!= name && s== Phone.Length-1)
                        Console.WriteLine("No such contact available.");
                }
                
                    
            }
            else
                Console.WriteLine("Invalid memory type cannot search the contact");
            
        }
        //to search  contact using numer
        public void searchContact(long mobileNumber, string memory)
        {
            if (mobileNumber.ToString().Length!= 10)
                throw new InvalidMobileNumberException("Invalid length for phone number");
            else if (memory.ToUpper() == "SIM")
            {
                for (int s = 0; s < SIM.Length; s++)
                {
                    if (SIM[s].getnumber().Equals(mobileNumber))
                    {
                        Console.WriteLine(SIM[s].ToString());
                        break;
                    }
                    else if (!SIM[s].getnumber().Equals(mobileNumber) && s == SIM.Length - 1)
                        Console.WriteLine("No matched contact found");
                }

            }
            else if (memory.ToUpper() == "PHONE")
            {
                for (int s = 0; s < Phone.Length; s++)
                {
                    if (Phone[s].getnumber().Equals(mobileNumber))
                    {
                        Console.WriteLine(Phone[s].ToString());
                        break;
                    }
                    else if (!Phone[s].getnumber().Equals(mobileNumber) && s == Phone.Length - 1)
                        Console.WriteLine("No matched contact found");
                }
            }
            else
                Console.WriteLine("Invalid memory type cannot search the contact");
            
        }

        
    }
}
