# Design Patterns 


Eric Gamma, Richard Helm, Ralph Johnson ve John Vlissides 1995’te “Design Patterns : Elements of Reusable Object – Oriented Software” kitabını çıkarttılar. 
Kitaplarında 3 kategoride 23 farklı kalıba yer vermişlerdir.

**Creational**:
Nesneleri yaratmakta kullanılan 5 adet tasarım kalıbı vardır.Yazılım sistemindeki nesnelerin yaratılışı hakkında yol gösterirler.

-Factory Method Pattern: Oluşturmak istediğimiz sınıfın kendisinden bir örnek istemek yerine Factory Metod patterni sayesinde tek bir instance üzerinden gerekli nesnenin üretilmesini sağlamaktır.

-Singleton Design Pattern: Singleton tasarım kalıbı, bir sınıfın tek bir örneğini almak için kullanılır.Amaç oluşturulan nesneye global erişim noktası sağlamaktır.

-Abstract Factory Design Pattern: Factory design pattern’de tek bir ürün ailesine ait tek bir arayüz mevcutken,abstract factory’de farklı ürün aileleri için farklı arayüzler mevcuttur.
Fabrika olarak düşünürsek, Factory Design Pattern sadece tek bir ürünün üretildiği fabrika, Abstract Factory Design Pattern ise farklı farklı ürünlerin üretildiği fabrika olarak düşünebiliriz.Product'ları yaratan fabrika sınıfından somut nesne yaratma işlemini çıkarmak istiyorsak, bu tasarım desenini kullanmak gereklidir. Ayrıca temel fabrika deseninde bulunan if-else yapısından da kurtulmak istiyorsanız soyut fabrika tasarım desenini kullanabilirsiniz.


-Builder

-Prototype

**Structural**:
Nesneler arasındaki yapıları ifade eden ilişkilerden 7 adet tasarım kalıbı vardır

-Adapter Pattern: Adaptör kalıp sadece bir class özel olan arayüzleri diğer sınıflarla uyumlu arayüzler haline getirir. Adaptörler uyumlu olmayan arayüzler sebebiyle birbirleri ile çalışamayan sınıflara da birbirleri ile çalışma imkanı sunarlar.

-Bridge Pattern: Bir sınıfın arayüzünü implementasyonundan ayırmak için kullanılır. Böylece her iki yapıda birbirinden bağımsız olarak değişebilir. Bu yapı kendi içerisinde başka bir yapının daha oluşturulmasına izin veren ve bu iç yapının değişikliğe uğramasıyla client’ların hiç bir şekilde etkilenmemesini garanti altına alan bir yapı bizlere sunmaktadır.

-Composite Pattern: Kendi içlerinde birbirlerinden farklı olan bir grup nesnenin sanki tek bir bütün nesneymiş gibi kullanılmasını bileşik kalıp sağlar. Bileşik kalıpların görevi, nesneleri bir ağaç yapısında birleştirip uygulamanın genelindeki parça bütün ilişkisini yeniden düzenleyip şekillendirmektir.

-Decorator Pattern

-Facade Pattern

-Flyweight Pattern

-Proxy Pattern


**Behavioral**:

Nesnelerin çalışma zamanına ait davranışlarını değiştirmek için oluşturulan tasarımlardan 11 adet tasarım kalıbı vardır.

-Iterator Design Pattern

-Observer Design Pattern

-Chain of Responsibility Design Pattern

-Interpreter Design Pattern

-Command Design Pattern

-Memento Design Pattern

-Mediator Design Pattern

-State Design Pattern

-Template Method Design Pattern: Sıralı operasyonları içeren fonksiyonellikleri ilgilendirmektedir.Code Reusability noktasında bir çözüm gerekliliği ortaya çıkmaktadır.Bir algoritmanın sıralı parçalarını oluşturan operasyonlardan değişime açık olanlarının Sub Classes'larda implemente edilmek suretiyle ele alınmasını öngeren bir desendir.

-Strategy Design Pattern

-Visitor Design Pattern
