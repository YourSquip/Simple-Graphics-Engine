using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphicsFinalBattle3
{
    public class Projection
    {
        public Projection() { }

        public Matrix<double> OrthographicViewYZ()
        {
            double[,] transf = { { 0, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }
        public Matrix<double> OrthographicViewXZ()
        {
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }
        public Matrix<double> OrthographicViewXY()
        {
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }

        public Matrix<double> AxonometricXY(double angle)
        {
            AffineTransform affineTransform = new AffineTransform();
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            matr = matr.Mul(affineTransform.RotationAroundOY(angle), matr);
            matr = matr.Mul(affineTransform.RotationAroundOX(angle), matr);
            matr = matr.Mul(OrthographicViewXY(), matr);
            return matr;
        }

        public Matrix<double> AxonometricXYBack(double angle)
        {
            AffineTransform affineTransform = new AffineTransform();
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            matr = matr.Mul(affineTransform.RotationAroundOY(-angle), matr);
            matr = matr.Mul(affineTransform.RotationAroundOX(-angle), matr);
            //matr = matr.Mul(OrthographicViewXY(), matr);
            return matr;
        }

        public Matrix<double> AxonometricXZ(double angle)
        {
            AffineTransform affineTransform = new AffineTransform();
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            matr = matr.Mul(affineTransform.RotationAroundOZ(angle), matr);
            matr = matr.Mul(affineTransform.RotationAroundOX(angle), matr);
            matr = matr.Mul(OrthographicViewXZ(), matr);
            return matr;
        }

        public Matrix<double> AxonometricYZ(double angle)
        {
            AffineTransform affineTransform = new AffineTransform();
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            matr = matr.Mul(affineTransform.RotationAroundOZ(angle), matr);
            matr = matr.Mul(affineTransform.RotationAroundOY(angle), matr);
            matr = matr.Mul(OrthographicViewYZ(), matr);
            return matr;
        }
    }
}
