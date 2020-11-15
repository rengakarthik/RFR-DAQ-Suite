namespace iss_bar_ho_jaega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.Panel();
            this.DriverData = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.RFRlogo = new System.Windows.Forms.PictureBox();
            this.topbar = new System.Windows.Forms.Panel();
            this.Pause = new FontAwesome.Sharp.IconButton();
            this.S = new FontAwesome.Sharp.IconButton();
            this.Slow = new FontAwesome.Sharp.IconButton();
            this.PS = new FontAwesome.Sharp.IconButton();
            this.Fast = new FontAwesome.Sharp.IconButton();
            this.FileName2 = new System.Windows.Forms.Label();
            this.FileName1 = new System.Windows.Forms.Label();
            this.Load2 = new FontAwesome.Sharp.IconButton();
            this.Load1 = new FontAwesome.Sharp.IconButton();
            this.mainArea = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RFRlogo)).BeginInit();
            this.topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sidebar.Controls.Add(this.DriverData);
            this.sidebar.Controls.Add(this.HomeButton);
            this.sidebar.Controls.Add(this.RFRlogo);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 711);
            this.sidebar.TabIndex = 0;
            // 
            // DriverData
            // 
            this.DriverData.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DriverData.FlatAppearance.BorderSize = 0;
            this.DriverData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.DriverData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DriverData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DriverData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverData.ForeColor = System.Drawing.Color.Lime;
            this.DriverData.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.DriverData.IconColor = System.Drawing.Color.Lime;
            this.DriverData.IconSize = 32;
            this.DriverData.Location = new System.Drawing.Point(0, 390);
            this.DriverData.Margin = new System.Windows.Forms.Padding(0);
            this.DriverData.Name = "DriverData";
            this.DriverData.Rotation = 0D;
            this.DriverData.Size = new System.Drawing.Size(200, 100);
            this.DriverData.TabIndex = 2;
            this.DriverData.Text = "Driver Data";
            this.DriverData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DriverData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DriverData.UseVisualStyleBackColor = false;
            this.DriverData.Click += new System.EventHandler(this.DriverData_Click_1);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.Lime;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeButton.IconColor = System.Drawing.Color.Lime;
            this.HomeButton.IconSize = 32;
            this.HomeButton.Location = new System.Drawing.Point(0, 254);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Rotation = 0D;
            this.HomeButton.Size = new System.Drawing.Size(200, 100);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // RFRlogo
            // 
            this.RFRlogo.Image = ((System.Drawing.Image)(resources.GetObject("RFRlogo.Image")));
            this.RFRlogo.Location = new System.Drawing.Point(0, 0);
            this.RFRlogo.Margin = new System.Windows.Forms.Padding(0);
            this.RFRlogo.Name = "RFRlogo";
            this.RFRlogo.Size = new System.Drawing.Size(200, 200);
            this.RFRlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RFRlogo.TabIndex = 0;
            this.RFRlogo.TabStop = false;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topbar.Controls.Add(this.Pause);
            this.topbar.Controls.Add(this.S);
            this.topbar.Controls.Add(this.Slow);
            this.topbar.Controls.Add(this.PS);
            this.topbar.Controls.Add(this.Fast);
            this.topbar.Controls.Add(this.FileName2);
            this.topbar.Controls.Add(this.FileName1);
            this.topbar.Controls.Add(this.Load2);
            this.topbar.Controls.Add(this.Load1);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(200, 0);
            this.topbar.Margin = new System.Windows.Forms.Padding(0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1064, 100);
            this.topbar.TabIndex = 1;
            // 
            // Pause
            // 
            this.Pause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Pause.ForeColor = System.Drawing.Color.Lime;
            this.Pause.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.Pause.IconColor = System.Drawing.Color.Lime;
            this.Pause.IconSize = 16;
            this.Pause.Location = new System.Drawing.Point(364, 25);
            this.Pause.Name = "Pause";
            this.Pause.Rotation = 0D;
            this.Pause.Size = new System.Drawing.Size(50, 50);
            this.Pause.TabIndex = 5;
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // S
            // 
            this.S.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.S.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.S.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.S.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.S.ForeColor = System.Drawing.Color.Lime;
            this.S.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.S.IconColor = System.Drawing.Color.Lime;
            this.S.IconSize = 16;
            this.S.Location = new System.Drawing.Point(566, 25);
            this.S.Name = "S";
            this.S.Rotation = 0D;
            this.S.Size = new System.Drawing.Size(50, 50);
            this.S.TabIndex = 4;
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // Slow
            // 
            this.Slow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Slow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.Slow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Slow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Slow.ForeColor = System.Drawing.Color.Lime;
            this.Slow.IconChar = FontAwesome.Sharp.IconChar.FastBackward;
            this.Slow.IconColor = System.Drawing.Color.Lime;
            this.Slow.IconSize = 16;
            this.Slow.Location = new System.Drawing.Point(430, 25);
            this.Slow.Name = "Slow";
            this.Slow.Rotation = 0D;
            this.Slow.Size = new System.Drawing.Size(40, 50);
            this.Slow.TabIndex = 1;
            this.Slow.UseVisualStyleBackColor = true;
            this.Slow.Click += new System.EventHandler(this.Slow_Click);
            // 
            // PS
            // 
            this.PS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.PS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.PS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PS.ForeColor = System.Drawing.Color.Lime;
            this.PS.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.PS.IconColor = System.Drawing.Color.Lime;
            this.PS.IconSize = 16;
            this.PS.Location = new System.Drawing.Point(493, 25);
            this.PS.Name = "PS";
            this.PS.Rotation = 0D;
            this.PS.Size = new System.Drawing.Size(50, 50);
            this.PS.TabIndex = 2;
            this.PS.UseVisualStyleBackColor = true;
            this.PS.Click += new System.EventHandler(this.PS_Click);
            // 
            // Fast
            // 
            this.Fast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.Fast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Fast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fast.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Fast.ForeColor = System.Drawing.Color.Lime;
            this.Fast.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            this.Fast.IconColor = System.Drawing.Color.Lime;
            this.Fast.IconSize = 16;
            this.Fast.Location = new System.Drawing.Point(640, 25);
            this.Fast.Name = "Fast";
            this.Fast.Rotation = 0D;
            this.Fast.Size = new System.Drawing.Size(40, 50);
            this.Fast.TabIndex = 3;
            this.Fast.UseVisualStyleBackColor = true;
            this.Fast.Click += new System.EventHandler(this.Fast_Click);
            // 
            // FileName2
            // 
            this.FileName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileName2.AutoEllipsis = true;
            this.FileName2.BackColor = System.Drawing.Color.Transparent;
            this.FileName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName2.ForeColor = System.Drawing.Color.Lime;
            this.FileName2.Location = new System.Drawing.Point(800, 35);
            this.FileName2.Name = "FileName2";
            this.FileName2.Size = new System.Drawing.Size(150, 25);
            this.FileName2.TabIndex = 3;
            this.FileName2.Text = "File 2";
            this.FileName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileName1
            // 
            this.FileName1.AutoEllipsis = true;
            this.FileName1.BackColor = System.Drawing.Color.Transparent;
            this.FileName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName1.ForeColor = System.Drawing.Color.Lime;
            this.FileName1.Location = new System.Drawing.Point(30, 35);
            this.FileName1.Name = "FileName1";
            this.FileName1.Size = new System.Drawing.Size(150, 25);
            this.FileName1.TabIndex = 2;
            this.FileName1.Text = "File 1";
            this.FileName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Load2
            // 
            this.Load2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.Load2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Load2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Load2.ForeColor = System.Drawing.Color.Lime;
            this.Load2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Load2.IconColor = System.Drawing.Color.Black;
            this.Load2.IconSize = 16;
            this.Load2.Location = new System.Drawing.Point(969, 33);
            this.Load2.Name = "Load2";
            this.Load2.Rotation = 0D;
            this.Load2.Size = new System.Drawing.Size(83, 27);
            this.Load2.TabIndex = 1;
            this.Load2.Text = "Load2";
            this.Load2.UseVisualStyleBackColor = true;
            this.Load2.Click += new System.EventHandler(this.Load2_Click);
            // 
            // Load1
            // 
            this.Load1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.Load1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Load1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Load1.ForeColor = System.Drawing.Color.Lime;
            this.Load1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Load1.IconColor = System.Drawing.Color.Black;
            this.Load1.IconSize = 16;
            this.Load1.Location = new System.Drawing.Point(203, 33);
            this.Load1.Name = "Load1";
            this.Load1.Rotation = 0D;
            this.Load1.Size = new System.Drawing.Size(83, 27);
            this.Load1.TabIndex = 0;
            this.Load1.Text = "Load1";
            this.Load1.UseVisualStyleBackColor = true;
            this.Load1.Click += new System.EventHandler(this.Load1_Click);
            // 
            // mainArea
            // 
            this.mainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainArea.Location = new System.Drawing.Point(200, 100);
            this.mainArea.Margin = new System.Windows.Forms.Padding(0);
            this.mainArea.Name = "mainArea";
            this.mainArea.Size = new System.Drawing.Size(1064, 611);
            this.mainArea.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.mainArea);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RFRlogo)).EndInit();
            this.topbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel mainArea;
        private System.Windows.Forms.PictureBox RFRlogo;
        private FontAwesome.Sharp.IconButton HomeButton;
        private FontAwesome.Sharp.IconButton DriverData;
        private FontAwesome.Sharp.IconButton Load1;
        private System.Windows.Forms.Label FileName2;
        private System.Windows.Forms.Label FileName1;
        private FontAwesome.Sharp.IconButton Load2;
        private FontAwesome.Sharp.IconButton Slow;
        private FontAwesome.Sharp.IconButton Fast;
        private FontAwesome.Sharp.IconButton S;
        private FontAwesome.Sharp.IconButton PS;
        private FontAwesome.Sharp.IconButton Pause;
    }
}

