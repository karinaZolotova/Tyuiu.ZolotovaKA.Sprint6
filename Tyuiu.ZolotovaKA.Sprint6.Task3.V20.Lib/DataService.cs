using tyuiu.cources.programming.interfaces.Sprint3;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZolotovaKA.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Создаем копию исходной матрицы
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            // Копируем исходную матрицу
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            return result;
        }
    }
}