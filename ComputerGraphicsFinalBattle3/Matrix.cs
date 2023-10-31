using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphicsFinalBattle3
{
    public class Matrix<T> where T : struct
    {
        int m, n; //rows, columns
        T[,] matrix;
        public Matrix() //конструктор по умолчанию
        {
            m = 0;
            n = 0;
            //! no new
        }
        public Matrix(Matrix<T> matr) // конструктор копирования
        {
            m = matr.m;
            n = matr.n;
            matrix = new T[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = matr.matrix[i, j];
                }
            }
        }
        public Matrix(int _m, int _n) // создание нулевой матрицы
        {
            m = _m;
            n = _n;
            matrix = new T[m, n];
        }
        public Matrix(int _m, int n, T zero_elem) // создание нулевой матрицы
        {
            m = _m;
            matrix = new T[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = zero_elem;
                }
            }
        }
        public Matrix(int _m, int _n, T[,] matr)
        {
            m = _m;
            n = _n;
            matrix = new T[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = matr[i, j];
                }
            }
        }

        public int get_m() { return m; }
        public int get_n() { return n; }

        public T get_elem(int i, int j) { return matrix[i, j]; }

        public void set_elem(int i, int j, T elem) { matrix[i, j] = elem; }
        public T get_X(int index) { return matrix[0, index]; }//!
        public T get_Y(int index) { return matrix[1, index]; }//!
        public string print()
        {
            string str = "";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    str += Convert.ToString(matrix[i, j]) + ' ';
                }
                str += "\n";
            }
            return str;
        }
        //public static Matrix<int> Add(Matrix<int> matr1, Matrix<int> matr2)
        //{
        //    if (matr1.m == matr2.m && matr1.n == matr2.n)
        //    {
        //        Matrix<int> matr = new Matrix<int>(matr1.m, matr1.n);
        //        for (int i = 0; i < matr.m; i++)
        //        {
        //            for (int j = 0; j < matr.n; j++)
        //            {
        //                matr.matrix[i, j] = matr1.matrix[i, j] + matr2.matrix[i, j];
        //            }
        //        }
        //        return matr;
        //    }
        //    else return null;


        //}
        public Matrix<double> Add(Matrix<double> matr1, Matrix<double> matr2)
        {

            if (matr1.m == matr2.m && matr1.n == matr2.n)
            {
                Matrix<double> matr = new Matrix<double>(matr1.m, matr1.n);
                for (int i = 0; i < matr.m; i++)
                {
                    for (int j = 0; j < matr.n; j++)
                    {
                        matr.matrix[i, j] = matr1.matrix[i, j] + matr2.matrix[i, j];
                    }
                }
                return matr;
            }
            else return null;


        }

        public Matrix<double> Sub(Matrix<double> matr1, Matrix<double> matr2)
        {
            if (matr1.m == matr2.m && matr1.n == matr2.n)
            {
                Matrix<double> matr = new Matrix<double>(matr1.m, matr1.n);
                for (int i = 0; i < matr.m; i++)
                {
                    for (int j = 0; j < matr.n; j++)
                    {
                        matr.matrix[i, j] = matr1.matrix[i, j] - matr2.matrix[i, j];
                    }
                }
                return matr;
            }
            else return null;
        }
        public Matrix<int> Sub(Matrix<int> matr1, Matrix<int> matr2)
        {
            if (matr1.m == matr2.m && matr1.n == matr2.n)
            {
                Matrix<int> matr = new Matrix<int>(matr1.m, matr1.n);
                for (int i = 0; i < matr.m; i++)
                {
                    for (int j = 0; j < matr.n; j++)
                    {
                        matr.matrix[i, j] = matr1.matrix[i, j] - matr2.matrix[i, j];
                    }
                }
                return matr;
            }
            else return null;
        }

        public Matrix<double> Mul(Matrix<double> matr1, Matrix<double> matr2)
        {
            if (matr1.n == matr2.m)
            {
                Matrix<double> matr = new Matrix<double>(matr1.m, matr2.n);

                for (int i = 0; i < matr.n; i++)
                {
                    for (int j = 0; j < matr.m; j++)
                    {
                        matr.matrix[j, i] = 0;
                        double temp = 0;
                        for (int k = 0; k < matr2.m; k++)
                        {
                            temp += matr1.matrix[j, k] * matr2.matrix[k, i];
                        }
                        matr.matrix[j, i] = temp;
                    }
                }
                return matr;
            }
            else return null;

        }

        public Matrix<int> Mul(Matrix<int> matr1, Matrix<int> matr2)
        {
            if (matr1.n == matr2.m)
            {
                Matrix<int> matr = new Matrix<int>(matr1.m, matr2.n);

                for (int i = 0; i < matr.n; i++)
                {
                    for (int j = 0; j < matr.m; j++)
                    {
                        matr.matrix[j, i] = 0;
                        int temp = 0;
                        for (int k = 0; k < matr2.m; k++)
                        {
                            temp += matr1.matrix[j, k] * matr2.matrix[k, i];
                        }
                        matr.matrix[j, i] = temp;
                    }
                }
                return matr;
            }
            else return null;
        }






    }
}
