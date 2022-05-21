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
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] != 1)
                    return false;
            }

            return true;
        }
        public static bool is_antireflexive(int[,] matrix)//проверка антирефлексивности
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] != 0)
                    return false;
            }

            return true;
        }
        public static void make_reflexive(ref int[,] matrix)//приведение ссылки на матрицу к рефлексивности
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, i] = 1;
            }
        }
        public static void make_antireflexive(ref int[,] matrix)//приведение ссылки на матрицу к антирефлексивности
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, i] = 0;
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
                    //Будет ли графы с 1 дугой транзитивны?
                    //if (i == j) continue; 

                    int temp = 0;
                    for (int k = 0; k < matrix.GetLength(0); k++)
                        temp += matrix[i, k]  * matrix[j, k];
                    if (temp > 0) temp = 1;

                    if (temp > matrix[i, j]) return false;
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
