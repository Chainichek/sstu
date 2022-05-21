using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryRelations
{
    class Reflexive
    {
        public static bool is_reflexive(int[,] matrix)//проверка рефлексивности
        {
            for (int i = 0, j = 0; i < matrix.GetLength(0); i++, j++)
            {
                if (matrix[i, j] == 0)
                    return false;
            }

            return true;
        }
        public static bool is_antireflexive(int[,] matrix)//проверка антирефлексивности
        {
            for (int i = 0, j = 0; i < matrix.GetLength(0); i++, j++)
            {
                if (matrix[i, j] == 1)
                    return false;
            }

            return true;
        }
        public static void make_reflexive(ref int[,] matrix)//приведение ссылки на матрицу к рефлексивности
        {
            for (int i = 0, j = 0; i < matrix.GetLength(0); i++, j++)
            {
                matrix[i, j] = 1;
            }
        }
        public static void make_antireflexive(ref int[,] matrix)//приведение ссылки на матрицу к антирефлексивности
        {
            for (int i = 0, j = 0; i < matrix.GetLength(0); i++, j++)
            {
                matrix[i, j] = 0;
            }
        }
    }

    class Symmetry
    {
        public static bool is_asymmetry(int[,] matrix) => Reflexive.is_antireflexive(matrix);
        public static bool is_antisymmetry(int[,] matrix) => Reflexive.is_reflexive(matrix);//проверка на антисимместричность
        public static bool is_symmetry(int[,] matrix)//проверка на симметричность
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] != matrix[j, i])
                        return false;
            return true;
        }
        public static void make_symmetry(ref int[,] matrix)////приведение ссылки на матрицу к симметричности
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = matrix[j, i];
        }
        public static void make_antisymmetry(ref int[,] matrix) => Reflexive.make_reflexive(ref matrix);//приведение ссылки на матрицу к антисимметричности
        public static void make_asymmetry(ref int[,] matrix) => Reflexive.make_antireflexive(ref matrix);//приведение ссылки на матрицу к ассиметричности
    }

    class Transitivity
    {
        public static bool is_transitive(int[,] matrix)//проверка транзитивности
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j || matrix[i, j] == 0) continue;//пропуск дальнейших действий для всех несуществующих дуг для матрицы смежности

                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (k != j)
                            if (!(matrix[i, k] != 0 && matrix[i, k] == matrix[j, k]))
                                /*если при проходе по столбцам нашлось k отличное от j, что не равно 0 и существует такой элемент и параллельный ему, не равные 0
                                причём оный находится на j строке, то транзитивность выполняется. Если хотя бы где-то нет - то не выполняется*/
                                return false;
                    }
                }
            return true;
        }

        public static void make_transitive(ref int[,] matrix)//приведение ссылки на матрицу к рефлексивности
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j || matrix[i, j] == 0) continue;

                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (k != j && matrix[i, k] != 0)
                            matrix[j, k] = matrix[i, k];
                    }
                }
        }
    }
}
