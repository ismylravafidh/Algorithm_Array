int[] arrays = { 1, 4, 6, 5, 7, 8, 23, 42, 13 };
int sum  = 0;
for(int i = 0; i < arrays.Length; i++)
{
    if (arrays[i] % 2 == 1)
    {
        sum += arrays[i];
    }
}
Console.WriteLine(sum);