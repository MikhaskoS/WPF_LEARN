using LearnOpenTK.Common;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Wpf;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace OpenGL.Sample
{
    /// <summary>
    /// Логика взаимодействия для OpenGLV4.xaml
    /// </summary>
    public partial class OpenGLV4 : Window
    {
        private Shader _shader;
        private float[] _vertices =
        {
            -0.5f, -0.5f, 0.0f, // Bottom-left vertex
             0.5f, -0.5f, 0.0f, // Bottom-right vertex
             0.0f,  0.5f, 0.0f  // Top vertex
        };
        private int _vertexBufferObject;
        private int _vertexArrayObject;

        public OpenGLV4()
        {
            InitializeComponent();
            var settings = new GLWpfControlSettings
            {
                MajorVersion = 2,
                MinorVersion = 1
            };
            OpenTkControl.Start(settings);
            OnLoad();
        }

     
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            OnUnload();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Key == Key.Space)
            {
               
            }
        }

        protected void OnLoad()
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            _vertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);

            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.DynamicDraw);

            _vertexArrayObject = GL.GenVertexArray();
            GL.BindVertexArray(_vertexArrayObject);

            // layout(location = 0) in vec3 aPosition;  поэтому 1 параметр - 0
            // vec - второй параметр - 3
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            GL.EnableVertexAttribArray(0);

            _shader = new Shader("Shaders/shader.vert", "Shaders/shader.frag");

            _shader.Use();
        }

       

        protected void OnUnload()
        {
            // Unbind all the resources by binding the targets to 0/null.
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindVertexArray(0);
            GL.UseProgram(0);

            // Delete all the resources.
            GL.DeleteBuffer(_vertexBufferObject);
            GL.DeleteVertexArray(_vertexArrayObject);

            GL.DeleteProgram(_shader.Handle);
        }

        private void OpenTkControl_OnRender(TimeSpan delta)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            //_shader.Use();

            GL.BindVertexArray(_vertexArrayObject);

            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
        }
    }
}
