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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db= new FinansalCrmDbEntities();
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            // Bankaları ComboBox'a yükle
            cmbBanks.DataSource = db.Banks.ToList();
            cmbBanks.DisplayMember = "BankTitle";
            cmbBanks.ValueMember = "BankaId";

            // Banka hareketlerini listele
            var values = db.BankProcesses.Select(p => new
            {
                p.BankProcessId,
                p.Description,
                p.ProcessDate,
                p.ProcessType,
                p.Amount,
                BankName = p.Banks.BankTitle // Banka adı
            }).ToList();

            dataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            cmbBanks.DataSource = db.Banks.ToList();
            cmbBanks.DisplayMember = "BankTitle";
            cmbBanks.ValueMember = "BankaId";

          
            var values = db.BankProcesses.Select(p => new
            {
                p.BankProcessId,
                p.Description,
                p.ProcessDate,
                p.ProcessType,
                p.Amount,
                BankName = p.Banks.BankTitle 
            }).ToList();

            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan veri al
            string description = txtDescription.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            DateTime processDate = dtpProcessDate.Value;
            string processType = txtProcessType.Text; // İşlem türü (örn. "Gelen Havale", "Giden Havale")
            int bankId = (int)cmbBanks.SelectedValue; // Seçilen Banka ID'si

            // Yeni hareket oluştur
            BankProcesses newProcess = new BankProcesses
            {
                Description = description,
                Amount = amount,
                ProcessDate = processDate,
                ProcessType = processType,
                BankId = bankId
            };

            // Veritabanına ekle ve kaydet
            db.BankProcesses.Add(newProcess);
            db.SaveChanges();

            // Kullanıcıya bilgi ver
            MessageBox.Show("Banka hareketi başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // DataGridView'i güncelle
            var values = db.BankProcesses.Select(p => new
            {
                p.BankProcessId,
                p.Description,
                p.ProcessDate,
                p.ProcessType,
                p.Amount,
                BankName = p.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Seçilen satırdan BankProcessId'yi al
            int id = int.Parse(txtId.Text); // Textbox'tan ID al (manuel giriş)

            // Veritabanında kaydı bul ve sil
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();

            // Kullanıcıya bilgi ver
            MessageBox.Show("Banka hareketi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // DataGridView'i güncelle
            var values = db.BankProcesses.Select(p => new
            {
                p.BankProcessId,
                p.Description,
                p.ProcessDate,
                p.ProcessType,
                p.Amount,
                BankName = p.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            // Güncellenecek hareketin ID'sini al
            int id = int.Parse(txtId.Text);

            // Veritabanında kaydı bul
            var updateValue = db.BankProcesses.Find(id);

            // Yeni değerleri ata
            updateValue.Description = txtDescription.Text;
            updateValue.Amount = decimal.Parse(txtAmount.Text);
            updateValue.ProcessDate = dtpProcessDate.Value;
            updateValue.ProcessType = txtProcessType.Text; // İşlem türü (ör. "Gelen Havale")
            updateValue.BankId = (int)cmbBanks.SelectedValue; // Seçilen banka ID'si

            // Değişiklikleri kaydet
            db.SaveChanges();

            // Kullanıcıya bilgi ver
            MessageBox.Show("Banka hareketi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // DataGridView'i güncelle
            var values = db.BankProcesses.Select(p => new
            {
                p.BankProcessId,
                p.Description,
                p.ProcessDate,
                p.ProcessType,
                p.Amount,
                BankName = p.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = values;
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
            FrmSpendings frm = new FrmSpendings();
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

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogOutForm_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı tamamen kapat
        }
    }
}
