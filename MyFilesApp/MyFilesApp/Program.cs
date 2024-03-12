static double GetAverage(int[] numbers)
{
    int suma = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        suma += numbers[i];
        
    }

    return (double)suma / numbers.Length;
}