# NorthWind
Ado.Net ile Web API, WindowsForm, Web MVC uygulamaları
Uygulamalar 2 farklı sql'e dependency injection pattern ile bağlanabilir şekilde hazırlanmıştır.

# Database Değiştirme İşlemi
* NorthWind.NorthWindDB.WebAPI projesinin Startup.cs dosyasında services.AddDbCreate<SqlOperation>(); kod satırındaki generic ifadenin sınıfı değiştirilerek database değiştirilebilir.
* Tabi bununla birlikte yine NorthWind.NorthWindDB.WebAPI projesinin appsettings.json dosyasında isimleri MsSqlServer ve NpgSql olacak şekilde connection stringleri hazır halde bulunması gereklidir.
* Projeyi klonlanlamanız halinde, kendi cihazınızdaki MsSql Server ya da Postgresql'e göre, connection stringleri tekrardan düzenleyerek. Ve Startup.cs dosyasındaki ayarlamayı da yapıp programı derleyip çaşıştırabilirsiniz.

# Desktop Uygulaması
* Anasyfa da istenilen northwind tablolarından birine girilerek veriler görüntülenebilir ve ekleme işlemi yapılabilir. 
* Silme ve güncelleme işlemi, datagridview satırlarından birisine çift tıklanarak yapılabilir. 
- Not: Güncelleme işlemi için gereken kodlar yazılmıştır. Lakin kullanılan https://northwind.vercel.app api ile http update komutu 404 hatası dönmektedir.

# Web MVC uygulaması
* Anasayfada navbardan tüm tablolara ulaşılabilir. Tablonun en üstünde, add butonu yardımı ile açılan formdan yeni kayıt eklenebilir. Tabloda ki her satırda silme ve güncelleme işlemleri için butonlar bulunmaktadır.
* Sayfalara veriler javascript fetch api ile getirilir. Ekleme silme ve güncelleme işlemlerinden sonra sayfadaki veriler asenkron bir şekilde yenilenir.
* Sitede tasarım için bootstrap kütüphanesinden faydalanılmıştır.  
