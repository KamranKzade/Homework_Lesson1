using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Homework_Lesson1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }



    private void Click(object sender, MouseButtonEventArgs e)
    {
        var btn = sender as Button;

        byte a = (byte)Random.Shared.Next(0, 256);
        byte b = (byte)Random.Shared.Next(0, 256);
        byte c = (byte)Random.Shared.Next(0, 256);

        if (e.RightButton == MouseButtonState.Pressed)
        {
            Title = btn?.Content.ToString();

            foreach (var item in MyStackPanel.Children)
            {
                if (item is StackPanel stack)
                {
                    stack.Children.Remove(btn);
                }
            }
        }
        else if (e.LeftButton == MouseButtonState.Pressed)
        {
            btn.Background = new SolidColorBrush(Color.FromRgb(a, b, c));
            MessageBox.Show($"Color: {btn.Background}", "Informaton", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
