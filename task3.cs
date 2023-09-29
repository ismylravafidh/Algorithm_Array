int[] arrays = { 1, 2, 4, 7, 3, 9, 12, 3, 8, 11 };
int sum = 0;
Console.Write("{ ");
for (int i  = 0; i  < arrays.Length;i++)
{
    if (i % 2 == 1)
    {
        Console.Write(arrays[i] +" ");
        sum += arrays[i];
    }
}
Console.Write("} => " + sum);