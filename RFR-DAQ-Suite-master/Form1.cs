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

namespace RFR_DAQ_Suite
{

    public partial class Form1 : Form
    {

        Timer timer;
        Random random;
        int xaxis;

        public Form1()
        {
            InitializeComponent();   // Danger !! Don't Touch... Might explode!
        }



        public class workhorse
        {

            // This is a user defined data type called 'Structure'. Read online.

            public int nrow, ncol;          // For number of rows and columns.
            public double[,] elements;      // To store the numerical data
            public string[] colnames;       // To store the headers
            public double[] x1, y1, z1;     // For Data Analysis
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
            varStat1.Text = "Variables Loaded";



        }

        private void Load_file2_Click(object sender, EventArgs e)
        {

            // Same thing as above.

            filldata(ref second.x1, ref second, comboBox4.SelectedIndex);
            filldata(ref second.y1, ref second, comboBox5.SelectedIndex);
            filldata(ref second.z1, ref second, comboBox6.SelectedIndex);
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


            random = new Random();
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            timer.Start();


            var chart = chart1.ChartAreas[0];

            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = 0;

            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 0.1;

            chart1.Series[0].IsVisibleInLegend = false;

            chart1.Series.Add("File1");
            chart1.Series["File1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series["File1"].Color = Color.Blue;

            //chart1.Series.Add("File2");
            //chart1.Series["File2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //chart1.Series["File2"].Color = Color.Green;


            //for(int i = 0; i < first.nrow - 1; i++)
            //{
              //  chart1.Series["File1"].Points.AddXY(i, first.x1[i]);

            //}

            //System.Threading.Thread.Sleep(3000);

            //for (int i = 0; i < second.nrow - 1; i++)
            //{
                //chart1.Series["File2"].Points.AddXY(i, second.x1[i]);

            //}


        }

        void timer_Tick(object sender,EventArgs e)
        {
            chart1.Series["File1"].Points.AddXY(xaxis++, first.x1[xaxis]);

            if (chart1.Series["File1"].Points.Count > 10)
            {
                chart1.Series["File1"].Points.Remove(chart1.Series["File1"].Points[0]);
                chart1.ChartAreas[0].AxisX.Minimum = chart1.Series["File1"].Points[0].XValue;
                chart1.ChartAreas[0].AxisX.Maximum = xaxis;
            }
        }

    }

}
