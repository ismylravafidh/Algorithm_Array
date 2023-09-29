string n="ATA";
int j = 0;
int poli=0;
for(int i = n.Length-1; i>(n.Length - 1)/2; i--)
{
    if (n[i] == n[j])
    {
        poli++;
    }
    else
    {
        poli *= 0;
    }
    j++;
}
if (poli== n.Length / 2)
{
    Console.WriteLine("Verilmis Soz Polindromdur");
}
else
{
    Console.WriteLine("Verilmis Soz Polindrom deyil");
}