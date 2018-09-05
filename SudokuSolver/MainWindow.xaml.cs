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

            Cells = new List<TextBox>();
            Kratki = new List<Kratka>();
            Rzady = new List<Row>();
            Kolumny = new List<Column>();
            Grupy = new List<Group>();


            for (int i = 0; i <=8; i++)
            {
                Rzady.Add(new Row());
                Kolumny.Add(new Column());
                Grupy.Add(new Group());
            }

            for (int i = 0; i <= 80; i++)
            {
                Kratki.Add(new Kratka());
            }

            //adding all 81 cells to list
            Functions.AddMany(Cells, ka1, ka2, ka3, ka4, ka5, ka6, ka7, ka8, ka9, kb1, kb2, kb3, kb4,kb5,kb6,kb7,kb8,kb9,kc1,kc2,kc3,kc4,kc5,kc6,kc7,kc8,kc9,kd1,kd2,kd3,kd4,kd5,kd6,kd7,kd8,kd9,ke1,ke2,ke3,ke4,ke5,ke6,ke7,ke8,ke9,kf1,kf2,kf3,kf4,kf5,kf6,kf7,kf8,kf9,kg1,kg2,kg3,kg4,kg5,kg6,kg7,kg8,kg9,kh1,kh2,kh3,kh4,kh5,kh6,kh7,kh8,kh9,ki1,ki2,ki3,ki4,ki5,ki6,ki7,ki8,ki9);
            ResetButton.IsEnabled = false;
            StepButton.IsEnabled = false;

            Functions.CopyCellsToKratka(Kratki, Cells);

            for (int i = 0; i <= 8; i++)
            {
                Functions.AddToRow(Rzady[i], Kratki[i * 9], Kratki[i * 9 + 1], Kratki[2 + i * 9], Kratki[3 + i * 9], Kratki[4 + i * 9], Kratki[5 + i * 9], Kratki[6 + i * 9], Kratki[7 + i * 9], Kratki[8 + i * 9]);
            }

            for (int i = 0; i <=8; i++)
            {
                Functions.AddToColumn(Kolumny[i], Kratki[i], Kratki[i + 9], Kratki[i + 9*2], Kratki[i + 9 * 3], Kratki[i + 9 * 4], Kratki[i + 9 * 5], Kratki[i + 9 * 6], Kratki[i + 9 * 7], Kratki[i + 9 * 8]);
            }

            Functions.AddToGroup(Grupy[0], Kratki[0], Kratki[1], Kratki[2], Kratki[9], Kratki[10], Kratki[11], Kratki[18], Kratki[19], Kratki[20]);
            Functions.AddToGroup(Grupy[1], Kratki[3], Kratki[4], Kratki[5], Kratki[12], Kratki[13], Kratki[14], Kratki[21], Kratki[22], Kratki[23]);
            Functions.AddToGroup(Grupy[2], Kratki[6], Kratki[7], Kratki[8], Kratki[15], Kratki[16], Kratki[17], Kratki[24], Kratki[25], Kratki[26]);

            Functions.AddToGroup(Grupy[3], Kratki[27], Kratki[28], Kratki[29], Kratki[36], Kratki[37], Kratki[38], Kratki[45], Kratki[46], Kratki[47]);
            Functions.AddToGroup(Grupy[4], Kratki[30], Kratki[31], Kratki[32], Kratki[39], Kratki[40], Kratki[41], Kratki[48], Kratki[49], Kratki[50]);
            Functions.AddToGroup(Grupy[5], Kratki[33], Kratki[34], Kratki[35], Kratki[42], Kratki[43], Kratki[44], Kratki[51], Kratki[52], Kratki[53]);

            Functions.AddToGroup(Grupy[6], Kratki[54], Kratki[55], Kratki[56], Kratki[63], Kratki[64], Kratki[65], Kratki[72], Kratki[73], Kratki[74]);
            Functions.AddToGroup(Grupy[7], Kratki[57], Kratki[58], Kratki[59], Kratki[66], Kratki[67], Kratki[68], Kratki[75], Kratki[76], Kratki[77]);
            Functions.AddToGroup(Grupy[8], Kratki[60], Kratki[61], Kratki[62], Kratki[69], Kratki[70], Kratki[71], Kratki[78], Kratki[79], Kratki[80]);

            ;

            // Kratki[0],  Kratki[1],  Kratki[2],    Kratki[3],  Kratki[4],  Kratki[5],     Kratki[6],  Kratki[7],  Kratki[8] );
            // Kratki[9],  Kratki[10], Kratki[11],   Kratki[12], Kratki[13], Kratki[14],    Kratki[15], Kratki[16], Kratki[17] );
            // Kratki[18], Kratki[19], Kratki[20],   Kratki[21], Kratki[22], Kratki[23],    Kratki[24], Kratki[25], Kratki[26] );

            // Kratki[27], Kratki[28], Kratki[29],   Kratki[30], Kratki[31], Kratki[32],    Kratki[33], Kratki[34], Kratki[35] );
            // Kratki[36], Kratki[37], Kratki[38],   Kratki[39], Kratki[40], Kratki[41],    Kratki[42], Kratki[43], Kratki[44] );
            // Kratki[45], Kratki[46], Kratki[47],   Kratki[48], Kratki[49], Kratki[50],    Kratki[51], Kratki[52], Kratki[53] );

            // Kratki[54], Kratki[55], Kratki[56],   Kratki[57], Kratki[58], Kratki[59],    Kratki[60], Kratki[61], Kratki[62] );
            // Kratki[63], Kratki[64], Kratki[65],   Kratki[66], Kratki[67], Kratki[68],    Kratki[69], Kratki[70], Kratki[71] );
            // Kratki[72], Kratki[73], Kratki[74],   Kratki[75], Kratki[76], Kratki[77],    Kratki[78], Kratki[79], Kratki[80] );



        }

        //variables////////////
        public List<TextBox> Cells;
        private List<Kratka> Kratki;

        private List<Row> Rzady;
        private List<Column> Kolumny;
        private List<Group> Grupy;

        private int Threshold = 1;
        //variables

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Kratka item in Kratki)
            {
                item.GetValueFromBox();
            }

            foreach (TextBox item in Cells)
            {
                item.IsReadOnly = true;
                item.Background = new SolidColorBrush(Color.FromRgb(221, 221, 217));
            }
            ResetButton.IsEnabled = true;
            startButton.IsEnabled = false;
            StepButton.IsEnabled = true;
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
            StepButton.IsEnabled = false;
            Threshold = 1;
            MyConsole.Text = "";
        }

        private void StepButton_Click(object sender, RoutedEventArgs e)
        {
             Boolean IfNeedToincrease=true;// when sudoku needs from player to choose one from many numbers, we need to tell program to rise thereshold
            foreach(Kratka item in Kratki)
            {
                item.UpdatePossibleInt();
                IfNeedToincrease=item.PrintAnswer(Threshold,IfNeedToincrease);
            }

            if(IfNeedToincrease==true)
            {
                Threshold++;
                MyConsole.Text = "Threshold was increased to:" + Threshold.ToString();
            }
            else
            {
                Threshold = 1;
                //MyConsole.Text = "Threshold was decreased to: 1";
                MyConsole.Text = "Threshold was decreased to: 1";
            }



        }
    }

}

