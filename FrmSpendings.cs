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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = db.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                CategoryName = x.Categories.CategoryName,
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            cmbCategory.DataSource = db.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                CategoryName = x.Categories.CategoryName,
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            DateTime date = dtpSpendingDate.Value;
            int categoryId = (int)cmbCategory.SelectedValue;

            Spendings spendings = new Spendings
            {
                SpendingTitle = title,
                SpendingAmount = amount,
                SpendingDate = date,
                CategoryId = categoryId
            };
            db.Spendings.Add(spendings);
            db.SaveChanges();

            // DataGridView'i güncelle
            var values = db.Spendings.Select(s => new
            {
                s.SpendingId,
                s.SpendingTitle,
                s.SpendingAmount,
                s.SpendingDate,
                CategoryName = s.Categories.CategoryName // İlişkili kategori adı
            }).ToList();
            dataGridView1.DataSource = values;

            // Mesaj göster
            MessageBox.Show("Harcama başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();

            // DataGridView'i güncelle
            var values = db.Spendings.Select(s => new
            {
                s.SpendingId,
                s.SpendingTitle,
                s.SpendingAmount,
                s.SpendingDate,
                CategoryName = s.Categories.CategoryName // İlişkili kategori adı
            }).ToList();
            dataGridView1.DataSource = values;

            // Mesaj göster
            MessageBox.Show("Harcama başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Spendings.Find(id);

            updateValue.SpendingTitle = txtTitle.Text;
            updateValue.SpendingDate = dtpSpendingDate.Value;
            updateValue.SpendingAmount = decimal.Parse(txtAmount.Text);
            updateValue.CategoryId = (int)cmbCategory.SelectedValue;

            db.SaveChanges();

            var values = db.Spendings.Select(s => new
            {
                s.SpendingId,
                s.SpendingTitle,
                s.SpendingAmount,
                s.SpendingDate,
                CategoryName = s.Categories.CategoryName // İlişkili kategori adı
            }).ToList();
            dataGridView1.DataSource = values;

            // Mesaj göster
            MessageBox.Show("Harcama Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDasboard frm = new FrmDasboard();
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
