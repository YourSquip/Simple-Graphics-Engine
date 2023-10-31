using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace ComputerGraphicsFinalBattle3
{
   
    public class Model3D
    {
        public double[] P = { 0, 600, 1200 };/*= { -1200, 1200, 1200 };*/
        //public double[] Pl = { -1200, 600, 0 };
        //public double[] Pr = { 0, 600, 1200 };


        public int x=0, xPrev = 0;
        public int y = 0, yPrev = 0;
        public int z = 0, zPrev = 0;


        protected int k_vertices;
        protected int k_edges;
        protected int k_faces;

        public Matrix<double> vertices;
        public Matrix<double> normals;
        public Matrix<double> pointOfView;

        public Matrix<double> BeforeProjectionVertices;
        //public Matrix<double> BeforeProjectionNormals;
        //public Matrix<double> BeforeProjectionPointOfView;
        protected Matrix<int> edges;
        protected Matrix<int> faces;

        public double diffX = 0;
        public double diffY = 0;
        public double diffZ = 0;

        public double allDiffX = 0;
        public double allDiffY = 0;
        public double allDiffZ = 0;

        public double scaleX=1, scaleY=1, scaleZ = 1;
        public double angleX=0, angleY=0, angleZ = 0;


        public double angleSavedX = 0, angleSavedY = 0, angleSavedZ = 0;


        protected PointF[] points;
        Pen pen;
        public bool zeroZ = false;
        public bool zeroY = false;
        public bool zeroX = false;

        public  Model3D()//cube
        {
            k_vertices = 8;
            k_edges = 12;
            k_faces = 6;

            double[,] vert =
               {{0,3,3,0,0,3,3,0},
                {0,0,0,0,3,3,3,3 },
                { 0,0,3,3,0,0,3,3},
                { 1,1,1,1,1,1,1,1}};
            double[,] norm =
               {{0,0,3,-3,0,0},
                {3,-3,0,0,0,0},
                { 0,0,0,0,3,-3},
                { 1,1,1,1,1,1}};
            double[,] pointView = { { -60 }, { 75 }, { 60 }, { 1 } };
            double[,] edgs = { {0,1 }, {0,3 }, {0,4 }, { 1,2}, { 1,5}, { 2,3}, { 2,6}, { 3,7}, { 4,5}, {4,7 }, { 6,5}, { 6,7} };
            vertices = new Matrix<double>(4,k_vertices, vert);
            normals = new Matrix<double>(4, 6, norm);
            pointOfView = new Matrix<double>(4, 1, pointView);
            edges = new Matrix<int>(k_edges, 2);
            faces = new Matrix<int>(k_faces, 3);

            pen = new Pen(Color.Black, 1);
            AffineTransform affineTransform = new AffineTransform();
            vertices = vertices.Mul(affineTransform.Scaling(20, 20, 20), vertices);
            normals = normals.Mul(affineTransform.Scaling(20, 20, 20), normals);
            pointOfView = pointOfView.Mul(affineTransform.Scaling(20, 20, 20), pointOfView);

            BeforeProjectionVertices = vertices;
            //BeforeProjectionNormals = normals;
            //BeforeProjectionPointOfView = pointOfView;
            
        }


        public virtual void Draw(PaintEventArgs e)
        {
            points = new PointF[k_vertices];
            for (int i = 0; i < k_vertices; i++)
            {
                PointF point1 = new PointF((float)vertices.get_elem(0, i), (float)vertices.get_elem(1, i));
                points[i] = point1;
            }
            

            e.Graphics.DrawLine(pen, points[0], points[1]);
            e.Graphics.DrawLine(pen, points[0], points[3]);
            e.Graphics.DrawLine(pen, points[0], points[4]);
            e.Graphics.DrawLine(pen, points[1], points[2]);
            e.Graphics.DrawLine(pen, points[1], points[5]);
            e.Graphics.DrawLine(pen, points[2], points[3]);
            e.Graphics.DrawLine(pen, points[2], points[6]);
            e.Graphics.DrawLine(pen, points[3], points[7]);
            e.Graphics.DrawLine(pen, points[4], points[5]);
            e.Graphics.DrawLine(pen, points[4], points[7]);
            e.Graphics.DrawLine(pen, points[6], points[5]);
            e.Graphics.DrawLine(pen, points[6], points[7]);


            PointF[] sideDown = { points[0], points[1], points[2], points[3] };
            PointF[] sideUp = { points[4], points[5], points[6], points[7] };
            PointF[] sideBack = { points[1], points[2], points[6], points[5] };
            PointF[] sideFront = { points[0], points[4], points[7], points[3] };
            PointF[] sideLeft = { points[0], points[1], points[5], points[4] };
            PointF[] sideRight = { points[3], points[2], points[6], points[7] };
            SolidBrush cyanBrush = new SolidBrush(Color.Cyan);
            SolidBrush coralBrush = new SolidBrush(Color.Coral);
            SolidBrush greenBrush = new SolidBrush(Color.GreenYellow);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush brownBrush = new SolidBrush(Color.Chocolate);
            SolidBrush crimsonBrush = new SolidBrush(Color.Crimson);

            //double[] POV = { -1200, 1500, 1200 };
            double[] POV = { pointOfView.get_X(0), pointOfView.get_Y(0), pointOfView.get_elem(2, 0) };

            if (normals.get_elem(0, 0) * (POV[0]) + normals.get_elem(2, 0) * (POV[2]) + normals.get_elem(1, 0) * (POV[1]) + normals.get_elem(0, 0) * vertices.get_elem(0, 3)/*/2*/ + normals.get_elem(1, 0) * vertices.get_elem(1, 3) + normals.get_elem(2, 0) * vertices.get_elem(2, 3)/*/2*/ <= 0)
            {
                e.Graphics.FillPolygon(brownBrush, sideDown);
                e.Graphics.DrawPolygon(pen, sideDown);
            }
            else
            {
                e.Graphics.FillPolygon(yellowBrush, sideUp);
                e.Graphics.DrawPolygon(pen, sideUp);
            }
            if (normals.get_elem(0, 2) * (POV[0]) + normals.get_elem(2, 2) * (POV[2]) + normals.get_elem(1, 2) * (POV[1]) + normals.get_elem(0, 2) * vertices.get_elem(0, 3) /*/ 2*/ + normals.get_elem(1, 2) * vertices.get_elem(1, 3) + normals.get_elem(2, 2) * vertices.get_elem(2, 3)  /*/ 2*/ <= 0)
            {
                e.Graphics.FillPolygon(greenBrush, sideFront);
                e.Graphics.DrawPolygon(pen, sideFront);
            }
            else
            {
                e.Graphics.FillPolygon(crimsonBrush, sideBack);
                e.Graphics.DrawPolygon(pen, sideBack);
            }

            if (normals.get_elem(0, 4) * (POV[0]) + normals.get_elem(2, 4) * (POV[2]) + normals.get_elem(1, 4) * (POV[1]) + normals.get_elem(0, 4) * vertices.get_elem(0, 2)  /*/ 2*/ + normals.get_elem(1, 4) * vertices.get_elem(1, 2) + normals.get_elem(2, 4) * vertices.get_elem(2, 2) /*/ 2*/ <= 0)
            {
                e.Graphics.FillPolygon(cyanBrush, sideLeft);
                e.Graphics.DrawPolygon(pen, sideLeft);
            }
            else
            {
                e.Graphics.FillPolygon(coralBrush, sideRight);
                e.Graphics.DrawPolygon(pen, sideRight);
            }

            //if (normals.get_elem(2, 0) * (1200) + normals.get_elem(1, 0)* (1200) + normals.get_elem(0, 0) * (-1200) + normals.get_elem(0, 0) * vertices.get_elem(0, 3)/*/2*/ + normals.get_elem(1, 0) * vertices.get_elem(1, 3) + normals.get_elem(2, 0) * vertices.get_elem(2, 3)/*/2*/ <= 0)
            //{
            //    e.Graphics.FillPolygon(brownBrush, sideDown);
            //    e.Graphics.DrawPolygon(pen, sideDown);
            //}
            //else
            //{
            //    e.Graphics.FillPolygon(yellowBrush, sideUp);
            //    e.Graphics.DrawPolygon(pen, sideUp);
            //}



        }

        public virtual void ApplyTransform()
        {
            vertices = BeforeProjectionVertices;

            
            Projection projection = new Projection();
            //vertices = vertices.Mul(projection.AxonometricXYBack((Math.PI) / 4), vertices);

            //vertices = vertices.Mul(affineTransform.Translation(diffX,diffY,diffZ), vertices);
            //affineTransform.TranslationOnCoords(vertices,x, y, z);
            //vertices = vertices.Mul(affineTransform.RotationAroundOX(angle), vertices);
            //vertices = vertices.Mul(affineTransform.Scaling(4, 4, 4), vertices);
            //vertices = vertices.Mul(affineTransform.MappingArondStartingPoint(), vertices);
            //vertices = vertices.Mul(affineTransform.RotationAroundOX((Math.PI) / 4), vertices);
            //vertices = vertices.Mul(affineTransform.RotationAroundOZ((Math.PI) / 6), vertices);
            //vertices = vertices.Mul(affineTransform.RotationAroundOX((Math.PI) / 4), vertices);

            BeforeProjectionVertices = vertices;
        }

        public virtual void ButtonApplyTransform(int choice)
        {

            AffineTransform affineTransform = new AffineTransform();
            switch (choice)
            {
                case 1://Translation
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        //pointOfView = BeforeProjectionPointOfView;
                        vertices = vertices.Mul(affineTransform.Translation(diffX, diffY, diffZ), vertices);
                        normals = normals.Mul(affineTransform.Translation(diffX, diffY, diffZ), normals);
                        //pointOfView = pointOfView.Mul(affineTransform.Scaling(10,10,10), pointOfView);
                        allDiffX += diffX;
                        allDiffY += diffY;
                        allDiffZ += diffZ;
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        //BeforeProjectionPointOfView = pointOfView;
                        break;
                    }
                case 2://TranslationOnCoords
                    {
                        vertices = BeforeProjectionVertices;//OUT OF ORDER
                        //normals = BeforeProjectionNormals;
                        affineTransform.TranslationOnCoords(vertices,x, y, z);
                        affineTransform.TranslationOnCoords(normals, x, y, z);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 3://RotationAroundOX
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.RotationAroundOX(angleX), vertices);
                        normals = normals.Mul(affineTransform.RotationAroundOX(angleX), normals);
                        if (angleSavedX>=Math.PI*2)
                        {
                            angleSavedX -= Math.PI*2;
                        }
                        else
                        {
                            angleSavedX += angleX;
                        }
                        
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 4://RotationAroundOY
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.RotationAroundOY(angleY), vertices);
                        normals = normals.Mul(affineTransform.RotationAroundOY(angleY), normals);
                        if (angleSavedY >= Math.PI * 2)
                        {
                            angleSavedY -= Math.PI * 2;
                        }
                        else
                        {
                            angleSavedY += angleY;
                        }
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 5://RotationAroundOZ
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.RotationAroundOZ(angleZ), vertices);
                        normals = normals.Mul(affineTransform.RotationAroundOZ(angleZ), normals);
                        if (angleSavedZ >= Math.PI * 2)
                        {
                            angleSavedZ -= Math.PI * 2;
                        }
                        else
                        {
                            angleSavedZ += angleZ;
                        }
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 6://Scaling
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.Scaling(scaleX, scaleY, scaleZ), vertices);
                        normals = normals.Mul(affineTransform.Scaling(scaleX, scaleY, scaleZ), normals);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 7://MappingArondX
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.MappingArondX(), vertices);
                        normals = normals.Mul(affineTransform.MappingArondX(), normals);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 8://MappingArondY
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.MappingArondY(), vertices);
                        normals = normals.Mul(affineTransform.MappingArondY(), normals);
                        BeforeProjectionVertices = vertices;
                       // BeforeProjectionNormals = normals;
                        break;
                    }
                case 9://MappingArondZ
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.MappingArondZ(), vertices);
                        normals = normals.Mul(affineTransform.MappingArondZ(), normals);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 10://MappingArondXY
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.MappingArondXY(), vertices);
                        normals = normals.Mul(affineTransform.MappingArondXY(), normals);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 11://MappingArondYZ
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.MappingArondYZ(), vertices);
                        normals = normals.Mul(affineTransform.MappingArondYZ(), normals);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 12://MappingArondXZ
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.MappingArondXZ(), vertices);
                        normals = normals.Mul(affineTransform.MappingArondXZ(), normals);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 13://MappingArondStart
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.MappingArondStartingPoint(), vertices);
                        normals = normals.Mul(affineTransform.MappingArondStartingPoint(), normals);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 14:
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.Translation(-4/3,0,0), vertices);
                        vertices = vertices.Mul(affineTransform.RotationAroundOY(-(Math.PI)/4), vertices);
                        vertices = vertices.Mul(affineTransform.RotationAroundOZ(angleZ), vertices);
                        vertices = vertices.Mul(affineTransform.RotationAroundOY((Math.PI) / 4), vertices);
                        vertices = vertices.Mul(affineTransform.Translation(4/3, 0, 0), vertices);
                        //vertices = vertices.Mul(affineTransform.MappingArondStartingPoint(), vertices);
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
                case 15:
                    {
                        vertices = BeforeProjectionVertices;
                        //normals = BeforeProjectionNormals;
                        vertices = vertices.Mul(affineTransform.Translation(-(vertices.get_elem(0,0)), -(vertices.get_elem(1, 0)), -(vertices.get_elem(2, 0))), vertices);
                        normals = normals.Mul(affineTransform.Translation(-(vertices.get_elem(0, 0)), -(vertices.get_elem(1, 0)), -(vertices.get_elem(2, 0))), normals);

                        double turnedSide = Math.Sqrt(Math.Pow((vertices.get_elem(0, 2) - vertices.get_elem(0, 1)), 2) + Math.Pow((vertices.get_elem(1, 2) - vertices.get_elem(1, 1)), 2));
                        double heightSide = Math.Sqrt(Math.Pow((vertices.get_elem(0, 6) - vertices.get_elem(0, 2)), 2) + Math.Pow(vertices.get_elem(1, 6) - vertices.get_elem(1, 2), 2));
                        vertices = vertices.Mul(affineTransform.RotationAroundOX(-angleSavedX), vertices);
                        normals = normals.Mul(affineTransform.RotationAroundOX(-angleSavedX), normals);
                        vertices = vertices.Mul(affineTransform.RotationAroundOZ(-angleSavedZ), vertices);
                        normals = normals.Mul(affineTransform.RotationAroundOZ(-angleSavedZ), normals);
                        vertices = vertices.Mul(affineTransform.RotationAroundOY(angleY), vertices);
                        normals = normals.Mul(affineTransform.RotationAroundOY(angleY), normals);
                        vertices = vertices.Mul(affineTransform.RotationAroundOZ(angleSavedZ), vertices);
                        normals = normals.Mul(affineTransform.RotationAroundOZ(angleSavedZ), normals);
                        vertices = vertices.Mul(affineTransform.RotationAroundOX(angleSavedX), vertices);
                        normals = normals.Mul(affineTransform.RotationAroundOX(angleSavedX), normals);
                        vertices = vertices.Mul(affineTransform.Translation((BeforeProjectionVertices.get_elem(0, 0)), (BeforeProjectionVertices.get_elem(1, 0)), (BeforeProjectionVertices.get_elem(2, 0))), vertices);
                        normals = normals.Mul(affineTransform.Translation((BeforeProjectionVertices.get_elem(0, 0)), (BeforeProjectionVertices.get_elem(1, 0)), (BeforeProjectionVertices.get_elem(2, 0))), normals);
                        ////vertices = vertices.Mul(affineTransform.MappingArondStartingPoint(), vertices);
                        ///allDiffX += diffX;
                        allDiffY += diffY;
                        allDiffZ += diffZ;
                        BeforeProjectionVertices = vertices;
                        //BeforeProjectionNormals = normals;
                        break;
                    }
            }


        }

        public void Project()
        {
            Projection projection = new Projection();
            //vertices = vertices.Mul(projection.OrthographicViewXY(), vertices);
            //vertices = vertices.Mul(projection.AxonometricXY((Math.PI)/4), vertices);
            //vertices = vertices.Mul(projection.AxonometricXZ((Math.PI) / 3), vertices);
            vertices = vertices.Mul(projection.AxonometricXY((Math.PI) / 4), vertices);
            //normals = normals.Mul(projection.AxonometricXY((Math.PI) / 4), normals);

        }


    }
    public class Line : Model3D
    {
        public Line() 
        {
            k_vertices = 2;
            k_edges = 1;
            k_faces = 0;

            double[,] vert =
               {{0,1},
                {0,0},
                {-4,-3},
                { 1,1}};
            double[,] edgs = { { 0, 1 } };
            vertices = new Matrix<double>(4, k_vertices, vert);
            edges = new Matrix<int>(k_edges, 2);
            faces = new Matrix<int>(k_faces, 3);
            AffineTransform affineTransform = new AffineTransform();
            vertices = vertices.Mul(affineTransform.Scaling(20, 20, 20), vertices);

            BeforeProjectionVertices = vertices;
        }

        public override void Draw(PaintEventArgs e)
        {
            points = new PointF[k_vertices];
            for (int i = 0; i < k_vertices; i++)
            {
                PointF point1 = new PointF((float)vertices.get_elem(0, i), (float)vertices.get_elem(1, i));
                points[i] = point1;
            }

            Pen aquamarinePen = new Pen(Color.Aquamarine, 2);
            
            e.Graphics.DrawLine(aquamarinePen, points[0], points[1]);

        }

        public override void ApplyTransform()
        {
            vertices = BeforeProjectionVertices;
            //vertices = vertices.Mul(affineTransform.Scaling(20, 20, 20), vertices);
            //vertices = vertices.Mul(affineTransform.RotationAroundOY((Math.PI)*1.5), vertices);
            //vertices = vertices.Mul(affineTransform.RotationAroundOX((Math.PI) / 6), vertices);
            //vertices = vertices.Mul(affineTransform.RotationAroundOX((Math.PI) / 4), vertices);
            BeforeProjectionVertices = vertices;
        }
        public override void ButtonApplyTransform(int choice)
        {

            AffineTransform affineTransform = new AffineTransform();


        }

    }

    public class AxesXYZ: Model3D
    { 
        public AxesXYZ()
        {
            k_vertices = 6;
            k_edges = 4;
            k_faces = 0;

            double[,] vert =
               {{0,30,0,0, 0, 100},
                {0,0,30,0, 0,0},
                { 0,0,0,30, -4, 296},
                { 1,1,1,1 ,1,1} };
            double[,] edgs = { { 0, 1 }, { 0, 2 }, { 0, 3 } };
            vertices = new Matrix<double>(4, k_vertices, vert);
            edges = new Matrix<int>(k_edges, 2);
            faces = new Matrix<int>(k_faces, 3);
            AffineTransform affineTransform = new AffineTransform();
            vertices = vertices.Mul(affineTransform.Scaling(20, 20, 20), vertices);

            BeforeProjectionVertices = vertices;
        }

        public override void Draw(PaintEventArgs e)
        {
            points = new PointF[k_vertices];
            for (int i = 0; i < k_vertices; i++)
            {
                PointF point1 = new PointF((float)vertices.get_elem(0, i), (float)vertices.get_elem(1, i));
                points[i] = point1;
            }

            Pen bluePen = new Pen(Color.Blue, 2);
            Pen greenPen = new Pen(Color.Green, 2);
            Pen redPen = new Pen(Color.Red, 2);
            Pen aquamarinePen = new Pen(Color.Aquamarine, 2);

            e.Graphics.DrawLine(aquamarinePen, points[4], points[5]);
            e.Graphics.DrawLine(bluePen, points[0], points[1]);
            e.Graphics.DrawLine(greenPen, points[0], points[2]);
            e.Graphics.DrawLine(redPen, points[0], points[3]);
        }

        public override void ApplyTransform() 
        {
            vertices = BeforeProjectionVertices;
            
            //vertices = vertices.Mul(affineTransform.RotationAroundOY((Math.PI)*1.5), vertices);
            //vertices = vertices.Mul(affineTransform.RotationAroundOX((Math.PI) / 6), vertices);
            //vertices = vertices.Mul(affineTransform.RotationAroundOX((Math.PI) / 4), vertices);
            BeforeProjectionVertices = vertices;
        }
        public override void ButtonApplyTransform(int choice)
        {

            AffineTransform affineTransform = new AffineTransform();


        }
    }

}
