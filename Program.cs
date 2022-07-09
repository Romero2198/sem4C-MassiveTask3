int [] randomArray = new int [8];

for(int index = 0; index < randomArray.Length; index++)
{
    randomArray[index] = new Random().Next(0,100);
}
PrintArray(randomArray);

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
