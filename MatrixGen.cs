using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binaryRelations;

namespace matrixGen
{
    class Generate
    {
        private Random randomgen = new Random();
        public int[,] matrixGenerate(int N)//Возвращает готовую матрицу, принимает размер и опции
        {
            int[,] matrix = randomGenerate(N);
            matrix = randomOptions(matrix);
            return matrix;
        }
        private int[,] randomGenerate(int N)//Случайно заполняет биннарную матрицу. Возвращает матрицу
        {
            int[,] temp = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    temp[i, j] = randomgen.Next(2);
            return temp;
        }
        private int[,] randomOptions(int[,] matrix)//Возвращает матрицу, имеющую указанные свойства
        {
            if (randomgen.Next(2) == 1)
            {
                Symmetry.make_symmetry(ref matrix);//Симметрия первой, чтобы не сохранять значения параметров тут

                if (randomgen.Next(2) == 1)
                    Reflexive.make_reflexive(ref matrix);
                else if (randomgen.Next(2) == 1)
                    Reflexive.make_antireflexive(ref matrix);
            }
            else
            {
                if (randomgen.Next(2) == 1)
                {
                    Reflexive.make_reflexive(ref matrix);
                    Symmetry.make_antisymmetry(ref matrix);
                }
                else if (randomgen.Next(2) == 1)
                {
                    Reflexive.make_antireflexive(ref matrix);
                    Symmetry.make_asymmetry(ref matrix);
                }
            }

            if (randomgen.Next(2) == 1)
                Transitivity.make_transitive(ref matrix);
            return matrix;
        }
    }
}