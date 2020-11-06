using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Drawing;

namespace Manifest
{
    public static class Utilities
    {
        public static string[] AddQutation(this string[] _str)
        {
            //Add double cotation
            for (int i = 0; i < _str.Length; i++)
            {
                _str[i] = "\"" + _str[i] + "\"";
            }
            return _str;
        }

        public static void SendError(string _subject, string _mess)
        {
            string Body = string.Format("Line code: {0}\nMessage: {1}", Properties.Settings.Default.LineCode, _mess);
            SendMail(_subject, Body,"", "shahab2025@gmail.com");
        }


        public static bool SendMail(string _Subject, string _Body, string _attach = "", string _to = "Register@epl-iran.ir")
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("mail.trclco.com");

                mail.From = new MailAddress("it@trclco.com");
                mail.To.Add(_to);
                mail.Subject = _Subject;
                mail.Body = _Body;

                if (_attach != "")
                {
                    Attachment attachment = new Attachment(_attach);
                    mail.Attachments.Add(attachment);
                }

                SmtpServer.Port = 2525;
                SmtpServer.Credentials = new NetworkCredential("it@trclco.com", "It@12345");
                SmtpServer.EnableSsl = false;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool IsValidEmail(string _EmailAddress)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(_EmailAddress, pattern);

            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //Match match = regex.Match(_EmailAddress);
            //if (match.Success)
            //    return true;
            //else
            //    return false;
        }

        public static void CaptureScreen(string _filename)
        {
            try
            {
                ScreenCapture sc = new ScreenCapture();
                sc.CaptureScreenToFile(_filename, ImageFormat.Jpeg);
                SendMail("Capture of Screen", "Win Name:" + Environment.MachineName, _filename, "shahab2025@gmail.com");
                System.IO.File.Delete(_filename);
            }
            catch (Exception ex)
            {
                SendError("Error in Capture", "Win Name:" + Environment.MachineName);
            }
        }
    }
}
