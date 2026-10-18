* ### 1- Sınıf ile nesne farkı nedir?

    Sınıf, nesnelerin özelliklerini ve davranışlarını tanımlayan bir şablondur.Nesne ise bu    sınıftan oluşturulan somut bir örnektir.
    Örneğin Member bir sınıftır. new Member() ile oluşturduğumuz ve Name özelliğine "Ayşe Yılmaz" değerini atadığımız üye kaydı ise bir nesnedir.

* ### 2- Parametreli constructor yazınca new Member() neden kırılır? Çözüm nedir?
    sınıf ilk oluşturulduğunda görünmeyen bir boş contructor oluşur. new Member() ile bu constructor çağrılır. Ancak ilgili sınıf içerisinde parametreli constructor oluşrulduğunda default oluşturulan constructor geçersiz kılınır ve new Member içerisine parametre girilmesi istenir veya parametreli contructor ile birlikte parametresiz bir contructor oluşturulabilir.
* ### 3- Book : LibraryItem ne demek? Member : IIdentifiable neden miras değildir?
    Book class'ı LibraryItem class'ının özelliklerini miras aldığı anlamına gelir.
    IIdentifiable burada class değil interface'dir. Interface'ler miras alınmaz. Implements edilir. interface içerisindeki methodlar override edilir.
* ### 4- BudgetTracker'deki string[20] + sayaç ile List<Member> farkı nedir?
    Aradaki temel fark verilerin nasil saklandigi ve yonetildigidir. string[20] 20 adet string veri tutulabilecegini belirtir. List collection tipidir. Ayni tipteki birden fazla veriyi tutabilir. dinamiktir.
* ### 5- List ne zaman, Dictionary ne zaman kullanılır? Id ile tek üye getirmek için hangisi?
    List tek tip veri tutmak istedigimizde dictionary 2 tip veriyi key value olarak tutmak istedigimizde kullaniriz. Id ile uye getirmek istedigimizde dictionary kullaniriz. key'in unique olma ozelligi ile key'i unique Id olarak tanimlariz. value'u de uyenin bilgileri olarak tanimlariz. Bu sekilde key ile Id aramasini kullanip tek uye getirebiliriz.  
* ### 6- LibraryService içindeki _members neden private?
    private access modifier alanin sadece class icerisinde erisim izninin verildigini belirten tiptir. encapsulation icin kullanilir. Ilgili alana getter setter methodlari uzerinden erisim ve kontrol saglanir.
* ### 7- BudgetService ile LibraryService birbirine nasıl benzer? (Kısa paragraf)

* ### 8- void Display() ile string GetSummary() farkı nedir?
 donus tipi farklidir. void metodun bir sey dondurmeyecegini belirtir. void yerine string yazdigimizda metodun string bir deger return edecegi anlamina gelir.
