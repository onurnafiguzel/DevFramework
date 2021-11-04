# DevFramework

## Projenin Amacı
  Bu proje birden fazla teknolojinin basit örneklerle, kurumsal mimari ile nasıl kullanılacağını öğretmek amacıyla hazırlanmıştır.
Birkaç yerde commitlemeyi unutmam dışında güzel bir türkçe kaynak.

## Kullanılan Teknolojiler
**Entity Framework (6.1.3)** <br/>
**NHibernate (5.3.10)** <br/>
**Mapping AutoMapper (6.1.1)** <br/>
**Moq Framework(4.16.1)** <br/>
**SqlServer->Northwind veritabanı** <br/>
**Fluent Validation (10.3.3)** <br/>
**Postsharp (4.2.17)** <br/>
**Ninject (3.2.2)** <br/>
**Log4net(2.0.12)** <br/>

## Yapılan İşlemler
  AOP olarak Postsharp (4.2.17) kullanıldı. Authorization, Cache, ExpectionLog, Log, PerformanceCounter,
TransactionScope ve FluentValidation işlemleri yapıldı.

**1-> Authorization işlemi için kullanıcının rolleri ve metotların izin verdiği roller kıyaslandı ve bir 
authorized işlemi yapıldı.** <br/>
**2->Caching olarak Microsoft MemoryCache kullanıldı.** <br/>
**3->Logging olarak Log4Net kullanıldı bir JSON dosyasına ve Veritabanına sonuçlar kaydedildi.** <br/>
**4->PerformanceCounter için temel bir stopwatch kullanıldı. Aksi durumda console sonuç yazdırıyor..** <br/>
**5->TransactionScope temel olarak metot içeriklerinin toplam sonucuna göre sonuç döndürüyor, tüm işlemler yapılıyor ya da hiçbiri yapılmıyor.** <br/>
**6->Validation olarak FluentValidation (10.3.3) kullanıldı.** <br/>
**7->Güvenlik kısmında WEB için firstname,lastname,id kullanılarak bir cookie oluşturuldu.** <br/>
**8->Veri erişim olarak Entity Framework(6.1.3) ve NHibernate(5.3.10) kullanıldı.** <br/>
**9->İhtiyaçlar kısmında ise WcfProxy, AutoMapper ve NinjectControllerFactory kullanıldı.**<br/>
**10->Bağımlılıkları enjekte etmede oldukça popüler olan IoC containerlardan Ninject(3.2.2) kullanıldı.** <br/>
**11->Web API, MVC,WCF etkinleştirilmiştir.** <br/>
**12->Angular katmanı Gulp'u etkinleştiremediğim için çalışmıyor.** <br/>

## Projeye dair birkaç not

1-	IQueryable vs IEnumerable
 IQueryable kullanıldığında sorgu alınırken öncelikle filtrelendirme yapılıp sorgu gönderilir. Bu konuda performans bakımından çok iyidir.
IEnumerable ise önce listeyi döndürür sonra filtreleme yapar.IEnumerable hafızadaki koleksiyonlar için idealdir.
IQueryable hafıza dışındaki (veritabanı, servis vs.) koleksiyonlar için idealdir.

2-	WCF Nedir?
  WCF, az kod yazarak birçok işlevi hızlı bir şekilde gerçekleştirmemizi sağlayan ve bir başka deyişle .NET teknolojisinde herşeyi herşeye bağlamaya yarayan bir teknolojidir. WCF’in en büyük getirisi, servis içine işlediğiniz iş mantığının dışa açarken göz önüne alacağınız yöntemlerden bağımsız olmasıdır.
Mesela bir bankamız olsun herhangi bir dilde yazılmış, onlarca da client’ı olsun farklı dillerde WCF ile bunları birbirine bağlayabiliriz. İletişim XML web servisi ile sağlanır.

3-AOP nedir?
  CrossCuttingConcerns’lerimizi daha iyi hale getirmemizi sağlar.İçi içe yazılı tekrar eden kod bloklarından bizi kurtarır, kodun temiz ve anlaşılır olmasını sağlar, yazmış olduğumuz kodları daha abstract hale getirerek modülerliğini arttırırız, bakım ve geliştirme maliyetlerini azaltıyoruz, uygulamamızı daha yönetilebilir ve daha esnek hale getirebiliyoruz.

4-Interceptor Nedir, Nasıl Çalışır?
  İş ihtiyaçlarına göre; metoda girmeden önce, işlem bittikten sonra, hata durumunda gibi durumlarda araya girerek istediğimiz müdahaleyi yapabilmemizi sağlar. Bu araya girme işlemleri Compile-Time (Derleme Zamanı) veya Run-Time (Çalışma Zamanı) olmak üzere iki farklı yönden gerçekleştirilebilir.
•	Compile-Time (Derleme Zamanı): Yazdığımız modüllere ait kodlar, uygulama derlendiği zaman çalışılması istenilen kod bloğu içerisine yerleştirilir.
•	Run-Time (Çalışma Zamanı): Burada ise işlemler çalışma zamanında gerçekleşmektedir.

5 -Serileştirme (Serialization), nesnelerin çalışma zamanındaki (runtime) durumlarını alıp geçici veya kalıcı olarak bir kaynağa (file,memory, database, socket, buffer vb.) saklamak/transfer etmek için belirli bir forma dönüştürülüp yazma işlemidir.

6-Ters-serileştirme (Deserialization), bir kaynakta (file,memory, database, socket, buffer vb.) bulunan serileştirilmiş (serialize) belirli bir formdaki nesnelerin, ihtiyaç olduğunda çalışma zamanındaki durumunu elde etme işlemidir.

Eğitimin Linki: [Google Linki](https://www.btkakademi.gov.tr/portal/course/c--7008#!/about) Engin Demiroğ'a teşekkürler
