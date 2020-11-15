using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Linq.Expressions;

namespace iss_bar_ho_jaega
{
    public partial class DAQHome : Form
    {


        List<Double> ax1 = new List<double>();// list declaration to enable easier addition and removal of data
        List<Double> ay1 = new List<double>();// lists for accelx and accely from two files

        List<Double> ax2 = new List<double>();
        List<Double> ay2 = new List<double>();

        Timer timer;
        //Stopwatch stopwatch;
        //Random random;
        int xaxis;
        int started;
        double str1Max = 0;
        double str2Max = 0;
        double strCP = 0;



        public class workhorse
        {

            // This is a user defined data type called 'Structure'. Read online.

            public int nrow, ncol;          // For number of rows and columns.
            public double[,] elements;      // To store the numerical data
            public string[] colnames;       // To store the headers
            public string filename;        //  To store name of the log file
            public double[] x1, y1, z1, t1, ax, ay, str, TPS, BPS;     // For Data Analysis
            // The extracted data is stord in the above
            // You need not worry on how they got there

        }

        workhorse first = new workhorse();
        workhorse second = new workhorse();

        public void setFirst(ref Form1.workhorse f)
        {
            first.ncol = f.ncol;
            first.nrow = f.nrow;
            first.elements = f.elements;
            first.colnames = f.colnames;
            first.filename = f.filename;


            populate(comboBox1, ref first);
            populate(comboBox2, ref first);
            populate(comboBox3, ref first);
            file1.Text = first.filename;

        }

        public void setSecond(ref Form1.workhorse s)
        {
            second.ncol = s.ncol;
            second.nrow = s.nrow;
            second.elements = s.elements;
            second.colnames = s.colnames;
            second.filename = s.filename;


            populate(comboBox4, ref second);
            populate(comboBox5, ref second);
            populate(comboBox6, ref second);
            file2.Text = second.filename;

        }


        public DAQHome()
        {
            InitializeComponent();

            ax1.Clear(); // clearing the lists once the form is loaded
            ay1.Clear();
            ax2.Clear();
            ay2.Clear();

            // customizing the plot for better visualization

            chart4.ChartAreas[0].AxisX.Minimum = -1.5;

            chart4.ChartAreas[0].AxisX.Maximum = 1.5;

            chart4.ChartAreas[0].AxisX.Interval = 0.1;

            chart4.ChartAreas[0].AxisY.Minimum = -1.5;

            chart4.ChartAreas[0].AxisY.Maximum = 1.5;

            chart4.ChartAreas[0].AxisY.Interval = 0.1;

            chart4.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart4.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;

            chart4.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = false;
            chart4.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = false;

            chart4.ChartAreas["ChartArea1"].AxisX.Crossing = 0;
            chart4.ChartAreas["ChartArea1"].AxisY.Crossing = 0;

            chart4.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chart4.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

            chart4.ChartAreas["ChartArea1"].AxisX.ArrowStyle = 0;
            chart4.ChartAreas["ChartArea1"].AxisY.ArrowStyle = 0;


            chart4.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = false;
            chart4.ChartAreas["ChartArea1"].AxisY.IsMarginVisible = false;

            chart4.ChartAreas["ChartArea1"].AxisX.LabelAutoFitMaxFontSize = 5;
            chart4.ChartAreas["ChartArea1"].AxisY.LabelAutoFitMaxFontSize = 5;


           // var backImage = new NamedImage("acceleration_circle", Properties.Resources.acceleration_circle);
            //chart4.Images.Add(backImage);
            chart4.ChartAreas["ChartArea1"].BackImage = "acceleration_circle";

            chart4.ChartAreas["ChartArea1"].BackImageAlignment = ChartImageAlignmentStyle.Center;
            chart4.ChartAreas["ChartArea1"].BackImageWrapMode = ChartImageWrapMode.Scaled;



            chart4.Series["plot1"].MarkerSize = 5;
            chart4.Series["plot2"].MarkerSize = 5;

            chart4.Series["plot1"].Color = Color.Red;
            chart4.Series["plot2"].Color = Color.Green;

        }
        

