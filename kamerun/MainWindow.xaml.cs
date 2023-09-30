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
        public MainWindow()
        {
            InitializeComponent();
            gl = openGLControl.OpenGL;
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
            gl.Color(0f, 0.6f, 0f);
            gl.Vertex(x+dx, y+dy, z+dz);
            gl.Vertex(x+dx, y+dy, z);
            gl.Vertex(x, y+dy, z);
            gl.Vertex(x, y + dy, z+dz);
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0.6f, 0f);
            gl.Vertex(x + dx, y, z + dz);
            gl.Vertex(x + dx, y, z);
            gl.Vertex(x, y, z);
            gl.Vertex(x, y, z + dz);
            gl.End();

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(0f, 0.6f, 0f);
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
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0.6f, 0f);
            gl.Vertex(1f, 3f, 1f);
            gl.Vertex(1f, 3f, -1f);
            gl.Vertex(-1f, 3f, -1f);
            gl.Vertex(-1f, 3f, 1f);
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0.6f, 0f);
            gl.Vertex(1f, 1f, 1f);
            gl.Vertex(1f, 1f, -1f);
            gl.Vertex(-1f, 1f, -1f);
            gl.Vertex(-1f, 1f, 1f);
            gl.End();

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(0f, 0.6f, 0f);
            gl.Vertex(1f, 1f, 1f);
            gl.Vertex(1f, 3f, 1f);
            gl.Vertex(1f, 1f, -1f);
            gl.Vertex(1f, 3f, -1f);
            gl.Vertex(-1f, 1f, -1f);
            gl.Vertex(-1f, 3f, -1f);
            gl.Vertex(-1f, 1f, 1f);
            gl.Vertex(-1f, 3f, 1f);
            gl.End();
        }

        private void Corpus()
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0.8f, 0f);
            gl.Vertex(3f, 1f, 2f);
            gl.Vertex(3f, 1f, -2f);
            gl.Vertex(-3f, 1f, -2f);
            gl.Vertex(-3f, 1f, 2f);
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0.8f, 0f);
            gl.Vertex(3f, -1f, 2f);
            gl.Vertex(3f, -1f, -2f);
            gl.Vertex(-3f, -1f, -2f);
            gl.Vertex(-3f, -1f, 2f);
            gl.End();

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(0f, 0.8f, 0f);
            gl.Vertex(3f, -1f, 2f);
            gl.Vertex(3f, 1f, 2f);
            gl.Vertex(3f, -1f, -2f);
            gl.Vertex(3f, 1f, -2f);
            gl.Vertex(-3f, -1f, -2f);
            gl.Vertex(-3f, 1f, -2f);
            gl.Vertex(-3f, -1f, 2f);
            gl.Vertex(-3f, 1f, 2f);
            gl.End();
        }

        private void Dulo()
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(1f, 2.5f, 0.2f);
            gl.Vertex(1f, 2.5f, -0.2f);
            gl.Vertex(4f, 2.5f, -0.2f);
            gl.Vertex(4f, 2.5f, 0.2f);
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(1f, 1.5f, 0.2f);
            gl.Vertex(1f, 1.5f, -0.2f);
            gl.Vertex(4f, 1.5f, -0.2f);
            gl.Vertex(4f, 1.5f, 0.2f);
            gl.End();

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(0f, 0f, 0f);
            gl.Vertex(1f, 1.5f, 0.2f);
            gl.Vertex(1f, 2.5f, 0.2f);
            gl.Vertex(1f, 1.5f, -0.2f);
            gl.Vertex(1f, 2.5f, -0.2f);
            gl.Vertex(4f, 1.5f, -0.2f);
            gl.Vertex(4f, 2.5f, -0.2f);
            gl.Vertex(4f, 1.5f, 0.2f);
            gl.Vertex(4f, 2.5f, 0.2f);
            gl.End();
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
        }

        private void OpenGLControl_OpenGLInitialized(object sender, SharpGL.WPF.OpenGLRoutedEventArgs args)
        {
            gl.ClearColor(1f, 1f, 1f, 1f);
            gl.Scale(0.2,0.2,0.2);
        }

        private void OpenGLControl_Resized(object sender, SharpGL.WPF.OpenGLRoutedEventArgs args)
        {

        }

        private void openGLControl_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void openGLControl_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            gl.Rotate(4f, 4f, 0f);
        }
    }
}
