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
    class Kratka
    {
        public TextBox Cell;
        public int value;
        private List<int> PossibleInt = new List<int>();
        public Row Rzad;
        public Column Kolumna;
        public Group Grupa;

        public void GetValueFromBox()
        {
            if (Cell.Text != "")
                value = int.Parse(Cell.Text);

        }
        
        public void UpdatePossibleInt()
        {
            List<int> FullGroup = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };// group containing all possible numbers- if one will not be able to use it will be deleted

            foreach (Kratka item in Rzad.Contained)
            {
                FullGroup.Remove(item.value);
            }

            foreach (Kratka item in Kolumna.Contained)
            {
                FullGroup.Remove(item.value);
            }

            foreach (Kratka item in Grupa.Contained)
            {
                FullGroup.Remove(item.value);
            }

            PossibleInt =new List<int>(FullGroup);
        }

        



    }
}
