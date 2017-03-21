using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace lab2_StopWatch
{
    public partial class Form1 : Form
    {
        public class CustomTime
        {
            public int hours;
            public int minutes;
            public int seconds;
            public int miliSeconds;
        }

        public Form1()
        {
            InitializeComponent();
            openGlControl.InitializeContexts();
        }

        private List<Brush> color = new List<Brush>()
        {
            Brushes.Black,
            Brushes.Olive,
            Brushes.Blue,
            Brushes.Chartreuse,
            Brushes.Chocolate,
            Brushes.Crimson,
            Brushes.DarkBlue,
            Brushes.DarkGreen,
            Brushes.DarkOrange,
            Brushes.DarkTurquoise,
            Brushes.Firebrick,
            Brushes.Fuchsia,
            Brushes.Gold,
            Brushes.Green,
            Brushes.GreenYellow,
            Brushes.Indigo,
            Brushes.Khaki,
        };

        CustomTime cusTime = new CustomTime { hours = 0, minutes = 0, seconds = 0, miliSeconds = 0 };
        private int _interval = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, openGlControl.Width, openGlControl.Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            if (openGlControl.Width <= openGlControl.Height)
            {
                Glu.gluOrtho2D(0.0, 120.0 * openGlControl.Height / openGlControl.Width, 0.0, 120.0);
            }

            else
            {
                Glu.gluOrtho2D(0.0, 120.0 * openGlControl.Width / openGlControl.Height, 0.0, 120.0);
            }

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // очистка матриці
            Gl.glLoadIdentity();

            // встановлення червоного кольору поточним
            Gl.glColor3f(30, 0, 0);
            Gl.glClearColor(255, 255, 255, 1);

            // hours
            if (cusTime.hours < 9)
            {
                DrawTime(0, 50, "0" + cusTime.hours.ToString(), Brushes.Black);
            }

            else
            {
                DrawTime(0, 50, cusTime.hours.ToString(), Brushes.Black);
            }

            // minutes
            if (cusTime.minutes < 9)
            {
                DrawTime(50, 50, "0" + cusTime.minutes.ToString(), Brushes.Black);
            }

            else
            {
                DrawTime(50, 50, cusTime.minutes.ToString(), Brushes.Black);
            }

            // seconds
            if (cusTime.seconds < 9)
            {
                DrawTime(100, 50, "0" + cusTime.seconds.ToString(), Brushes.Black);
            }

            else
            {
                DrawTime(100, 50, cusTime.seconds.ToString(), Brushes.Black);
            }

            // miliseconds
            if (cusTime.miliSeconds < 9)
            {
                DrawTime(150, 50, "0" + cusTime.miliSeconds.ToString(), Brushes.Black);
            }

            else
            {
                DrawTime(150, 50, cusTime.miliSeconds.ToString(), Brushes.Black);
            }

            DrawTime(35, 55, ":", Brushes.Black);
            DrawTime(85, 55, ":", Brushes.Black);
            DrawTime(135, 55, ":", Brushes.Black);


            cusTime.miliSeconds++;
            if (cusTime.miliSeconds == 100)
            {
                cusTime.miliSeconds = 0;
                cusTime.seconds++;
            }

            if (cusTime.seconds == 60)
            {
                cusTime.seconds = 0;
                cusTime.minutes++;
            }

            if (cusTime.minutes == 60)
            {
                cusTime.minutes = 0;
                cusTime.hours++;
            }

            if (cusTime.hours == 60)
            {
                cusTime.miliSeconds = 0;
                cusTime.seconds = 0;
                cusTime.minutes = 0;
                cusTime.hours = 0;
            }
        }

        public void DrawTime(float x, float y, string text, Brush brush)
        {
            uint textureText;

            Bitmap textBitmap;
            Graphics graphics;

            Font font = new Font(FontFamily.GenericMonospace, 220.0f, FontStyle.Bold);
            BitmapData data;

            textBitmap = new Bitmap(openGlControl.Width, openGlControl.Height);
            graphics = Graphics.FromImage(textBitmap);

            graphics.DrawString(text, font, brush, new PointF(0, 0));
            data = textBitmap.LockBits(new Rectangle(0, 0, textBitmap.Width, textBitmap.Height), ImageLockMode.ReadOnly,
            PixelFormat.Format32bppArgb);

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glGenTextures(1, out textureText);

            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);

            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, textBitmap.Width, textBitmap.Height, 0, Gl.GL_BGRA,
            Gl.GL_UNSIGNED_BYTE, data.Scan0);

            textBitmap.UnlockBits(data);

            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2d(0, 1);
            Gl.glVertex2d(x, y);

            Gl.glTexCoord2d(1, 1);
            Gl.glVertex2d(x + 50, y);

            Gl.glTexCoord2d(1, 0);
            Gl.glVertex2d(x + 50, y + 50);

            Gl.glTexCoord2d(0, 0);
            Gl.glVertex2d(x, y + 50);
            Gl.glEnd();

            Gl.glDisable(Gl.GL_BLEND);
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0);
            Gl.glDeleteTextures(1, ref textureText);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = _interval;

            // очистка буферу кольору
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // очистка матриці
            Gl.glLoadIdentity();

            // встановлення червоного кольору поточним
            Gl.glColor3f(30, 45, 244);
            Gl.glClearColor(255, 255, 255, 1);

            Random rand = new Random();

            int _h = 0, _m = 0, _s = 0, _ts = 0, _k1 = 0, _k2 = 0, _k3 = 0;

            if (checkBoxAnimation.Checked)
            {
                _h = rand.Next(color.Count - 1);
                _m = rand.Next(color.Count - 1);
                _s = rand.Next(color.Count - 1);
                _ts = rand.Next(color.Count - 1);
                _k1 = rand.Next(color.Count - 1);
                _k2 = rand.Next(color.Count - 1);
                _k3 = rand.Next(color.Count - 1); 
            }

            if (cusTime.hours < 10)
            {
                DrawTime(0, 50, "0" + cusTime.hours.ToString(), color[_h]);
            }

            else
            {
                DrawTime(0, 50, cusTime.hours.ToString(), color[_h]);
            }

            if (cusTime.minutes < 10)
            {
                DrawTime(50, 50, "0" + cusTime.minutes.ToString(), color[_m]);
            }

            else
            {
                DrawTime(50, 50, cusTime.minutes.ToString(), color[_m]);
            }

            if (cusTime.seconds < 10)
            {
                DrawTime(100, 50, "0" + cusTime.seconds.ToString(), color[_s]);
            }

            else
            {
                DrawTime(100, 50, cusTime.seconds.ToString(), color[_s]);
            }

            if (cusTime.miliSeconds < 10)
            {
                DrawTime(150, 50, "0" + cusTime.miliSeconds.ToString(), color[_ts]);
            }

            else
            {
                DrawTime(150, 50, cusTime.miliSeconds.ToString(), color[_ts]);
            }

            DrawTime(35, 55, ":", color[_k1]);
            DrawTime(85, 55, ":", color[_k2]);
            DrawTime(135, 55, ":", color[_k3]);

            openGlControl.Invalidate();
            cusTime.miliSeconds++;

            if (cusTime.miliSeconds == 100)
            {
                cusTime.miliSeconds = 0;
                cusTime.seconds++;
            }

            if (cusTime.seconds == 60)
            {
                cusTime.seconds = 0;
                cusTime.minutes++;
            }

            if (cusTime.minutes == 60)
            {
                cusTime.minutes = 0;
                cusTime.hours++;
            }

            if (cusTime.hours == 60)
            {
                cusTime.miliSeconds = 0;
                cusTime.seconds = 0;
                cusTime.minutes = 0;
                cusTime.hours = 0;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Btn_Start.Text = "Продовжити";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _interval = Convert.ToInt32(comboBox1.Text);
        }
    }
}
