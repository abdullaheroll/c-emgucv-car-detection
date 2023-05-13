using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
namespace EmguCvCarDec
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
   
            VideoCapture capture = new VideoCapture(@"C:\Users\abdul\Downloads\Video\video2.mp4");

            // Video oynatıldığı sürece devam edecek bir döngü
                
            while (true)
            {
                // Bir sonraki video karesini yakalayalım
                Mat frame = capture.QueryFrame();

                // Eğer video sona erdiyse döngüden çık
                if (frame == null)
                    break;

                // Kareden araçları tespit etmek için gerekli işlemleri yapalım

                // Örneğin, araçları tespit etmek için HaarCascade sınıfını kullanabiliriz
                using (CascadeClassifier carDetector = new CascadeClassifier("haarcascade_car.xml"))
                {
                    // Kareden araçları tespit etmek için sınıflandırıcıyı kullanalım
                    Rectangle[] carRectangles = carDetector.DetectMultiScale(frame, 1.09, 5, new Size(30, 30), new Size(200, 200));


                    // Tespit edilen araç sayısını ekrana yazdıralım
                    Console.WriteLine("Tespit edilen araç sayısı: " + carRectangles.Length);

                    // Kareden tespit edilen araçları çizelim
                    foreach (Rectangle carRectangle in carRectangles)
                    {
                        CvInvoke.Rectangle(frame, carRectangle, new Bgr(Color.Violet).MCvScalar, 1);
                    }
                }

                // Kareyi ekrana gösterelim
                CvInvoke.Imshow("Araç Tespiti", frame);
                CvInvoke.WaitKey(1); // Bir tuşa basılmasını bekleyelim
            }

            // Video oynatma işlemi tamamlandığında kaynakları serbest bırakalım
            capture.Dispose();
            CvInvoke.DestroyAllWindows();

        }
    }
}
