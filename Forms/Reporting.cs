using DevExpress.XtraEditors;
using MatematikIslemleri.Class;
using System;
using System.Data;
using System.Data.SQLite;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MatematikIslemleri.Forms
{
    public partial class Reporting : Form
    {
        private ushort id = default;
        public Reporting(ushort ID)
        {
            id = ID;
            InitializeComponent();
        }
        private void SendMail(string mail)
        {
            gridControl1.ExportToXlsx(Application.StartupPath + "\\temp\\OtiMatematik.xlsx");
            SmtpClient cl = new();
            MailMessage ms = new();
            cl.EnableSsl = true;
            ms.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            ms.Priority = MailPriority.High;
            cl.DeliveryMethod = SmtpDeliveryMethod.Network;
            cl.Credentials = new NetworkCredential("dogukandevp@hotmail.com", "48877278690dd");
            ms.From = new MailAddress("dogukandevp@hotmail.com");
            cl.Host = "smtp-mail.outlook.com";
            cl.Port = 587;
            Attachment at = new(Application.StartupPath + "\\temp\\OtiMatematik.xlsx");
            ms.Attachments.Add(at);
            ms.Subject = "OĞUZHAN KAAN KOŞAN";
            try
            {
                ms.To.Add(mail);
                cl.Send(ms);
                at.Dispose();
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show(hata.Message, "MAİL GÖNDERME İŞLEMİ BAŞARISIZ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                at.Dispose();
                return;
            }
            XtraMessageBox.Show("MAİL GÖNDERME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void List()
        {
            SQLiteDataAdapter da;
            if (id != 0)
            {
                da = new("select _Date as 'Tarih',Number1 as '1.Sayi',Type as 'Islem_Turu',Number2 as '2.Sayi',Conclusion as 'Sonuc',Result as 'Yanıtınız',case IsTrue when 0 THEN 'HATALI' else 'Doğru' END as 'Durum' from MathProccess where ProccessID=" + Variables.ID + " order by IsTrue ", Connection.dbConnection);
            }
            else
            {
                da = new("select _Date as 'Tarih',Number1 as '1.Sayi',Type as 'Islem_Turu',Number2 as '2.Sayi',Conclusion as 'Sonuc',Result as 'Yanıtınız',case IsTrue when 0 THEN 'HATALI' else 'Doğru' END as 'Durum' from MathProccess   order by IsTrue ", Connection.dbConnection);
            }
            DataSet ds = new();
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        private void Reporting_Load(object sender, EventArgs e)
        {
            List();
            if (id != 0)
                SendMail("ghasab101@gmail.com");
        }
        private void mailGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMail("ghasab101@gmail.com");
        }

        private void whatsappAnneyeGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMail("kardelen1777@hotmail.com");
        }
    }
}