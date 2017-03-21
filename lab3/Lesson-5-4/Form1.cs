using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows; 

namespace Lesson_5_4
{
    public partial class Form1 : Form
    {
        double ScreenW, ScreenH;

        private float devX;
        private float devY;

        private float[,] GrapValuesArray;
        private int elements_count = 0;
        double deg1 =1;
        double deg2 = 1; 
        private bool not_calculate = true;

        private int pointPosition = 0;

        float lineX, lineY;
        float Mcoord_X = 0, Mcoord_Y = 0; 

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void PointInGrap_Tick(object sender, EventArgs e)
        {
            if (pointPosition == elements_count - 1)
                pointPosition = 0;

            Draw();

            pointPosition++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();

            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);

            Gl.glClearColor(255, 255, 255, 1);

            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            if ((float)AnT.Width <= (float)AnT.Height)
            {
                ScreenW = 30.0;
                ScreenH = 30.0 * (float)AnT.Height / (float)AnT.Width;
                Gl.glOrtho(0.0, ScreenW, 0.0, ScreenH,100,-100);
            }
            else
            {
                ScreenW = 30.0 * (float)AnT.Width / (float)AnT.Height;
                ScreenH = 30.0;
                Gl.glOrtho(0.0, 30.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0,100, -100);
            }

            devX = (float)ScreenW / (float)AnT.Width;
            devY = (float)ScreenH / (float)AnT.Height;

            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            PointInGrap.Stop();
        }

        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            Mcoord_X = e.X;
            Mcoord_Y = e.Y;

            lineX = devX * e.X;
            lineY = (float)(ScreenH - devY * e.Y);
        }

        private void PrintText2D(float x, float y, string text)
        {
            Gl.glRasterPos2f(x, y);

            foreach (char char_for_draw in text)
            {
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_TIMES_ROMAN_10, char_for_draw);
            }
        }

        private void functionCalculation()
        {
            float x = 0, y = 0;

            GrapValuesArray = new float[300, 2];

            elements_count = 0;

            for (x = -15; x < 15; x += 0.1f)
            {
                y = 2*x;

                GrapValuesArray[elements_count, 0] = x;
                GrapValuesArray[elements_count, 1] = y;
                elements_count++;
            }
            not_calculate = false;
        }

       
        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);

            Gl.glPushMatrix();

            Gl.glTranslated(15, 15, 0);
            if(deg2 >= 360)
                deg2 = 1;

            Gl.glRotated(-deg2,0,0,1);
            deg2 += 2;
            Gl.glBegin(Gl.GL_POINTS);

            for (int ax = -15; ax < 15; ax++)
            {
                for (int bx = -15; bx < 15; bx++)
                {
                    Gl.glVertex2d(ax, bx);
                }
            }

            Gl.glEnd();
         
            Gl.glBegin(Gl.GL_LINES);

            Gl.glVertex2d(0, -15);
            Gl.glVertex2d(0, 15);

            Gl.glVertex2d(-15, 0);
            Gl.glVertex2d(15, 0);

            Gl.glVertex2d(0, 15);
            Gl.glVertex2d(0.1, 14.5);
            Gl.glVertex2d(0, 15);
            Gl.glVertex2d(-0.1, 14.5);

            Gl.glVertex2d(15, 0);
            Gl.glVertex2d(14.5, 0.1);
            Gl.glVertex2d(15, 0);
            Gl.glVertex2d(14.5, -0.1);

            Gl.glEnd();
            
            PrintText2D(15.5f, 0, "x");
            PrintText2D(0.5f, 14.5f, "y");
            PrintText2D(-1f, 14.5f, "15");
            PrintText2D(-1f, 10.0f, "10");
            PrintText2D(-1f, 5.0f, "5");
            PrintText2D(-1f, 1.0f, "0");
            PrintText2D(-1.5f, -5.0f, "-5");
            PrintText2D(-1.5f, -10.0f, "-10");
            PrintText2D(-1.5f, -15.0f, "-15");
            PrintText2D(-15.0f, -0.5f, "-15");
            PrintText2D(-10.0f, -0.5f, "-10");
            PrintText2D(-5.0f, -0.5f, "-5");
            PrintText2D(-1.0f, -0.5f, "0");
            PrintText2D(15.0f, -0.5f, "15");
            PrintText2D(10.0f, -0.5f, "10");
            PrintText2D(5.0f, -0.5f, "5");
            if (deg1 >= 360)
                deg1 = 1;

            Gl.glRotated(deg1, 0, 0, 1);
            deg1 += 1;
    

            Gl.glPopMatrix();
 
            PrintText2D(devX * Mcoord_X + 0.2f, (float)ScreenH - devY * Mcoord_Y + 0.4f, "[ x: " + (devX * Mcoord_X - 15).ToString() + " ; y: " + ((float)ScreenH - devY * Mcoord_Y - 15).ToString() + "]");

            Gl.glColor3f(255, 0, 0);

            Gl.glBegin(Gl.GL_LINES);

            Gl.glVertex2d(lineX, 15);
            Gl.glVertex2d(lineX, lineY);
            Gl.glVertex2d(15, lineY);
            Gl.glVertex2d(lineX, lineY);
            Gl.glEnd();

            Gl.glFlush();

            AnT.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointInGrap.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!PointInGrap.Enabled)
                PointInGrap.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                PointInGrap.Stop();
        } 
    }
}
