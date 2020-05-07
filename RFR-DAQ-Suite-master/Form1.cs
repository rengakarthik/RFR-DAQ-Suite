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
        public Form1()
        {
            InitializeComponent();   // Danger !! Don't Touch... Might explode!
        }


        public struct workhorse
        {

            // This is a user defined data type called 'Structure'. Read online.

            public int nrow, ncol;          // For number of rows and columns.
            public double[,] elements;      // To store the numerical data
            public string[] colnames;       // To store the headers
            public double[] x1, y1, z1;     // For Data Analysis
            // The extracted data is stord in the above
            // You need not worry on how they got there

        }

        workhorse first;        // Ojects for channels 1 aand 2.
        workhorse second;



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

            readit(file2,ref second);
            populate(comboBox4, ref second);
            populate(comboBox5, ref second);
            populate(comboBox6, ref second);

        }


        private void Load_file1_Click(object sender, EventArgs e)
        {

            // The try-catch block checkes whether all fields have been filled.

            try
            {
                // To get the channel data.
                filldata(ref first.x1, ref first);
                filldata(ref first.y1, ref first);
                filldata(ref first.z1, ref first);
                varStat1.Text = "Done !!";

            }
            catch
            {

                MessageBox.Show("Pls fill all three boxes", "Error !!", MessageBoxButtons.OK);      // Error message.

            }


        }

        private void Load_file2_Click(object sender, EventArgs e)
        {
            try
            {
                // Same thing as above.

                filldata(ref second.x1, ref second);
                filldata(ref second.y1, ref second);
                filldata(ref second.z1, ref second);
                varStat2.Text = "Done !!";

            }
            catch
            {

                MessageBox.Show("Pls fill all three boxes", "Error !!", MessageBoxButtons.OK);      // Lol

            }


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

        public void filldata(ref double[] x, ref workhorse current)         // Fills data int the channels (one at a time) for further processing
        {

            x = new double[current.nrow - 1];       // Because header row has been removed

            for (int i = 1; i < current.nrow - 1; i++)
            {
                x[i] = current.elements[i, comboBox1.SelectedIndex];       // Dropdown items are indexed from 0
            }



        }

    }

}
