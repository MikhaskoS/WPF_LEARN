using OpenTK.Wpf;
using System;
using System.Windows;

namespace OpenGL.Sample
{
    /// <summary>
    /// Логика взаимодействия для OpenGLV4.xaml
    /// </summary>
    public partial class OpenGLV4 : Window
    {
        public OpenGLV4()
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
