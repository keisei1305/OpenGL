using System.Windows;
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

        #region Всё для танков
        private void Bashnya()
        {
            //x=-1f,y=1f,z=-1f dx=2f, dy = 2f, dz=2f
            gl.Color(0f, 0.4f, 0f);
            Parallelepiped(-1f,1f,-1f,2f,2f,2f);
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
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(2.5f, -0.8f, 1.8f);
            gl.Vertex(2.5f, -0.8f, 1.6f);
            gl.Vertex(-2.5f, -0.8f, 1.6f);
            gl.Vertex(-2.5f, -0.8f, 1.8f);
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(2.3f, -1.6f, 1.8f);
            gl.Vertex(2.3f, -1.6f, 1.6f);
            gl.Vertex(-2.3f, -1.6f, 1.6f);
            gl.Vertex(-2.3f, -1.6f, 1.8f);
            gl.End();

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(2.5f, -0.8f, 1.8f);
            gl.Vertex(2.3f, -1.6f, 1.8f);
            gl.Vertex(2.5f, -0.8f, 1.6f);
            gl.Vertex(2.3f, -1.6f, 1.6f);
            gl.Vertex(-2.5f, -0.8f, 1.6f);
            gl.Vertex(-2.3f, -1.6f, 1.6f);
            gl.Vertex(-2.5f, -0.8f, 1.8f);
            gl.Vertex(-2.3f, -1.6f, 1.8f);
            gl.End();
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

        private void OpenGLControl_OpenGLDraw(object sender, SharpGL.WPF.OpenGLRoutedEventArgs args)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            TankBuild();
            gl.Flush();
        }

        private void OpenGLControl_OpenGLInitialized(object sender, SharpGL.WPF.OpenGLRoutedEventArgs args)
        {
            gl.ClearColor(1f, 1f, 1f, 1f);
            gl.Scale(scale.x,scale.y,scale.z);
        }

        private void OpenGLControl_Resized(object sender, SharpGL.WPF.OpenGLRoutedEventArgs args)
        {

        }

        private void openGLControl_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            gl.Rotate(4f, 4f, 0f);
        }
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
}
