using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Tao.FreeGlut;
using Tao.OpenGl;

using System.Windows.Forms;
using Tao.Platform.Windows;
using System.Drawing;

namespace CG_3
{
    class Tools
    {

        public bool GlutInitilization(SimpleOpenGlControl anT)
        {
            try
            {                
                Glut.glutInit();
                Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
                // Setup Color!!!!!
                Gl.glClearColor(0,0,0,1);

                Gl.glViewport(0, 0, anT.Width, anT.Height);
                // настройка параллельной проекции
                Gl.glMatrixMode(Gl.GL_PROJECTION);
                Gl.glLoadIdentity();

                const double W = 7;
                double H = W * anT.Height / anT.Width;

                Gl.glOrtho(-W, W, -H, H, -200, 200);
                Gl.glMatrixMode(Gl.GL_MODELVIEW);
                Gl.glLoadIdentity();
                // настройка параметров OpenGL для визуализации
                Gl.glEnable(Gl.GL_DEPTH_TEST);
                Gl.glEnable(Gl.GL_COLOR_MATERIAL);
                Gl.glEnable(Gl.GL_LIGHTING);

                Gl.glEnable(Gl.GL_LIGHT0);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Render(SimpleOpenGlControl anT, Point ePoint,Cone cone)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glColor3f(1, 1, 1); // цвет фигуры - белый

            Gl.glPushMatrix();
            Gl.glTranslated(0, -1, -6);
            Gl.glRotated(((double)ePoint.X - anT.Height) * 180 / anT.Height, 0, 1, 0);
            Gl.glRotated(((double)ePoint.Y - anT.Width) * 180 / anT.Width, 1, 0, 0);
            Glut.glutSolidCone(cone.Radius, cone.Height,cone.Slices, 1);
            //Glut.glutSolidCube(5);
            Gl.glPopMatrix();
            Gl.glFlush();
            anT.Invalidate();
        }

        public void SetLight(Light light)
        {
            Gl.glEnable(Gl.GL_LIGHT0);
            float[] pos =
            {
                light.X,
                light.Y,
                light.Z,
                3
            };
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION,new float[]{light.X,light.Y,light.Z,3});
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, new float[] { light.Color.R / (float)255, light.Color.G / (float)255, light.Color.B / (float)255, 1 });
        }
    }
}
