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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db=new FinansalCrmDbEntities();
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var users = db.Users.Select(u => new
            {
                u.UserId,
                u.UserName,
                u.Password
            }).ToList();

            dataGridView1.DataSource = users;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            // TextBox'lardan yeni bilgileri al
            string newUserName = txtUserName.Text;
            string newPassword = txtPassword.Text;

            // Veritabanında kullanıcıyı bul
            var user = db.Users.FirstOrDefault(); // Örneğin tek kullanıcı varsa

            if (user != null)
            {
                // Yeni bilgileri ata
                user.UserName = newUserName;
                user.Password = newPassword;

                // Değişiklikleri kaydet
                db.SaveChanges();

                // Kullanıcıya bilgi ver
                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm= new FrmSpendings();
            frm.Show();
            this.Hide();

        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm= new FrmBilling();
            frm.Show();
            this.Hide();

        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm= new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDasboard frm= new FrmDasboard();
            frm.Show();
            this.Hide();

        }

        private void btnLogOutForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
