using System.Net.Mail;


namespace Мыло
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Mylo());
        }
    }
    public class _email
    {
        public bool verified = false;
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string text_message { get; set; }
        public string text_subjest { get; set; }
        public string domein = null;
        SmtpClient smtpClient = new SmtpClient("smtp.rambler.ru");

        public _email()
        {

        }

        public void Send()
        {
            try
            {
                smtpClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential Authentificator = new System.Net.NetworkCredential(Username, Password);
                smtpClient.Credentials = Authentificator;
                MailAddress from = new MailAddress(Username, Username);
                MailAddress to = new MailAddress(Email, Email);
                MailMessage message = new MailMessage(from, to);

                message.Subject = text_subjest;
                message.Body = text_message;

                smtpClient.Send(message);

                MessageBox.Show("Сообщение отправлено");
            }
            catch
            {
                MessageBox.Show("Ошибка отправления");
            }

        }
    }

}