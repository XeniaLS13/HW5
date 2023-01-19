int[] GetArray()
{
    int number = Random.Shared.Next(5, 10);
    int[] arr = new int[number];
    return arr;
}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(10);
    }
}
string PrintArray(int[] prinArray)
{
    string output = String.Empty;
    int size = prinArray.Length;
    for (int i = 0; i < size; i++)
    {
        output = output + $"{prinArray[i]} ";
    }
    return output;
}
int[] CountProduct(int[] collection)
{
    int[] arrayProd = new int [collection.Length/2];
    for (int i = 0; i < collection.Length/2; i++)
    {
        arrayProd[i] = collection[i] * collection[collection.Length - 1 - i];
    }
    return arrayProd;
}
int[] arr = GetArray();
FillArray(arr);
string Print = PrintArray(arr);
Console.WriteLine(Print);
int[] newArr = CountProduct(arr);
string newPrint = PrintArray(newArr);
Console.WriteLine(newPrint);
