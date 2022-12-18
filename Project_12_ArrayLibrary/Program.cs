// See https://aka.ms/new-console-template for more information

void FillArray(int[collection])
{
    int length = CollectionExtensions.Length;
    int index = 0;
    while (index < length)
    {
        Collection[index]=new Random().Next(1,10);
        index++;
    }
}



