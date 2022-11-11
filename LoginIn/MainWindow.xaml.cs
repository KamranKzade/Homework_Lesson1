using LogIn_Master.Models;
using System.Windows;
using System.Windows.Input;

namespace LogIn_Master;

public partial class MainWindow : Window
{
    public Student student = new("Kamran", "Kamran123");

    public MainWindow()
    {
        InitializeComponent();
    }


    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
            DragMove();
    }

    private void Minimize_Btn(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;
    private void Close_Btn(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

    private void Login_Click(object sender, RoutedEventArgs e)
    {
        if (student.Username == Username.Text)
        {
            textblock.Text = string.Empty;
            if (student.Password == Password.Password)
            {
                MessageBox.Show($"Welcome {student.Username}", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                textblock.Text = string.Empty;
            }
            else
            {
                textblock.Text = "Your Password is Wrong";
                textblock.Visibility = Visibility.Visible;
            }
        }
        else
        {
            textblock.Text = "Your Username is Wrong";
            textblock.Visibility = Visibility.Visible;
        }
    }
}
