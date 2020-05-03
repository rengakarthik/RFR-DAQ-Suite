namespace RFR_DAQ_Suite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Play = new System.Windows.Forms.Button();
            this.Channel1_file1 = new System.Windows.Forms.TextBox();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Load_file1 = new System.Windows.Forms.Button();
            this.Remove_file1 = new System.Windows.Forms.Button();
            this.Load_file2 = new System.Windows.Forms.Button();
            this.Remove_file2 = new System.Windows.Forms.Button();
            this.Annimation_channel1 = new System.Windows.Forms.Button();
            this.Annimation_channel2 = new System.Windows.Forms.Button();
            this.Annimation_channel3 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Channel2_file1 = new System.Windows.Forms.TextBox();
            this.Channel3_file1 = new System.Windows.Forms.TextBox();
            this.Channel1_file2 = new System.Windows.Forms.TextBox();
            this.Channel2_file2 = new System.Windows.Forms.TextBox();
            this.Channel3_file2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.File_name2 = new System.Windows.Forms.ComboBox();
            this.File_Name1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Speed = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 276);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Channel 3";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(479, 100);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(12, 64);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Channel 1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(479, 100);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(12, 170);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Channel 2";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(479, 100);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(43, 402);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 3;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            // 
            // Channel1_file1
            // 
            this.Channel1_file1.Location = new System.Drawing.Point(497, 133);
            this.Channel1_file1.Name = "Channel1_file1";
            this.Channel1_file1.Size = new System.Drawing.Size(100, 20);
            this.Channel1_file1.TabIndex = 4;
            this.Channel1_file1.Text = "channel 1";
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(157, 402);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 5;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(277, 402);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Load_file1
            // 
            this.Load_file1.Location = new System.Drawing.Point(497, 278);
            this.Load_file1.Name = "Load_file1";
            this.Load_file1.Size = new System.Drawing.Size(75, 23);
            this.Load_file1.TabIndex = 8;
            this.Load_file1.Text = "Load";
            this.Load_file1.UseVisualStyleBackColor = true;
            // 
            // Remove_file1
            // 
            this.Remove_file1.Location = new System.Drawing.Point(578, 278);
            this.Remove_file1.Name = "Remove_file1";
            this.Remove_file1.Size = new System.Drawing.Size(75, 23);
            this.Remove_file1.TabIndex = 9;
            this.Remove_file1.Text = "Remove";
            this.Remove_file1.UseVisualStyleBackColor = true;
            // 
            // Load_file2
            // 
            this.Load_file2.Location = new System.Drawing.Point(722, 278);
            this.Load_file2.Name = "Load_file2";
            this.Load_file2.Size = new System.Drawing.Size(75, 23);
            this.Load_file2.TabIndex = 10;
            this.Load_file2.Text = "Load";
            this.Load_file2.UseVisualStyleBackColor = true;
            // 
            // Remove_file2
            // 
            this.Remove_file2.Location = new System.Drawing.Point(803, 278);
            this.Remove_file2.Name = "Remove_file2";
            this.Remove_file2.Size = new System.Drawing.Size(75, 23);
            this.Remove_file2.TabIndex = 11;
            this.Remove_file2.Text = "Remove";
            this.Remove_file2.UseVisualStyleBackColor = true;
            // 
            // Annimation_channel1
            // 
            this.Annimation_channel1.Location = new System.Drawing.Point(83, 431);
            this.Annimation_channel1.Name = "Annimation_channel1";
            this.Annimation_channel1.Size = new System.Drawing.Size(130, 100);
            this.Annimation_channel1.TabIndex = 12;
            this.Annimation_channel1.Text = "Annimation Channel 1";
            this.Annimation_channel1.UseVisualStyleBackColor = true;
            // 
            // Annimation_channel2
            // 
            this.Annimation_channel2.Location = new System.Drawing.Point(277, 431);
            this.Annimation_channel2.Name = "Annimation_channel2";
            this.Annimation_channel2.Size = new System.Drawing.Size(130, 100);
            this.Annimation_channel2.TabIndex = 13;
            this.Annimation_channel2.Text = "Annimation Channel 2";
            this.Annimation_channel2.UseVisualStyleBackColor = true;
            // 
            // Annimation_channel3
            // 
            this.Annimation_channel3.Location = new System.Drawing.Point(467, 431);
            this.Annimation_channel3.Name = "Annimation_channel3";
            this.Annimation_channel3.Size = new System.Drawing.Size(130, 100);
            this.Annimation_channel3.TabIndex = 14;
            this.Annimation_channel3.Text = "Annimation Channel 3";
            this.Annimation_channel3.UseVisualStyleBackColor = true;
            // 
            // Channel2_file1
            // 
            this.Channel2_file1.Location = new System.Drawing.Point(497, 170);
            this.Channel2_file1.Name = "Channel2_file1";
            this.Channel2_file1.Size = new System.Drawing.Size(100, 20);
            this.Channel2_file1.TabIndex = 15;
            this.Channel2_file1.Text = "channel 2";
            // 
            // Channel3_file1
            // 
            this.Channel3_file1.Location = new System.Drawing.Point(497, 212);
            this.Channel3_file1.Name = "Channel3_file1";
            this.Channel3_file1.Size = new System.Drawing.Size(100, 20);
            this.Channel3_file1.TabIndex = 16;
            this.Channel3_file1.Text = "channel  3";
            // 
            // Channel1_file2
            // 
            this.Channel1_file2.Location = new System.Drawing.Point(722, 133);
            this.Channel1_file2.Name = "Channel1_file2";
            this.Channel1_file2.Size = new System.Drawing.Size(100, 20);
            this.Channel1_file2.TabIndex = 17;
            this.Channel1_file2.Text = "channel 1";
            // 
            // Channel2_file2
            // 
            this.Channel2_file2.Location = new System.Drawing.Point(722, 170);
            this.Channel2_file2.Name = "Channel2_file2";
            this.Channel2_file2.Size = new System.Drawing.Size(100, 20);
            this.Channel2_file2.TabIndex = 18;
            this.Channel2_file2.Text = "channel 2";
            // 
            // Channel3_file2
            // 
            this.Channel3_file2.Location = new System.Drawing.Point(722, 212);
            this.Channel3_file2.Name = "Channel3_file2";
            this.Channel3_file2.Size = new System.Drawing.Size(100, 20);
            this.Channel3_file2.TabIndex = 19;
            this.Channel3_file2.Text = "channel  3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(603, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(603, 169);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(603, 212);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 22;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(828, 132);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 21);
            this.comboBox4.TabIndex = 23;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(828, 169);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 24;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(828, 212);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 21);
            this.comboBox6.TabIndex = 25;
            // 
            // File_name2
            // 
            this.File_name2.FormattingEnabled = true;
            this.File_name2.Location = new System.Drawing.Point(722, 64);
            this.File_name2.Name = "File_name2";
            this.File_name2.Size = new System.Drawing.Size(140, 21);
            this.File_name2.TabIndex = 27;
            this.File_name2.Text = "File Name 2";
            // 
            // File_Name1
            // 
            this.File_Name1.FormattingEnabled = true;
            this.File_Name1.Location = new System.Drawing.Point(497, 64);
            this.File_Name1.Name = "File_Name1";
            this.File_Name1.Size = new System.Drawing.Size(140, 21);
            this.File_Name1.TabIndex = 28;
            this.File_Name1.Text = "File Name 1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(436, 21);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(120, 20);
            this.textBox7.TabIndex = 29;
            this.textBox7.Text = "DAQ";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Speed
            // 
            this.Speed.BackColor = System.Drawing.SystemColors.Window;
            this.Speed.FormattingEnabled = true;
            this.Speed.Items.AddRange(new object[] {
            "speed"});
            this.Speed.Location = new System.Drawing.Point(445, 402);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(85, 19);
            this.Speed.TabIndex = 30;
            this.Speed.SelectedIndexChanged += new System.EventHandler(this.Speed_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 530);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.File_Name1);
            this.Controls.Add(this.File_name2);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Channel3_file2);
            this.Controls.Add(this.Channel2_file2);
            this.Controls.Add(this.Channel1_file2);
            this.Controls.Add(this.Channel3_file1);
            this.Controls.Add(this.Channel2_file1);
            this.Controls.Add(this.Annimation_channel3);
            this.Controls.Add(this.Annimation_channel2);
            this.Controls.Add(this.Annimation_channel1);
            this.Controls.Add(this.Remove_file2);
            this.Controls.Add(this.Load_file2);
            this.Controls.Add(this.Remove_file1);
            this.Controls.Add(this.Load_file1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Channel1_file1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DAQ Suite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.TextBox Channel1_file1;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Load_file1;
        private System.Windows.Forms.Button Remove_file1;
        private System.Windows.Forms.Button Load_file2;
        private System.Windows.Forms.Button Remove_file2;
        private System.Windows.Forms.Button Annimation_channel1;
        private System.Windows.Forms.Button Annimation_channel2;
        private System.Windows.Forms.Button Annimation_channel3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox Channel2_file1;
        private System.Windows.Forms.TextBox Channel3_file1;
        private System.Windows.Forms.TextBox Channel1_file2;
        private System.Windows.Forms.TextBox Channel2_file2;
        private System.Windows.Forms.TextBox Channel3_file2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox File_name2;
        private System.Windows.Forms.ComboBox File_Name1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckedListBox Speed;
    }
}

