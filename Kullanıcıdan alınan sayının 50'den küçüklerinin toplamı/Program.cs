
int toplam = 0;
int sayi = 0;
Console.WriteLine("Lütfen 10 farklı sayı giriniz. ");
   
    for (int i = 1; i <= 10; i++)
    {
        Console.Write("{0}. sayıyı girin: ", i);
        sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi < 50)
    {
        toplam += sayi;
    }
    }
Console.WriteLine("50'den küçük sayıların toplamı: {0} ", toplam);




Console.ReadKey();