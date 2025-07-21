//1.İstifadəçi ay adı daxil edəcək, daxil olunan ayın günlərinin sayını ekrana çıxaran alqoritmi yazın(Məsələn: input "October", output 31)

Console.Write("Enter month :");
string month = Console.ReadLine();
switch (month)
{
    case "January" or "March" or "May" or "July":
    case "August" or "October" or "December":
        Console.WriteLine(31);
        break;
    case "April" or "June" or "September" or "July" or "November":
        Console.WriteLine(30);
        break;
    case "February":
        Console.WriteLine(28);
        break;
}

//2. 1 ile 100 araligindaki cüt ededlerin cemini tapan algorithm 

int sum = 0;

for (int i = 0; i < 100; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }

}
Console.WriteLine(sum);

//3. Verilmish ededin sade ve ya murekkeb oldugunu tapan alqoritm: Misal input 25 output "Murekkebdir"

Console.Write("Enter number :");
int num = int.Parse(Console.ReadLine());
int count = 0;

if (num<2)
{
    Console.WriteLine("Ne sade, ne murekkebdir");
    return;
}
for (int i = 1; num >= i; i++)
{
 
    if (num % i == 0)
    {
        count++;
    }

}
switch (count)
{
    case 2 : Console.WriteLine("Sadedir");
        break;
    default:
        Console.WriteLine("Murekkebdir");
        break;
}

