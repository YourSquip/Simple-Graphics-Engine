using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphicsFinalBattle3
{
    class AffineTransform
    {
        public AffineTransform() { }
        public Matrix<double> GeneralView(double[,] eqsn, int size)
        {

            Matrix<double> matr = new Matrix<double>(4, size, eqsn);
            return matr;
        }
        public Matrix<double> IdenticalTransform()
        {
            double[,] transf = { { 1, 0, 0, 0}, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1} };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }

        public Matrix<double> Translation(double dx, double dy, double dz)
        {
            double[,] transf = { { 1, 0, 0, dx }, { 0, 1, 0, dy }, { 0, 0, 1, dz}, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }

        public void TranslationOnCoords(Matrix<double> vert, double x, double y, double z)
        {
            //vert = vert.Mul(Translation(0, 0, 0), vert);
            //vert = vert.Mul(Translation(x, y, z), vert);

        }
        public Matrix<double> RotationAroundOX(double angle)
        {
            double[,] transf =
                { { 1, 0, 0, 0 }, { 0, Math.Cos(angle), -Math.Sin(angle), 0 },
                { 0, Math.Sin(angle), Math.Cos(angle), 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }
        public Matrix<double> RotationAroundOY(double angle)
        {
            double[,] transf =
                { { Math.Cos(angle), 0, Math.Sin(angle), 0 }, { 0, 1, 0, 0 },
                { -Math.Sin(angle), 0,Math.Cos(angle), 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }
        public Matrix<double> RotationAroundOZ(double angle)
        {
            double[,] transf =
                { { Math.Cos(angle), -Math.Sin(angle),0, 0 }, { Math.Sin(angle), Math.Cos(angle), 0, 0 },
                { 0, 0,1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }

        public Matrix<double> RotationAroundPointOX(double x, double y, double z, double angle)
        {
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 },
                { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            matr = matr.Mul(Translation(x,y,z), matr);
            matr = matr.Mul(RotationAroundOX(angle), matr);
            matr = matr.Mul(Translation(-x, -y, z),matr);
            return matr;
        }
        public Matrix<double> RotationAroundPointOY(double x, double y, double z, double angle)
        {
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 },
                { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            matr = matr.Mul(Translation(x, y, z), matr);
            matr = matr.Mul(RotationAroundOY(angle), matr);
            matr = matr.Mul(Translation(-x, -y, z), matr);
            return matr;
        }

        public Matrix<double> RotationAroundPointOZ(double x, double y, double z, double angle)
        {
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 },
                { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            matr = matr.Mul(Translation(x, y, z), matr);
            matr = matr.Mul(RotationAroundOZ(angle), matr);
            matr = matr.Mul(Translation(-x, -y, z), matr);
            return matr;
        }

        public Matrix<double> Scaling(double kx, double ky, double kz)
        {
            double[,] transf = { { kx, 0, 0, 0 }, { 0, ky, 0, 0 },
                { 0, 0, kz, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }



        public Matrix<double> MappingArondX()
        {
            double[,] transf = { { 1, 0, 0, 0 }, { 0, -1, 0, 0 },
                { 0, 0, -1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }

        public Matrix<double> MappingArondY()
        {
            double[,] transf = { { -1, 0, 0, 0 }, { 0, 1, 0, 0 },
                { 0, 0, -1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }
        public Matrix<double> MappingArondZ()
        {
            double[,] transf = { { -1, 0, 0, 0 }, { 0, -1, 0, 0 },
                { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }

        public Matrix<double> MappingArondXZ()
        {
            double[,] transf = { { 1, 0, 0, 0 }, { 0, -1, 0, 0 },
                { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }
        public Matrix<double> MappingArondXY()
        {
            double[,] transf = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 },
                { 0, 0, -1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }

        public Matrix<double> MappingArondYZ()
        {
            double[,] transf = { { -1, 0, 0, 0 }, { 0, 1, 0, 0 },
                { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }

        public Matrix<double> MappingArondStartingPoint()
        {
            double[,] transf = { { -1, 0, 0, 0 }, { 0, -1, 0, 0 },
                { 0, 0, -1, 0 }, { 0, 0, 0, 1 } };
            Matrix<double> matr = new Matrix<double>(4, 4, transf);
            return matr;
        }


    }
}
