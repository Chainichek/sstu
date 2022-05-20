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
        public int[,] matrixGenerate(int N, Options options)//Возвращает готовую матрицу, принимает размер и опции
        {
            int[,] matrix = randomGenerate(N);
            matrix = useOptions(matrix, options);

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
        private int[,] useOptions(int[,] matrix, Options options)//Возвращает матрицу, имеющую указанные свойства
        {
            if (options.reflexive)
                Reflexive.make_reflexive(ref matrix);
            if (options.antireflexive)
                Reflexive.make_antireflexive(ref matrix);

            if (options.symmetry)
                Symmetry.make_symmetry(ref matrix);
            if (options.asymmetry)
                Symmetry.make_asymmetry(ref matrix);
            if (options.antisymmetry)
                Symmetry.make_antisymmetry(ref matrix);

            if (options.transitivie)
                Transitivity.make_transitive(ref matrix);
            return matrix;
        }
    }
    class Options
    {
        public bool reflexive;
        public bool antireflexive;
        public bool symmetry;
        public bool asymmetry;
        public bool antisymmetry;
        public bool transitivie;

        private Random randombool = new Random();

        public void randomize_options()
        {
            //рефлексивность и антирефлексивность
            if (randombool.Next(2) == 0)
            {
                reflexive = false;

                antireflexive = randombool.Next(2) == 0 ? false : true;
            }
            else
            {
                reflexive = true;
                antireflexive = false;
            }
            //симметричность, асимметричность, антисимместричность
            if (randombool.Next(2) == 0)
            {
                symmetry = false;

                asymmetry = reflexive ? false : true;
                antisymmetry = asymmetry ? false : true;

            }
            else
            {
                symmetry = true;
                asymmetry = false;
                antisymmetry = false;
            }
            //транзитивность
            transitivie = randombool.Next(2) == 0 ? false : true;
        }

    }
}
