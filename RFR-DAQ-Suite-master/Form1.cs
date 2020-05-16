using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;


namespace RFR_DAQ_Suite
{

    public partial class Form1 : Form
    {
        List<Double> ax1 = new List<double>();// list declaration to enable easier addition and removal of data
        List<Double> ay1 = new List<double>();// lists for accelx and accely from two files

        List<Double> ax2 = new List<double>();
        List<Double> ay2 = new List<double>();

        Timer timer; //timer added

        int xaxis;    //an integer variable called xaxis: used to move the x-axis to make it look animated ;)
        int started;    //just one more useful variable

        public Form1()
        {
            InitializeComponent();   // Danger !! Don't Touch... Might explode!

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

            chart4.ChartAreas["ChartArea1"].AxisX.Crossing = 0;
            chart4.ChartAreas["ChartArea1"].AxisY.Crossing = 0;

            chart4.ChartAreas["ChartArea1"].AxisX.Title = "Accely";
            chart4.ChartAreas["ChartArea1"].AxisY.Title = "Accelx";

            chart4.ChartAreas["ChartArea1"].AxisX.LabelAutoFitMaxFontSize = 5;
            chart4.ChartAreas["ChartArea1"].AxisY.LabelAutoFitMaxFontSize = 5;

            chart4.Series["plot1"].MarkerSize = 5;
            chart4.Series["plot2"].MarkerSize = 5;

            chart4.Series["plot1"].Color = Color.Red;
            chart4.Series["plot2"].Color = Color.Blue;
        }



        public class workhorse
        {

            // This is a user defined data type called 'Structure'. Read online.

            public int nrow, ncol;          // For number of rows and columns.
            public double[,] elements;      // To store the numerical data
            public string[] colnames;       // To store the headers
            public double[] x1, y1, z1, t1,ax,ay;     // For Data Analysis
            // The extracted data is stord in the above
            // You need not worry on how they got there

        }

        workhorse first = new workhorse();        // Ojects for channels 1 aand 2.
        workhorse second = new workhorse();



        private void Read1_Click(object sender, EventArgs e)
        {

            // Reads the file loaded in first channel 

            readit(file1, ref first);

            populate(comboBox1, ref first);        // Populates the dropdown menus.

            populate(comboBox2, ref first);

            populate(comboBox3, ref first);


        }

        private void Read2_Click(object sender, EventArgs e)
        {

            // Same as above, but for channel 2

            readit(file2, ref second);

            populate(comboBox4, ref second);

            populate(comboBox5, ref second);

            populate(comboBox6, ref second);

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
            varStat1.Text = "Variables Loaded";



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
            varStat2.Text = "Variables Loaded";



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
            varStat1.Text = "Variables Emptied !";

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
            varStat2.Text = "Variables Emptied !!";
        }


        // The next few are empty functions that are to be used to add functionality to the specified actions as suggested by the names...

        private void file1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Speed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void File_Name1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label_x2_Click(object sender, EventArgs e)
        {

        }


        // The next few are functions I have defined to read and load the data...


        public void readit(Label file, ref workhorse current)           // Reads the data and extracts it's contents as a matrix
        {

            OpenFileDialog open = new OpenFileDialog();                         // Opens dialogue box to ask for file to read.
            open.Title = "Open";
            open.Filter = "Text Files (*.csv)|*.csv| All Files (*.*)|*.*";      // What type to read.

            if (open.ShowDialog() == DialogResult.OK)       //  Executes iff "OK" is pressed on the dialogue box. 
            {

                StreamReader read = new StreamReader(File.OpenRead(open.FileName));         // good luck with PTSD.
                String fileName = open.FileName;
                file.Text = Path.GetFileName(fileName);                                     // Displays filename in a label.


                String text = read.ReadToEnd();     // Reads the entire file but as a string.


                String[] lines = text.Split('\n');      // Use blank space as delimiter to distingish rows.

                current.nrow = lines.Length - 1;        // Last line is empty...

                current.ncol = lines[1].Split(',').Length;      // Use commas to distinguish elemints



                current.elements = new Double[current.nrow - 1, current.ncol];      // Dimensioning the matrix

                String[] row;           // Temporary storage for the row-data
                row = new String[current.ncol];
                current.colnames = new string[current.ncol];        // For headers

                for (int i = 0; i < current.nrow; i++)
                {

                    row = lines[i].Split(',');      // Stores lines in row as a string.


                    for (int j = 0; j < current.ncol; j++)
                    {
                        if (i == 0)
                        {

                            current.colnames[j] = row[j];       // Stores column names.

                        }
                        else
                        {

                            current.elements[i - 1, j] = Convert.ToDouble(row[j]);      // Stores corresponding numerical data.

                        }

                    }



                    read.Dispose();         // Destroy !!

                }
            }

        }


