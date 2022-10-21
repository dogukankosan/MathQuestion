using DevExpress.XtraEditors;
using MatematikIslemleri.Class;
using System;
using System.Windows.Forms;

namespace MatematikIslemleri.Forms
{
    public partial class MathFrm : Form
    {
        public MathFrm()
        {
            InitializeComponent();
        }
        private bool formClose=true;
        private byte timerValues = 120;
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            formClose = default;
            MathProccess.IdProccess(Lbl_Type);
            groupControl3.Visible = false;
            Txt_Result.Enabled = true;
            Btn_Start.Enabled = false;
            Variables.trueCount = 0;
            Variables.totalCount = 0;
            Variables.falseCount = 0;
            MathProccess.NewQuestion(Lbl_Number1, Lbl_Type, Lbl_Number2, Txt_Result);
            contextMenuStrip1.Enabled = false;
            timer1.Enabled = true; timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerValues--;
            Lbl_timer.Text = timerValues.ToString();
            if (timerValues == 0)
            {
                formClose = true;
                timer1.Stop();
                XtraMessageBox.Show("SÜRENİZ BİTTİ !!", "İŞLEM BİTTİ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Txt_Result.Text = "";
                Txt_Result.Enabled = false;
                Lbl_Number1.Text = "";
                Lbl_Number2.Text = "";
                Btn_Start.Enabled = true;
                groupControl3.Visible = true;
                timerValues = 10;
                contextMenuStrip1.Enabled = true;
                Reporting cd = new(Variables.ID);
                cd.ShowDialog();
            }
        }
        private void Txt_Result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool status = MathProccess.Control(Lbl_Number1, Lbl_Type, Lbl_Number2, Txt_Result, Lbl_FalseCount, Lbl_true, Lbl_QuestionCount);
                if (status)
                {
                    MathProccess.SqliteConnect(Variables.number1, Variables.type, Variables.number2,
                        Variables.Conclusion, Variables.resultText, Variables.isTrue, Variables.ID);
                    MathProccess.NewQuestion(Lbl_Number1, Lbl_Type, Lbl_Number2, Txt_Result);
                }
            }
        }
        private void Plus_Load(object sender, EventArgs e)
        {
            Txt_Result.Focus();
            Txt_Result.Enabled = false;
        }
        private void Txt_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }
        private void çIKARMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lbl_Type.Text = "-";
        }
        private void çARPMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lbl_Type.Text = "X";
        }
        private void tOPLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lbl_Type.Text = "+";
        }

        private void MathFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formClose == false)
            {
                e.Cancel = true;
            }
        }
    }
}