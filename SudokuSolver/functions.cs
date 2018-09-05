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

        static public void AddMany<T>(List<T> List, params T[] values)
        {
            foreach (T item in values)
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

        static public void CopyCellsToKratka(List<Kratka> ListK, List<TextBox> ListCells)
        {
            for(int i=0; i<81;i++)
            {
                ListK[i].Cell = ListCells[i];
            }
        }

        static public Boolean MorePossibilities(Kratka Object, Boolean Status,int _HowMuch)
        {
            List<PossibleAnswer> List = new List<PossibleAnswer>();
            List<Kratka> CellsRowColGrp = new List<Kratka>();
            foreach (Kratka item in Object.Grupa.Contained)
            {
                CellsRowColGrp.Add(item);
            }
            foreach (Kratka item in Object.Kolumna.Contained)
            {
                if(!CellsRowColGrp.Contains(item))
                {
                CellsRowColGrp.Add(item);
                }
            }
            foreach (Kratka item in Object.Rzad.Contained)
            {
                if (!CellsRowColGrp.Contains(item))
                {
                    CellsRowColGrp.Add(item);
                }
            }
            foreach (int item in Object.PossibleInt)
            {
                List.Add(new PossibleAnswer(item));
            }

            foreach (PossibleAnswer PossibleNumber in List)
            {
                foreach (Kratka item in CellsRowColGrp)
                {
                    if(item.PossibleInt.Contains(PossibleNumber.Value))
                    {
                        PossibleNumber.Appears++;
                    }
                }
            }// counts how many Value appears in certain row column and group


            List.Sort();

            if(List[0].Appears==List[1].Appears)
            {
                return Status;
            }
            else
            {
                Object.value = List[0].Value;
                Object.Cell.Text = List[0].Value.ToString();
                _HowMuch = 1;
                return false;

            }







            //foreach (PossibleAnswer PossibleNumber in List)
            //{
            //    foreach (Kratka item in Object.Grupa.Contained)
            //    {


            //    }// na końcu trzeba ojąć 3 , bo policzy trzy 
            //}





        }


        static public Boolean CheckEachCell(Kratka Object,Boolean Status, int _HowMuch)// if there is no single cell with one possible int, program checks if there is possible int which can be place ONLY in one specific cell #perfectEnglish
        {
            Boolean Selected = false;// if function will find maching number this bool will stop each foreach loop
            List<List<Kratka>> CollectionOfGroups = new List<List<Kratka>>() { Object.Rzad.Contained, Object.Kolumna.Contained, Object.Grupa.Contained };// its list of 

            foreach (List<Kratka> List in CollectionOfGroups)
            {
                foreach(int IntFromPossibleInt in Object.PossibleInt)
                {
                     foreach (Kratka cellFromList in List)
                     {
                        if (cellFromList!= Object && cellFromList.value== 0)
                        {
                            if (cellFromList.PossibleInt.Contains(IntFromPossibleInt))
                            {
                                Selected = false;
                                break;
                            }
                            else
                            {
                                Selected = true;
                            }
                        }

                     }

                     if(Selected==true)
                    {
                        Object.value = IntFromPossibleInt;
                        Object.Cell.Text = IntFromPossibleInt.ToString();
                        _HowMuch = 1;
                        return false;
                    }


                }
            }

            return Status;

        }

    }
}
