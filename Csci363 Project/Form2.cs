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

        private void batteryButton_Click(object sender, EventArgs e)
        {
            _form1.systemWarnings("Low Battery");
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

        
        // Fix things
        private void replaceNeedleUnitButton_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("No Needle Unit");
            _form1.warningRemove("Needle Failure");
            _form1.addInsulinMessage("Needle Unit Replaced at " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void insulinReservoirButton_Click(object sender, EventArgs e)
        {
            _form1.systemReset(); // This may not be needed, the system reqs are confusing
            _form1.replaceReservoir();
            _form1.warningRemove("Low Insulin Level");
            _form1.warningRemove("No Insulin Remaining");
            _form1.addInsulinMessage("Insulin reservoir replaced at " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void replaceBatteryButton_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("Low Battery");
            _form1.addInsulinMessage("Battery replaced at " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void replacePumpButton_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("Pump Failure");
            _form1.addInsulinMessage("Pump replaced at " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void replaceSensorButton_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("Sensor Failure");
            _form1.addInsulinMessage("Sensor replaced at " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void consumeSugar_Click(object sender, EventArgs e)
        {
            _form1.warningRemove("Sugar Low");
            _form1.addInsulinMessage("Sugar normalized at " + DateTime.Now.ToString("HH:mm:ss"));
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

                runtimeAddButton.Enabled = true;

                bloodSugarLevelBox.Enabled = true;
                bloodSugarLevelButton.Enabled = true;

                bloodSugarBox.Enabled = false;
                hardwareBox.Enabled = false;
                alarmBox.Enabled = false;
                setButton.Enabled = false;

                needleUnitButton.Enabled = true;
                noInsulinButton.Enabled = true;
                lowInsulinButton.Enabled = true;
                batteryButton.Enabled = true;
                pumpFailureButton.Enabled = true;
                needleFailureButton.Enabled = true;
                sensorFailureButton.Enabled = true;
                sugarLowButton.Enabled = true;

                replaceNeedleUnitButton.Enabled = true;
                insulinReservoirButton.Enabled = true;
                replaceBatteryButton.Enabled = true;
                replacePumpButton.Enabled = true;
                replaceSensorButton.Enabled = true;
                consumeSugar.Enabled = true;

                _form1.setParameters(bloodSugar, hardware, alarm);
            }
        }


        // Code to input blood sugar levels
        private void bloodSugarLevelButton_Click(object sender, EventArgs e)
        {
            double bloodSugarLevel = double.Parse(bloodSugarLevelBox.Text);
            _form1.addSugarLevel(bloodSugarLevel);
            bloodSugarLevelBox.Clear();
        }

        private void runtimeAddButton_Click(object sender, EventArgs e)
        {
            _form1.addRuntime();
        }
    }
}
