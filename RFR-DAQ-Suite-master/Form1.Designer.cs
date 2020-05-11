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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Load_file1 = new System.Windows.Forms.Button();
            this.Load_file2 = new System.Windows.Forms.Button();
            this.Annimation_channel1 = new System.Windows.Forms.Button();
            this.Annimation_channel2 = new System.Windows.Forms.Button();
            this.Annimation_channel3 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.Speed = new System.Windows.Forms.CheckedListBox();
            this.Read1 = new System.Windows.Forms.Button();
            this.Read2 = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.Label();
            this.file2 = new System.Windows.Forms.Label();
            this.label_z1 = new System.Windows.Forms.Label();
            this.label_y1 = new System.Windows.Forms.Label();
            this.label_x1 = new System.Windows.Forms.Label();
            this.label_z2 = new System.Windows.Forms.Label();
            this.label_y2 = new System.Windows.Forms.Label();
            this.label_x2 = new System.Windows.Forms.Label();
            this.ProgName = new System.Windows.Forms.Label();
            this.varStat1 = new System.Windows.Forms.Label();
            this.varStat2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 276);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Channel 3";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(440, 100);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(22, 64);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Channel 1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(440, 100);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(22, 170);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Channel 2";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(440, 100);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
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
            this.Load_file1.Location = new System.Drawing.Point(561, 266);
            this.Load_file1.Name = "Load_file1";
            this.Load_file1.Size = new System.Drawing.Size(75, 23);
            this.Load_file1.TabIndex = 8;
            this.Load_file1.Text = "Initiate";
            this.Load_file1.UseVisualStyleBackColor = true;
            this.Load_file1.Click += new System.EventHandler(this.Load_file1_Click);
            // 
            // Load_file2
            // 
            this.Load_file2.Location = new System.Drawing.Point(786, 266);
            this.Load_file2.Name = "Load_file2";
            this.Load_file2.Size = new System.Drawing.Size(75, 23);
            this.Load_file2.TabIndex = 10;
            this.Load_file2.Text = "Initiate";
            this.Load_file2.UseVisualStyleBackColor = true;
            this.Load_file2.Click += new System.EventHandler(this.Load_file2_Click);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(598, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(599, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(598, 215);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 22;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(834, 129);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 21);
            this.comboBox4.TabIndex = 23;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(834, 172);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 24;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(834, 213);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 21);
            this.comboBox6.TabIndex = 25;
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
            // Read1
            // 
            this.Read1.Location = new System.Drawing.Point(611, 72);
            this.Read1.Name = "Read1";
            this.Read1.Size = new System.Drawing.Size(75, 23);
            this.Read1.TabIndex = 31;
            this.Read1.Text = "Read";
            this.Read1.UseVisualStyleBackColor = true;
            this.Read1.Click += new System.EventHandler(this.Read1_Click);
            // 
            // Read2
            // 
            this.Read2.Location = new System.Drawing.Point(847, 72);
            this.Read2.Name = "Read2";
            this.Read2.Size = new System.Drawing.Size(75, 23);
            this.Read2.TabIndex = 32;
            this.Read2.Text = "Read";
            this.Read2.UseVisualStyleBackColor = true;
            this.Read2.Click += new System.EventHandler(this.Read2_Click);
            // 
            // file1
            // 
            this.file1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.file1.AutoEllipsis = true;
            this.file1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.file1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file1.Location = new System.Drawing.Point(508, 70);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(59, 25);
            this.file1.TabIndex = 35;
            this.file1.Text = "File1";
            this.file1.Click += new System.EventHandler(this.file1_Click);
            // 
            // file2
            // 
            this.file2.AutoEllipsis = true;
            this.file2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.file2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file2.Location = new System.Drawing.Point(744, 70);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(59, 25);
            this.file2.TabIndex = 36;
            this.file2.Text = "File2";
            // 
            // label_z1
            // 
            this.label_z1.AutoEllipsis = true;
            this.label_z1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_z1.Location = new System.Drawing.Point(487, 212);
            this.label_z1.Name = "label_z1";
            this.label_z1.Size = new System.Drawing.Size(96, 24);
            this.label_z1.TabIndex = 37;
            this.label_z1.Text = "Channel 3";
            // 
            // label_y1
            // 
            this.label_y1.AutoEllipsis = true;
            this.label_y1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_y1.Location = new System.Drawing.Point(487, 170);
            this.label_y1.Name = "label_y1";
            this.label_y1.Size = new System.Drawing.Size(96, 24);
            this.label_y1.TabIndex = 38;
            this.label_y1.Text = "Channel 2";
            // 
            // label_x1
            // 
            this.label_x1.AutoEllipsis = true;
            this.label_x1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x1.Location = new System.Drawing.Point(487, 129);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(96, 24);
            this.label_x1.TabIndex = 39;
            this.label_x1.Text = "Channel 1";
            // 
            // label_z2
            // 
            this.label_z2.AutoEllipsis = true;
            this.label_z2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_z2.Location = new System.Drawing.Point(726, 212);
            this.label_z2.Name = "label_z2";
            this.label_z2.Size = new System.Drawing.Size(96, 24);
            this.label_z2.TabIndex = 40;
            this.label_z2.Text = "Channel c";
            // 
            // label_y2
            // 
            this.label_y2.AutoEllipsis = true;
            this.label_y2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_y2.Location = new System.Drawing.Point(725, 170);
            this.label_y2.Name = "label_y2";
            this.label_y2.Size = new System.Drawing.Size(97, 24);
            this.label_y2.TabIndex = 41;
            this.label_y2.Text = "Channel b";
            // 
            // label_x2
            // 
            this.label_x2.AutoEllipsis = true;
            this.label_x2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x2.Location = new System.Drawing.Point(727, 127);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(96, 24);
            this.label_x2.TabIndex = 42;
            this.label_x2.Text = "Channel a";
            this.label_x2.Click += new System.EventHandler(this.label_x2_Click);
            // 
            // ProgName
            // 
            this.ProgName.AutoSize = true;
            this.ProgName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgName.Location = new System.Drawing.Point(440, 21);
            this.ProgName.Name = "ProgName";
            this.ProgName.Size = new System.Drawing.Size(106, 25);
            this.ProgName.TabIndex = 43;
            this.ProgName.Text = "RFR DAQ";
            // 
            // varStat1
            // 
            this.varStat1.AutoEllipsis = true;
            this.varStat1.AutoSize = true;
            this.varStat1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.varStat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varStat1.Location = new System.Drawing.Point(525, 310);
            this.varStat1.Name = "varStat1";
            this.varStat1.Size = new System.Drawing.Size(146, 24);
            this.varStat1.TabIndex = 44;
            this.varStat1.Text = "Variables Empty";
            // 
            // varStat2
            // 
            this.varStat2.AutoEllipsis = true;
            this.varStat2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.varStat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varStat2.Location = new System.Drawing.Point(758, 310);
            this.varStat2.Name = "varStat2";
            this.varStat2.Size = new System.Drawing.Size(146, 24);
            this.varStat2.TabIndex = 45;
            this.varStat2.Text = "Variables Empty";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(624, 369);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(62, 95);
            this.listBox1.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(742, 369);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(61, 95);
            this.listBox2.TabIndex = 48;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(847, 369);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(57, 95);
            this.listBox3.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(946, 573);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.varStat2);
            this.Controls.Add(this.varStat1);
            this.Controls.Add(this.ProgName);
            this.Controls.Add(this.label_x2);
            this.Controls.Add(this.label_y2);
            this.Controls.Add(this.label_z2);
            this.Controls.Add(this.label_x1);
            this.Controls.Add(this.label_y1);
            this.Controls.Add(this.label_z1);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.Read2);
            this.Controls.Add(this.Read1);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Annimation_channel3);
            this.Controls.Add(this.Annimation_channel2);
            this.Controls.Add(this.Annimation_channel1);
            this.Controls.Add(this.Load_file2);
            this.Controls.Add(this.Load_file1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Load_file1;
        private System.Windows.Forms.Button Load_file2;
        private System.Windows.Forms.Button Annimation_channel1;
        private System.Windows.Forms.Button Annimation_channel2;
        private System.Windows.Forms.Button Annimation_channel3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.CheckedListBox Speed;
        private System.Windows.Forms.Button Read1;
        private System.Windows.Forms.Button Read2;
        private System.Windows.Forms.Label file1;
        private System.Windows.Forms.Label file2;
        private System.Windows.Forms.Label label_z1;
        private System.Windows.Forms.Label label_y1;
        private System.Windows.Forms.Label label_x1;
        private System.Windows.Forms.Label label_z2;
        private System.Windows.Forms.Label label_y2;
        private System.Windows.Forms.Label label_x2;
        private System.Windows.Forms.Label ProgName;
        private System.Windows.Forms.Label varStat1;
        private System.Windows.Forms.Label varStat2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

