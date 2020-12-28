using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phonebookapp1
{
    public class Contacts
    {

        private string Name;
        private long Mobilenumber;
        private string emailid;

        public Contacts()
        {
            this.Name = "abc";
            this.Mobilenumber = 1111111111;
            this.emailid = "abc@gmail.com";
        }

        public Contacts(string Name,long Mobilenumber,string emailid)
        {
            this.Name = Name;
            this.Mobilenumber = Mobilenumber;
            this.emailid = emailid;
        }

        public string getcontactname()
        {
            return Name;
        }

        public void setcontactname(string name)
        {
            this.Name = name;
        }

        public long getnumber()
        {
            return Mobilenumber;
        }

        public void setnumber(long number)
        {
            //throwing exception using user defined exception method
            if (number.ToString().Length == 10)
                this.Mobilenumber = number;
            else
                throw new InvalidMobileNumberException("Invalid length for phone number");
        }

        public string getid()
        {
            return emailid;
        }

        public void setid(string id)
        {
            
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new InvalidEmailException("Emailid is in invalid format.");
            }//using Regularexpreassion for checking valid format of email that user inputs 
            else if (Regex.IsMatch(id, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                this.emailid = id;
            }
            else
                throw new InvalidEmailException("Emailid is in invalid format.");//throwing exception using user defined exception method
        }

        public override string ToString()
        {
            return "contact Details: " + this.Name + " " + this.Mobilenumber + " " + this.emailid;
        }
        
    }

}

