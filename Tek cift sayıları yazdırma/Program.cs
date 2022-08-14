

Console.WriteLine("Lütfen bir sayı giriniz.");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
{
    Console.WriteLine("Çift bir sayı girdiniz " + number);
}
else
{
    Console.WriteLine("Tek bir sayı girdiniz " + number);
}


