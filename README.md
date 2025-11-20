# Basic CQRS Practice

Bu proje, **CQRS (Command Query Responsibility Segregation)** mimarisini temel düzeyde deneyimlemek için hazırlanmış bir örnek uygulamadır. Bu proje CQRS in temel mantığını göz önüne alıp aynı zamanda Folder Structor yapısını koruyarak "Komut(Command)" ve "Sorgu(Query)" işlemlerini birbirinden ayırmış bu doğrultuda .NET ortamındaki kullanımını göstermeyi amaşlamıştır.

## 🚀 Proje Amacı

Bu uygulama ile:

* CQRS mimarisinin temel kavramlarını öğrenmek,
* Command ve Query işlemlerini ayrı katmanlarda yönetmek,
* MediatR kullanımını örneklemek,
* AutoMapper kütüphanesini kullanmak,
* Temel CRUD işlemlerini CQRS yaklaşımıyla gerçekleştirmek amaçlanmıştır.
* Farklı pojeden referans aldığı .dll dosyası ile generic yapıyı merkezileştirmek

## 🏗️ Kullanılan Teknolojiler

* **.NET 8**
* **CQRS Pattern**
* **MediatR**
* **AutoMapper**
* **Entity Framework Core**
* **MSSQL**
* **Dependency Injection**

```

## 📌 CQRS Mantığı Nasıl Uygulandı?

Proje iki temel işlem türüne ayrılmıştır:

### ✔ Command İşlemleri (Write Operations)

* Veri ekleme
* Veri güncelleme
* Veri silme

Her komutun kendi **Command** sınıfı ve aynı class içinde **Handler** sınıfı vardır.

```

### ✔ Query İşlemleri (Read Operations)

* Veri listeleme
* Id'ye göre veri getirme

Her sorgunun kendi Query sınıfı ve Handler sınıfı vardır.


```


## 📚 Öğrenilenler

Bu proje sayesinde:

* CQRS mantığının temeli,
* Command-Query ayrımı,
* MediatR pipeline yapısı,
* AutoMapper ile kolay dönüşüm işlemleri,
* Temiz ve ölçeklenebilir bir mimari oluşturma
  konularında pratik kazanırsınız.


