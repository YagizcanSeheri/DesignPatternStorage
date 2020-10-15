
Builder Pattern

Karmaşık bir nesnenin özelliklerini gerçek yapısından ayırarak aynı yapım süreci içerisinde faklı temsiller yaratmaktır. Herhangi bir builder sınıfı bir soyut IBuilder nesnesinden kalıtım alır. Ayrıca düzenin mimarisi gereği temsilden yola çıkarak faklı türlerde ürünler ortaya koymaktadır. Directory'nin rolü builder sınıflarından oluşturulan türleri çağırmak, bir araya getirmek yada kullanmaktır. Client yani istemci belirli bir builder sınıfını yani üretmek istediği ürün tipine göre belirli bir directory için bir inşa edici yapıcı methot çağırmaktır. Directory builder interface'sinden kalıtılan parçaları bir araya getirmekle yükümlüdür.

Builder Pattern'da kullanılan mimarinin nesnelerin inceleyelim
1. IBuilder: Neyin inşa edileceğini tanımlayan bir arayüzdür. Üretilecek yada bir araya getirilecek ürünün nesnelerin uygulanması gerekir.
2. Builder: Concrete içerisinde barındıracağımız Builder sınıfı, ürün nesnelerimiz oluşturan nesnelerdir. Temsilci (delagate) baz alınacak farklı türler burada oluşturlur. Concrete klasörü altında bulundurulan builder nesneleri aynı temsilciye sahip farklı birer ürün oluşturulmasını sağlar.
3.Directory: Ürün oluşturulurken yani ürün oluşturulacak bileşenler bir araya getirilmesi için ihtiyaç duyulan işlemleri dizisini yütürüldüğü yer.
4.Delagate(Örnekte product sınıf): Yapım aşamasın da parçalara göre oluşturulacak ürünlerin baz aldığı sınıf.

Bu modele örnek vericek olursam fastfood restorantlarıdır. Bu restorantlarda farklı menü temsilcileri yani prototipelri var. Lakin her menü bir standarta dayanmaktadır. Örneğin buradan temsilciye bu örneği verebiliriz, Hamburge +Patates Kızartması+ İçecek gibi. Bu örnekte verdiğimiz temsilciden farklı ürünler yani menüler ürettiğimizde kullanabileceğimiz pattern builder'dır. Yani bir müşteri cheeseburger, tavuk yada et burger siparişi verebilir ve bu süreçteki yapılacak işlemler aynıdır. Tezgahta çalışan kişiler bir burger patates kızartması ve içecek hazırlayacaktır. Bu işlem herhangi bir şube için değişmemektedir. Son olarak bir temsil üzerinden farklı ürünler oluşturma düşüncesinden hareket edildiğini unutmayalım.