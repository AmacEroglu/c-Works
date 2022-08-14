
bool userData = true;
while (userData)
{
    Console.WriteLine("Lütfen bir değer giriniz");
    string deger = Console.ReadLine();
    if (deger == "")
    {
        userData = true;
        Console.WriteLine("Lütfen geçerli bir değer giriniz");
    }
    else
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(deger);
            userData = false;
        }
    }
}

