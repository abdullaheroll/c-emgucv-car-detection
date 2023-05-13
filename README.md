# Emgu.Cv Car Detection
Proje Tanımı: Araç Tespit Sistemi

Bu proje, görüntü işleme ve yapay zeka tekniklerini kullanarak bir video dosyasındaki araçları tespit etmek için geliştirilmiş bir uygulamayı içermektedir. Proje, C# programlama dili ve Emgu.CV kütüphanesi kullanılarak gerçekleştirilmiştir.

Kullanılan Dil: C#
Proje, C# programlama dilinde geliştirilmiştir. C#, .NET platformunda geniş bir kullanıcı tabanına sahip olan ve Windows Forms uygulamaları oluşturmak için sıklıkla tercih edilen bir dildir.

Kullanılan Kütüphane: Emgu.CV
Emgu.CV (Emgu Computer Vision), .NET platformunda OpenCV (Açık Kaynak Bilgisayar Görüşü Kütüphanesi)'yi kullanmak için bir arayüz sağlayan bir kütüphanedir. Bu proje, Emgu.CV kütüphanesini kullanarak araç tespiti işlemlerini gerçekleştirmektedir. Emgu.CV, görüntü işleme ve video analizi gibi pek çok temel bilgisayar görüşü görevini desteklemektedir.

Kullanılan Model: Haar Cascade
Araç tespiti için Haar Cascade sınıflandırıcı modeli kullanılmıştır. Haar Cascade, OpenCV'nin bir parçası olan bir nesne tespit yöntemidir. Bu yöntem, belirli bir nesnenin görüntüsündeki özellikleri tanımlayan önceden eğitilmiş bir modeldir. Proje, "haarcascade_car.xml" adlı bir Haar Cascade modelini kullanarak araçları tespit etmektedir.

Proje, belirtilen video dosyasını okuyarak her kare üzerinde araç tespiti yapar. Tespit edilen araçların sayısını hesaplar ve sonuçları kullanıcıya bildirir. Ayrıca, tespit edilen araçları çerçeve üzerinde görsel olarak işaretler.

Bu proje, görüntü işleme, nesne tespiti ve yapay zeka konularına ilgi duyanlar için temel bir örnek teşkil etmektedir. Geliştirme sürecinde Emgu.CV kütüphanesinin güçlü özelliklerinden yararlanılarak, kolayca araç tespiti yapabilen bir uygulama oluşturulmuştur.
