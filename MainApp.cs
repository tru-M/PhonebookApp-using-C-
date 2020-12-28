using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebookapp1
{
    class MainApp
    {
        public static void Main(string[] args)
        {
            //creating class object to access methods.
            ContactServiceImpl Cobj = new ContactServiceImpl();
            //referencing interface using variable
            IContactService S;
            //storing class object to interface refernce var
            S = Cobj;
            Cobj.intializer();
            //inserting some data to memoies
            Contacts c1 = new Contacts("THG", 5632417890, "THG@gmail.com");
            Contacts c2 = new Contacts("weq", 5632417890, "weq@gmail.com");
            Contacts c3 = new Contacts("acb", 5632417891, "acb@gmail.com");
            Contacts c4 = new Contacts("ert", 5632417892, "ert@gmail.com");
            Contacts c5 = new Contacts("tyu", 8529631470, "tyu@gmail.com");
            Contacts c6 = new Contacts("uio", 8529631470, "uio@gmail.com");
            Contacts c7 = new Contacts("kji", 9929631470, "kji@gmail.com");
            Contacts c8 = new Contacts("kli", 9829631470, "kli@gmail.com");
            Contacts c9 = new Contacts("kix", 8829631470, "kix@gmail.com");
            Contacts c10 = new Contacts("pok", 6566621433, "pok@gmail.com");
            Contacts c11 = new Contacts("wsx", 9829631476, "wsk@gmail.com");
            Contacts c12 = new Contacts("jhu", 9829631452, "jhu@gmail.com");
            Contacts c13 = new Contacts("mkb", 9829638974, "mkb@gmail.com");
            Contacts c14 = new Contacts("lpo", 9829638972, "lpo@gmail.com");

            Cobj.insertContact(c1, "SIM");
            Cobj.insertContact(c2, "sim");
            Cobj.insertContact(c3, "SIM");
            Cobj.insertContact(c4, "SIM");
            Cobj.insertContact(c9, "SIM");
            Cobj.insertContact(c10, "sim");
            Cobj.insertContact(c11, "SIM");
            Cobj.insertContact(c5, "Phone");
            Cobj.insertContact(c6, "phone");
            Cobj.insertContact(c7, "phone");
            Cobj.insertContact(c8, "phone");
            Cobj.insertContact(c12, "Phone");
            Cobj.insertContact(c13, "Phone");
            Cobj.insertContact(c14, "phone");
            //user operational section starts here
            Console.WriteLine("Select any one option to perform the operation: "+ "\n1.Insert"+ "\n2.Update"+ "\n3.Search" + "\n4.Display"+ "\n5.Copy"+ "\n6.Copy All"+ "\n0.To Exit");
            int value=int.Parse(Console.ReadLine());
          
            switch (value)
            {
                case 1:
                    {
                        Contacts c = new Contacts();
                        Console.WriteLine("Enter details to insert contact:");
                        Console.WriteLine("Contact name: ");
                        c.setcontactname(Console.ReadLine());
                        Console.WriteLine("Contact number: ");
                        try
                        {
                            c.setnumber(long.Parse(Console.ReadLine()));
                        }
                        catch(Exception e)
                        {   Console.WriteLine(e.Message);
                            Console.WriteLine("Contact number: ");
                            c.setnumber(long.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine("Contact emailid: ");
                        try
                        {
                            c.setid(Console.ReadLine());
                        }
                        catch(Exception e)
                        { Console.WriteLine(e.Message); }
                        Console.WriteLine("Contact store into sim or phone: ");
                        string memory=Console.ReadLine();
                        Cobj.insertContact(c, memory);
                        Console.WriteLine("Contact succesfully added in {0} memory",memory);
                    }
                    break;
                case 2:
                    {
                        Contacts c = new Contacts();
                        Console.WriteLine("Enter details to update the contact:");
                        Console.WriteLine("Contact name: ");
                        c.setcontactname(Console.ReadLine());
                        Console.WriteLine("Contact number: ");
                        try
                        {
                            c.setnumber(long.Parse(Console.ReadLine()));
                        }
                        catch (Exception e)
                        { Console.WriteLine(e.Message); }
                        Console.WriteLine("Contact emailid: ");
                        try
                        {
                            c.setid(Console.ReadLine());
                        }
                        catch (Exception e)
                        { Console.WriteLine(e.Message); }
                        Console.WriteLine("Contact has stored in sim or phone memory: ");
                        string memory = Console.ReadLine();
                        Cobj.updateContact(c, memory);
                        
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Select any one option to search the contact:"+"\n1.By contact_name"+"\n2.By contact_number");
                        int value1 = int.Parse(Console.ReadLine());
                        switch (value1)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter contact name: ");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Contact has stored in sim or phone memory: ");
                                    string memory = Console.ReadLine();
                                    Cobj.searchContact(name, memory);
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Enter contact number: ");
                                    long num = long.Parse(Console.ReadLine());
                                    Console.WriteLine("Contact has stored in sim or phone memory: ");
                                    string memory = Console.ReadLine();
                                    Cobj.searchContact(num, memory);
                                }
                                break;
                            default: Console.WriteLine("Incorrect information entered.");
                                break;
                        }
                    }
                    break;
                case 4:
                    {
                        Cobj.Display();
                    }
                    break;
                case 5:
                    {
                        Contacts c = new Contacts();
                        Console.WriteLine("Enter details of contact to copy:");
                        Console.WriteLine("Contact name: ");
                        c.setcontactname(Console.ReadLine());
                        Console.WriteLine("Contact number: ");
                        try
                        {
                            c.setnumber(long.Parse(Console.ReadLine()));
                        }
                        catch (Exception e)
                        { Console.WriteLine(e.Message); }
                        Console.WriteLine("Contact emailid: ");
                        try
                        {
                            c.setid(Console.ReadLine());
                        }
                        catch (Exception e)
                        { Console.WriteLine(e.Message); }
                        Console.WriteLine("Contact copy to sim or phone memory: ");
                        string memory = Console.ReadLine();
                        Cobj.Copy(c, memory);


                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Select any one option to copy the contact:" + "\n1.SIM to Phone" + "\n2.Phone to SIM");
                        int value1 = int.Parse(Console.ReadLine());
                        switch (value1)
                        {
                            case 1:
                                {
                                    Cobj.CopyAll("SIM", "Phone");
                                }
                                break;
                            case 2:
                                {
                                    Cobj.CopyAll("Phone", "SIM");
                                }
                                break;
                        }

                    }
                    break;
                case 0:
                    {
                        Console.WriteLine("HAPPY TO SERVICE.....:-)");
                    }
                    break;
                default: Console.WriteLine("IncorrecT Input Entered.");
                    break;
            }
         }
    }
}
