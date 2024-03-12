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