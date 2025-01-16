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

- **Banka Hareketleri**:
  - Gelen ve giden banka hareketlerini kayıt altına alma.
  - Detaylı işlem takibi (tarih, açıklama, tutar).

- **Faturalar**:
  - Faturaları kaydetme ve organize etme.
  - Fatura ödemeleri için kullanıcı dostu bir yapı.

- **Giderler**:
  - Tüm harcamaları kategori bazlı yönetme.

- **Ayarlar**:
  - Kullanıcı bilgilerini (ad, şifre) güncelleme.
  - Tema seçeneklerini değiştirme.

- **Çıkış**:
  - Uygulamadan kolayca çıkış yapma.

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

