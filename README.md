# Ehliyet Yönetim Sistemi

Bu proje, kullanıcıların ehliyet sınav içeriklerini görüntüleyebildiği ve yöneticilerin sistem üzerindeki verileri yönetebildiği, **ASP.NET Core 8.0** ile geliştirilmiş modern bir web uygulamasıdır. Proje, çok katmanlı mimari (N-Tier Architecture) ile yapılandırılmış olup, özellikle ViewComponent kullanımı sayesinde modüler ve sürdürülebilir bir yapıya sahiptir.

## 🎯 Projenin Amacı

- Ehliyet sınav sorularını kullanıcıya Türkçe olarak sunmak  
- Ana sayfayı ViewComponent’ler ile parçalara bölerek yeniden kullanılabilir hale getirmek  
- Admin paneli aracılığıyla sistemdeki içerikleri listelemek (sadece Read işlemi)  
- ASP.NET Core ile MVC mimarisi ve katmanlı yapı uygulamalarını göstermek  

## 🧱 Kullanılan Teknolojiler

### ✅ Frontend
- HTML CSS JS
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


<img width="946" alt="proje resim 1" src="https://github.com/user-attachments/assets/6e94f99c-c3af-4c1d-a247-2d37fe201629" />
<img width="950" alt="proje resim 4" src="https://github.com/user-attachments/assets/99b016e5-aa5e-4664-85b6-941c983dd824" />
<img width="955" alt="proje resim 3" src="https://github.com/user-attachments/assets/05957ffa-02cb-42b2-a171-8d1ed4a8559b" />
<img width="950" alt="proje resim 2" src="https://github.com/user-attachments/assets/1d56bbc7-3ad3-4601-ab07-d3b552cd36c2" />