        public void populate(ComboBox dropdown, ref workhorse current)         // Populates the dropdown menu with column headers
        {


            dropdown.Items.Clear();     // Clears the list. Necessary if files are changed.

            for (int i = 0; i < current.ncol; i++)
            {

                dropdown.Items.Add(current.colnames[i]);        // This is what populates the list

            }

            dropdown.SelectedIndex = 0;
        }


        private void Load_file1_Click(object sender, EventArgs e)
        {

            // The try-catch block checkes whether all fields have been filled.


            // To get the channel data.
            filldata(ref first.x1, ref first, comboBox1.SelectedIndex);
            filldata(ref first.y1, ref first, comboBox2.SelectedIndex);
            filldata(ref first.z1, ref first, comboBox3.SelectedIndex);
            filldata(ref first.t1, ref first, 0);
            fillaccelxdata(ref first.ax, ref first); // loading the acceleration data into the variables 
            fillaccelydata(ref first.ay, ref first);
            //varStat1.Text = "Variables Loaded";

            MessageBox.Show("Variables Loaded", "Notification", MessageBoxButtons.OK);

        }

        private void Load_file2_Click(object sender, EventArgs e)
        {
            // Same thing as above.

            filldata(ref second.x1, ref second, comboBox4.SelectedIndex);
            filldata(ref second.y1, ref second, comboBox5.SelectedIndex);
            filldata(ref second.z1, ref second, comboBox6.SelectedIndex);
            filldata(ref second.t1, ref second, 0);
            fillaccelxdata(ref second.ax, ref second);
            fillaccelydata(ref second.ay, ref second);
            //varStat2.Text = "Variables Loaded";
            //string message = " Variables Loaded";
            MessageBox.Show("Variables Loaded", "Notification", MessageBoxButtons.OK);

        }

        private void Purge1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();               // Clears the dropdown for current run
            comboBox1.ResetText();                 // Clears Text in the combobox textbox
            comboBox2.Items.Clear();
            comboBox2.ResetText();
            comboBox3.Items.Clear();
            comboBox3.ResetText();
            first.x1 = null;
            first.y1 = null;
            first.z1 = null;
            //varStat1.Text = "Variables Emptied !";
            MessageBox.Show("Variables Emptied !!", "Notification", MessageBoxButtons.OK);
        }

