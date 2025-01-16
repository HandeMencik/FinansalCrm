using FinansalCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinansalCrm
{
    public partial class FrmDasboard : Form
    {
        public FrmDasboard()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        int count = 0;

        private void FrmDasboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotelBalance.Text = totalBalance.ToString() + " ₺";

            var lastProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastProcessAmount.Text = lastProcessAmount.ToString() + "₺";

            //Chart1
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //Chart2
            var billdata = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType=System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            foreach (var item in billdata)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 5 == 1)
            {
                var billValue = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = billValue.ToString() + " ₺";

            }
            if (count %5 == 4)
            {
                var billValue = db.Bills.Where(x => x.BillTitle == "Telefon Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Telefon Faturası";
                lblBillAmount.Text = billValue.ToString() + " ₺";

            }
            if (count % 5 == 3)
            {
                var billValue = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = billValue.ToString() + " ₺";

            }
            if (count %5==2 )
            {
                var billValue = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = billValue.ToString() + " ₺";

            }
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
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
