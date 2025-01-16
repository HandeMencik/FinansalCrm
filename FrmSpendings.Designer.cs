namespace FinansalCrm
{
    partial class FrmSpendings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpSpendingDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnSpendingForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBankProcessForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOutForm = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(199, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 188);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpSpendingDate);
            this.panel3.Controls.Add(this.cmbCategory);
            this.panel3.Controls.Add(this.btnBill);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnList);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(199, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 181);
            this.panel3.TabIndex = 8;
            // 
            // dtpSpendingDate
            // 
            this.dtpSpendingDate.Location = new System.Drawing.Point(120, 122);
            this.dtpSpendingDate.Name = "dtpSpendingDate";
            this.dtpSpendingDate.Size = new System.Drawing.Size(340, 20);
            this.dtpSpendingDate.TabIndex = 14;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(120, 155);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(340, 21);
            this.cmbCategory.TabIndex = 13;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.White;
            this.btnBill.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBill.ForeColor = System.Drawing.Color.Navy;
            this.btnBill.Location = new System.Drawing.Point(476, 131);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(130, 27);
            this.btnBill.TabIndex = 11;
            this.btnBill.Text = "Güncelle";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(55, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kategori:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(476, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 27);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(476, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.White;
            this.btnList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.Navy;
            this.btnList.Location = new System.Drawing.Point(476, 32);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(130, 27);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "Harcama Listesi";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(77, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tarih:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(120, 83);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(340, 26);
            this.txtAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(120, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(340, 26);
            this.txtTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gider Açıklaması:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(120, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(340, 26);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gider Id:";
            // 
            // btnBillForm
            // 
            this.btnBillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(23, 156);
            this.btnBillForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(143, 38);
            this.btnBillForm.TabIndex = 12;
            this.btnBillForm.Text = "Faturalar";
            this.btnBillForm.UseVisualStyleBackColor = false;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btnSpendingForm
            // 
            this.btnSpendingForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnSpendingForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingForm.ForeColor = System.Drawing.Color.White;
            this.btnSpendingForm.Location = new System.Drawing.Point(23, 111);
            this.btnSpendingForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnSpendingForm.Name = "btnSpendingForm";
            this.btnSpendingForm.Size = new System.Drawing.Size(143, 38);
            this.btnSpendingForm.TabIndex = 11;
            this.btnSpendingForm.Text = "Giderler";
            this.btnSpendingForm.UseVisualStyleBackColor = false;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(23, 66);
            this.btnBanksForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(143, 38);
            this.btnBanksForm.TabIndex = 10;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnCategoryForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoryForm.Location = new System.Drawing.Point(23, 21);
            this.btnCategoryForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(143, 38);
            this.btnCategoryForm.TabIndex = 9;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = false;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 38);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gider Formu";
            // 
            // btnBankProcessForm
            // 
            this.btnBankProcessForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnBankProcessForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessForm.ForeColor = System.Drawing.Color.White;
            this.btnBankProcessForm.Location = new System.Drawing.Point(23, 201);
            this.btnBankProcessForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnBankProcessForm.Name = "btnBankProcessForm";
            this.btnBankProcessForm.Size = new System.Drawing.Size(143, 38);
            this.btnBankProcessForm.TabIndex = 13;
            this.btnBankProcessForm.Text = "Banka Hareketleri";
            this.btnBankProcessForm.UseVisualStyleBackColor = false;
            this.btnBankProcessForm.Click += new System.EventHandler(this.btnBankProcessForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogOutForm);
            this.panel1.Controls.Add(this.btnSettingsForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnBankProcessForm);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnSpendingForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(5, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 384);
            this.panel1.TabIndex = 6;
            // 
            // btnLogOutForm
            // 
            this.btnLogOutForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnLogOutForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOutForm.ForeColor = System.Drawing.Color.White;
            this.btnLogOutForm.Location = new System.Drawing.Point(23, 335);
            this.btnLogOutForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogOutForm.Name = "btnLogOutForm";
            this.btnLogOutForm.Size = new System.Drawing.Size(143, 38);
            this.btnLogOutForm.TabIndex = 16;
            this.btnLogOutForm.Text = "Çıkış Yap";
            this.btnLogOutForm.UseVisualStyleBackColor = false;
            this.btnLogOutForm.Click += new System.EventHandler(this.btnLogOutForm_Click);
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnSettingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsForm.Location = new System.Drawing.Point(23, 290);
            this.btnSettingsForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(143, 38);
            this.btnSettingsForm.TabIndex = 15;
            this.btnSettingsForm.Text = "Ayarlar ";
            this.btnSettingsForm.UseVisualStyleBackColor = false;
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnDashboardForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForm.Location = new System.Drawing.Point(23, 246);
            this.btnDashboardForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(143, 38);
            this.btnDashboardForm.TabIndex = 14;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = false;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 454);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSpendings";
            this.Text = "FrmSpendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnBillForm;
        public System.Windows.Forms.Button btnSpendingForm;
        public System.Windows.Forms.Button btnBanksForm;
        public System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBankProcessForm;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnLogOutForm;
        public System.Windows.Forms.Button btnSettingsForm;
        public System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpSpendingDate;
    }
}