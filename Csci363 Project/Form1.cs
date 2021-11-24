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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Loads second form after first form is loaded
            Simulator simulation = new Simulator();
            simulation.Show();
        }

        private void clockTimer_Tick_1(object sender, EventArgs e)
        {
            // Sets and updates clock time, label is called "clock"
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void runtime_Tick(object sender, EventArgs e)
        {
            // Increments runetime timer
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

            sysMsgBox.Items.Add(messageToAdd);
            sysMsgBox.Items.Add(secondMessage);

            if (sysMsgBox.Items.Count == 8)
            {
                sysMsgBox.Items.RemoveAt(1);
                sysMsgBox.Items.RemoveAt(0);
            }

            insulinTimer.Enabled = false;
            insulinCounter.Text = " ";
            counter = 0;
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
            } 
            else
            {
                // Switch to auto mode
                operationModeLabel.Text = "Auto";
            }
        }

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

        private void systemReset()
        {
            hour = 0;
            minute = 0;
            second = 0;

            totalShots = 0;
        }

        private void sysMsgBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
