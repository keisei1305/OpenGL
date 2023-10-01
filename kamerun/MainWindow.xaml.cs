using System.Windows;
using System.Linq;
using System.Collections.Generic;
using SharpGL;

namespace kamerun
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenGL gl;
        Point3d scale;
        Point3d rotate;
        public MainWindow()
        {
            InitializeComponent();
            gl = openGLControl.OpenGL;
            scale = new Point3d(0.2f, 0.2f, 0.2f);
            rotate = new Point3d(0f, 0f, 0f);
        }

        #region Задачи

        #region Задание 1
        private void SenegaleBuild()
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0.4f, 0f);
            gl.Vertex(-4f, -4f);
            gl.Vertex(-4f, 4f);
            gl.Vertex(-1.33f, 4f);
            gl.Vertex(-1.33f, -4f);

            gl.Color(1f, 1f, 0f);
            gl.Vertex(-1.33f, 4f);
            gl.Vertex(-1.33f, -4f);
            gl.Vertex(1.33f, -4f);
            gl.Vertex(1.33f, 4f);

            gl.Color(1f, 0f, 0f);
            gl.Vertex(1.33f, 4f);
            gl.Vertex(1.33f, -4f);
            gl.Vertex(4f, -4f);
            gl.Vertex(4f, 4f);
            gl.End();
            //

            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(0f, 0.4f, 0f);
            gl.Vertex(0f, 1.6f);
            gl.Vertex(-0.5f, -0.8f);
            gl.Vertex(0.5f, -0.8f);

            gl.Vertex(-0.8f, 0.7f);
            gl.Vertex(0.8f, 0.7f);
            gl.Vertex(0f, -0.12f);

            gl.Color(1f, 1f, 0f);
            gl.Vertex(0f, -0.12f);
            gl.Vertex(-0.5f, -0.8f);
            gl.Vertex(0.5f, -0.8f);
            gl.End();
        }
        #endregion

        #region Задание 2        

        #region Всё для танков
        private void Bashnya()
        {
            //x=-1f,y=1f,z=-1f dx=2f, dy = 2f, dz=2f
            gl.Color(0f, 0.4f, 0f);
            Parallelepiped(-1f, 1f, -1f, 2f, 2f, 2f);
        }

        private void Corpus()
        {
            //x=-3f, y=-1f, z=-2f, dx=6f,dy=2f,dz=4f
            gl.Color(0f, 0.5f, 0f);
            Parallelepiped(-3f, -1f, -2f, 6f, 2f, 4f);
        }

        private void Dulo()
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0f, 0f);
            //x=1f,y=1.5f,z=-0.2f,dx=3f,dy=1f,dz=0.4f
            Parallelepiped(1f, 1.5f, -0.2f, 3f, 1f, 0.4f);
        }

        private void gusenica1()
        {
        }

        private void gusenica2()
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(2.5f, -0.8f, -1.8f);
            gl.Vertex(2.5f, -0.8f, -1.6f);
            gl.Vertex(-2.5f, -0.8f, -1.6f);
            gl.Vertex(-2.5f, -0.8f, -1.8f);
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(2.3f, -1.6f, -1.8f);
            gl.Vertex(2.3f, -1.6f, -1.6f);
            gl.Vertex(-2.3f, -1.6f, -1.6f);
            gl.Vertex(-2.3f, -1.6f, -1.8f);
            gl.End();

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(2.5f, -0.8f, -1.8f);
            gl.Vertex(2.3f, -1.6f, -1.8f);
            gl.Vertex(2.5f, -0.8f, -1.6f);
            gl.Vertex(2.3f, -1.6f, -1.6f);
            gl.Vertex(-2.5f, -0.8f, -1.6f);
            gl.Vertex(-2.3f, -1.6f, -1.6f);
            gl.Vertex(-2.5f, -0.8f, -1.8f);
            gl.Vertex(-2.3f, -1.6f, -1.8f);
            gl.End();
        }
        #endregion

        private void TankBuild()
        {
            Bashnya();
            Corpus();
            Dulo();
            gusenica1();
            gusenica2();
        }

        #endregion

        #endregion

        #region Вспомогательные инструменты для рисования
        private void Parallelepiped(double x, double y, double z, double dx, double dy, double dz)
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Vertex(x+dx, y+dy, z+dz);
            gl.Vertex(x+dx, y+dy, z);
            gl.Vertex(x, y+dy, z);
            gl.Vertex(x, y + dy, z+dz);
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            gl.Vertex(x + dx, y, z + dz);
            gl.Vertex(x + dx, y, z);
            gl.Vertex(x, y, z);
            gl.Vertex(x, y, z + dz);
            gl.End();

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Vertex(x + dx, y, z + dz);
            gl.Vertex(x + dx, y + dy, z + dz);
            gl.Vertex(x + dx, y, z);
            gl.Vertex(x + dx, y + dy, z);
            gl.Vertex(x, y, z);
            gl.Vertex(x, y + dy, z);
            gl.Vertex(x, y, z + dz);
            gl.Vertex(x, y + dy, z + dz);
            gl.End();
        }

        private void Polygon(params Point3d[] points)
        {
            gl.Begin(OpenGL.GL_QUAD_STRIP);
            for (int i = 0; i < points.Length; i++)
            {
                gl.Vertex(points[i].x, points[i].y, points[i].z);
            }
            gl.Vertex(points[0].x, points[0].y, points[0].z);
            gl.Vertex(points[1].x, points[1].y, points[1].z);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            for (int i = 0; i < points.Length; i += 2)
            {
                gl.Vertex(points[i].x, points[i].y, points[i].z);
            }
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            for (int i = 1; i < points.Length; i += 2)
            {
                gl.Vertex(points[i].x, points[i].y, points[i].z);
            }
            gl.End();
        }

        private void Polygon(RGB[] rgb, params Point3d[] points)
        {
            gl.Color(rgb[0].rgb); 
            gl.Begin(OpenGL.GL_QUAD_STRIP);
            for (int i = 0; i < points.Length; i++)
            {
                gl.Vertex(points[i].x, points[i].y, points[i].z);
            }
            gl.Vertex(points[0].x, points[0].y, points[0].z);
            gl.Vertex(points[1].x, points[1].y, points[1].z);
            gl.End();

            gl.Color(rgb[1].rgb);
            gl.Begin(OpenGL.GL_POLYGON);
            for (int i = 0; i < points.Length; i += 2)
            {
                gl.Vertex(points[i].x, points[i].y, points[i].z);
            }
            gl.End();

            gl.Color(rgb[2].rgb);
            gl.Begin(OpenGL.GL_POLYGON);
            for (int i = 1; i < points.Length; i += 2)
            {
                gl.Vertex(points[i].x, points[i].y, points[i].z);
            }
            gl.End();
        }

        private void Prism(float dz, params Point3d[] points)
        {
            int n = points.Length;
            List<Point3d> newPoints = new List<Point3d>(n*2);
            for(int i=0; i<n; i++)
            {
                newPoints.Add(points[i]);
                newPoints.Add(new Point3d(points[i].x, points[i].y, points[i].z+dz));
            }
            Polygon(newPoints.ToArray());
        }

        private void Prism(RGB[] rgb, float dz, params Point3d[] points)
        {
            int n = points.Length;
            List<Point3d> newPoints = new List<Point3d>(n * 2);
            for (int i = 0; i < n; i++)
            {
                newPoints.Add(points[i]);
                newPoints.Add(new Point3d(points[i].x, points[i].y, points[i].z + dz));
            }
            Polygon(rgb,newPoints.ToArray());
        }

        struct Point3d
        {
            public float x, y, z;
            public Point3d(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
        struct RGB
        {
            public float[] rgb;
            public RGB(float R, float G, float B)
            {
                rgb = new float[3];
                rgb[0] = R;
                rgb[1]= G;
                rgb[2] = B;
            }

            public RGB(int R, int G, int B)
            {
                rgb = new float[3];
                rgb[0]= R / 255;
                rgb[1] = G / 255;
                rgb[1] = B / 255;
            }
        }
        #endregion

        #region examples
        private void symbolM()
        {
            Prism(new RGB[3] {new RGB(1f,0f,0f), new RGB(0f,1f,0f), new RGB(0f,0f,1f)}, 2f, new Point3d(-2f, -2f, -1f),
                new Point3d(-1f, 1f, -1f),
                new Point3d(0f, 0f, -1f),
                new Point3d(1f, 1f, -1f),
                new Point3d(2f, -2f, -1f));
        }
        #endregion

        #region openglControlInit
        private void OpenGLControl_OpenGLDraw(object sender, SharpGL.WPF.OpenGLRoutedEventArgs args)
        {
            Draw();
        }

        private void OpenGLControl_OpenGLInitialized(object sender, SharpGL.WPF.OpenGLRoutedEventArgs args)
        {
            gl.ClearColor(1f, 1f, 1f, 1f);
            gl.Scale(scale.x,scale.y,scale.z);
            Draw();
        }

        private void OpenGLControl_Resized(object sender, SharpGL.WPF.OpenGLRoutedEventArgs args)
        {

        }
        #endregion
        private void openGLControl_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            gl.Rotate(15f, 0f, 0f);
            openGLControl.DoRender();
            Draw();
        }

        private void Draw()
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            symbolM();
        }
    }
}
