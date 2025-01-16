# Finansal CRM Uygulaması

Bu proje, **Windows Forms** kullanılarak geliştirilmiş bir **Finansal CRM** uygulamasıdır. Uygulama, finansal işlemleri yönetmek, banka hareketlerini takip etmek ve kullanıcı dostu bir arayüzle gider/fatura kayıtlarını organize etmek için tasarlanmıştır.

---

## 🚀 Özellikler

- **Kategoriler**:
  - Gider ve fatura kategorilerini yönetme.
  - CRUD (Ekle, Listele, Güncelle, Sil) işlemleri.
![Category](https://github.com/user-attachments/assets/99dd1084-3b02-46a5-8d3c-f35bd93a64d6)
- **Bankalar**:
  - Banka hesap bilgilerini yönetme.
  - Toplam bakiye takibi.
![Banks](https://github.com/user-attachments/assets/6aaae4ab-950b-4963-afeb-bc27daa4de6f)

- **Banka Hareketleri**:
  - Gelen ve giden banka hareketlerini kayıt altına alma.
  - Detaylı işlem takibi (tarih, açıklama, tutar).
![BankProcess](https://github.com/user-attachments/assets/28e54ceb-192a-4014-b78a-985c4f8d578b)

- **Faturalar**:
  - Faturaları kaydetme ve organize etme.
  - Fatura ödemeleri için kullanıcı dostu bir yapı.
![Billing](https://github.com/user-attachments/assets/559579bb-3408-4261-8c26-bbe529dfb79e)

- **Giderler**:
  - Tüm harcamaları kategori bazlı yönetme.
![Spendings](https://github.com/user-attachments/assets/788dda68-94a2-4a8b-86f9-462b4351ce13)

- **Ayarlar**:
  - Kullanıcı bilgilerini (ad, şifre) güncelleme.
  - Tema seçeneklerini değiştirme.
![Settings](https://github.com/user-attachments/assets/dc2b1f8b-08d5-4e17-91bc-255ad29876d8)

- **Çıkış**:
  - Uygulamadan kolayca çıkış yapma.
![image](https://github.com/user-attachments/assets/770df6a5-6741-4649-b955-0b1b816dae55)

---

## 🛠️ Kullanılan Teknolojiler

- **C# (.NET Framework)**: Windows Forms uygulaması.
- **Entity Framework**: Veritabanı işlemleri için.
- **MSSQL**: Veritabanı yönetimi.
- **GitHub**: Proje versiyon kontrolü.

---

## 📂 Veritabanı Yapısı

### Tablolar:
1. **Users**:
   - Kullanıcı bilgileri (UserName, Password).
   
2. **Banks**:
   - Banka hesap bilgileri (BankTitle, BankBalance).

3. **BankProcesses**:
   - Banka hareketleri (Description, ProcessType, Amount, ProcessDate).

4. **Categories**:
   - Gider ve fatura kategorileri.

5. **Spendings**:
   - Harcama kayıtları (SpendingTitle, SpendingAmount, SpendingDate, CategoryId).

6. **Bills**:
   - Faturalar (BillTitle, BillAmount, BillPeriod).

---

