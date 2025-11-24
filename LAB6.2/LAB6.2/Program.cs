try
{
    Random rand = new Random();
    double[,] mas = new double[7, 5];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = rand.Next(-9, 10);
            Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Массив суммы отрицательных элементов строк страницы: ");
    double[] mas1 = MyLib.Matrix.MasStrNegSum(mas);
    for (int i = 0; i < mas1.GetLength(0); i++)
    {
        Console.Write(mas1[i] + " ");
    }
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);

}
