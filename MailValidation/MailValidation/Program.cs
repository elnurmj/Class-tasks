using System;

namespace MailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            MailValidation mail = new MailValidation("cavid@code.edu.az", "12345");
            mail.CheckAcc();
        }
    }
}
