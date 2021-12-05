using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csci363_Project
{
    public partial class Form1 : Form
    {
        // Used to track amount of insulin shots
        int counter = 0;
        int totalShots = 0;
        int insulinReservoir = 100;

        // Used to track blood sugar levels
        List<double> bloodSugarLevels = new List<double>();
        List<double> bloodSugarLevelsTime = new List<double>();


        // Used to track runtime timer
        int hour = 20;
        int minute = 0;
        int second = 0;

        // Keeps track of warnings and loops through them
        List<string> warnings = new List<string>();
        int index = 0;
        int length;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Loads second form after first form is loaded
            Simulator simulation = new Simulator(this);
            simulation.Show();

            chart1.ChartAreas[0].AxisX.Maximum = 12;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 300;

            chart1.ChartAreas[0].AxisX.Title = "Time (hours)";
            chart1.ChartAreas[0].AxisY.Title = "Blood Sugar (mg/dL)";

            var bloodSugar = new List<double>() {150, 200, 140, 175, 160, 125};
            var runtimes = new List<double>() {0, 4, 8, 12, 16, 20};

            for (int i = 0; i < bloodSugar.Count(); i++) 
            {
                chart1.Series[0].Points.AddXY(runtimes[i], bloodSugar[i]);
            }


            for (int i = 0; i < 26; i++)
            {
                chart1.Series[1].Points.AddXY(i, 80);
                chart1.Series[2].Points.AddXY(i, 160);
            }
        }


        // Clocks for time and runtime, and the timer that tracks insulin over 5 seconds
        private void clockTimer_Tick_1(object sender, EventArgs e)
        {
            // Sets and updates clock time, label is called "clock"
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void runtime_Tick(object sender, EventArgs e)
        {
            // Increments runtime timer
            second += 1;
            string currentRunTime = calculateRunTime();
            runtimeLabel.Text = currentRunTime;

            if (hour >= 24)
            {
                systemReset();
                totalShots = 0;
            }
        }

        private void insulinTimer_Tick(object sender, EventArgs e)
        {
            // Used to time 5 seconds for insulin delivery
            deliverInsulin(counter);

            insulinTimer.Enabled = false;
            insulinCounter.Text = " ";

            counter = 0;
        }
        

        // Timers for self-tests
        private void bloodSugarTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void hardwareTimer_Tick(object sender, EventArgs e)
        {
            // This isn't done - If condition happens, add warning - I'm just not sure what to have as the conditions for each of these
            if (this.warnings.Contains("No Needle Unit") || this.warnings.Contains("Needle Failure"))
            {
                addWarning("No Needle Unit");
                addWarning("Needle Failure");
            }

            if (this.warnings.Contains("Sensor Failure"))
            {
                addWarning("Sensor Failure");
            }

            if (this.warnings.Contains("Pump Failure"))
            {
                addWarning("Pump Failure");
            }

            if (this.warnings.Contains("Low Battery"))
            {
                addWarning("Low Battery");
            }
        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {

        }


        // Fixing Broken Things
        public void replaceReservoir()
        {
            insulinReservoir = 100;
        }


        // Code to add messages to insulinMessages
        public void addInsulinMessage(string message)
        {
            insulinMessages.Items.Add(message);
            if (insulinMessages.Items.Count >= 8)
            {
                insulinMessages.Items.RemoveAt(1);
                insulinMessages.Items.RemoveAt(0);
            }
        }


        //Code to add blood sugar level to list
        public void addSugarLevel(double value)
        {
            double time = minute / 24;
            double xtime = hour + time;

            bloodSugarLevelsTime.Add(xtime);
            bloodSugarLevels.Add(value);

            if (xtime > chart1.ChartAreas[0].AxisX.Maximum)
            {
                chart1.ChartAreas[0].AxisX.Maximum += 12;
                chart1.ChartAreas[0].AxisX.Minimum += 12;
            }

            if (chart1.ChartAreas[0].AxisX.Maximum == 24 && xtime < chart1.ChartAreas[0].AxisX.Minimum)
            {
                chart1.Series[0].Points.Clear();

                /*for (int i = 0; i < bloodSugarLevels.Count(); i++)
                {
                    List<double> newbloodSugarLevels = new List<double>();
                    List<double> newbloodSugarLevelsTime = new List<double>();

                    if (!(bloodSugarLevelsTime[i] - 12 < 0))
                    {
                        newbloodSugarLevels.Add(bloodSugarLevels[i]);
                        newbloodSugarLevelsTime.Add(bloodSugarLevelsTime[i] - 12);
                    }
                }*/
                int length = bloodSugarLevels.Count();
                double finalval = bloodSugarLevels[length - 1] - 24;
                double finaltime = bloodSugarLevelsTime[length - 1] - 24;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = 12;

                bloodSugarLevels.Clear();
                bloodSugarLevelsTime.Clear();
            }

            chart1.Series[0].Points.AddXY(xtime, value);
            if (chart1.Series[0].Points.Count > 100)
            {
                chart1.Series[0].Points.RemoveAt(0);
            }
        }


        // Functions related to warnings
        public void warningRemove(string warning)
        {
            // Used to remove warnings from the list, right now has a bug
            if (this.warnings.Contains(warning))
            {
                this.warnings.Remove(warning);
                length -= 1;
                if (length == 0)
                {
                    errorLabel.Visible = false;
                }
            }
        }

        public void systemWarnings(string warning)
        {
            // This isn't needed with add warnings
            switch (warning)
            {
                case "No Needle Unit":
                    addWarning("No Needle Unit");
                    break;

                case "No Insulin Remaining":
                    addWarning("No Insulin Remaining");
                    break;

                case "Low Insulin Level":
                    addWarning("Low Insulin Level");
                    break;

                case "Low Battery":
                    addWarning("Low Battery");
                    break;

                case "Pump Failure":
                    addWarning("Pump Failure");
                    break;

                case "Needle Failure":
                    addWarning("Needle Failure");
                    break;

                case "Sensor Failure":
                    addWarning("Sensor Failure");
                    break;

                case "Sugar Low":
                    addWarning("Sugar Low");
                    break;
            }
        }

        private void addWarning(string warning)
        {
            if (!this.warnings.Contains(warning))
            {
                this.warnings.Add(warning);
                length += 1;

                if (length == 1)
                {
                    errorLabel.Text = warning;
                    errorLabel.Visible = true;
                }
                else if (systemMessageTimer.Enabled == false && length >= 2)
                {
                    systemMessageTimer.Enabled = true;
                }
            }
        }

        
        // Cycles through messages on system if there are more than 1
        private void systemMessageTimer_Tick(object sender, EventArgs e)
        {
            // Timer used to cycle through messages
            if (length == 0)
            {
                systemMessageTimer.Enabled = false;
                
            }
            
            if (index >= length)
            { 
                index = 0;
            }

            if (length == 0)
            {
                systemMessageTimer.Enabled = false;
                errorLabel.Text = "";
                errorLabel.Visible = false;
            } 
            else
            {
                errorLabel.Text = this.warnings[index];
                index += 1;
            }
        }

        private void insulinButton_Click(object sender, EventArgs e)
        {
            // Tracks amount of times insulin button pushed in a 5 second interval
            insulinTimer.Enabled = true;
            if (counter < 5)
            {
                counter += 1;
            }

            insulinCounter.Text = counter.ToString();
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            // Changes operator mode
            if (operationModeLabel.Text == "Auto")
            {
                // Switch to manual mode
                operationModeLabel.Text = "Manual";
                insulinButton.Enabled = true;
                insulinButton.Visible = true;
            }
            else if (operationModeLabel.Text == "Manual")
            {
                // Switch to auto mode
                operationModeLabel.Text = "Auto";
                startSystem();
                insulinButton.Enabled = false;
                insulinButton.Visible = false;
            }
        }


        // Calculates run time and returns string
        public string calculateRunTime()
        {
            string currentRunTime = "";

            if (second == 60)
            {
                minute += 1;
                second = 0;
            }

            if (minute == 60)
            {
                hour += 1;
                minute = 0;
            }

            if (hour < 10)
            {
                currentRunTime += "0" + hour;
            }
            else
            {
                currentRunTime += hour;
            }

            currentRunTime += ":";

            if (minute < 10)
            {
                currentRunTime += "0" + minute;
            }
            else
            {
                currentRunTime += minute;
            }

            currentRunTime += ":";

            if (second < 10)
            {
                currentRunTime += "0" + second;
            }
            else
            {
                currentRunTime += second;
            }

            return currentRunTime;
        }


        // System start and stop, as well as the button for toggling both. Does not reset total shots
        public void systemReset()
        {
            hour = 0;
            minute = 0;
            second = 0;


        }

        private void startSystem()
        {
            if (operationModeLabel.Text == "Auto")
            {
                insulinButton.Enabled = false;
            } else
            {
                insulinButton.Enabled = true;
            }

            operatorButton.Enabled = true;
            clockTimer.Enabled = true;
            runtimeTimer.Enabled = true;

            if (bloodSugarTimer.Interval % 1000 == 0)
            {
                bloodSugarTimer.Enabled = true;
                hardwareTimer.Enabled = true;
                alarmTimer.Enabled = true;
            }

            if (offButton.Text == "Turn On")
            {
                offButton.Text = "Turn Off";
            }
        }

        private void stopTimers()
        {
            clockTimer.Enabled = false;
            insulinTimer.Enabled = false;
            runtimeTimer.Enabled = false;
            systemMessageTimer.Enabled = false;
            bloodSugarTimer.Enabled = false;
            hardwareTimer.Enabled = false;
            alarmTimer.Enabled = false;

        }

        public void stopSystem()
        {
            // Stops system when mode is off, I think there is a better way to do this but for now I just individually reset everything to default values
            // Auto mode will have to start what is necessary again

            insulinMessages.Items.Clear();
            insulinMessages.Items.Clear();
            errorLabel.Text = "";
            errorLabel.Visible = false;

            stopTimers();
            systemReset();
            
            operatorButton.Enabled = false;
            insulinButton.Enabled = false;
            insulinCounter.Text = "";
            clock.Text = "00:00:00";
            runtimeLabel.Text = "00:00:00";
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            if (offButton.Text == "Turn Off")
            {
                stopSystem();
                offButton.Text = "Turn On";

            } else
            {
                startSystem();
                offButton.Text = "Turn Off";
            }
        }


        // Sets initial parameters
        public void setParameters(int sugarInterval, int hardwareInterval, int alarmInterval)
        {
            sugarInterval *= 1000;
            hardwareInterval *= 1000;
            alarmInterval *= 1000;

            bloodSugarTimer.Interval = sugarInterval;
            bloodSugarTimer.Enabled = true;

            hardwareTimer.Interval = hardwareInterval;
            hardwareTimer.Enabled = true;

            alarmTimer.Interval = alarmInterval;
            alarmTimer.Enabled = true;

            offButton.Enabled = true;
            operatorButton.Enabled = true;
            startSystem();
        }


        // Code to deliver insulin
        private void deliverInsulin(int dose)
        {
            string doseString = dose.ToString();
            string timeAtDelivery = DateTime.Now.ToString("HH:mm:ss");
            string timeSinceReset = calculateRunTime();

            if (insulinReservoir >= dose && totalShots <= 100)
            {
                insulinReservoir -= dose;
                totalShots += dose;

                string messageToAdd = doseString + " ml insulin dose delivery at " + timeAtDelivery + ", at runtime " + timeSinceReset + ".";
                string secondMessage = "Total shots delivered during runtime: " + totalShots + ". There are " + insulinReservoir + " ml remaining.";

                addInsulinMessage(messageToAdd);
                addInsulinMessage(secondMessage);

                string lastInsulinDose = "Last insulin dose delivered at " + timeAtDelivery;

                insulinDoseLabel.Text = lastInsulinDose;
            }
            else
            {
                if (insulinReservoir >= dose)
                {
                    addInsulinMessage("Not enough insulin available in the reservoir.");
                }
                else
                {
                    addInsulinMessage("Total shots today have exceeded acceptable limits");
                }
            }
        }


        // Extra functions, don't delete
        private void sysMsgBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clock_Click(object sender, EventArgs e)
        {

        }

        public void addRuntime()
        {
            hour += 1;
        }
    }
}
