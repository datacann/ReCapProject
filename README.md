İkinci El Araç Satış Platformu



SON GÜNCELLEMELER
Frontend tarafı için CustomerDetailDto oluşturuldu, CarDetailDto ve RentalDetailDto bölümleri düzenlendi. Bu Dto'lar için API tarafına kadar olan implementasyonları gerçekleştirildi. Postman üzerinden test edildi ve veriler doğrulandı. Cache, Transaction ve Performance entegrasyonu yapıldı. !!! Json Web Token ENTEGRASYONU yapıldı.

CORE
IEntity, IDto, IEntityRepository, EfEntityRepositoryBase yapıları bu katman içerisinde oluşturuldu. IDto: Özel sorgular ile çekilebilecek nesneler için oluşturulan arayüz. IEntityRepository: T generic yapısı ile kolayca implemente edilebilen, Gerçek DataAccess katmanındaki arayüzler için temel database işlemlerini tutmaktadır., EfEntityRepositoryBase: Entity Framework yapısı için yine generic bir yapıda context ve yapısını oluşturacak olan nesnesi(entity) yardımıyla temel database işlemleri için somut bir arayüz implementasyonunu sağlayacak iskeleti tutmaktadır. ICrudServices: Gerçek Business katmanında farklı nesnelere ait servisler için benzer veri tabanı işlemlerinin uygulanabilirliğini kolaylaştırmak amacıyla generic yapıda oluşturulmuştur. Autofac desteği getirildi. Fluent Validation desteği getirildi. (A)spect (O)riented (P)rogramming temel seviye giriş gerçekleştirildi.

ENTITIES
Database üzerinde CarImages tablosu ve ilgili sütunlar için (Id,CarId,ImagePath,Date) ilgili varlık oluşturuldu. Car adında bir sınıf ile araç özelliklerini tutan nesne oluşturuldu. Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanları eklendi. Brand ve Color nesneleri eklendi. Bu nesneler Id ve Name özelliklerini taşımaktadırlar. Users tablosu oluşturuldu. Customers tablosu oluşturuldu Rentals tablosu oluşturuldu ve Key atamaları yapıldı. Projede bu tablolardaki elemanlara karşılık gelecek Entity'ler oluşturuldu. Yeni kullanıcılar, müşteriler ve kira kayıtları oluşturuldu. (SQL)

DATAACCESS
Resim silme, güncelleme yetkileri eklendi. Veritabanından ekleme, silme, listeleme gibi işlemleri içermektedir. Database için gerekli sorgular projeye eklenmiştir. Car, Brand ve Color nesneleri için Entity Framework altyapısını yazılmıştır. DAL operasyonlarında yeni eklenen Customers, Users ve Rentals için CRUD işlemleri yazıldı.

BUSINESS
Bir arabaya ait resimleri listeleme imkanı oluşturuldu. Fakat listede araç olmadığında şirket logosu kullanıldı. Resmin eklendiği tarih, sistem tarafından otomatik olarak encapsulation yardımıyla entity seviyesinde atanacaktır. Keyfi değer verildiğinde ise sistem o değeri tarih olarak alacaktır. Bir araba için maksimum 5 resim ekleme kısıtı getirildi. Resim silme, güncelleme yetkileri eklendi. Data Access katmanı aracılığıyla

GetAllService() : Liste içerisindeki bütün araçları döndürmek,
GetById(int id) : Dışarıdan verilen bir ID ile ilişkili nesneyi döndürmektedir.
AddService(T entity) : Dışarıdan verilen bir nesnenin sisteme eklenmesi,
UpdateService(T entity) : Dışarıdan verilen bir nesnenin sistemdeki eşleşen ilanın güncellenmesi,
DeleteService(T entity) : Yine dışarıdan verilen bir nesne ile eşleşen ilanın silinmesi fonksiyonları gerçekleştirilmiştir. Fluent Validation ile yeni kısıtlamalar getirildi.

CONSOLEUI
Consolda bütün CRUD test işlemleri gerçekleştirilmektedir. Ayrıca GetCarDetails() ile farklı tablolarda bulunan CarName, BrandName, ColorName, DailyPrice bilgileri tabloların join edilmesi işlemi ile bir araya getirildi. Program.cs üzerinde yeni test operasyonları eklendi. Kiralama imkanı kod üzerinde gerçekleştirildi. Eğer araç ofis tarafından teslim alınmamışsa, yeni kiralama işlemi yapılması engellendi.

WEBAPI
Eklenen resimler API içerisindeki wwwroot içerisinde tutuldu. API aracılığyla resim ekleme işlemi gerçekleştirildi. WebAPI bölümü oluşturuldu. Business katmanındaki bütün servisler için API karşılığı getirildi.


![READı](https://user-images.githubusercontent.com/59285855/121585127-e5f6c200-ca3a-11eb-8a2b-a230dec6871e.PNG)

![2ı](https://user-images.githubusercontent.com/59285855/121585293-15a5ca00-ca3b-11eb-9824-9432e36292d1.PNG)

![3Alıntısı](https://user-images.githubusercontent.com/59285855/121585369-2d7d4e00-ca3b-11eb-8b62-8d17a9e0bceb.PNG)

![4Alıntısı](https://user-images.githubusercontent.com/59285855/121585394-353cf280-ca3b-11eb-8420-467e156d74ff.PNG)

![5Alıntısı](https://user-images.githubusercontent.com/59285855/121585492-543b8480-ca3b-11eb-8e7b-18ee1549829d.PNG)

![6Alıntısı](https://user-images.githubusercontent.com/59285855/121585553-63bacd80-ca3b-11eb-8739-9c9d39bd24e8.PNG)

![7Alıntısı](https://user-images.githubusercontent.com/59285855/121585721-91077b80-ca3b-11eb-995b-3d69a972036a.PNG)
