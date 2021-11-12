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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clockTimer_Tick_1(object sender, EventArgs e)
        {
            // Sets and updates clock time, label is called "clock"
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void insulinPanel_Paint(object sender, PaintEventArgs e)
        {
            // Panel used to display insulin doses
            
        }

        private void systemPanel_Paint(object sender, PaintEventArgs e)
        {
            // Panel to display system messages

        }

        private void insulinButton_Click(object sender, EventArgs e)
        {

        }

        private void operatorButton_Click(object sender, EventArgs e)
        {

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
    }
}
