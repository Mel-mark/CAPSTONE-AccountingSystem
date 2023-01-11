using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
namespace LoginForm
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
              cartesianChart1.Series = new SeriesCollection
         {
             new LineSeries
             {
                 Values = new ChartValues<ObservablePoint>
                 {
                     new ObservablePoint(0, 10),        //firstpoint of first line
                     new ObservablePoint(4, 7),         //2nd point
                     new ObservablePoint(5, 3),         //.....
                     new ObservablePoint(7, 6),
                     new ObservablePoint(10, 8)
                 },
                 PointGeometrySize = 15
             },
             new LineSeries
             {
                  Values = new ChartValues<ObservablePoint>
                 {
                     new ObservablePoint(0, 2),        //firstpoint of second line
                     new ObservablePoint(2, 5),         //2nd point
                     new ObservablePoint(3, 6),         //.....
                     new ObservablePoint(6, 8),
                     new ObservablePoint(10, 5)
                 },
                 PointGeometrySize = 15
             },
                new LineSeries
             {
                  Values = new ChartValues<ObservablePoint>
                 {
                     new ObservablePoint(0, 4),        //firstpoint of third line
                     new ObservablePoint(5, 5),         //2nd point
                     new ObservablePoint(7, 7),         //.....
                     new ObservablePoint(9, 10),
                     new ObservablePoint(10, 9)
                 },
                 PointGeometrySize = 15
             },

         };
        }

      
    }
}
