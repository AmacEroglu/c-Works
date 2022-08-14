
int total = 0;
Console.WriteLine("Lütfen bir sayı girin.");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= number; i++)
{
    total += i;
    Console.WriteLine("Kullanıcıdan alınan değer " + total);
}


Console.ReadLine();