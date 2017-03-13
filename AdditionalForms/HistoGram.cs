using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdditionalForms
{
    public partial class HistoGram : Form
    {
        public HistoGram()
        {
            InitializeComponent();
        }
        public HistoGram(Bitmap map)
        {
            InitializeComponent();
            Dictionary<double, int> values = HelperFunctionality.HelperFunctions.ShowHistoGram(map);

            chart1.Series.Add("Histogram");
            chart1.Series["Histogram"].ChartType = SeriesChartType.Column;
            foreach (var item in values)
            {
                chart1.Series["Histogram"].Points.AddXY(item.Key, item.Value);
            }
        }
    }
}
