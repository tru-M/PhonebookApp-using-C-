using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebookapp1
{
    public class InvalidEmailException:Exception
    {
        public InvalidEmailException(string s) : base(s)
        {
        }
    }
}
