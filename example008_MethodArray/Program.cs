int[] array = { 19, 52, 73, 44, 50, 65, 77, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}