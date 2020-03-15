using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace JikyungHomePage_JKPDM.Data
{
    public class ExampleModel
    {
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Contents { get; set; }

    }

    public class SendMail
    {
        private const char v = '1';
        public char GetMailDataAsync(ExampleModel _exampleModel)
        {
            try
            {
                if (_exampleModel == null) { char v = '0'; return v; }
                MailAddress fromAddress = new MailAddress(_exampleModel.Email, _exampleModel.Name);
                MailAddress toAddress = new MailAddress("shhan@jikyung.com", "한승희");

              
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("shhan@jikyung.com", "teachersue89!")
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = "온라인 문의_지경",
                    Body = "문의자 : " + _exampleModel.Name + "<br /></br/>" + "이메일: " + _exampleModel.Email + "<br/><br/>" + "내용 : " + _exampleModel.Contents
                })
                {
                    message.IsBodyHtml = true;

                    smtp.Send(message);

                    char v = '1';

                }

                return v;
            }

            catch (Exception ex)
            {

                if (ex.Message.ToString().Contains("e-mail"))
                {
                    char v = '2';
                    return v;
                }
                else
                {
                    char v = '0';
                    return v;
                }

            }

        }
    }
}
