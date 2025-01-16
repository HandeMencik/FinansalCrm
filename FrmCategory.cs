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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

            // "Spendings" sütununu gizle
            if (dataGridView1.Columns["Spendings"] != null)
            {
                dataGridView1.Columns["Spendings"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            Categories categories = new Categories();
            categories.CategoryName = categoryName;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Bir Şekilde Sisteme Eklendi.", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var valueCategoryId = db.Categories.Find(id);
            db.Categories.Remove(valueCategoryId);
            db.SaveChanges();
            MessageBox.Show("Kategori Bir Şekilde Silindi.", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string categoryName=txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);

            var updatedValue=db.Categories.Find(id);
           
            updatedValue.CategoryName = categoryName;
            db.SaveChanges();
            MessageBox.Show("Kategori Bir Şekilde Güncellendi.", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm=new FrmBanks();
            frm.Show();
            this.Hide();
        }


        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm=new FrmBilling();
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
            FrmSpendings frm=new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm=new FrmBankProcesses();
            frm.Show();
            this.Hide();

        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm=new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogOutForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
