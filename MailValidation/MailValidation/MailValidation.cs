using System;
using System.Collections.Generic;
using System.Text;

namespace MailValidation
{
    class MailValidation
    {
        public string mail;
        public string password;

        public MailValidation(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
        }
        public void CheckAcc()
        {
            if (this.mail == "cavid@code.edu.az" && this.password == "12345")
            {
                Console.WriteLine("Giris olundu");

            }
            else
            {
                Console.WriteLine("Mail ve yaxud password sehvdir");
            }
        }
    }    
}    
