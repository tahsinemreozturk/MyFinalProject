# E-Ticaret Sitesi Projesi

Bu proje, kullanıcıların çeşitli kategorilerde ürünleri arayıp satın alabileceği bir e-ticaret platformudur. Proje, sürdürülebilir yazılım geliştirme prensiplerine dikkat edilerek .Net Core ve ASP.NET teknolojileri kullanılarak geliştirilmiştir. Projenin ana bileşenleri Web API, Business, Core, DataAccess ve Entities katmanlarından oluşmaktadır ve SOLID, OOP, AOP prensiplerine uygun olarak yapılandırılmıştır.

## Proje Yapısı

- **Web API**: RESTful API servislerini barındırır. Kullanıcılar ve ürünler gibi temel işlevler burada sağlanır.
- **Business**: İş mantığı bu katmanda yer alır. Veritabanı işlemleri ve iş kuralları burada uygulanır.
- **Core**: Uygulamanın çekirdek katmanıdır. Genel tanımlar, yardımcı sınıflar ve servisler burada bulunur.
- **DataAccess**: Veritabanı işlemleri bu katmanda gerçekleştirilir. Entity Framework kullanılarak veri erişim işlemleri burada yapılır.
- **Entities**: Uygulamanın veri modelleri bu katmanda tanımlanır.

## Kullanılan Teknolojiler

- .Net Core
- ASP.NET
- Entity Framework
- Autofac
- Fluent Validation
- Toastr
- TypeScript
- Angular
- HTML
- CSS
- Bootstrap

## Proje Özellikleri

- **SOLID Prensipleri**: Tüm kod yapısı, SOLID prensiplerine uygun olarak geliştirilmiştir. Bu, kodun daha okunabilir, bakımı daha kolay ve daha esnek olmasını sağlar.
- **OOP ve AOP**: Nesne yönelimli programlama (OOP) ve yönlü programlama (AOP) teknikleri kullanılmıştır.
- **Sürdürülebilirlik**: Kodun sürdürülebilir olması için, temiz kod yazma (Clean Code) prensiplerine dikkat edilmiştir. Kodun bakımı ve genişletilebilirliği göz önünde bulundurulmuştur.
- **Çok Katmanlı Mimari**: Proje, farklı sorumlulukları olan katmanlara ayrılarak daha modüler bir yapı oluşturulmuştur.

## Kurulum ve Kullanım

1. **Proje Dosyalarını Klonlayın**:
    ```bash
    git clone https://github.com/tahsinemreozturk/e-ticaret-sitesi.git
    ```
2. **Gerekli Bağımlılıkları Yükleyin**:
    ```bash
    cd e-ticaret-sitesi
    dotnet restore
    ```
3. **Veritabanı Ayarlarını Yapın**:
   - `appsettings.json` dosyasındaki veritabanı bağlantı ayarlarını güncelleyin.
4. **Veritabanı Migrasyonlarını Uygulayın**:
    ```bash
    dotnet ef database update
    ```
5. **Uygulamayı Çalıştırın**:
    ```bash
    dotnet run
    ```

## Proje Geliştirme Süreci

- **Planlama ve Tasarım**: Proje başlamadan önce gereksinimler belirlendi ve proje yapısı tasarlandı.
- **Geliştirme**: Belirlenen katmanlar ve teknolojiler kullanılarak projenin geliştirilmesi gerçekleştirildi.
- **Test ve Değerlendirme**: Projenin işlevsellik ve performans açısından testleri yapıldı. Geri bildirimler doğrultusunda iyileştirmeler yapıldı.
- **Devreye Alma**: Proje, üretim ortamına aktarılmadan önce son kontroller yapıldı ve devreye alındı.

## Katkıda Bulunma

Katkıda bulunmak isteyenler için:
1. Bu projeyi fork'layın.
2. Yeni bir dal (branch) oluşturun: `git checkout -b yeni-ozellik`
3. Değişikliklerinizi commit edin: `git commit -m 'Yeni özellik ekleme'`
4. Dalınıza push yapın: `git push origin yeni-ozellik`
5. Bir Pull Request oluşturun.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.
