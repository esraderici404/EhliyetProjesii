# Çalışanlar ve Ehliyet Yönetim Sistemi

Bu proje, çalışan bilgilerini ve ehliyet sınav içeriklerini yönetmek için geliştirilmiş çok katmanlı mimariye sahip bir ASP.NET Core web uygulamasıdır. Projede modern yazılım mimarileri kullanılarak hem kullanıcıya hem de yöneticiye hitap eden fonksiyonel bir yapı sunulmuştur.

## 🎯 Projenin Amacı

- **Çalışan Yönetimi:** CRUD (Create, Read, Update, Delete) işlemleriyle çalışan bilgilerini yönetme
- **Ehliyet Sınav Sistemi:** ViewComponent yapısıyla modüler bir sınav sayfası
- **Admin Paneli:** Yöneticilerin çalışan ve sınav içeriklerini listeleyebildiği panel

## 🧱 Kullanılan Teknolojiler

### ✅ Frontend
- HTML
- Razor View Engine (ASP.NET MVC)

### ✅ Backend
- C#
- ASP.NET Core 8.0
- N-Tier Architecture (Katmanlı Mimari)
  - **Data Access Layer (DAL)**
  - **Business Logic Layer (BLL)**
  - **Presentation Layer (UI)**

### ✅ Veritabanı
- Microsoft SQL Server (MSSQL)

## ⚙️ Proje Özellikleri

- Katmanlı mimari ile sürdürülebilir ve test edilebilir yapı
- ViewComponent ile modülerleştirilmiş ana sayfa yapısı (Default Layout)
- Admin paneli üzerinden çalışanları listeleme
- Temel CRUD işlemleri (Ekleme, Silme, Güncelleme, Listeleme)
- SQL veritabanı ile güçlü veri yönetimi
- ASP.NET Core 8.0 avantajları ile modern web geliştirme

## 🖥️ Admin Paneli

Admin paneli sayesinde yöneticiler sistemdeki çalışanları görüntüleyebilir. Şu anda sadece **listeleme işlemi** aktiftir ancak yapı, diğer işlemler için de genişletilmeye uygundur.

## 🧩 Mimari Yapı

