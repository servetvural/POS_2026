using System.Net.Mail;

namespace WinLayer;
   
public class DRSmtp
{
    public DRSmtp()
    {
    }

    public static SmtpClient GetSmtp(string SmtpServer, string SmtpUserName, string SmtpPassword)
    {
        SmtpClient smtp = new SmtpClient(SmtpServer);
        System.Net.NetworkCredential nc = new System.Net.NetworkCredential(SmtpUserName, SmtpPassword);
        smtp.Credentials = nc;
        return smtp;
    }
    public static SmtpClient GetSmtp(string SmtpServer, string SmtpUserName, string SmtpPassword, int TimeOutPeriod)
    {
        SmtpClient smtp = new SmtpClient(SmtpServer);
        smtp.Timeout = TimeOutPeriod;
        System.Net.NetworkCredential nc = new System.Net.NetworkCredential(SmtpUserName, SmtpPassword);
        smtp.Credentials = nc;
        return smtp;
    }
    public static MailMessage CompileMessage(string FromAddress, string ToAddress,
        string Subject, string Body, MailPriority Priority, bool IsBodyHtml)
    {
        MailMessage message = new MailMessage(FromAddress, ToAddress);
        message.Priority = Priority;
        message.Subject = Subject;
        message.Body = Body;
        message.IsBodyHtml = IsBodyHtml;
        message.Sender = new MailAddress(FromAddress);
        message.ReplyTo = new MailAddress(FromAddress);
        //foreach (ListViewItem item in lvwAttachments.Items) {
        //    Attachment att = new Attachment(item.Text);
        //    message.Attachments.Add(att);
        //}
        //Attachment att = new Attachment(filename);
        return message;
    }

    public static void SendEmail(SmtpClient smtp, MailMessage message)
    {
        smtp.Send(message);
    }
    public static void SendEmail(string SmtpServer, string SmtpUserName, string SmtpPassword, MailMessage message)
    {
        SmtpClient smtp = GetSmtp(SmtpServer, SmtpUserName, SmtpPassword);
        if (smtp != null)
        {
            smtp.Send(message);
        }
    }
    public static void SendEmail(string SmtpServer, string SmtpUserName, string SmtpPassword, string FromAddress, string ToAddress,
        string Subject, string Body, MailPriority Priority, bool IsBodyHtml)
    {
        SmtpClient smtp = GetSmtp(SmtpServer, SmtpUserName, SmtpPassword);
        if (smtp != null)
        {
            MailMessage message = CompileMessage(FromAddress, ToAddress, Subject, Body, Priority, IsBodyHtml);
            smtp.Send(message);
        }
    }

}
