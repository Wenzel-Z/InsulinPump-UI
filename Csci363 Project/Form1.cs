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


        // Used to track runtime timer
        int hour = 0;
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

            if (hour == 24)
            {
                systemReset();
            }
        }

        private void insulinTimer_Tick(object sender, EventArgs e)
        {
            // Used to time 5 seconds for insulin delivery
            string counterString = counter.ToString();
            string timeAtDelivery = DateTime.Now.ToString("HH:mm:ss");
            string timeSinceReset = calculateRunTime();

            totalShots += counter;

            string messageToAdd = counterString + " insulin dose delivery at " + timeAtDelivery + ", at runtime " + timeSinceReset + ".";
            string secondMessage = "Total shots delivered during runtime: " + totalShots + ".";

            addInsulinMessage(messageToAdd);
            addInsulinMessage(secondMessage);

            insulinTimer.Enabled = false;
            insulinCounter.Text = " ";
            counter = 0;

            // Need to add safety measures
        }
        

        // Timers for self-tests
        private void bloodSugarTimer_Tick(object sender, EventArgs e)
        {

        }

        private void hardwareTimer_Tick(object sender, EventArgs e)
        {

        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {

        }


        // Code to add messages to insulinMessages
        public void addInsulinMessage(string message)
        {
            insulinMessages.Items.Add(message);
            if (insulinMessages.Items.Count == 8)
            {
                insulinMessages.Items.RemoveAt(1);
                insulinMessages.Items.RemoveAt(0);
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
            }
        }

        public void systemWarnings(string warning)
        {
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
            this.warnings.Add(warning);
            length += 1;

            if (length == 1) 
            {
                systemMessages.Items.Add(warning);
            }
            else if (systemMessageTimer.Enabled == false && length >= 2)
            {
                systemMessageTimer.Enabled = true;
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
                systemMessages.Items.Clear();
            } 
            else
            {
                systemMessages.Items.Clear();
                systemMessages.Items.Add(this.warnings[index]);
                index += 1;
            }
        }

        private void insulinButton_Click(object sender, EventArgs e)
        {
            // Tracks amount of times insulin button pushed in a 5 second interval
            insulinTimer.Enabled = true;
            counter += 1;
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
            }
            else if (operationModeLabel.Text == "Manual")
            {
                // Switch to auto mode
                operationModeLabel.Text = "Auto";
                startSystem();
                insulinButton.Enabled = false;
            }
        }


        // Calculates run time and returns string
        private string calculateRunTime()
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


        // System start and stop, as well as the button for toggling both
        public void systemReset()
        {
            hour = 0;
            minute = 0;
            second = 0;

            totalShots = 0;
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
            systemMessages.Items.Clear();
            insulinMessages.Items.Clear();

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


        // Extra functions, don't delete
        private void sysMsgBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void systemMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
