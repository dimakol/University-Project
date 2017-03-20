using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace University
{
    class Email
    {
        Database db = Database.Instance();

        private static Email em; //singleton

        private String Body;
        private String Subject;

        private Email() { }
        public static Email Instance()   //creates a new db if none exist, or returns the current existing one
        {
            if (em == null)
            {
                em = new Email();
            }
            return em;
        }

        public void PasswordRec(String id)
        {
            List<String> itemList = db.FetchList(db.TPERSON, "*", "id = " + id);
            Subject = "University: Password Recovery";
            Body = "Hello " + ((Gender)(Convert.ToInt32(itemList[7]))).ToString() + " " + itemList[3] + " " + itemList[4] + ", your password is: " + itemList[1];
            List<String> Adrs = new List<String>();
            Adrs.Add(itemList[5]);

            SendMail(Adrs, Body, Subject);
            MessageBox.Show("Password Sent!", "Message");
        }

        public void AnnounceGrade(List<String> Addresses, String CName, String Grade)
        {
            Subject = "University: New Grade";
            Body = "You have recieved a new grade: " + CName + " - " + Grade;

            SendMail(Addresses, Body, Subject);
            MessageBox.Show("New Grades Sent!", "Message");
        }

        public void AnnounceCancel(List<String> Addresses, String CName, String Lect)
        {
            Subject = "University: Notice about cancelation";
            Body = "Your next lecture\\practice at " + CName + " with " + Lect + " has been canceled!";

            SendMail(Addresses, Body, Subject);
            MessageBox.Show("Cancelation Message Sent!", "Message");
        }


        private void SendMail(List<String> AddressList, String Body, String Subject)
        {
            try
            {
                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                foreach (String value in AddressList)
                {
                    email.To.Add(value);
                }

                email.From = new MailAddress("univer315@gmail.com");
                email.Subject = Subject;
                email.Body = Body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("univer315", "uniteam4");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
