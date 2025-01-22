using System;

namespace DaireKonsol
{
    class KullaniciGirdi
    {
        public int YaricapGirdi()
        {
            Console.Write("Yarıçap değerini girin: ");
            if (int.TryParse(Console.ReadLine(), out int yaricap) && yaricap > 0)
            {
                return yaricap;
            }
            
            Console.WriteLine("Geçersiz değer. Lütfen sıfırdan büyük bir sayı giriniz.");
            return YaricapGirdi();
        }
    }
    
    class DaireCizim
    {
        public void DaireCiz(int yaricap)
        {
            for (int y = -yaricap; y <= yaricap; y++)
            {
                for (int x = -yaricap; x <= yaricap; x++)
                {
                    if (DaireAlan(x, y, yaricap))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        private bool DaireAlan(int x, int y, int yaricap)
        {
            double yaricapUzak = Math.Sqrt(x * x + y * y);
            return Math.Abs(yaricapUzak - yaricap) < 0.5;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var kullaniciGirdi = new KullaniciGirdi();
            var daireCizim = new DaireCizim();
            
            int yaricap = kullaniciGirdi.YaricapGirdi();
            daireCizim.DaireCiz(yaricap);
            
            Console.WriteLine("\nDaire çizimi tamamlandı.");
        }
    }
}