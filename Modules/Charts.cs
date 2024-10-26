//using StockMonitoring.Models;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms.DataVisualization.Charting;

//namespace StockMonitoringNetF.Modules
//{
//    public static class Charts
//    {

//        public static void StockMonitoring(List<ChartMonitor> dt2, Chart chart1)
//        {
//            if (dt2.Count > 0)
//            {

//                int totalRow = dt2.Count;
//                chart1.Series.Clear();
//                var chartSeries1 = new System.Windows.Forms.DataVisualization.Charting.Series
//                {
//                    Name = "Qty",
//                    Color = System.Drawing.Color.AntiqueWhite,
//                    IsVisibleInLegend = false,
//                    IsXValueIndexed = true,
//                    ChartType = SeriesChartType.Column,
//                };
//                chart1.Series.Add(chartSeries1);
//                var chartSeries2 = new System.Windows.Forms.DataVisualization.Charting.Series
//                {
//                    Name = "Upper",
//                    Color = System.Drawing.Color.AntiqueWhite,
//                    IsVisibleInLegend = false,
//                    IsXValueIndexed = true,
//                    ChartType = SeriesChartType.StepLine,
//                };
//                chart1.Series.Add(chartSeries2);
//                var chartSeries3 = new System.Windows.Forms.DataVisualization.Charting.Series
//                {
//                    Name = "Lower",
//                    Color = System.Drawing.Color.AntiqueWhite,
//                    IsVisibleInLegend = false,
//                    IsXValueIndexed = true,
//                    ChartType = SeriesChartType.StepLine,
//                };
//                chart1.Series.Add(chartSeries3);
//                var chartSeries4 = new System.Windows.Forms.DataVisualization.Charting.Series
//                {
//                    Name = "Lowest",
//                    Color = System.Drawing.Color.AntiqueWhite,
//                    IsVisibleInLegend = false,
//                    IsXValueIndexed = true,
//                    ChartType = SeriesChartType.StepLine,
//                };
//                chart1.Series.Add(chartSeries4);




//                chartSeries1.YAxisType = AxisType.Primary;

//                //chartSeries2.YAxisType = AxisType.Secondary;

//                //chart1.ChartAreas[0].AxisY2.Title = "%";
//                //chart1.ChartAreas[0].AxisY2.TextOrientation = TextOrientation.Rotated90;
//                //chart1.ChartAreas[0].AxisY2.TitleFont = new Font("Arial", 11, FontStyle.Bold);
//                //chart1.ChartAreas[0].AxisY2.TitleForeColor = Color.Red;

//                chart1.ChartAreas[0].AxisX.Interval = 1;
//                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
//                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0,}K";
//                chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 9, FontStyle.Regular);

//                chart1.ChartAreas[0].BorderWidth = 1;
//                chart1.ChartAreas[0].BorderColor = Color.Transparent; // Color.White;
//                chart1.ChartAreas[0].BackColor = Color.White;
//                chart1.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
//                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
//                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Transparent;
//                chart1.ChartAreas[0].AxisY2.MajorGrid.LineColor = Color.Transparent;

//                chartSeries1.Points.AddXY(chartSeries1.Points.Count + 1, 100);

//              //  chartSeries1["PixelPointWidth"] = "20";


//                chartSeries1.Points.Clear();
//                for (int count = 0; count < totalRow; count++)
//                {
//                    string station = dt2[count].PartNumber;
//                    int len = station.Length;
//                    station = station.Substring(9, len - 9);
//                    int qtyint = dt2[count].Qty;
//                         string qty = qtyint.ToString();
//                    int hiint = dt2[count].UpperLimit;
//                    string hi = hiint.ToString();

//                    int loint = dt2[count].LowerLimit;
//                    string lo = loint.ToString();

//                    int loloint = dt2[count].LowerLoLimit;
//                    string lolo = loloint.ToString();


//                    chartSeries1.Points.AddXY(station, qty);
//                    if (qtyint < loint)
//                    {
//                        chartSeries1.Points[count].Color = Color.Pink;
//                    }
//                    else if (loint <= qtyint && qtyint <= hiint)
//                    {
//                        chartSeries1.Points[count].Color = Color.LightGreen;
//                    }
//                    else if (qtyint > hiint)
//                    {
//                        chartSeries1.Points[count].Color = Color.FromArgb(255, 255, 0);
//                    }
//                    //  chartSeries1.Points[count].Color = Color.AliceBlue;
//                    chartSeries1.Points[count].BorderWidth = 1;
//                    chartSeries1.Points[count].BorderColor = Color.Black;
//                    chartSeries1.Points[count].BorderDashStyle = ChartDashStyle.Solid;

//                    chartSeries2.Points.AddXY(station, hi);
//                    chartSeries2.Points[count].Color = Color.Blue;
//                    chartSeries2.Points[count].BorderWidth = 1;
//                    chartSeries2.Points[count].BorderColor = Color.Black;
//                    chartSeries2.Points[count].BorderDashStyle = ChartDashStyle.Solid;
//                    chartSeries2.Points[count].MarkerStyle = MarkerStyle.Circle;
//                    chartSeries2.Points[count].MarkerSize = 1;
//                    chartSeries2.Points[count].MarkerColor = Color.Red;



//                    chartSeries3.Points.AddXY(station, lo);
//                    chartSeries3.Points[count].Color = Color.DeepPink;
//                    chartSeries3.Points[count].BorderWidth = 1;
//                    chartSeries3.Points[count].BorderColor = Color.Black;
//                    chartSeries3.Points[count].BorderDashStyle = ChartDashStyle.Solid;
//                    chartSeries3.Points[count].MarkerStyle = MarkerStyle.Circle;
//                    chartSeries3.Points[count].MarkerSize = 1;
//                    chartSeries3.Points[count].MarkerColor = Color.Red;

//                    chartSeries4.Points.AddXY(station, lolo);
//                    chartSeries4.Points[count].Color = Color.DeepPink;
//                    chartSeries4.Points[count].BorderWidth = 1;
//                    chartSeries4.Points[count].BorderColor = Color.Black;
//                    chartSeries4.Points[count].BorderDashStyle = ChartDashStyle.Solid;
//                    chartSeries4.Points[count].MarkerStyle = MarkerStyle.Circle;
//                    chartSeries4.Points[count].MarkerSize = 1;
//                    chartSeries4.Points[count].MarkerColor = Color.Red;



//                }
//                chartSeries1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
//                chartSeries1.IsValueShownAsLabel = true;
//                chartSeries2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
//                chartSeries2.IsValueShownAsLabel = false;
//                chartSeries3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
//                chartSeries3.IsValueShownAsLabel = false;
//            }
//            else
//            {
//                chart1.Series.Clear();
//            }
//        }

//    }
//}
