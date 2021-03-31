using OpenGL.Sample;
using System.Windows;


namespace OpenGL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenGLV1 win = new OpenGLV1();
            win.Show();
        }

        private void Button_Click_V4(object sender, RoutedEventArgs e)
        {
            OpenGLV4 win = new OpenGLV4();
            win.Show();
        }
    }
}
