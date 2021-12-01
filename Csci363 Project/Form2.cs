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
    public partial class Simulator : Form
    {

        private readonly Form1 _form1;

        // Having the form1 as a parameter takes it in as an instance, which allows form2 to interact with it.
        // There is no instance of form2 on form1, so form2 cannot be changed through commands on form1
        public Simulator(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        // Break things
        private void needleUnitButton_Click(object sender, EventArgs e)
        {
            _form1.systemWarnings("No Needle Unit");
        }

        private void noInsulinButton_Click(object sender, EventArgs e)
        {
            _form1.systemWarnings("No Insulin Remaining");
        }

        private void lowInsulinButton_Click(object sender, EventArgs e)
        {
           _form1.systemWarnings("Low Insulin Level");
        }

        private void pumpFailureButton_Click(object sender, EventArgs e)
        {
            _form1.systemWarnings("Pump Failure");
        }

        private void needleFailureButton_Click(object sender, EventArgs e)
        {
            _form1.systemWarnings("Needle Failure");
        }

        private void sensorFailureButton_Click(object sender, EventArgs e)
        {
            _form1.systemWarnings("Sensor Failure");
        }

        private void sugarLowButton_Click(object sender, EventArgs e)
        {
            _form1.systemWarnings("Sugar Low");
        }

        private void replaceNeedleUnitButton_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("No Needle Unit");
            _form1.warningRemove("Needle Failure");
        }


        // Fix errors
        private void insulinReservoirButton_Click(object sender, EventArgs e)
        {
            _form1.systemReset();
            _form1.warningRemove("Low Insulin Level");
            _form1.warningRemove("No Insulin Remaining");
        }

        private void replaceBatteryButton_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("Low Battery");
        }

        private void replacePumpButton_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("Pump Failure");
        }

        private void replaceSensorButton_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("Sensor Failure");
        }

        private void consumeSugar_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("Sugar Low");
        }


        // Code related to the inital settings
        private void setButton_Click(object sender, EventArgs e)
        {
            if (bloodSugarBox.Text == "" || hardwareBox.Text == "" || alarmBox.Text == "")
            {
                MessageBox.Show("Please enter intial intervals");
            } 
            else
            {
                int bloodSugar = int.Parse(bloodSugarBox.Text);
                int hardware = int.Parse(hardwareBox.Text);
                int alarm = int.Parse(alarmBox.Text);

                bloodSugarBox.Enabled = false;
                hardwareBox.Enabled = false;
                alarmBox.Enabled = false;
                setButton.Enabled = false;

                _form1.setParameters(bloodSugar, hardware, alarm);
            }
           
        }
    }
}
