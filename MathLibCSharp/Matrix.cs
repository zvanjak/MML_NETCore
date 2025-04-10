using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MML
{
    public class Matrix
    {
        private int _rows, _cols;
        private double[,] _elems = null;

        public Matrix(int n, int m)
        {
          _rows = n;
          _cols = m;
          _elems = new double[n, m];
            
          for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                _elems[i, j] = 0.0;
        }

        public Matrix(int n, int m, double val)
        {
          _rows = n;
          _cols = m;
            _elems = new double[n, m];
            
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    _elems[i, j] = val;
        }

        public Matrix(Matrix b)
        {
            _elems = new double[b.Rows, b.Cols];

            for (int i = 0; i < b.Rows; i++)
                for (int j = 0; j < b.Cols; j++)
                    _elems[i, j] = b._elems[i,j];
        }

        static Matrix GetUnitMatrix(int dim)
        {
            Matrix unitMat = new Matrix(dim, dim);
            
            for( int i=0; i<dim; i++ )
                unitMat._elems[i, i] = 1.0;

            return unitMat;            
        }

        public int Rows { get => _rows; set => _rows = value; }
        public int Cols { get => _cols; set => _cols = value; }

        public double ElemAt(int i, int j) { return _elems[i, j]; }
        public void SetElemAt(int i, int j, double val) { _elems[i, j] = val; }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            // TODO check dimensions
            Matrix ret = new Matrix(a._rows, a._cols);

            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Cols; j++)
                    ret._elems[i, j] = a._elems[i,j] + b._elems[i,j];

            return ret;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            // TODO check dimensions
            Matrix ret = new Matrix(a._rows, a._cols);
            
            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Cols; j++)
                    ret._elems[i, j] = a._elems[i,j] - b._elems[i,j];

            return ret;
        }

        public static Matrix operator *(double a, Matrix b)
        {
            Matrix ret = new Matrix(b._rows, b._cols);

            for (int i = 0; i < b.Rows; i++)
                for (int j = 0; j < b.Cols; j++)
                    ret._elems[i, j] = a * b._elems[i,j];

            return ret;
        }

        public static Matrix operator *(Matrix a, double b)
        {
            Matrix ret = new Matrix(a._rows, a._cols);

            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Cols; j++)
                    ret._elems[i, j] = a._elems[i,j] * b; 

            return ret;
        }

        public static Matrix operator /(Matrix a, double b)
        {
            Matrix ret = new Matrix(a._rows, a._cols);

            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Cols; j++)
                    ret._elems[i, j] = a._elems[i,j] / b; 

            return ret;
        }

    }
}
