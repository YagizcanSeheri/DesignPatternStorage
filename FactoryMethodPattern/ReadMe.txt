Factory Method

-Bu desen nesne oluşturma ile ilgili yaratıcı bir tasarım modelidir. Fabrika modelinin mantığı, istemciye maruz bırakmadan nesne oluştururuz ve istemci yeni bir nesne türü oluşturmak için aynı ortak ara birimi kullanır.

-Nesne oluşturmak için bir ara birim tanımlayın, ancak alt sınıfların hangi sınıfı başlatacağına karar vermesine izin verin. Fabrika yöntemi bir sınıfn alt sınıflara örnek oluşturmayı ertelemesini sağlar. Diğer tasarım kalıpları yeni sınfılar gerektirirken, Fabrika yöntemi yanlızca yeni bir işlem gerektirir.

-Bu pattern yazılımda değişimi kontrol altında tutumak içinde kullanılır. Projenizde kullandığınız ORM mimarinizden değişkenlik gösterebilecek, farklı yapıların implemantasyonunu gerçekleştirecek bir yapıyı barındırır.

-Her bir Product alt sınıfları için bir fabrika sınıfı oluşturmak gereklidir. Bu oluşturulacak fabrika sınıfları ise türü interface veya abstract olan bir süper fabrika sınıfından türümelidir.

-Client sınıfına, bir abstract arayüz kullanmasını sağlayarak, gerçekte üretilecek ilişkili Product sınıflarını bilmeden veya önemsemeden oluşturulmasına olanak tanır.

-if-else yapısından kurtararak daha anlaşılır kod yazmayı sağlar.