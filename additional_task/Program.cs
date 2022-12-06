Console.Clear();
int[] array = {2, 23, 12, 5, 6, 34, 77, 3, 99, 5};
int N = array.Length;
int sum = 0;
int i = 0;
int max = 0;

while (i < N)
{
    if (i == 0)
        sum = array[i] + array[i+1] + array[N-1];
    else if (i > 0 && i < N-1)
        sum = array[i] + array[i-1] + array[i+1];
    else 
        sum = array[i] + array[0] + array[i-1];

    if(sum > max)
    {
        max = sum;
    }
    i ++;
}
Console.WriteLine(max);
        
