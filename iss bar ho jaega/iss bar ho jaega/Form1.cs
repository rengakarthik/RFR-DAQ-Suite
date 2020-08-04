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

namespace iss_bar_ho_jaega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        
        public class workhorse
        {

            // This is a user defined data type called 'Structure'. Read online.

            public int nrow, ncol, status = 0;          // For number of rows and columns.
            public double[,] elements;      // To store the numerical data
            public string[] colnames;       // To store the headers
            public string filename;        //  To store name of the log file
            //public double[] x1, y1, z1, t1, ax, ay, str;     // For Data Analysis
            // The extracted data is stord in the above
            // You need not worry on how they got there

        }


        workhorse first = new workhorse();        // Ojects for channels 1 aand 2.
        workhorse second = new workhorse();

        DAQHome a = new DAQHome();                 // Form object to access DAQ Home
        DD b = new DD();                           // Form object to access Driver Data
        int currentFormNumber = 0;                 // To id which form is currently open



        // Self Explanatory...

        private void Form1_Load(object sender, EventArgs e)
        {

            openChildForm(a);

        }

        private void DriverData_Click_1(object sender, EventArgs e)
        {
            openChildForm(b);
            currentFormNumber = 1;
            //a.Pauseit();
            //b.Pauseit();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            openChildForm(a);
            currentFormNumber = 0;
            //a.Pauseit();
            //b.Pauseit();
        }


        private void Load1_Click(object sender, EventArgs e)
        {
            // Reads the file loaded in first channel 

            readit(FileName1, ref first);
            if (first.status == 1)
            {

                a.setFirst(ref first);
                b.setFirst(ref first);

            }
        
        }



        private void Load2_Click(object sender, EventArgs e)
        {
            // Same as above, but for channel 2

            readit(FileName2, ref second);
            if (second.status == 1)
            {

                a.setSecond(ref second);
                b.setSecond(ref second);

            }

        }





        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        // The following function is used to achieve siwtching of forms

        private Form activeForm = null;

        private void openChildForm(Form childForm) 
        {

            //if (activeForm != null) 
                //activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            mainArea.Controls.Add(childForm);
            mainArea.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>



        // The next few are functions I have defined to read and load the data...
        
        
        public void readit(Label file, ref workhorse current)           // Reads the data and extracts it's contents as a matrix
        {

            OpenFileDialog open = new OpenFileDialog();                         // Opens dialogue box to ask for file to read.
            open.Title = "Open";
            open.Filter = "Text Files (*.log)|*.log| All Files (*.*)|*.*";      // What type to read.

            if (open.ShowDialog() == DialogResult.OK)       //  Executes iff "OK" is pressed on the dialogue box. 
            {

                StreamReader read = new StreamReader(File.OpenRead(open.FileName));         // good luck with PTSD.
                String FN = open.FileName;
                current.filename = Path.GetFileName(FN);
                file.Text =current.filename;                                     // Displays filename in a label.
                

                String text = read.ReadToEnd();     // Reads the entire file but as a string.


                String[] lines = text.Split('\n');      // Use blank space as delimiter to distingish rows.

                current.nrow = lines.Length - 1;        // Last line is empty...

                current.ncol = lines[1].Split(',').Length + 1;      // Use commas to distinguish elemints



                current.elements = new Double[current.nrow - 1, current.ncol];      // Dimensioning the matrix

                String[] row;           // Temporary storage for the row-data
                row = new String[current.ncol];
                current.colnames = new string[current.ncol];        // For headers
                current.colnames[0] = "None";
                for (int i = 0; i < current.nrow; i++)
                {

                    row = lines[i].Split(',');      // Stores lines in row as a string.


                    for (int j = 0; j < current.ncol; j++)
                    {
                        if (i == 0)
                        {
                            if (j < current.ncol - 1)
                                current.colnames[j + 1] = row[j];       // Stores column names.

                        }
                        else
                        {
                            if (j == 0)
                            {
                                current.elements[i - 1, j] = -9999.9999;
                                continue;
                            }
                            String temp = row[j - 1];    // technical reasons
                            if (temp.Length == 0)
                            {

                                current.elements[i - 1, j] = -9999.9999;                    // If a field iss empty, enter a preassigned value

                            }
                            else
                            {

                                current.elements[i - 1, j] = Convert.ToDouble(row[j - 1]);      // Stores corresponding numerical data.

                            }



                        }

                    }



                    read.Dispose();         // Destroy !!
                    current.status = 1;

                }
            }
            else 
            {

                current.status = 0;

            }

        }

        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // The following funtions may appeaar incoherent for the lack of a dedicated pause function
        
        private void PS_Click(object sender, EventArgs e)
        {

            if (currentFormNumber == 0)
                a.Playit();                 // The Playit() function pauses the graphs if called more than once.
            else
                b.Playit();
        }

        private void Slow_Click(object sender, EventArgs e)
        {
            if (currentFormNumber == 0)
                a.Slowit();
            else
                b.Slowit();

        }

        private void Fast_Click(object sender, EventArgs e)
        {
            if (currentFormNumber == 0)
                a.Speedit();
            else
                b.Speedit();
        }

        private void S_Click(object sender, EventArgs e)
        {
            if (currentFormNumber == 0)
                a.Stopit();
            else
                b.Stopit();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (currentFormNumber == 0)
                a.Pauseit();
            else
                b.Pauseit();
        }
    }
}
