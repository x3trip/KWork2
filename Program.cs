string[] CreatArray(int size)
{
    string[] array = new string[size];  
    for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент массива ({i+1}/{size}) >: ");
            array[i] = Console.ReadLine();
        }
    return array;
}    

void WriteArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

string[] NewArray(string[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            n++;
        }
    }
    string[] res = new string[n];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            res[j] = array[i];
            j++;
        }
    }
    return res;
}

Console.Write("введите размер массива ");
int num2 = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreatArray(num2);
WriteArray(myArray);
string[] res = NewArray(myArray);
WriteArray(res);
