using MatematikIslemleri.Forms;
using System.Windows.Forms;
namespace MatematikIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Forms.MathFrm mathFrm;
        private void Btn_Plus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mathFrm is null || mathFrm.IsDisposed)
            {
                mathFrm = new MathFrm() { MdiParent = this };
                mathFrm.Show();
            }
        }
        private void Btn_Report_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reporting fReporting = new (0);
            fReporting.ShowDialog();
        }
    }
}