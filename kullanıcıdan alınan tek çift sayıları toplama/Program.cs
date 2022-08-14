
Console.WriteLine("Lütfen bir sayı giriniz");

int number = Convert.ToInt32(Console.ReadLine());
int cift = 0;
int tek = 0;

for (int i = 0; i < number; i++)
{
    if (i %2 == 0)
    {
        cift += i;
    }
    else
    {
        tek += i;

    }

}

Console.WriteLine("Çift sayıların toplamı " + cift);
Console.WriteLine("Tek sayıların toplamı " + tek);

