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
    class Functions
    {

        static public void AddMany(List<TextBox> List, params TextBox[] values)
        {
            foreach (TextBox item in values)
            {
                List.Add(item);

            }
        }


        static public void AddToRow(Row element, params Kratka[] values)
        {
            foreach (Kratka item in values)
            {
                element.Contained.Add(item);
                item.Rzad = element;
            }
        }

        static public void AddToColumn(Column element, params Kratka[] values)
        {
            foreach (Kratka item in values)
            {
                element.Contained.Add(item);
                item.Kolumna = element;
            }
        }


        static public void AddToGroup(Group element, params Kratka[] values)
        {
            foreach (Kratka item in values)
            {
                element.Contained.Add(item);
                item.Grupa= element;
            }
        }


    }
}
