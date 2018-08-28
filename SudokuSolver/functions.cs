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

         static public void AddMany(List<TextBox> List, params TextBox[] values )
        {

            foreach (TextBox item in values)
            {
                List.Add(item);

            }
        }





    }
}
