using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuSolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //adding all 81 cells to list
            Functions.AddMany(Cells, ka1, ka2, ka3, ka4, ka5, ka6, ka7, ka8, ka9, kb1, kb2, kb3, kb4,kb5,kb6,kb7,kb8,kb9,kc1,kc2,kc3,kc4,kc5,kc6,kc7,kc8,kc9,kd1,kd2,kd3,kd4,kd5,kd6,kd7,kd8,kd9,ke1,ke2,ke3,ke4,ke5,ke6,ke7,ke8,ke9,kf1,kf2,kf3,kf4,kf5,kf6,kf7,kf8,kf9,kg1,kg2,kg3,kg4,kg5,kg6,kg7,kg8,kg9,kh1,kh2,kh3,kh4,kh5,kh6,kh7,kh8,kh9,ki1,ki2,ki3,ki4,ki5,ki6,ki7,ki8,ki9);
            ResetButton.IsEnabled = false;
        }

        public List<TextBox> Cells = new List<TextBox>();

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox item in Cells)
            {
                item.IsReadOnly = true;
                item.Background = new SolidColorBrush(Color.FromRgb(221, 221, 217));
            }
            ResetButton.IsEnabled = true;
            startButton.IsEnabled = false;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox item in Cells)
            {
                item.IsReadOnly = false;
                item.Background = new SolidColorBrush(Colors.White);
                item.Text = "";
            }

            startButton.IsEnabled = true;
            ResetButton.IsEnabled = false;
        }
    }

}

