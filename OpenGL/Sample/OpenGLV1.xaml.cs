using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Wpf;
using System;
using System.Windows;

namespace OpenGL.Sample
{
    /// <summary>
    /// Логика взаимодействия для OpenGLV1.xaml
    /// </summary>
    public partial class OpenGLV1 : Window
    {
        public OpenGLV1()
        {
            InitializeComponent();

            var settings = new GLWpfControlSettings
            {
                MajorVersion = 2,
                MinorVersion = 1
            };
            OpenTkControl.Start(settings);
        }


        private void OpenTkControl_OnRender(TimeSpan delta)
        {
           
        }
    }
    
}
