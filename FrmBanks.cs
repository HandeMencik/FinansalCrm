using FinansalCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinansalCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //banka bakiyeleri
            var ziraatBankBlance = db.Banks.Where(x => x.BankTitle == "Ziraat Bank").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBlance = db.Banks.Where(x => x.BankTitle == "Vakıf Bank").Select(y => y.BankBalance).FirstOrDefault();
            var garantiBankasiBlance = db.Banks.Where(x => x.BankTitle == "Garanti Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var enparaBlance = db.Banks.Where(x => x.BankTitle == "Enpara").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBalance.Text = ziraatBankBlance.ToString() + " ₺";
            lblVakifBalance.Text = vakifBankBlance.ToString() + " ₺";
            lblGarantiBalance.Text = garantiBankasiBlance.ToString() + " ₺";
            lblEnparaBalance.Text = enparaBlance.ToString() + " ₺";

            //banka hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " | " + bankProcess1.Amount + " | " + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " | " + bankProcess2.Amount + " | " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " | " + bankProcess3.Amount + " | " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " | " + bankProcess4.Amount + " | " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " | " + bankProcess5.Amount + " | " + bankProcess5.ProcessDate;
        }



        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();

        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDasboard frm = new FrmDasboard();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();

        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogOutForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
