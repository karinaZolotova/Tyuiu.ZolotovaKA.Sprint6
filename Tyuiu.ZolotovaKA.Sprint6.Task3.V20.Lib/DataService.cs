using tyuiu.cources.programming.interfaces.Sprint3;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZolotovaKA.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию исходной матрицы
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            // Заменяем последнюю строку на нули
            for (int j = 0; j < cols; j++)
            {
                result[rows - 1, j] = 0;
            }

            return result;
        }
    }
}