# Ehliyet Yönetim Sistemi

Bu proje, kullanıcıların ehliyet sınav içeriklerini görüntüleyebildiği ve yöneticilerin sistem üzerindeki verileri yönetebildiği, **ASP.NET Core 8.0** ile geliştirilmiş modern bir web uygulamasıdır. Proje, çok katmanlı mimari (N-Tier Architecture) ile yapılandırılmış olup, özellikle ViewComponent kullanımı sayesinde modüler ve sürdürülebilir bir yapıya sahiptir.

## 🎯 Projenin Amacı

- Ehliyet sınav sorularını kullanıcıya Türkçe olarak sunmak  
- Ana sayfayı ViewComponent’ler ile parçalara bölerek yeniden kullanılabilir hale getirmek  
- Admin paneli aracılığıyla sistemdeki içerikleri listelemek (sadece Read işlemi)  
- ASP.NET Core ile MVC mimarisi ve katmanlı yapı uygulamalarını göstermek  

## 🧱 Kullanılan Teknolojiler

### ✅ Frontend
- HTML  
- Razor View Engine (ASP.NET MVC)

### ✅ Backend
- C#  
- ASP.NET Core 8.0  
- N-Tier Architecture
  - Data Access Layer (DAL)
  - Business Logic Layer (BLL)
  - Presentation Layer (UI)

### ✅ Veritabanı
- Microsoft SQL Server (MSSQL)

## ⚙️ Proje Özellikleri

- Katmanlı mimari ile sürdürülebilir ve test edilebilir yapı  
- ViewComponent ile modülerleştirilmiş ana sayfa yapısı (Default Layout yaklaşık 2000 satır kod parçalanarak bölündü)  
- Admin paneli üzerinden yalnızca listeleme (read) işlemi yapılabilir  
- Türkçe dil desteğiyle kullanıcı dostu arayüz  
- SQL veritabanı ile güçlü veri yönetimi  

## 🖥️ Admin Paneli

Admin paneli sayesinde yöneticiler sistemdeki sınav içeriklerini görüntüleyebilir. Şu anda yalnızca **listeleme** işlemi yapılabilmektedir. Ancak yapı, ekleme, silme, güncelleme gibi diğer işlemler için genişletilmeye uygundur.


