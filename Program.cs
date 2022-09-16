string[] input = new string[] {"hello", "2", "world", ":-)"};
string[] array1 = new string[input.Length]; 

int count = 0; // счетчик
for (int i = 0; i < input.Length; i++)
{
    if(input[i].Length <= 3)
    {
        array1[count] = input[i];
        count++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array1);
