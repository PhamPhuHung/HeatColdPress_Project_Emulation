using HeatCold_Press.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatCold_Press
{
    public partial class Form1 : Form
    {
        int currentStep = 0;
        XStation x;
        YStation y;
        int check;
        DateTime start, stop;
        DateTime duration;
        public Form1()
        {
            InitializeComponent();
            InitializeParameter();
        }
        
        private void InitializeParameter()
        {
            tbH1Time.Text = (CONS.HeatPressTime/1000).ToString();
            tbH2Time.Text = (CONS.HeatPressTime / 1000).ToString();
            tbC1Time.Text = (CONS.ColdPressTime/1000).ToString();
            tbC2Time.Text = (CONS.ColdPressTime/1000).ToString();

            timerH1.Interval = CONS.TimerInterval;
            timerH2.Interval = CONS.TimerInterval;
            timerC1.Interval = CONS.TimerInterval;
            timerC2.Interval = CONS.TimerInterval;

            x = new XStation() { x1 = 0, x2 = 0, noSewIsWorking = true };
            y = new YStation() { y1 = 0, y2 = 0 };
        }

        private void UpdateParameter()
        {
            tbH1Time.Enabled = false;
            tbH2Time.Enabled = false;
            tbC1Time.Enabled = false;
            tbC2Time.Enabled = false;

            CONS.HeatPressTime = (int)Convert.ToDouble(tbH1Time.Text) * 1000; 
            CONS.ColdPressTime = (int)Convert.ToDouble(tbC1Time.Text) * 1000;

            pbarH1.Maximum = CONS.HeatPressTime;
            pbarH2.Maximum = CONS.HeatPressTime;
            pbarC1.Maximum = CONS.ColdPressTime;
            pbarC2.Maximum = CONS.ColdPressTime;

            lbRobot.Text = CONS.RobotStep[currentStep];
            x = new XStation() { x1 = 1000, x2 = 0, noSewIsWorking = true };
            y = new YStation() { y1 = 0, y2 = 0 };
            lbX1.Text = x.x1.ToString();
            currentStep = 0;
        }
        private void btSettings_Click(object sender, EventArgs e)
        {

        }

        private void btX1_Click(object sender, EventArgs e)
        {
            x.x1++;
            lbX1.Text = x.x1.ToString();
        }

        private void btX2_Click(object sender, EventArgs e)
        {
            if(x.x2 == 1)
            {
                x.x2 = 2;
                lbX2.BackColor = Color.Green;
                y.y2 = 1;
                lbY2.BackColor = Color.Yellow;
            }
        }

        private void btY2_Click(object sender, EventArgs e)
        {
            if(y.y2 == 1)
            {
                y.y2 = 2;
                lbY2.BackColor = Color.Green;
            }
        }

        private void btRobotNext_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                RobotPerfomceStep(currentStep);
            }
            else
            {
                CheckStep(currentStep);
            }
        }

        private void timerH1_Tick(object sender, EventArgs e)
        {
            try
            {
                pbarH1.Value += CONS.TimerInterval;
                tbH1Time.Text = ((pbarH1.Maximum - pbarH1.Value)/1000.0).ToString("0.0");
            }
            catch
            {
                timerH1.Stop();
            }
        }

        private void timerH2_Tick(object sender, EventArgs e)
        {
            try
            {
                pbarH2.Value += CONS.TimerInterval;
                tbH2Time.Text = ((pbarH2.Maximum - pbarH2.Value) / 1000.0).ToString("0.0");
            }
            catch
            {
                timerH2.Stop();
            }
        }

        private void timerC1_Tick(object sender, EventArgs e)
        {
            try
            {
                pbarC1.Value += CONS.TimerInterval;
                tbC1Time.Text = ((pbarC1.Maximum - pbarC1.Value) / 1000.0).ToString("0.0");
            }
            catch
            {
                timerC1.Stop();
            }
        }

        private void timerC2_Tick(object sender, EventArgs e)
        {
            try
            {
                pbarC2.Value += CONS.TimerInterval;
                tbC2Time.Text = ((pbarC2.Maximum - pbarC2.Value) / 1000.0).ToString("0.0");
            }
            catch
            {
                timerC2.Stop();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {

        }

        private void RobotPerfomceStep(int step)
        {
            switch (step)
            {
                case 0://E2
                    E2();
                    CheckB1();
                    break;
                case 1://B1
                    B1();
                    CheckA1();
                    break;
                case 2://A1
                    A1();
                    CheckD2();
                    break;
                case 3://D2
                    D2();
                    CheckE1();
                    break;
                case 4://E1
                    E1();
                    CheckB2();
                    break;
                case 5://B2
                    B2();
                    CheckA2();
                    break;
                case 6://A2
                    A2();
                    CheckD1();
                    break;
                case 7://D1
                    D1();
                    CheckE2();
                    break;
                default:
                    break;
            }
        }

        private void CheckStep(int step)
        {
            switch (step)
            {
                case 0://E2
                    CheckE2();
                    break;
                case 1://B1
                    CheckB1();
                    break;
                case 2://A1
                    CheckA1();
                    break;
                case 3://D2
                    CheckD2();
                    break;
                case 4://E1
                    CheckE1();
                    break;
                case 5://B2
                    CheckB2();
                    break;
                case 6://A2
                    CheckA2();
                    break;
                case 7://D1
                    CheckD1();
                    break;
                default:
                    break;
            }
        }
        private void MoveToNextStep()
        {
            currentStep++;
            if (currentStep >= CONS.TotalStep) currentStep = 0;
        }
        private void ShowStep(bool stepIsReady)
        {
            lbRobot.Text = CONS.RobotStep[currentStep];
            if (stepIsReady) lbRobot.BackColor = Color.Green;
            else lbRobot.BackColor = Color.Transparent;
        }
        public int CheckE2()
        {
            check = 1;
            if (pbarC2.Value >= CONS.ColdPressTime)// Pizza pan already come out from H1 -> perfomce step
            {
                check = 1;
                ShowStep(true);
            }
            else if (pbarC2.Value < CONS.ColdPressTime && timerC2.Enabled == true)//H1 still pressing -> waiting
            {
                check = 0;
                ShowStep(false);
            }
            else if (pbarC2.Value < CONS.HeatPressTime && timerC2.Enabled == false)//C2 don't have pizza pan -> skip step
            {
                check = 2;
                currentStep++;
                CheckB1();
            }
            return check;
        }
        private void E2()        
        {
                pbarC2.Value = 0;
                y.y1++;
                lbY1.Text = y.y1.ToString();
                lbC2.BackColor = Color.White;

            currentStep++;
            //if (currentStep >= CONS.TotalStep) currentStep = 0;
            //lbRobot.Text = CONS.RobotStep[currentStep];

        }
        private int CheckB1()
        {
            check = 1;
            if (pbarH1.Value >= CONS.HeatPressTime)// Pizza pan already come out from H1 -> perfomce step
            {
                check = 1;
                ShowStep(true);
            }
            else if (pbarH1.Value < CONS.HeatPressTime && timerH1.Enabled == true)//H1 still pressing -> waiting
            {
                check = 0;
                ShowStep(false);
            }
            else if (pbarH1.Value < CONS.HeatPressTime && timerH1.Enabled == false)//H1 don't have pizza pan -> skip step
            {
                check = 2;
                currentStep++;
                CheckA1();
            }
            return check;
        }
        private void B1()
        {
            pbarH1.Value = 0;
            x.x2 = 1;
            lbX2.BackColor = Color.Yellow;
            lbH1.BackColor = Color.White;
            currentStep++;

        }
        private int CheckA1()
        {
            check = 1;
            if (pbarH1.Value < CONS.HeatPressTime && timerH1.Enabled == false && x.x1 > 0) // H1 don't have pizza pan, CVX have pizza pan -> performce step
            {
                check = 1;
                ShowStep(true);
            } 
            else if (pbarH1.Value < CONS.HeatPressTime && timerH1.Enabled == false && x.x1 <= 0)// H1 don't have pizza pan, CVX don't have pizza pan -> waiting
            {
                check = 0;
                ShowStep(false);
            }
            else if (x.noSewIsWorking == false)
            {
                check = 2;
                currentStep++;
                CheckD2();
            }
            return check;
        }
        private void A1()
        {
            timerH1.Start();
            x.x1--;
            lbX1.Text = x.x1.ToString();
            lbH1.BackColor = Color.Transparent;

            currentStep++;

        }
        private int CheckD2()
        {
            check = 1;

            if (pbarC2.Value < CONS.HeatPressTime && timerC2.Enabled == false && y.y2 == 2) // C2 don't have pizza pan, Already put silicon on pizza pan on Y2
            {
                check = 1;
                ShowStep(true);
            }
            else if (pbarC2.Value < CONS.HeatPressTime && timerC2.Enabled == false && y.y2 == 1)// C2 don't have pizza pan, Still not put sillicon on pizza pan on Y2
            {
                check = 0;
                ShowStep(false);
            }
            else if (y.y2 == 0)// C2 still working OR no pizza pan on Y2
            {
                check = 2;
                currentStep++;
                CheckE1();
            }
            return check;
        }
        private void D2()
        {
            timerC2.Start();
            y.y2 = 0;
            //lbY2.BackColor = Color.White;
            lbC2.BackColor = Color.Transparent;

            currentStep++;

        }
        private int CheckE1()
        {
            check = 1;
            if (pbarC1.Value >= CONS.ColdPressTime)// Pizza pan already come out from H1 -> perfomce step
            {
                check = 1;
                ShowStep(true);
            }
            else if (pbarC1.Value < CONS.ColdPressTime && timerC1.Enabled == true)//H1 still pressing -> waiting
            {
                check = 0;
                ShowStep(false);
            }
            else if (pbarC1.Value < CONS.HeatPressTime && timerC1.Enabled == false)//C2 don't have pizza pan -> skip step
            {
                check = 2;
                currentStep++;
                CheckB2();
            }
            return check;
        }
        private void E1()
        {
            pbarC1.Value = 0;
            y.y1++;
            lbY1.Text = y.y1.ToString();
            lbC1.BackColor = Color.White;


            currentStep++;

        }
        private int CheckB2()
        {
            check = 1;
            if (pbarH2.Value >= CONS.HeatPressTime)// Pizza pan already come out from H2 -> perfomce step
            {
                check = 1;
                ShowStep(true);
            }
            else if (pbarH2.Value < CONS.HeatPressTime && timerH2.Enabled == true)//H2 still pressing -> waiting
            {
                check = 0;
                ShowStep(false);
            }
            else if (pbarH2.Value < CONS.HeatPressTime && timerH2.Enabled == false)// H2 don't have pizza pan -> skip step
            {
                check = 2;
                currentStep++;
                CheckA2();
            }
            return check;
        }
        private void B2()
        {
            pbarH2.Value = 0;
            x.x2 = 1;
            lbX2.BackColor = Color.Yellow;
            lbH2.BackColor = Color.White;

            currentStep++;
        }
        private int CheckA2()
        {
            check = 1;
            if (pbarH2.Value < CONS.HeatPressTime && timerH2.Enabled == false && x.x1 > 0) // H1 don't have pizza pan, CVX have pizza pan -> performce step
            {
                check = 1;
                ShowStep(true);
            }
            else if (pbarH2.Value < CONS.HeatPressTime && timerH2.Enabled == false && x.x1 <= 0)// H1 don't have pizza pan, CVX don't have pizza pan -> waiting
            {
                check = 0;
                ShowStep(false);
            }
            else if (x.noSewIsWorking == false)
            {
                check = 2;
                currentStep++;
                CheckD1();
            }
            return check;
        }
        private void A2()
        {
            timerH2.Start();
            x.x1--;
            lbX1.Text = x.x1.ToString();
            lbH2.BackColor = Color.Transparent;

            currentStep++;

        }
        private int CheckD1()
        {
            check = 1;
            if (pbarC1.Value < CONS.HeatPressTime && timerC1.Enabled == false && y.y2 == 2) // C1 don't have pizza pan, Already put silicon on pizza pan on Y2
            {
                check = 1;
                ShowStep(true);
            }
            else if (pbarC1.Value < CONS.HeatPressTime && timerC1.Enabled == false && y.y2 == 1)// C1 don't have pizza pan, Still not put sillicon on pizza pan on Y2
            {
                check = 0;
                ShowStep(false);
            }
            else if (y.y2 == 0)// C2 still working OR no pizza pan on Y2
            {
                check = 2;
                currentStep= 0;
                CheckE1();
            }
            return check;
        }
        private void D1()
        {
            timerC1.Start();
            y.y2 = 0;
            lbY2.BackColor = Color.White;
            lbC1.BackColor = Color.Transparent;

            currentStep = 0;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            x.noSewIsWorking = false;
            btEnd.Enabled = true;
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            double time = duration.Hour + duration.Minute / 60.0 + duration.Second / 3600.0;
            double count = Convert.ToDouble(lbY1.Text);
            double productivity = count / time;
            MessageBox.Show("Duration: " + time.ToString() + " hrs\n" +
                                            "Total: " + count.ToString() + " pizza pans\n" +
                                            "Productivity: " + productivity.ToString() + " pizza pans / hrs");

            tbH1Time.Enabled = true;
            tbH2Time.Enabled = true;
            tbC1Time.Enabled = true;
            tbC2Time.Enabled = true;
            btStart.Enabled = true;

            timerH1.Enabled = false;
            timerH2.Enabled = false;
            timerC1.Enabled = false;
            timerC2.Enabled = false;
            timerDuration.Enabled = false;
            lbDuration.Text = "00:00:00";

            pbarH1.Value = 0;
            pbarH2.Value = 0;
            pbarC1.Value = 0;
            pbarC2.Value = 0;

            lbH1.BackColor = Color.White;
            lbH2.BackColor = Color.White;
            lbC2.BackColor = Color.White;
            lbC2.BackColor = Color.White;

            lbX1.Text = "0";
            lbX2.BackColor = Color.Green;
            lbY1.Text = "0";
            lbY2.BackColor = Color.Green;

            lbRobot.Text = "";

            btEnd.Enabled = false;
            btStop.Enabled = false;
        }

        private void timerDuration_Tick(object sender, EventArgs e)
        {
            duration = duration.AddSeconds(1);
            lbDuration.Text = duration.Hour.ToString("00") + ":" + duration.Minute.ToString("00") + ":" + duration.Second.ToString("00");
        }

        private void tbH1Time_TextChanged(object sender, EventArgs e)
        {
            if (btStart.Enabled == true) tbH2Time.Text = tbH1Time.Text;
        }

        private void tbC1Time_TextChanged(object sender, EventArgs e)
        {

            if (btStart.Enabled == true) tbC2Time.Text = tbC1Time.Text;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            x.noSewIsWorking = true;
            pnX.Enabled = true;
            pnY.Enabled = true;
            pnRobot.Enabled = true;
            btStart.Enabled = false;
            btStop.Enabled = true;

            UpdateParameter();
            CheckE2();

            timerDuration.Start();
            duration = new DateTime(2021,6, 20, 0,0,0);
        }
    }
}
