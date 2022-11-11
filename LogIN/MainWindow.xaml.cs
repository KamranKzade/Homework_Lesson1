using LogIN.Models;
using System.Windows;

namespace LogIN;

public partial class MainWindow : Window
{
    public Student student = new ("Kamran", "Kamran123");



    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

        if (student.Username == Username.Text)
        {
            username_lbl.Content = string.Empty;
            if (student.Password == Password.Password)
            {
                MessageBox.Show($"Welcome {student.Username}", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                password_lbl.Content = string.Empty;
                username_lbl.Content = string.Empty;
            }
            else
            {
                password_lbl.Content = "Your Password is Wrong";
                password_lbl.Visibility = Visibility.Visible;
            }
        }
        else
        {
            if (student.Password == Password.Password)
            {
                password_lbl.Content = string.Empty;
                username_lbl.Content = "Your Username is Wrong";
                username_lbl.Visibility = Visibility.Visible;
            }
            else
            {
                username_lbl.Content = "Your Username is Wrong";
                username_lbl.Visibility = Visibility.Visible;
            }
        }

    }
}