        public void populate(ComboBox dropdown, ref workhorse current)         // Populates the dropdown menu with column headers
        {

            dropdown.Items.Clear();     // Clears the list. Necessary if files are changed.

            for (int i = 0; i < current.ncol; i++)
            {

                dropdown.Items.Add(current.colnames[i]);        // This is what populates the list

            }


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

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();


            try
            {
                for (int i = 0; i < first.nrow - 1; i++)
                {

                    listBox1.Items.Add(first.x1[i]);
                    listBox2.Items.Add(first.y1[i]);
                    listBox3.Items.Add(first.z1[i]);

                }
            }
            catch
            {

                MessageBox.Show("variables purged !", "Lol !", MessageBoxButtons.OK);

            }


        }

        public void Play_Click(object sender, EventArgs e)
        {
            if(started==0)          //creating a flag
            {


                var chart_1 = chart1.ChartAreas[0];         //creating plotting areas for plotting charts
                var chart_2 = chart2.ChartAreas[0];
                var chart_3 = chart3.ChartAreas[0];



                timer = new Timer();
                timer.Interval = 80;    //present playback speed is 0.25x
                timer.Tick += timer_Tick;
                timer.Start();



                chart_1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                chart_2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                chart_3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;


                chart_1.AxisX.LabelStyle.Format = "";           //hiding the original labels
                chart_1.AxisY.LabelStyle.Format = "";
                chart_1.AxisX.LabelStyle.IsEndLabelVisible = true;

                chart_2.AxisX.LabelStyle.Format = "";
                chart_2.AxisY.LabelStyle.Format = "";
                chart_2.AxisX.LabelStyle.IsEndLabelVisible = true;

                chart_3.AxisX.LabelStyle.Format = "";
                chart_3.AxisY.LabelStyle.Format = "";
                chart_3.AxisX.LabelStyle.IsEndLabelVisible = true;



                chart_1.AxisX.Interval = 200;                 //fixed x axis interval as 200 ms
                chart_1.AxisY.Interval = 0.2;                 //fixed y axis interval as 0.2, but this will be dynamically changed in the later part of the code

                chart_2.AxisX.Interval = 200;
                chart_2.AxisY.Interval = 0.2;

                chart_3.AxisX.Interval = 200;
                chart_3.AxisY.Interval = 0.2;


                chart1.Series[0].IsVisibleInLegend = false;
                chart1.ChartAreas[0].InnerPlotPosition.Auto = true;

                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(50, 200, 200, 200);            //making the rows and columns easily visible
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(50, 200, 200, 200);

                chart1.Series.Add("File1");                 //adding a new series
                chart1.Series["File1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;  //making a spline chart type- for smoothing purpose
                chart1.Series["File1"].Color = Color.Blue;      //giving the spline blue color

                chart1.Series.Add("File2");
                chart1.Series["File2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series["File2"].Color = Color.Green;


                chart2.Series[0].IsVisibleInLegend = false;
                chart2.ChartAreas[0].InnerPlotPosition.Auto = true;

                chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(50, 200, 200, 200);
                chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(50, 200, 200, 200);

                chart2.Series.Add("File1");
                chart2.Series["File1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart2.Series["File1"].Color = Color.Blue;

                chart2.Series.Add("File2");
                chart2.Series["File2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart2.Series["File2"].Color = Color.Green;


                chart3.Series[0].IsVisibleInLegend = false;
                chart3.ChartAreas[0].InnerPlotPosition.Auto = true;

                chart3.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(50, 200, 200, 200);
                chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(50, 200, 200, 200);

                chart3.Series.Add("File1");
                chart3.Series["File1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart3.Series["File1"].Color = Color.Blue;

                chart3.Series.Add("File2");
                chart3.Series["File2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart3.Series["File2"].Color = Color.Green;

                started = 1;
            }
            else
            {
                timer.Start();          //restarting the timer
                Play.Text = "Play";
            }
        }

        void timer_Tick(object sender,EventArgs e)
        {
            try
            {
                ax1.Clear(); // clearing each time to plot new points thereby the moving effect
                ay1.Clear();
                ax2.Clear();
                ay2.Clear();

                ax1.Add(first.ax[xaxis]); // loading data fro workhorse to lists
                ay1.Add(first.ay[xaxis]);

                ax2.Add(second.ax[xaxis]);
                ay2.Add(second.ay[xaxis]);

                chart4.Series["plot1"].Points.DataBindXY(ax1, ay1); //plotting the data using the lists
                chart4.Series["plot2"].Points.DataBindXY(ax2, ay2);

                chart4.Invalidate(); // use this to plot and replot the points

                // dynamically varying y axis of plot to ensure that data always stays within plot
                chart1.ChartAreas[0].AxisY.Maximum = UpperLimit(first.x1, second.x1, xaxis) + 0.4;
                chart1.ChartAreas[0].AxisY.Minimum = LowerLimit(first.x1, second.x1, xaxis) - 0.4;
                chart2.ChartAreas[0].AxisY.Maximum = UpperLimit(first.y1, second.y1, xaxis) + 0.4;
                chart2.ChartAreas[0].AxisY.Minimum = LowerLimit(first.y1, second.y1, xaxis) - 0.4;
                chart3.ChartAreas[0].AxisY.Maximum = UpperLimit(first.z1, second.z1, xaxis) + 0.4;
                chart3.ChartAreas[0].AxisY.Minimum = LowerLimit(first.z1, second.z1, xaxis) - 0.4;

                if (chart1.Series["File1"].Points.Count <= 50)
                {
                    chart1.Series["File1"].Points.AddXY(first.t1[xaxis], first.x1[xaxis]);          //add X,Y points for first 50 points
                    chart1.Series["File2"].Points.AddXY(second.t1[xaxis], second.x1[xaxis]);

                    chart2.Series["File1"].Points.AddXY(first.t1[xaxis], first.y1[xaxis]);
                    chart2.Series["File2"].Points.AddXY(second.t1[xaxis], second.y1[xaxis]);

                    chart3.Series["File1"].Points.AddXY(first.t1[xaxis], first.z1[xaxis]);
                    chart3.Series["File2"].Points.AddXY(second.t1[xaxis], second.z1[xaxis]);


                    for (int n = 0; n < xaxis; n++)
                    {
                        chart1.Series["File1"].Points[n].MarkerStyle = MarkerStyle.Circle;         //making the natural marker not to be visible
                        chart1.Series["File1"].Points[n].MarkerSize = 1;
                        chart1.Series["File2"].Points[n].MarkerStyle = MarkerStyle.Circle;
                        chart1.Series["File2"].Points[n].MarkerSize = 1;

                        chart2.Series["File1"].Points[n].MarkerStyle = MarkerStyle.Circle;
                        chart2.Series["File1"].Points[n].MarkerSize = 1;
                        chart2.Series["File2"].Points[n].MarkerStyle = MarkerStyle.Circle;
                        chart2.Series["File2"].Points[n].MarkerSize = 1;

                        chart3.Series["File1"].Points[n].MarkerStyle = MarkerStyle.Circle;
                        chart3.Series["File1"].Points[n].MarkerSize = 1;
                        chart3.Series["File2"].Points[n].MarkerStyle = MarkerStyle.Circle;
                        chart3.Series["File2"].Points[n].MarkerSize = 1;
                    }


                    chart1.Series["File1"].Points[xaxis].MarkerStyle = MarkerStyle.Cross;       //making the leading marker to be visible in "Cross" symbol with larger size
                    chart1.Series["File1"].Points[xaxis].MarkerSize = 10;
                    chart1.Series["File2"].Points[xaxis].MarkerStyle = MarkerStyle.Cross;
                    chart1.Series["File2"].Points[xaxis].MarkerSize = 10;

                    chart2.Series["File1"].Points[xaxis].MarkerStyle = MarkerStyle.Cross;
                    chart2.Series["File1"].Points[xaxis].MarkerSize = 10;
                    chart2.Series["File2"].Points[xaxis].MarkerStyle = MarkerStyle.Cross;
                    chart2.Series["File2"].Points[xaxis].MarkerSize = 10;

                    chart3.Series["File1"].Points[xaxis].MarkerStyle = MarkerStyle.Cross;
                    chart3.Series["File1"].Points[xaxis].MarkerSize = 10;
                    chart3.Series["File2"].Points[xaxis].MarkerStyle = MarkerStyle.Cross;
                    chart3.Series["File2"].Points[xaxis].MarkerSize = 10;


                    xaxis += xaxis;
                    //chart1.ChartAreas[0].AxisX.Maximum = first.t1[xaxis];


                }

                else if (chart1.Series["File1"].Points.Count > 50)
                {

                    chart1.Series["File1"].Points.AddXY(first.t1[xaxis], first.x1[xaxis]);          //adding points after first 50 points 
                    chart1.Series["File2"].Points.AddXY(second.t1[xaxis++], second.x1[xaxis]);

                    chart2.Series["File1"].Points.AddXY(first.t1[xaxis], first.y1[xaxis]);
                    chart2.Series["File2"].Points.AddXY(second.t1[xaxis], second.y1[xaxis]);

                    chart3.Series["File1"].Points.AddXY(first.t1[xaxis], first.z1[xaxis]);
                    chart3.Series["File2"].Points.AddXY(second.t1[xaxis], second.z1[xaxis]);


                    chart1.Series["File1"].Points[50].MarkerStyle = MarkerStyle.Cross;          //highlighting the dynamic 50th point
                    chart1.Series["File1"].Points[50].MarkerSize = 10;
                    chart1.Series["File2"].Points[50].MarkerStyle = MarkerStyle.Cross;
                    chart1.Series["File2"].Points[50].MarkerSize = 10;

                    chart2.Series["File1"].Points[50].MarkerStyle = MarkerStyle.Cross;
                    chart2.Series["File1"].Points[50].MarkerSize = 10;
                    chart2.Series["File2"].Points[50].MarkerStyle = MarkerStyle.Cross;
                    chart2.Series["File2"].Points[50].MarkerSize = 10;

                    chart3.Series["File1"].Points[50].MarkerStyle = MarkerStyle.Cross;
                    chart3.Series["File1"].Points[50].MarkerSize = 10;
                    chart3.Series["File2"].Points[50].MarkerStyle = MarkerStyle.Cross;
                    chart3.Series["File2"].Points[50].MarkerSize = 10;



                    for (int m = 0; m < 50; m++)
                    {
                        chart1.Series["File1"].Points[m].MarkerStyle = MarkerStyle.Circle;          //changing the natural marker to be invisble
                        chart1.Series["File1"].Points[m].MarkerSize = 1;
                        chart1.Series["File2"].Points[m].MarkerStyle = MarkerStyle.Circle;
                        chart1.Series["File2"].Points[m].MarkerSize = 1;

                        chart2.Series["File1"].Points[m].MarkerStyle = MarkerStyle.Circle;
                        chart2.Series["File1"].Points[m].MarkerSize = 1;
                        chart2.Series["File2"].Points[m].MarkerStyle = MarkerStyle.Circle;
                        chart2.Series["File2"].Points[m].MarkerSize = 1;

                        chart3.Series["File1"].Points[m].MarkerStyle = MarkerStyle.Circle;
                        chart3.Series["File1"].Points[m].MarkerSize = 1;
                        chart3.Series["File2"].Points[m].MarkerStyle = MarkerStyle.Circle;
                        chart3.Series["File2"].Points[m].MarkerSize = 1;
                    }



                    chart1.Series["File1"].Points.Remove(chart1.Series["File1"].Points[0]);         //removing the first point stored in the dynamic array
                    chart1.Series["File2"].Points.Remove(chart1.Series["File2"].Points[0]);         //this will create a changing array whose values get shifted one value at time to a lower index in the array

                    chart2.Series["File1"].Points.Remove(chart2.Series["File1"].Points[0]);
                    chart2.Series["File2"].Points.Remove(chart2.Series["File2"].Points[0]);

                    chart3.Series["File1"].Points.Remove(chart3.Series["File1"].Points[0]);
                    chart3.Series["File2"].Points.Remove(chart3.Series["File2"].Points[0]);


                    chart1.ChartAreas[0].AxisX.Minimum = chart1.Series["File1"].Points[0].XValue;       //setting the minimum and maximum of the X axis in order to create a dynamic moving effect
                    chart2.ChartAreas[0].AxisX.Minimum = chart2.Series["File1"].Points[0].XValue;
                    chart3.ChartAreas[0].AxisX.Minimum = chart3.Series["File1"].Points[0].XValue;

                    chart1.ChartAreas[0].AxisX.Maximum = first.t1[xaxis + 10];      //making the lead (that is marked with a 'cross' symbol) to be within theplotting region
                    chart2.ChartAreas[0].AxisX.Maximum = first.t1[xaxis + 10];
                    chart3.ChartAreas[0].AxisX.Maximum = first.t1[xaxis + 10];

                }
            }
            catch
            {
                timer.Stop();       //stopping the timer if some error is caught in the try statement: Happens when all the data stored in the array are used up aldready
                MessageBox.Show("End of Data", "Done");
  
            }

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            System.Threading.Thread.Sleep(1500); //waits for 1.5s before clearing the data after stopping
            chart1.Series["File1"].Points.Clear();      //clears all the points in the plot
            chart1.Series["File2"].Points.Clear();

            chart2.Series["File1"].Points.Clear();
            chart2.Series["File2"].Points.Clear();

            chart3.Series["File1"].Points.Clear();
            chart3.Series["File2"].Points.Clear();

            chart4.Series["plot1"].Points.Clear(); // clearing the lists 
            chart4.Series["plot2"].Points.Clear();

            xaxis = 0;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer.Stop();       //stopping the timer on clicking pause button
            Play.Text = "Resume";
        }

        private void Slow_Click(object sender, EventArgs e)
        {
            timer.Interval *= 2;        //doubling the interval inorder to slow down the graph by 2x times
        }

        private void fast_Click(object sender, EventArgs e)
        {
            timer.Interval /= 2;        //making the timer interval to get halved in order to increase the speed by 2x times
            //PS: DO NOT increase the speed too much!!!! Else, it will crash since the value stored in the timer.Interval will reach 0; 
        }

        // functions to load data to acceleration variables
        public void fillaccelxdata(ref double[] x, ref workhorse current)         // Fills data int the channels (one at a time) for further processing
        {

            x = new double[current.nrow - 1];  // Because header row has been removed 


            int j;
            String str = "Accelx";

            for (j = 1; j < current.ncol - 1; j++)
            {
                
                if (String.Compare(current.colnames[j], 1 , str, 0, 6, true) == 0) // make sure that the col name is like "accelx"
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
            String str = "Accely";
        
            for (j = 1; j < current.ncol - 1; j++)
            {
               
                if (String.Compare(current.colnames[j], 1, str, 0, 6, true) == 0)// make sure that the col name is like "accely"
                {
                   
                    for (int i = 1; i < current.nrow - 1; i++)
                    {
                        x[i] = current.elements[i,j];       // Dropdown items are indexed from 0
                    }
                }


            }
            
        }

        public double UpperLimit(double[] px1, double[] px2, int xaxis) //function to find max y value currently in graph
        {
            int startPoint = (xaxis >= 50) ? (xaxis - 50) : 0;
            double a = px1.Skip(startPoint).Take(50).Max();
            double b = px2.Skip(startPoint).Take(50).Max();
            if (a > b)
                return a;
            else
            {
                return b;
            }
        }
        public double LowerLimit(double[] px1, double[] px2, int xaxis) //function to find min y value currently in graph
        {
            int startPoint = (xaxis >= 50) ? (xaxis - 50) : 0;
            double a = px1.Skip(startPoint).Take(50).Min();
            double b = px2.Skip(startPoint).Take(50).Min();
            if (a < b)
                return a;
            else
            {
                return b;
            }
        }
    }

}
