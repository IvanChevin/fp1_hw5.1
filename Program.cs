string[] array = new string[4] { "hello", "2", "world", ":=)" };

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

string[] array2 = new string[array.Length];
for (int i = 0, j = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        array2[j] = array[i]; j++;

}

for (int i = 0; i < array2.Length; i++)
{
    Console.Write($"{array2[i]} ");
}
