

string[] names = { "Amaç", "Ali", "Veli" };
char harf;

bool secildiMi = false;

Console.WriteLine("Aradığınız kişi için bir harf girin: ");
harf = Convert.ToChar(Console.ReadLine());

for (int i = 0; i < names.Length; i++)
{
    if (names[i][0]==harf)
    {
        Console.WriteLine(names[i]);
        secildiMi = true;
    }
    if(!secildiMi)
    {
        Console.WriteLine("Aradığınız isim bulunamadı.");
        secildiMi=true;
    }
}