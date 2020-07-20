# SurveyApplication

 Asp.Net Core Web Application (MVC) kullanılarak geliştirilmiş bir anket projesidir.
 
## Ön Şartlar

- Bilgisayarınıza [.NET Core](https://www.microsoft.com/net/download/core) kurun.
- Bilgisayarınıza [MsSql(LocalDB)](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15) kurun.

## Kurulum

- Bu depoyu `SurveyApplication` klasöründe klonlayın.
- Solution içerisinde yer alan `SurveyApplication.SurveyDb.MvcWebUI`ı başlangıç projesi olarak ayarlayın.(Proje seçeneklerinden Set as Startup Project)
- `SurveyApplication.SurveyDb.MvcWebUI` içerisinde yer alan package.json dosyasındaki paketleri tekrar yükleyin.(Dosya seçeneklerinden Restore Packages)
- Son olarak, test verileri ile projeyi çalıştırmak isterseniz `SurveyApplication.SurveyDb.DataAccess\Concrete\EntityFramework\SurveyDbContext.cs` içerisinde yer alan `SetInitializer'i` aktifleştirin. (Test verileri `SurveyDBInitializer` içerisinde yer almaktadır)

## SurveyApplication Kullanımı

## SurveyApplication'a Katkıda Bulunmak

## Katkıda Bulunanlar

* [@ugurcansoruc](https://github.com/ugurcansoruc)

## İletişim

Eğer benimle iletişime geçmek isterseniz bana <ugurcan.soruc@gmail.com> adresinden ulaşabilirsiniz.

## Lisans
Bu proje bu lisansı kullanmaktadır: [<MIT>](<https://github.com/ugurcansoruc/SurveyApplication/blob/master/LICENSE>).
