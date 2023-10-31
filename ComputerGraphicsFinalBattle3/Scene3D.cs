using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ComputerGraphicsFinalBattle3
{

    public class Scene3D
    {
        public Queue<Model3D> objects;
        public int transfChoice = 0;
        public Scene3D(int numOfModels)
        {
            objects = new Queue<Model3D>();
            //e = _e;
            //for (int i = 0; i < numOfModels; i++)
            //{
            //    Model3D model = new Model3D();
            //    objects.Enqueue(model);
            //}
            Model3D axises = new AxesXYZ();
            objects.Enqueue(axises);
            Model3D cube = new Model3D();
            objects.Enqueue(cube);
            
            

            
        }
        public void Render(PaintEventArgs _e)
        {

            foreach (Model3D model in objects)
            {
                model.ButtonApplyTransform(transfChoice);
                model.ApplyTransform();
                
                model.Project();
                model.Draw(_e);
            }
        }
    }

    
}