        private void Purge2_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();            // Same as above but for channel 2
            comboBox4.ResetText();
            comboBox5.Items.Clear();
            comboBox5.ResetText();
            comboBox6.Items.Clear();
            comboBox6.ResetText();
            second.x1 = null;
            second.y1 = null;
            second.z1 = null;
            //varStat2.Text = "Variables Emptied !!";
            MessageBox.Show("Variables Emptied !!", "Notification", MessageBoxButtons.OK);
        }


        public void filldata(ref double[] x, ref workhorse current, int index)         // Fills data int the channels (one at a time) for further processing
        {
            try
            {

                x = new double[current.nrow - 1];       // Because header row has been removed

                for (int i = 0; i < current.nrow - 1; i++)
                {
                    x[i] = current.elements[i, index];       // Dropdown items are indexed from 0
                                                             //listBox1.Items.Add(x[i]);
                }

            }
            catch
            {

                for (int i = 0; i < current.nrow - 1; i++)
                {
                    x[i] = 0;                                // Set default value to zero

                }

            }

        }


        private void DAQHome_Load(object sender, EventArgs e)
        {

        }

        //writing my own function to initiate the 3 graphs
        public void Chart_initiate(Chart chartx)
        {
            chartx.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartx.ChartAreas[0].AxisX.LabelStyle.Format = "";
            chartx.ChartAreas[0].AxisY.LabelStyle.Format = "";
            chartx.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;

            chartx.ChartAreas[0].AxisX.Interval = 2;
            chartx.ChartAreas[0].AxisY.Interval = 0.2;

            chartx.Series[0].IsVisibleInLegend = false;
            chartx.ChartAreas[0].InnerPlotPosition.Auto = true;

            chartx.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(50, 200, 200, 200);
            chartx.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(50, 200, 200, 200);

            chartx.Series.Add("File1");
            chartx.Series["File1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chartx.Series["File1"].Color = Color.Blue;

            chartx.Series.Add("File2");
            chartx.Series["File2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chartx.Series["File2"].Color = Color.Green;
        }

        public void Playit()
        {
            if (started == 0)
            {

                string name = null;
                int str1Count;
                int str2Count;
                int tps1Count; int tps2Count; int bps1Count; int bps2Count;

                for (str1Count = 0; str1Count < first.ncol; str1Count++)
                {
                    name = first.colnames[str1Count];
                    if (name[0] == '"' && name[1] == 'S' && name[2] == 'T' && name[3] == 'R')
                    {
                        break;
                    }
                }


                for (str2Count = 0; str2Count < second.ncol; str2Count++)
                {
                    name = second.colnames[str2Count];
                    if (name[0] == '"' && name[1] == 'S' && name[2] == 'T' && name[3] == 'R')
                    {
                        break;
                    }
                }

                for (tps1Count = 0; tps1Count < first.ncol; tps1Count++)
                {
                    name = first.colnames[tps1Count];
                    if (name[0] == '"' && name[1] == 'T' && name[2] == 'P' && name[3] == 'S')
                    {
                        break;
                    }
                }

                for (tps2Count = 0; tps2Count < second.ncol; tps2Count++)
                {
                    name = second.colnames[tps2Count];
                    if (name[0] == '"' && name[1] == 'T' && name[2] == 'P' && name[3] == 'S')
                    {
                        break;
                    }
                }

                for (bps1Count = 0; bps1Count < first.ncol; bps1Count++)
                {
                    name = first.colnames[bps1Count];
                    if (name[0] == '"' && name[1] == 'F' && name[2] == 'B' && name[3] == 'P')
                    {
                        break;
                    }
                }

                for (bps2Count = 0; bps2Count < second.ncol; bps2Count++)
                {
                    name = second.colnames[bps2Count];
                    if (name[0] == '"' && name[1] == 'F' && name[2] == 'B' && name[3] == 'P')
                    {
                        break;
                    }
                }

                for (int i = 0; i < first.nrow - 1; i++)
                {
                    if (first.elements[i, str1Count] > str1Max)
                    {
                        str1Max = first.elements[i, str1Count];
                    }
                }

                for (int i = 0; i < second.nrow - 1; i++)
                {
                    if (second.elements[i, str2Count] > str2Max)
                    {
                        str2Max = second.elements[i, str2Count];
                    }
                }

                filldata(ref first.str, ref first, str1Count);
                filldata(ref second.str, ref second, str2Count);
                filldata(ref first.TPS, ref first, tps1Count);
                filldata(ref second.TPS, ref second, tps2Count);
                filldata(ref first.BPS, ref first, bps1Count);
                filldata(ref second.BPS, ref second, bps2Count);

                timer = new Timer();
                timer.Interval = 320;    //present playback speed is 0.0625x
                timer.Tick += timer_Tick;
                timer.Start();


                Chart_initiate(chart1);
                Chart_initiate(chart2);
                Chart_initiate(chart3);


                started = 1;
            }
            else if (started==1)
            {
                timer.Start();
            }
        }
        public void Pauseit()
        {
            timer.Stop();
        }
        int firstCounter;
        int secondCounter;

        int[,] c = new int[2, 3];
    

        public void AddToInitially(Chart chartx, int i, int j, string fileName)
        {
            for (int a = 0; a < c[i, j]; a++)
            {
                chartx.Series[fileName].Points[a].MarkerStyle = MarkerStyle.Circle;
                chartx.Series[fileName].Points[a].MarkerSize = 1;
            }

            //int a1 = chart1.Series["File1"].Points.Count;
            chartx.Series[fileName].Points[c[i, j]].MarkerStyle = MarkerStyle.Cross;
            chartx.Series[fileName].Points[c[i, j]].MarkerSize = 10;
            c[i, j]++;
        }

        public void AddTo(Chart chartx, int i, int j, string fileName)
        {
            chartx.Series[fileName].Points[c[i, j]].MarkerStyle = MarkerStyle.Cross;
            chartx.Series[fileName].Points[c[i, j]].MarkerSize = 10;

            for (int a3 = 0; a3 < c[i, j]; a3++)
            {
                chartx.Series[fileName].Points[a3].MarkerStyle = MarkerStyle.Circle;
                chartx.Series[fileName].Points[a3].MarkerSize = 1;
            }

            chartx.Series[fileName].Points.Remove(chartx.Series[fileName].Points[0]);
            //cx1++;
        }

        void timer_Tick(object sender, EventArgs e)
        {

            try
            {

                ax1.Clear(); // clearing each time to plot new points thereby the moving effect
                ay1.Clear();
                ax2.Clear();
                ay2.Clear();

                ax1.Add(first.ax[xaxis]); // loading data from workhorse to lists
                ay1.Add(first.ay[xaxis]);

                ax2.Add(second.ax[xaxis]);
                ay2.Add(second.ay[xaxis]);

                chart4.Series["plot1"].Points.DataBindXY(ax1, ay1); //plotting the data using the lists
                chart4.Series["plot2"].Points.DataBindXY(ax2, ay2);

                double a1 = Math.Sqrt(first.ax[xaxis] * first.ax[xaxis] + first.ay[xaxis] * first.ay[xaxis]);
                double a2 = Math.Sqrt(second.ax[xaxis] * second.ax[xaxis] + second.ay[xaxis] * second.ay[xaxis]);

                a1 = Math.Round(a1, 2);
                a2 = Math.Round(a2, 2);


                String s1 = a1.ToString();
                String s2 = a2.ToString();


                chart4.Series["plot1"].LabelForeColor = Color.Red;
                chart4.Series["plot2"].LabelForeColor = Color.Green;

                chart4.Series["plot1"].Label = s1;
                chart4.Series["plot2"].Label = s2;


                chart4.Invalidate(); // use this to plot and replot the points

                // dynamically varying y axis of plot to ensure that data always stays within plot
                chart1.ChartAreas[0].AxisY.Maximum = UpperLimit(first.x1, second.x1, xaxis) + 0.4;
                chart1.ChartAreas[0].AxisY.Minimum = LowerLimit(first.x1, second.x1, xaxis) - 0.4;
                chart2.ChartAreas[0].AxisY.Maximum = UpperLimit(first.y1, second.y1, xaxis) + 0.4;
                chart2.ChartAreas[0].AxisY.Minimum = LowerLimit(first.y1, second.y1, xaxis) - 0.4;
                chart3.ChartAreas[0].AxisY.Maximum = UpperLimit(first.z1, second.z1, xaxis) + 0.4;
                chart3.ChartAreas[0].AxisY.Minimum = LowerLimit(first.z1, second.z1, xaxis) - 0.4;



                if (xaxis <= 20)
                {



                    if (first.x1[xaxis] > -1000)
                    {
                        chart1.Series["File1"].Points.AddXY(xaxis, first.x1[xaxis]);

                        AddToInitially(chart1, 0, 0, "File1");
                    }

                    if (second.x1[xaxis] > -1000)
                    {
                        chart1.Series["File2"].Points.AddXY(xaxis, second.x1[xaxis]);

                        AddToInitially(chart1, 1, 0, "File2");
                    }

                    if (first.y1[xaxis] > -1000)
                    {
                        chart2.Series["File1"].Points.AddXY(xaxis, first.y1[xaxis]);

                        AddToInitially(chart2, 0, 1, "File1");
                    }

                    if (second.y1[xaxis] > -1000)
                    {
                        chart2.Series["File2"].Points.AddXY(xaxis, second.y1[xaxis]);

                        AddToInitially(chart2, 1, 1, "File2");
                    }

                    if (first.z1[xaxis] > -1000)
                    {
                        chart3.Series["File1"].Points.AddXY(xaxis, first.z1[xaxis]);

                        AddToInitially(chart3, 0, 2, "File1");
                    }

                    if (second.z1[xaxis] > -1000)
                    {
                        chart3.Series["File2"].Points.AddXY(xaxis, second.z1[xaxis]);
                        AddToInitially(chart3, 1, 2, "File2");
                    }

                    xaxis++;



                }

                else if (xaxis > 20)
                {

                    xaxis++;

                    if (first.x1[xaxis] > -1000)
                    {
                        chart1.Series["File1"].Points.AddXY(xaxis, first.x1[xaxis]);

                        //int a2 = chart1.Series["File1"].Points.Count;

                        AddTo(chart1, 0, 0, "File1");
                    }

                    if (second.x1[xaxis] > -1000)
                    {
                        chart1.Series["File2"].Points.AddXY(xaxis, second.x1[xaxis]);

                        //int b2 = chart1.Series["File2"].Points.Count;

                        AddTo(chart1, 1, 0, "File2");
                    }

                    if (first.y1[xaxis] > -1000)
                    {
                        chart2.Series["File1"].Points.AddXY(xaxis, first.y1[xaxis]);

                        //int a2 = chart1.Series["File1"].Points.Count;

                        AddTo(chart2, 0, 1, "File1");
                    }

                    if (second.y1[xaxis] > -1000)
                    {
                        chart2.Series["File2"].Points.AddXY(xaxis, second.y1[xaxis]);

                        //int b2 = chart1.Series["File2"].Points.Count;

                        AddTo(chart2, 1, 1, "File2");
                    }

                    if (first.z1[xaxis] > -1000)
                    {
                        chart3.Series["File1"].Points.AddXY(xaxis, first.z1[xaxis]);

                        //int a2 = chart3.Series["File1"].Points.Count;

                        AddTo(chart3, 0, 2, "File1");
                    }

                    if (second.z1[xaxis] > -1000)
                    {
                        chart3.Series["File2"].Points.AddXY(xaxis, second.z1[xaxis]);

                        //int b2 = chart3.Series["File2"].Points.Count;
                        AddTo(chart3, 1, 2, "File2");
                    }




                    try
                    {
                        chart1.ChartAreas[0].AxisX.Minimum = chart1.Series["File1"].Points[0].XValue;
                    }
                    catch { }
                    try
                    {
                        chart2.ChartAreas[0].AxisX.Minimum = chart2.Series["File1"].Points[0].XValue;
                    }
                    catch { }
                    try
                    {
                        chart3.ChartAreas[0].AxisX.Minimum = chart3.Series["File1"].Points[0].XValue;
                    }
                    catch { }


                    //xaxis += xaxis;

                    chart1.ChartAreas[0].AxisX.Maximum = xaxis + 2;
                    chart2.ChartAreas[0].AxisX.Maximum = xaxis + 2;
                    chart3.ChartAreas[0].AxisX.Maximum = xaxis + 2;



                }

                if (firstCounter < first.nrow - 1 && secondCounter < second.nrow - 1)
                {
                    firstCounter++; secondCounter++;
                    gauge1.value = first.str[firstCounter] * 60 / (str1Max - 2.89) - str1Max * 60 / (str1Max - 2.89) + 60;
                    gauge11.value = second.str[secondCounter] * 60 / (str2Max - 2.89) - str2Max * 60 / (str2Max - 2.89) + 60;
                    gauge1.ChangeValue(); gauge11.ChangeValue();

                }
                tps1empty.Height = 152 - (int)(first.TPS[firstCounter] * 38);
                tps1text.Text = first.TPS[firstCounter].ToString();
                bps1empty.Height = 152 - (int)(first.BPS[firstCounter] * 38);
                bps1text.Text = first.BPS[firstCounter].ToString();
                tps2empty.Height = 152 - (int)(second.TPS[secondCounter] * 38);
                tps2text.Text = second.TPS[secondCounter].ToString();
                bps2empty.Height = 152 - (int)(second.BPS[secondCounter] * 38);
                bps2text.Text = second.BPS[secondCounter].ToString();


            }

            catch
            {
                timer.Stop();
                MessageBox.Show("End of Data", "Done");

            }
        }

        public void Stopit()
        {
            timer.Stop();

            firstCounter = 0; secondCounter = 0;
            gauge1.value = 0; gauge11.value = 0;
            gauge1.ChangeValue();
            gauge11.ChangeValue();
            tps1empty.Height = 152;
            bps1empty.Height = 152;
            tps2empty.Height = 152;
            bps2empty.Height = 152;
            tps1text.Text = 0.ToString();
            bps1text.Text = 0.ToString();
            tps2text.Text = 0.ToString();
            bps2text.Text = 0.ToString();



            //System.Threading.Thread.Sleep(1500); //waits for 1.5s before clearing the data after stopping
            chart1.Series["File1"].Points.Clear();
            chart1.Series["File2"].Points.Clear();

            chart2.Series["File1"].Points.Clear();
            chart2.Series["File2"].Points.Clear();

            chart3.Series["File1"].Points.Clear();
            chart3.Series["File2"].Points.Clear();

            chart4.Series["plot1"].Points.Clear(); // clearing the lists 
            chart4.Series["plot2"].Points.Clear();

            xaxis = 0;

        }

        public void Slowit()
        {
            timer.Interval *= 2;
        }

        public void Speedit()
        {
            timer.Interval /= 2;
        }



        // functions to load data to acceleration variables
        public void fillaccelxdata(ref double[] x, ref workhorse current)         // Fills data int the channels (one at a time) for further processing
        {

            x = new double[current.nrow - 1];  // Because header row has been removed 


            int j;
            String str = "Accely";

            for (j = 1; j < current.ncol - 1; j++)
            {

                if (String.Compare(current.colnames[j], 1, str, 0, 6, true) == 0) // make sure that the col name is like "accelx"
                {
                    for (int i = 1; i < current.nrow - 1; i++)
                    {
                        x[i] = current.elements[i, j];       // Dropdown items are indexed from 0
                    }
                }


            }

        }
        public void fillaccelydata(ref double[] x, ref workhorse current)         // Fills data int the channels (one at a time) for further processing
        {

            x = new double[current.nrow - 1];  // Because header row has been removed

            int j;
            String str = "Accelz";

            for (j = 1; j < current.ncol - 1; j++)
            {

                if (String.Compare(current.colnames[j], 1, str, 0, 6, true) == 0)// make sure that the col name is like "accely"
                {

                    for (int i = 1; i < current.nrow - 1; i++)
                    {
                        x[i] = current.elements[i, j];       // Dropdown items are indexed from 0
                    }
                }


            }

        }

        public double UpperLimit(double[] px1, double[] px2, int xaxis) //function to find max y value currently in graph
        {
            int startPoint = (xaxis >= 20) ? (xaxis - 20) : 0;
            double a = px1.Skip(startPoint).Take(20).Max();
            double b = px2.Skip(startPoint).Take(20).Max();
            if (a > b)
                return a;
            else
            {
                return b;
            }
        }
        public double LowerLimit(double[] px1, double[] px2, int xaxis) //function to find min y value currently in graph
        {
            int startPoint = (xaxis >= 20) ? (xaxis - 20) : 0;
            double a = px1.Skip(startPoint).Take(20).Min();
            double b = px2.Skip(startPoint).Take(20).Min();
            if (a < b && a > -9000.0)
                return a;
            else
            {
                return b;
            }
        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }
    }
}
