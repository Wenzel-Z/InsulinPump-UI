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
        public Simulator(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

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
        }

        private void insulinReservoirButton_Click(object sender, EventArgs e)
        {
            _form1.systemReset();
            _form1.warningRemove("Low Insulin Level");
            _form1.warningRemove("No Insulin Remaining");
        }
    }
}
