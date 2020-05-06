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
            InitializeComponent();
        }


        int nrow, ncol;
        Double[,] elements;
        String[] colnames;
        Double[] x1, y1, z1, x2, y2, z2;

        // The extracted data is stord in the above
        // You need not worry on how they got there


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Speed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Load_file1_Click(object sender, EventArgs e)
        {

            try
            {
                filldata(x1);
                filldata(y1);
                filldata(z1);
                varStat1.Text = "Done !!";

            }
            catch 
            {

                MessageBox.Show("Pls fill all three boxes", "Error !!", MessageBoxButtons.OK);

            }

            
        }

        private void Load_file2_Click(object sender, EventArgs e)
        {
            try
            {
                filldata(x2);
                filldata(y2);
                filldata(z2);
                varStat2.Text = "Done !!";

            }
            catch
            {

                MessageBox.Show("Pls fill all three boxes", "Error !!", MessageBoxButtons.OK);

            }

            
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

        private void Read1_Click(object sender, EventArgs e)
        {

            readit(file1);
            populate(comboBox1);
            populate(comboBox2);
            populate(comboBox3);


        }

        private void Read2_Click(object sender, EventArgs e)
        {

            readit(file2);
            populate(comboBox4);
            populate(comboBox5);
            populate(comboBox6);

        }

        private void label_x2_Click(object sender, EventArgs e)
        {

        }


        public void readit(Label file) 
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open";
            open.Filter = "Text Files (*.csv)|*.csv| All Files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {

                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                String fileName = open.FileName;
                file.Text = Path.GetFileName(fileName);

                extract(read);

                read.Dispose();

            }

        }

        public void extract(StreamReader read) 
        {

            
            String text = read.ReadToEnd();


            String[] lines = text.Split('\n');

            nrow = lines.Length - 1;
            ncol = lines[1].Split(',').Length;

            elements = new Double[nrow - 1, ncol];

            String[] row;
            row = new String[ncol];
            colnames = new string[ncol];

            for (int i = 0; i < nrow; i++)
            {

                row = lines[i].Split(',');



                for (int j = 0; j < ncol; j++)
                {
                    if (i == 0)
                    {

                        colnames[j] = row[j];

                    }
                    else
                    {

                        elements[i - 1, j] = Convert.ToDouble(row[j]);

                    }

                }


            }



        }


        public void populate(ComboBox dropdown) 
        {

            dropdown.Items.Clear();

            for (int i = 0; i < colnames.Length; i++) 
            {

                dropdown.Items.Add(colnames[i]);

            }


        }

        public void filldata(double[] x)
        {

            x = new double[nrow - 1];

            for (int i = 1; i < nrow - 1; i++)
            {
                x[i] = elements[i, comboBox1.SelectedIndex];
            }

           

        }

    }
}
