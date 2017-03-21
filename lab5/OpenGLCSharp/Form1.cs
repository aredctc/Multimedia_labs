using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.DevIl;

namespace OpenGLCSharp
{
    public partial class Form1 : Form
    {
        public int top = 1, animationTime = 0;
        public float zoom = 0.5f, xc = 0, yc = 0, zc = 0;
        public bool direction = false;
        public double s = 0;
        public float angle = 0f;
        private int _root = 0;
        private bool _textureIsLoaded = false;
        private bool _motionIsStoped = false;
        public string textureName = "";
        public int imageId = 0;
        public uint mGlTextureObject = 0;
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            OpenGLControl.InitializeContexts();
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glClearColor(255, 255, 255, 0f);
            timer.Interval = 15;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            if (animationTime == 360) 
                animationTime = 0;

            if (animationTime <= 60)
            // right
                xc += 0.01f;

            // bottom
            else if (animationTime > 60 && animationTime <= 120)
            {
                xc -= 0.01f;
                yc -= 0.01f;
            }

            // forward
            else if (animationTime > 120 && animationTime <= 180)
            {
                zoom -= 0.002f;
                yc += 0.01f;
            }

            else if (animationTime > 180 && animationTime <= 240)
            {
                zoom += 0.002f;
                xc -= 0.01f;
            }

            else if (animationTime > 240 && animationTime <= 300)
            {
                zoom += 0.002f;
                xc += 0.01f;
                yc += 0.01f;
            }

            else if (animationTime > 300 && animationTime <= 360)
            {
                zoom -= 0.002f;
                yc -= 0.01f;
            }
                
            animationTime++;
            angle += 1f;
            DrawPyramid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glClearColor(255, 255, 255, 0f);
            Gl.glClearDepth(1.0f);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glLightModelf(Gl.GL_LIGHT_MODEL_LOCAL_VIEWER, Gl.GL_TRUE);
            Gl.glEnable(Gl.GL_DEPTH_TEST);            
            Gl.glDepthFunc(Gl.GL_LEQUAL);
            Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST);
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGBA | Glut.GLUT_SINGLE);

            Il.ilInit();
            Il.ilEnable(Il.IL_ORIGIN_SET);

            Gl.glViewport(0, 0, OpenGLControl.Width, OpenGLControl.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            
            //LoadGraniteTexture();
            timer.Start();
        }

        //private void LoadGraniteTexture()
        //{
        //    Il.ilGenImages(1, out imageId);
        //    Il.ilBindImage(imageId);
        // //   string url = "E:\\University\\3-й курс\\2-й семестр\\ЗП КГ\\Lab4\\OpenGLCSharp\\OpenGLCSharp\\Textures\\granite_texture.jpg";
        //    try
        //    {
        //        if (Il.ilLoadImage(url))
        //        {
        //            int width = Il.ilGetInteger(Il.IL_IMAGE_WIDTH);
        //            int height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT);
        //            int bitspp = Il.ilGetInteger(Il.IL_IMAGE_BITS_PER_PIXEL);

        //            switch (bitspp)
        //            {
        //                case 24:
        //                    mGlTextureObject = MakeGraniteTexture(Gl.GL_RGB, Il.ilGetData(), width, height);
        //                    break;
        //                case 32:
        //                    mGlTextureObject = MakeGraniteTexture(Gl.GL_RGBA, Il.ilGetData(), width, height);
        //                    break;
        //            }

        //            _textureIsLoaded = true;
        //            Il.ilDeleteImages(1, ref imageId);
        //        }
        //    }
        //    catch (FileLoadException ex)
        //    {
        //        MessageBox.Show("Виникла помилка під час завантаження текстури", "Can not load texture", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private static uint MakeGraniteTexture(int format, IntPtr pixels, int w, int h)
        {
          uint texObject;

          Gl.glGenTextures(1, out texObject);
          Gl.glPixelStorei( Gl.GL_UNPACK_ALIGNMENT, 1);
          Gl.glBindTexture( Gl.GL_TEXTURE_2D, texObject);
          Gl.glTexParameteri( Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
          Gl.glTexParameteri( Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);
          Gl.glTexParameteri( Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
          Gl.glTexParameteri( Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
          Gl.glTexEnvf( Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE);

          switch (format)
          { 
            case Gl.GL_RGB:
                Gl.glTexImage2D( Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, w, h, 0, Gl.GL_RGB, Gl.GL_UNSIGNED_BYTE, pixels);
            break;

            case Gl.GL_RGBA:
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, w, h, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, pixels);
            break;
          }

          return texObject;
        }

        public void DrawPyramid()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();

            float[] fogColor = new float[4] { 0.5f, 0.5f, 0.5f, 1.0f };
            Gl.glClearColor(0.5f, 0.5f, 0.5f, 1.0f);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            float[] matdiffu = new float[]{1.0f, 1.0f, 1.0f, 1.0f};
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_DIFFUSE,matdiffu);

            float[] light1_diffuse =  new float[]{1.0f, 1.0f, 1.0f, 0.0f};
            float[] light1_position = new float[]{-1.0f, -1.0f, -1.0f, 1.0f};
            float[] light2_position = new float[] { -1f, 1f, 0f, 1.0f };

            // light
            Gl.glEnable(Gl.GL_LIGHT1);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_DIFFUSE, light1_diffuse);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_POSITION, light1_position);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, light1_diffuse);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light2_position);        

            // textures
            Gl.glEnable(Gl.GL_TEXTURE_2D);

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, mGlTextureObject);

            Gl.glRotatef(angle, 0.0f, 0.5f, 0.5f);
            Gl.glScalef(zoom, zoom, zoom);           

            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glTexCoord2f(0.0f, 0.0f);
            Gl.glVertex3f(0.0f, 1f, 0.0f);
            Gl.glTexCoord2f(0.5f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);
            Gl.glTexCoord2f(1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);

            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glColor3f(0.3f, 1.0f, 0.5f);

            // Gl.glTexCoord2f(0.0f, 0.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            // Gl.glTexCoord2f(0.5f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);
            // Gl.glTexCoord2f(1.0f, 0.0f);
            Gl.glVertex3f(0.0f, -1.0f, -1.0f);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(0.0f, -1.0f, -1.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);

            Gl.glColor3f(0.6f, 0.2f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);
            Gl.glVertex3f(0.0f, -1.0f, -1.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);

            Gl.glEnd();
            Gl.glPopMatrix();
            Gl.glFlush();
            OpenGLControl.Invalidate();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glClearColor(255, 255, 255, 0f);
            timer.Tick += Timer_Tick;
        }
    }
}
