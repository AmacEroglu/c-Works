
int toplam = 0;
int sayi = 0;
int adet = 0;

Console.WriteLine("Kaç adet sayı toplamak istiyorsunuz?");
adet = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= adet; i++)
{
    Console.Write("Toplamak istediğiniz {0} sayıyı giriniz: ", i);
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;

}
Console.WriteLine("Girdiğiniz sayıların toplamı: {0}", toplam);

Console.ReadKey();

