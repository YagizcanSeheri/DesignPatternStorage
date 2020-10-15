Singleton Design Pattern

-Tasarım desenleri arasında creational grubuna ait en popüler desendir. Uluslar arası standartlarda %80 kullanım oranına sahiptir. Esas amaç her daim nesnenin kullanım süresini boyunca bir nesnenin bir kez oluşturulması ve oluşturulan bu nesnenin defalarca faklı konumlarda kullanılması sağlamaktadır.

-Bir nesne örneğinden sadece bir kere üretilip, o nesnenin örnekleminin her zaman kullanılamasını önermektedir. Örneğin, katmanlı mimaride katmanlar arasında bir nesne örnekleminnin ilgili katmanlar arasında geçerken sadece işlem yapıyorsa yani üzerinde bir değeri tutmak gibi bir görevi yoksa singleton ile üretilebilir. Somut bir örnek vermek gerekirse Business Katmanındaki tutulabilecek ve CRUD operasyonlarında kullanılabilecek bir nesne örneklemine ihtiyaç duyulduğunda ilgili nesne singleton ile üretilebilir. Bir nesnenin durumunun kontrol edilmesinide temin etmektedir. Örneğin nesne üretiminde nesnenin kendi içerisinde belirli bir şart koşmak istediğimizde kullanabiliriz.

-Ne zaman kullanmamalıyız, singleton ile bir nesne ürettiğimizde bu ürettiğimiz nesne her zaman RAM'in heap alanında ISS restart edilinceye kadar yaşar buda bizim için maliyet demektir. Bu yüzden singleton kullanarak nesne ürettirken dikkatli olmak gerekir. 

-Singleton ile nesne üretirken kendimize şu soruyu sormalıyız. Ben singleton ile nesne ürettiğimde bu nesneyi herkes çok sık bir şekilde kullanacak mı? Cevap evet ise üret değilse üretme.

-Bir başka mekanizmaya kontrollü erişmek istediğimizde, kontrol kapsamında singleton obje yaratabiliriz. Bu işlem muhakkak concrete sınıf içerisinde yapmalıyız. Bu desen sınıfın yanlızca bir kez başaltılmasını ve tüm isteklerin bu obje üzerinden yönlendirilmesi prensibine dayanır. Singleton deseninde instancesi alınan sınıftan yararlanan diğer sınıflar değil, sınıfın kendisi kısıtlmaların sağlanmasından sorumludur.

-Örneğin ay sonu maaş bordolarını hesaplamak için kullanılan bir nesnemiz var ve bu nesneyi sadece muhassebe biriminden bir kişi çağrıyor, bu senaryoda bu nesnenin örneklemini singleton ile üretmemeliyiz.
