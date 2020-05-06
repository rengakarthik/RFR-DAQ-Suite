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


        public struct workhorse
        {

            public int nrow, ncol;
            public double[,] elements;
            public string[] colnames;
            public double[] x1, y1, z1;
            // The extracted data is stord in the above
            // You need not worry on how they got there

        }

        public workhorse first;
        public workhorse second;


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
                filldata(ref first.x1, ref first);
                filldata(ref first.y1, ref first);
                filldata(ref first.z1, ref first);
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
                filldata(ref second.x1, ref second);
                filldata(ref second.y1, ref second);
                filldata(ref second.z1, ref second);
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

        

            readit(file1, ref first);
            populate(comboBox1, ref first);
            populate(comboBox2, ref first);
            populate(comboBox3, ref first);


        }

        private void Read2_Click(object sender, EventArgs e)
        {

         

            readit(file2,ref second);
            populate(comboBox4, ref second);
            populate(comboBox5, ref second);
            populate(comboBox6, ref second);

        }

        private void label_x2_Click(object sender, EventArgs e)
        {

        }


        public void readit(Label file, ref workhorse current)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open";
            open.Filter = "Text Files (*.csv)|*.csv| All Files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {

                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                String fileName = open.FileName;
                file.Text = Path.GetFileName(fileName);


                String text = read.ReadToEnd();


                String[] lines = text.Split('\n');

                current.nrow = lines.Length - 1;

                current.ncol = lines[1].Split(',').Length;

                

                current.elements = new Double[current.nrow - 1, current.ncol];

                String[] row;
                row = new String[current.ncol];
                current.colnames = new string[current.ncol];

                for (int i = 0; i < current.nrow; i++)
                {

                    row = lines[i].Split(',');
         



                    for (int j = 0; j < current.ncol; j++)
                    {
                        if (i == 0)
                        {

                            current.colnames[j] = row[j];
                            //listBox1.Items.Add(current.colnames[j]);

                        }
                        else
                        {

                            current.elements[i - 1, j] = Convert.ToDouble(row[j]);

                        }

                    }

                    

                    read.Dispose();

                }
            }

        }


        public void populate(ComboBox dropdown, ref workhorse current) 
        {

            dropdown.Items.Clear();

            for (int i = 0; i < current.ncol; i++) 
            {

                dropdown.Items.Add(current.colnames[i]);

            }


        }

        public void filldata(ref double[] x, ref workhorse current)
        {

            x = new double[current.nrow - 1];

            for (int i = 1; i < current.nrow - 1; i++)
            {
                x[i] = current.elements[i, comboBox1.SelectedIndex];
            }

           

        }

    }
}
