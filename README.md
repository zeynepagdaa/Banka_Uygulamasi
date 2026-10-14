
Proje, veritabanı veya dosya sistemi kullanılmadan tamamen bellek (RAM) üzerinde `List` ve `Array` yapıları ile çalışmaktadır.

## 🚀 Temel Özellikler

- **Müşteri Yönetimi:** Benzersiz müşteri numaraları ile **Ticari** ve **Bireysel** olmak üzere iki farklı müşteri tipi eklenebilmektedir.
- **Hesap İşlemleri:** Bir müşteriye birden fazla benzersiz hesap numarasına sahip hesap açılabilir. Yalnızca bakiyesi 0 TL olan hesaplar kapatılabilmektedir.
- **Finansal İşlemler:**
  - **Para Yatırma & Çekme:** Günlük maksimum 750 TL para çekme limiti bulunmaktadır. Bakiye yetersizliğinde ek hesap devreye girmektedir.
  - **Havale:** Havale işlemleri yalnızca kayıtlı hesaplara yapılabilmektedir. Bireysel müşterilerden %2 havale komisyonu kesilirken, ticari müşterilerden kesinti yapılmamaktadır.
- **Raporlama:**
  - **Gelir-Gider Raporu:** Bankanın toplam nakit akışı ve mevcut durumu Grid bileşeni üzerinde görüntülenir.
  - **Hesap Özeti:** İstenen tarih aralığında, hesap bazlı detaylı işlem (para yatırma, çekme, gönderici/alıcı bilgisiyle havale) dökümleri listelenir.

## 🛠️ Mimari ve Teknik Altyapı

Projede **Nesne Yönelimli Programlama** prensipleri aktif olarak kullanılmıştır:

- **Çok Biçimlilik (Polymorphism) & Soyutlama (Abstraction):** Bireysel ve ticari müşteriler arasındaki havale ücreti gibi kural farklılıkları, `abstract` sınıflar ve çok biçimlilik özellikleri ile tasarlanmıştır.
- **Kullanıcı Arayüzü (GUI):** Formlar üzerinde `Panel` ve `TabControl` (`PageControl`) gibi gruplama bileşenleri kullanılmış, kullanıcı deneyimi için `Tab-Order` düzeni optimize edilmiştir.
- **Veri Doğrulama (Validation):** Form alanlarında boş değer geçilmesi engellenmiş ve maksimum uzunluk kontrolleri sağlanmıştır.

