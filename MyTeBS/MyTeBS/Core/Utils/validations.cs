using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace MyTeBS.Core.Utils
{
    class validations
    {

        public bool isValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}