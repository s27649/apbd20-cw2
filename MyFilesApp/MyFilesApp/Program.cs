static double GetAverage(int[] numbers)
{
    int suma = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        suma += numbers[i];
        
    }

    return (double)suma / numbers.Length;
}

int[] numbers={1,2,3,4};
double average = GetAverage(numbers);
Console.WriteLine(average);


static int GetMax(int[] numbers)
{
    int max = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i]> max)
        {
           max=numbers[i];
        }
    }
    return max;
}

int[] numbers1={5,7,11,0};
int max = GetMax(numbers1);
Console.WriteLine(max);
