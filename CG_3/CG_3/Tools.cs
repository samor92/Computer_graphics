using System;
using System.Drawing;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace CG_3
{
    internal class Tools
    {
        public bool GlutInitilization(SimpleOpenGlControl anT)
        {
            try
            {
                Glut.glutInit();
                Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
                // Setup background
                Gl.glClearColor(0, 0, 0, 1);

                Gl.glViewport(0, 0, anT.Width, anT.Height);
                // настройка параллельной проекции
                Gl.glMatrixMode(Gl.GL_PROJECTION);
                Gl.glLoadIdentity();

                const double w = 7;
                double h = w*anT.Height/anT.Width;

                Gl.glOrtho(-w, w, -h, h, -200, 200);
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

        public int Render(SimpleOpenGlControl anT, Point ePoint, Cone cone)
        {
            try
            {
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

                Gl.glLoadIdentity();
                Gl.glColor3f(1, 1, 1); // цвет фигуры - белый

                Gl.glPushMatrix();
                Gl.glTranslated(0, -1, -6);
                Gl.glRotated(((double) ePoint.X - anT.Height)*180/anT.Height, 0, 1, 0);
                Gl.glRotated(((double) ePoint.Y - anT.Width)*180/anT.Width, 1, 0, 0);
                Glut.glutSolidCone(cone.Radius, cone.Height, cone.Slices, 1);
                Gl.glPopMatrix();
                Gl.glFlush();
                anT.Invalidate();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int SetLight(Light light)
        {
            try
            {
                Gl.glEnable(Gl.GL_LIGHT0);
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, new float[] { light.X, light.Y, light.Z, 3 });
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE,
                    new[] { light.Color.R / (float)255, light.Color.G / (float)255, light.Color.B / (float)255, 1 });
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}