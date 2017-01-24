using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSite.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "martineza79@outlook.com"; //use your own e-mail address with in the double quotation marks
        public string MailFromAddress = "martineza79@outlook.com"; //use your own e-mail address with in the double quotation marks
        public bool UseSsl = true;
        public string Username = "martineza79@outlook.com"; //use your own e-mail address with in the double quotation marks
        public string Password = "ivonne11";//use your own password
        public string ServerName = "smtp.live.com"; //use your own server name i.e. "smtp.gmail.com"
        public int ServerPort = 587; //use your own e-mail server port number (remember, server port number is an int i.e. 587).
    }
}
