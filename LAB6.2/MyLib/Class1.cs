namespace MyLib
{
    public class Matrix
    {
        public static double[] MasStrNegSum(double[,] mas)
        {
            double[] msns = new double[mas.GetLength(0)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                double x = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < 0)
                    {
                        x += mas[i, j];
                    }
                }
                msns[i] = x;
            }
            return msns;
        }
    }
}
