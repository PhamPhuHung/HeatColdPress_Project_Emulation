
namespace HeatCold_Press
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timerH1 = new System.Windows.Forms.Timer(this.components);
            this.timerH2 = new System.Windows.Forms.Timer(this.components);
            this.timerC1 = new System.Windows.Forms.Timer(this.components);
            this.timerC2 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            this.lbDuration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnX = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbX1 = new System.Windows.Forms.Label();
            this.btX1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.btX2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnY = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbY1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbY2 = new System.Windows.Forms.Label();
            this.btY2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnRobot = new System.Windows.Forms.Panel();
            this.pbRobot = new System.Windows.Forms.PictureBox();
            this.lbRobot = new System.Windows.Forms.Label();
            this.btRobotNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbH1 = new System.Windows.Forms.PictureBox();
            this.lbH1 = new System.Windows.Forms.Label();
            this.pbarH1 = new System.Windows.Forms.ProgressBar();
            this.tbH1Time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbH2 = new System.Windows.Forms.PictureBox();
            this.lbH2 = new System.Windows.Forms.Label();
            this.pbarH2 = new System.Windows.Forms.ProgressBar();
            this.tbH2Time = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbC1 = new System.Windows.Forms.PictureBox();
            this.lbC1 = new System.Windows.Forms.Label();
            this.pbarC1 = new System.Windows.Forms.ProgressBar();
            this.tbC1Time = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pbC2 = new System.Windows.Forms.PictureBox();
            this.lbC2 = new System.Windows.Forms.Label();
            this.pbarC2 = new System.Windows.Forms.ProgressBar();
            this.tbC2Time = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnX.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.pnY.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.pnRobot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).BeginInit();
            this.pbRobot.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH1)).BeginInit();
            this.pbH1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH2)).BeginInit();
            this.pbH2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbC1)).BeginInit();
            this.pbC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbC2)).BeginInit();
            this.pbC2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 232);
            this.label1.TabIndex = 7;
            this.label1.Text = "H1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerH1
            // 
            this.timerH1.Tick += new System.EventHandler(this.timerH1_Tick);
            // 
            // timerH2
            // 
            this.timerH2.Tick += new System.EventHandler(this.timerH2_Tick);
            // 
            // timerC1
            // 
            this.timerC1.Tick += new System.EventHandler(this.timerC1_Tick);
            // 
            // timerC2
            // 
            this.timerC2.Tick += new System.EventHandler(this.timerC2_Tick);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.btStart);
            this.flowLayoutPanel6.Controls.Add(this.btStop);
            this.flowLayoutPanel6.Controls.Add(this.btEnd);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(702, 351);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(273, 150);
            this.flowLayoutPanel6.TabIndex = 16;
            // 
            // timerDuration
            // 
            this.timerDuration.Interval = 1000;
            this.timerDuration.Tick += new System.EventHandler(this.timerDuration_Tick);
            // 
            // lbDuration
            // 
            this.lbDuration.Location = new System.Drawing.Point(836, 505);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(138, 32);
            this.lbDuration.TabIndex = 17;
            this.lbDuration.Text = "00:00:00";
            this.lbDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HeatCold_Press.Properties.Resources.Background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pnX);
            this.panel1.Controls.Add(this.pnY);
            this.panel1.Location = new System.Drawing.Point(9, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 150);
            this.panel1.TabIndex = 18;
            // 
            // pnX
            // 
            this.pnX.BackColor = System.Drawing.Color.Transparent;
            this.pnX.Controls.Add(this.flowLayoutPanel3);
            this.pnX.Controls.Add(this.label2);
            this.pnX.Enabled = false;
            this.pnX.Location = new System.Drawing.Point(5, 0);
            this.pnX.Name = "pnX";
            this.pnX.Size = new System.Drawing.Size(235, 142);
            this.pnX.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label9);
            this.flowLayoutPanel3.Controls.Add(this.lbX1);
            this.flowLayoutPanel3.Controls.Add(this.btX1);
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Controls.Add(this.lbX2);
            this.flowLayoutPanel3.Controls.Add(this.btX2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1, 60);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(234, 87);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 34);
            this.label9.TabIndex = 13;
            this.label9.Text = "CV";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbX1
            // 
            this.lbX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbX1.Location = new System.Drawing.Point(66, 3);
            this.lbX1.Margin = new System.Windows.Forms.Padding(3);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(120, 34);
            this.lbX1.TabIndex = 10;
            this.lbX1.Text = "0";
            this.lbX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btX1
            // 
            this.btX1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btX1.BackgroundImage")));
            this.btX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btX1.Location = new System.Drawing.Point(192, 3);
            this.btX1.Name = "btX1";
            this.btX1.Size = new System.Drawing.Size(35, 37);
            this.btX1.TabIndex = 9;
            this.btX1.UseVisualStyleBackColor = true;
            this.btX1.Click += new System.EventHandler(this.btX1_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 34);
            this.label12.TabIndex = 14;
            this.label12.Text = "Top";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbX2
            // 
            this.lbX2.BackColor = System.Drawing.Color.Green;
            this.lbX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbX2.Location = new System.Drawing.Point(66, 46);
            this.lbX2.Margin = new System.Windows.Forms.Padding(3);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(120, 34);
            this.lbX2.TabIndex = 12;
            this.lbX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btX2
            // 
            this.btX2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btX2.BackgroundImage")));
            this.btX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btX2.Location = new System.Drawing.Point(192, 46);
            this.btX2.Name = "btX2";
            this.btX2.Size = new System.Drawing.Size(35, 37);
            this.btX2.TabIndex = 11;
            this.btX2.UseVisualStyleBackColor = true;
            this.btX2.Click += new System.EventHandler(this.btX2_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnY
            // 
            this.pnY.BackColor = System.Drawing.Color.Transparent;
            this.pnY.Controls.Add(this.flowLayoutPanel5);
            this.pnY.Controls.Add(this.label6);
            this.pnY.Enabled = false;
            this.pnY.Location = new System.Drawing.Point(246, 3);
            this.pnY.Name = "pnY";
            this.pnY.Size = new System.Drawing.Size(235, 150);
            this.pnY.TabIndex = 11;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label10);
            this.flowLayoutPanel5.Controls.Add(this.lbY1);
            this.flowLayoutPanel5.Controls.Add(this.label11);
            this.flowLayoutPanel5.Controls.Add(this.lbY2);
            this.flowLayoutPanel5.Controls.Add(this.btY2);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 59);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(234, 88);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 34);
            this.label10.TabIndex = 14;
            this.label10.Text = "CV";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbY1
            // 
            this.lbY1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbY1.Location = new System.Drawing.Point(66, 3);
            this.lbY1.Margin = new System.Windows.Forms.Padding(3);
            this.lbY1.Name = "lbY1";
            this.lbY1.Size = new System.Drawing.Size(160, 34);
            this.lbY1.TabIndex = 10;
            this.lbY1.Text = "0";
            this.lbY1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 34);
            this.label11.TabIndex = 15;
            this.label11.Text = "Top";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbY2
            // 
            this.lbY2.BackColor = System.Drawing.Color.Green;
            this.lbY2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbY2.Location = new System.Drawing.Point(66, 43);
            this.lbY2.Margin = new System.Windows.Forms.Padding(3);
            this.lbY2.Name = "lbY2";
            this.lbY2.Size = new System.Drawing.Size(120, 34);
            this.lbY2.TabIndex = 12;
            this.lbY2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btY2
            // 
            this.btY2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btY2.BackgroundImage")));
            this.btY2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btY2.Location = new System.Drawing.Point(192, 43);
            this.btY2.Name = "btY2";
            this.btY2.Size = new System.Drawing.Size(35, 37);
            this.btY2.TabIndex = 11;
            this.btY2.UseVisualStyleBackColor = true;
            this.btY2.Click += new System.EventHandler(this.btY2_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(0, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 49);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnRobot
            // 
            this.pnRobot.BackColor = System.Drawing.Color.Transparent;
            this.pnRobot.BackgroundImage = global::HeatCold_Press.Properties.Resources.Robot;
            this.pnRobot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnRobot.Controls.Add(this.pbRobot);
            this.pnRobot.Controls.Add(this.btRobotNext);
            this.pnRobot.Controls.Add(this.label5);
            this.pnRobot.Enabled = false;
            this.pnRobot.Location = new System.Drawing.Point(501, 351);
            this.pnRobot.Name = "pnRobot";
            this.pnRobot.Size = new System.Drawing.Size(195, 150);
            this.pnRobot.TabIndex = 10;
            // 
            // pbRobot
            // 
            this.pbRobot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRobot.Controls.Add(this.lbRobot);
            this.pbRobot.Image = global::HeatCold_Press.Properties.Resources.Auto;
            this.pbRobot.Location = new System.Drawing.Point(9, 55);
            this.pbRobot.Name = "pbRobot";
            this.pbRobot.Size = new System.Drawing.Size(99, 92);
            this.pbRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRobot.TabIndex = 11;
            this.pbRobot.TabStop = false;
            // 
            // lbRobot
            // 
            this.lbRobot.BackColor = System.Drawing.Color.Transparent;
            this.lbRobot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRobot.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbRobot.Location = new System.Drawing.Point(0, 0);
            this.lbRobot.Margin = new System.Windows.Forms.Padding(9);
            this.lbRobot.Name = "lbRobot";
            this.lbRobot.Size = new System.Drawing.Size(99, 92);
            this.lbRobot.TabIndex = 7;
            this.lbRobot.Text = "A1";
            this.lbRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRobotNext
            // 
            this.btRobotNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRobotNext.BackgroundImage")));
            this.btRobotNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRobotNext.Location = new System.Drawing.Point(120, 55);
            this.btRobotNext.Name = "btRobotNext";
            this.btRobotNext.Size = new System.Drawing.Size(75, 88);
            this.btRobotNext.TabIndex = 8;
            this.btRobotNext.UseVisualStyleBackColor = true;
            this.btRobotNext.Click += new System.EventHandler(this.btRobotNext_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 49);
            this.label5.TabIndex = 7;
            this.label5.Text = "ROBOT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStart
            // 
            this.btStart.BackgroundImage = global::HeatCold_Press.Properties.Resources.Start1;
            this.btStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btStart.Location = new System.Drawing.Point(3, 3);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(264, 69);
            this.btStart.TabIndex = 16;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.BackgroundImage = global::HeatCold_Press.Properties.Resources.End1;
            this.btStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(3, 78);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(129, 69);
            this.btStop.TabIndex = 15;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btEnd
            // 
            this.btEnd.BackgroundImage = global::HeatCold_Press.Properties.Resources.Stop;
            this.btEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEnd.Enabled = false;
            this.btEnd.Location = new System.Drawing.Point(138, 78);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(129, 69);
            this.btEnd.TabIndex = 14;
            this.btEnd.Text = "End";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::HeatCold_Press.Properties.Resources.Heat_Press;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.pbH1);
            this.flowLayoutPanel1.Controls.Add(this.pbarH1);
            this.flowLayoutPanel1.Controls.Add(this.tbH1Time);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.pbH2);
            this.flowLayoutPanel1.Controls.Add(this.pbarH2);
            this.flowLayoutPanel1.Controls.Add(this.tbH2Time);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 16);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 160);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(940, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "HEAT PRESS MACHINE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbH1
            // 
            this.pbH1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbH1.Controls.Add(this.lbH1);
            this.pbH1.Image = global::HeatCold_Press.Properties.Resources.Blink;
            this.pbH1.Location = new System.Drawing.Point(8, 60);
            this.pbH1.Margin = new System.Windows.Forms.Padding(8);
            this.pbH1.Name = "pbH1";
            this.pbH1.Size = new System.Drawing.Size(75, 35);
            this.pbH1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbH1.TabIndex = 10;
            this.pbH1.TabStop = false;
            // 
            // lbH1
            // 
            this.lbH1.BackColor = System.Drawing.Color.White;
            this.lbH1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH1.Location = new System.Drawing.Point(0, 0);
            this.lbH1.Margin = new System.Windows.Forms.Padding(9);
            this.lbH1.Name = "lbH1";
            this.lbH1.Size = new System.Drawing.Size(75, 35);
            this.lbH1.TabIndex = 7;
            this.lbH1.Text = "H1";
            this.lbH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbarH1
            // 
            this.pbarH1.BackColor = System.Drawing.Color.Turquoise;
            this.pbarH1.Location = new System.Drawing.Point(99, 60);
            this.pbarH1.Margin = new System.Windows.Forms.Padding(8);
            this.pbarH1.Name = "pbarH1";
            this.pbarH1.Size = new System.Drawing.Size(668, 35);
            this.pbarH1.TabIndex = 1;
            // 
            // tbH1Time
            // 
            this.tbH1Time.Location = new System.Drawing.Point(781, 58);
            this.tbH1Time.Margin = new System.Windows.Forms.Padding(6);
            this.tbH1Time.Name = "tbH1Time";
            this.tbH1Time.Size = new System.Drawing.Size(72, 38);
            this.tbH1Time.TabIndex = 13;
            this.tbH1Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbH1Time.TextChanged += new System.EventHandler(this.tbH1Time_TextChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(862, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 34);
            this.label7.TabIndex = 15;
            this.label7.Text = "second";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbH2
            // 
            this.pbH2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbH2.Controls.Add(this.lbH2);
            this.pbH2.Image = global::HeatCold_Press.Properties.Resources.Blink;
            this.pbH2.Location = new System.Drawing.Point(8, 111);
            this.pbH2.Margin = new System.Windows.Forms.Padding(8);
            this.pbH2.Name = "pbH2";
            this.pbH2.Size = new System.Drawing.Size(75, 35);
            this.pbH2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbH2.TabIndex = 11;
            this.pbH2.TabStop = false;
            // 
            // lbH2
            // 
            this.lbH2.BackColor = System.Drawing.Color.White;
            this.lbH2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH2.Location = new System.Drawing.Point(0, 0);
            this.lbH2.Margin = new System.Windows.Forms.Padding(9);
            this.lbH2.Name = "lbH2";
            this.lbH2.Size = new System.Drawing.Size(75, 35);
            this.lbH2.TabIndex = 7;
            this.lbH2.Text = "H2";
            this.lbH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbarH2
            // 
            this.pbarH2.Location = new System.Drawing.Point(99, 111);
            this.pbarH2.Margin = new System.Windows.Forms.Padding(8);
            this.pbarH2.Name = "pbarH2";
            this.pbarH2.Size = new System.Drawing.Size(668, 35);
            this.pbarH2.TabIndex = 4;
            // 
            // tbH2Time
            // 
            this.tbH2Time.Enabled = false;
            this.tbH2Time.Location = new System.Drawing.Point(781, 109);
            this.tbH2Time.Margin = new System.Windows.Forms.Padding(6);
            this.tbH2Time.Name = "tbH2Time";
            this.tbH2Time.Size = new System.Drawing.Size(72, 38);
            this.tbH2Time.TabIndex = 14;
            this.tbH2Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(862, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "second";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = global::HeatCold_Press.Properties.Resources.Cold_Press;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.pbC1);
            this.flowLayoutPanel2.Controls.Add(this.pbarC1);
            this.flowLayoutPanel2.Controls.Add(this.tbC1Time);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.pbC2);
            this.flowLayoutPanel2.Controls.Add(this.pbarC2);
            this.flowLayoutPanel2.Controls.Add(this.tbC2Time);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 181);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(960, 160);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(941, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "COLD PRESS MACHINE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbC1
            // 
            this.pbC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbC1.Controls.Add(this.lbC1);
            this.pbC1.Image = global::HeatCold_Press.Properties.Resources.Blink;
            this.pbC1.Location = new System.Drawing.Point(8, 60);
            this.pbC1.Margin = new System.Windows.Forms.Padding(8);
            this.pbC1.Name = "pbC1";
            this.pbC1.Size = new System.Drawing.Size(75, 35);
            this.pbC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC1.TabIndex = 10;
            this.pbC1.TabStop = false;
            // 
            // lbC1
            // 
            this.lbC1.BackColor = System.Drawing.Color.White;
            this.lbC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC1.Location = new System.Drawing.Point(0, 0);
            this.lbC1.Margin = new System.Windows.Forms.Padding(9);
            this.lbC1.Name = "lbC1";
            this.lbC1.Size = new System.Drawing.Size(75, 35);
            this.lbC1.TabIndex = 7;
            this.lbC1.Text = "C1";
            this.lbC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbarC1
            // 
            this.pbarC1.Location = new System.Drawing.Point(99, 60);
            this.pbarC1.Margin = new System.Windows.Forms.Padding(8);
            this.pbarC1.Name = "pbarC1";
            this.pbarC1.Size = new System.Drawing.Size(668, 35);
            this.pbarC1.TabIndex = 1;
            // 
            // tbC1Time
            // 
            this.tbC1Time.Location = new System.Drawing.Point(781, 58);
            this.tbC1Time.Margin = new System.Windows.Forms.Padding(6);
            this.tbC1Time.Name = "tbC1Time";
            this.tbC1Time.Size = new System.Drawing.Size(72, 38);
            this.tbC1Time.TabIndex = 12;
            this.tbC1Time.Text = "   ";
            this.tbC1Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbC1Time.TextChanged += new System.EventHandler(this.tbC1Time_TextChanged);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(862, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 38);
            this.label14.TabIndex = 17;
            this.label14.Text = "second";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbC2
            // 
            this.pbC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbC2.Controls.Add(this.lbC2);
            this.pbC2.Image = global::HeatCold_Press.Properties.Resources.Blink;
            this.pbC2.Location = new System.Drawing.Point(8, 111);
            this.pbC2.Margin = new System.Windows.Forms.Padding(8);
            this.pbC2.Name = "pbC2";
            this.pbC2.Size = new System.Drawing.Size(75, 35);
            this.pbC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC2.TabIndex = 11;
            this.pbC2.TabStop = false;
            // 
            // lbC2
            // 
            this.lbC2.BackColor = System.Drawing.Color.White;
            this.lbC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC2.Location = new System.Drawing.Point(0, 0);
            this.lbC2.Margin = new System.Windows.Forms.Padding(9);
            this.lbC2.Name = "lbC2";
            this.lbC2.Size = new System.Drawing.Size(75, 35);
            this.lbC2.TabIndex = 7;
            this.lbC2.Text = "C2";
            this.lbC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbarC2
            // 
            this.pbarC2.Location = new System.Drawing.Point(99, 111);
            this.pbarC2.Margin = new System.Windows.Forms.Padding(8);
            this.pbarC2.Name = "pbarC2";
            this.pbarC2.Size = new System.Drawing.Size(668, 35);
            this.pbarC2.TabIndex = 4;
            // 
            // tbC2Time
            // 
            this.tbC2Time.Enabled = false;
            this.tbC2Time.Location = new System.Drawing.Point(781, 109);
            this.tbC2Time.Margin = new System.Windows.Forms.Padding(6);
            this.tbC2Time.Name = "tbC2Time";
            this.tbC2Time.Size = new System.Drawing.Size(72, 38);
            this.tbC2Time.TabIndex = 13;
            this.tbC2Time.Text = "   ";
            this.tbC2Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(862, 106);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 34);
            this.label13.TabIndex = 16;
            this.label13.Text = "second";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDuration);
            this.Controls.Add(this.pnRobot);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Heat - Cold Pressing Project Simulation";
            this.flowLayoutPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnX.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.pnY.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.pnRobot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).EndInit();
            this.pbRobot.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH1)).EndInit();
            this.pbH1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbH2)).EndInit();
            this.pbH2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbC1)).EndInit();
            this.pbC1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbC2)).EndInit();
            this.pbC2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ProgressBar pbarH1;
        private System.Windows.Forms.ProgressBar pbarH2;
        private System.Windows.Forms.Panel pnX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btX1;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.Button btX2;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnRobot;
        private System.Windows.Forms.Button btRobotNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnY;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label lbY1;
        private System.Windows.Forms.Button btY2;
        private System.Windows.Forms.Label lbY2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerH1;
        private System.Windows.Forms.Timer timerH2;
        private System.Windows.Forms.Timer timerC1;
        private System.Windows.Forms.Timer timerC2;
        private System.Windows.Forms.PictureBox pbH1;
        private System.Windows.Forms.Label lbH1;
        private System.Windows.Forms.PictureBox pbH2;
        private System.Windows.Forms.Label lbH2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbC1;
        private System.Windows.Forms.Label lbC1;
        private System.Windows.Forms.ProgressBar pbarC1;
        private System.Windows.Forms.PictureBox pbC2;
        private System.Windows.Forms.Label lbC2;
        private System.Windows.Forms.ProgressBar pbarC2;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.PictureBox pbRobot;
        private System.Windows.Forms.Label lbRobot;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbC1Time;
        private System.Windows.Forms.TextBox tbC2Time;
        private System.Windows.Forms.TextBox tbH1Time;
        private System.Windows.Forms.TextBox tbH2Time;
        private System.Windows.Forms.Timer timerDuration;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

