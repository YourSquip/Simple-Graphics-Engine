using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ComputerGraphicsFinalBattle3
{
    public partial class Form1 : Form
    {
        Matrix transform = new Matrix();
        AffineTransform affineTransform= new AffineTransform();
        Scene3D scene;

        int width, height;

        private int xCenterPrev = 642;
        private int yCenterPrev = 326;
        private int xCenterNew = 200;
        private int yCenterNew = 300;//200
        public Form1()
        {
            InitializeComponent();

            width = pictureBox1.Width;
            height = pictureBox1.Height;
            scene = new Scene3D(2);
            TranslationButton.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void TranslationButton_Click(object sender, EventArgs e)
        {
            
            if(textBox5.Text != "" && textBox6.Text !="" && textBox7.Text != "")
            {
                Model3D saveAxis = scene.objects.Dequeue();
                scene.objects.Peek().diffX = Convert.ToInt32(textBox5.Text);
                scene.objects.Peek().diffY = Convert.ToInt32(textBox6.Text);
                scene.objects.Peek().diffZ = Convert.ToInt32(textBox7.Text);
                scene.transfChoice = 1;
                Model3D saveObject = scene.objects.Dequeue();
                scene.objects.Enqueue(saveAxis);
                scene.objects.Enqueue(saveObject);
                pictureBox1.Invalidate();
            }
            
            //scene.objects.Last().diffX = 0;
            //scene.objects.Last().diffY = 0;
            //scene.objects.Last().diffZ = 0;
        }

        private void MappingXButton_Click(object sender, EventArgs e)
        {
            Model3D saveAxis = scene.objects.Dequeue();
            scene.transfChoice = 7;
            Model3D saveObject = scene.objects.Dequeue();
            scene.objects.Enqueue(saveAxis);
            scene.objects.Enqueue(saveObject);
            pictureBox1.Invalidate();

        }

        private void MappingYButton_Click(object sender, EventArgs e)
        {
            Model3D saveAxis = scene.objects.Dequeue();
            scene.transfChoice = 8;
            Model3D saveObject = scene.objects.Dequeue();
            scene.objects.Enqueue(saveAxis);
            scene.objects.Enqueue(saveObject);
            pictureBox1.Invalidate();
        }

        private void MappingZButton_Click(object sender, EventArgs e)
        {
            Model3D saveAxis = scene.objects.Dequeue();
            scene.transfChoice = 9;
            Model3D saveObject = scene.objects.Dequeue();
            scene.objects.Enqueue(saveAxis);
            scene.objects.Enqueue(saveObject);
            pictureBox1.Invalidate();
        }

        private void MappingXYButton_Click(object sender, EventArgs e)
        {
            Model3D saveAxis = scene.objects.Dequeue();
            scene.transfChoice = 10;
            Model3D saveObject = scene.objects.Dequeue();
            scene.objects.Enqueue(saveAxis);
            scene.objects.Enqueue(saveObject);
            pictureBox1.Invalidate();
        }

        private void MappingYZButton_Click(object sender, EventArgs e)
        {
            Model3D saveAxis = scene.objects.Dequeue();
            scene.transfChoice = 11;
            Model3D saveObject = scene.objects.Dequeue();
            scene.objects.Enqueue(saveAxis);
            scene.objects.Enqueue(saveObject);
            pictureBox1.Invalidate();
        }

        private void MappingXZButton_Click(object sender, EventArgs e)
        {
            Model3D saveAxis = scene.objects.Dequeue();
            scene.transfChoice = 12;
            Model3D saveObject = scene.objects.Dequeue();
            scene.objects.Enqueue(saveAxis);
            scene.objects.Enqueue(saveObject);
            pictureBox1.Invalidate();
        }

        private void MappingStartPointButton_Click(object sender, EventArgs e)
        {
            Model3D saveAxis = scene.objects.Dequeue();
            scene.transfChoice = 13;
            Model3D saveObject = scene.objects.Dequeue();
            scene.objects.Enqueue(saveAxis);
            scene.objects.Enqueue(saveObject);
            pictureBox1.Invalidate();
        }

        private void ScalingButton_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "" && textBox13.Text != "" && textBox12.Text != "")
            {
                Model3D saveAxis = scene.objects.Dequeue();
                scene.objects.Peek().scaleX = Convert.ToDouble(textBox14.Text);
                scene.objects.Peek().scaleY = Convert.ToDouble(textBox13.Text);
                scene.objects.Peek().scaleZ = Convert.ToDouble(textBox12.Text);
                scene.transfChoice = 6;
                Model3D saveObject = scene.objects.Dequeue();
                scene.objects.Enqueue(saveAxis);
                scene.objects.Enqueue(saveObject);
                pictureBox1.Invalidate();
            }
        }

        

        private void RotationOxButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                Model3D saveAxis = scene.objects.Dequeue();
                scene.objects.Peek().angleX = Convert.ToDouble(textBox1.Text);
                scene.transfChoice = 3;
                Model3D saveObject = scene.objects.Dequeue();
                scene.objects.Enqueue(saveAxis);
                scene.objects.Enqueue(saveObject);
                pictureBox1.Invalidate();
            }
            //timer.Stop();


        }

        private void RotationOyButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Model3D saveAxis = scene.objects.Dequeue();
                scene.objects.Peek().angleY = Convert.ToDouble(textBox1.Text);
                scene.transfChoice = 4;
                Model3D saveObject = scene.objects.Dequeue();
                scene.objects.Enqueue(saveAxis);
                scene.objects.Enqueue(saveObject);
                pictureBox1.Invalidate();
            }
        }

        private void RotationOzButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Model3D saveAxis = scene.objects.Dequeue();
                scene.objects.Peek().angleZ = Convert.ToDouble(textBox1.Text);
                scene.transfChoice = 5;
                Model3D saveObject = scene.objects.Dequeue();
                scene.objects.Enqueue(saveAxis);
                scene.objects.Enqueue(saveObject);
                pictureBox1.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Model3D saveAxis = scene.objects.Dequeue();
                scene.objects.Peek().angleZ = Convert.ToDouble(textBox1.Text);
                scene.transfChoice = 14;
                Model3D saveObject = scene.objects.Dequeue();
                scene.objects.Enqueue(saveAxis);
                scene.objects.Enqueue(saveObject);
                pictureBox1.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Model3D saveAxis = scene.objects.Dequeue();
                scene.objects.Peek().angleY = Convert.ToDouble(textBox1.Text);
                scene.transfChoice = 15;
                Model3D saveObject = scene.objects.Dequeue();
                scene.objects.Enqueue(saveAxis);
                scene.objects.Enqueue(saveObject);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(xCenterNew, yCenterNew);
            e.Graphics.ScaleTransform(1, -1);
            transform = e.Graphics.Transform;

            //Pen pen = new Pen(Color.Aquamarine, 2);
            //e.Graphics.DrawLine(pen,0,);

            scene.Render(e);
        }
    }
}
