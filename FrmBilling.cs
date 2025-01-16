using FinansalCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinansalCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills =new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi.","Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Silindi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);

            var UpdateValue = db.Bills.Find(id);

           
            UpdateValue.BillTitle = title;
            UpdateValue.BillAmount = amount;
            UpdateValue.BillPeriod = period;          
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }  

        private void btnCategoryForm_Click_2(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click_1(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click_1(object sender, EventArgs e)
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
