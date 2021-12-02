
namespace Csci363_Project
{
    partial class Simulator
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
            this.insulinReservoirButton = new System.Windows.Forms.Button();
            this.needleUnitButton = new System.Windows.Forms.Button();
            this.noInsulinButton = new System.Windows.Forms.Button();
            this.lowInsulinButton = new System.Windows.Forms.Button();
            this.pumpFailureButton = new System.Windows.Forms.Button();
            this.needleFailureButton = new System.Windows.Forms.Button();
            this.sensorFailureButton = new System.Windows.Forms.Button();
            this.sugarLowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.replaceNeedleUnitButton = new System.Windows.Forms.Button();
            this.replaceBatteryButton = new System.Windows.Forms.Button();
            this.replacePumpButton = new System.Windows.Forms.Button();
            this.replaceSensorButton = new System.Windows.Forms.Button();
            this.consumeSugar = new System.Windows.Forms.Button();
            this.bloodSugarBox = new System.Windows.Forms.TextBox();
            this.hardwareBox = new System.Windows.Forms.TextBox();
            this.alarmBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.batteryButton = new System.Windows.Forms.Button();
            this.bloodSugarLevelBox = new System.Windows.Forms.TextBox();
            this.bloodSugarLevelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insulinReservoirButton
            // 
            this.insulinReservoirButton.Enabled = false;
            this.insulinReservoirButton.Location = new System.Drawing.Point(192, 89);
            this.insulinReservoirButton.Name = "insulinReservoirButton";
            this.insulinReservoirButton.Size = new System.Drawing.Size(148, 23);
            this.insulinReservoirButton.TabIndex = 0;
            this.insulinReservoirButton.Text = "Replace Insulin Reservoir";
            this.insulinReservoirButton.UseVisualStyleBackColor = true;
            this.insulinReservoirButton.Click += new System.EventHandler(this.insulinReservoirButton_Click);
            // 
            // needleUnitButton
            // 
            this.needleUnitButton.AutoSize = true;
            this.needleUnitButton.Enabled = false;
            this.needleUnitButton.Location = new System.Drawing.Point(38, 60);
            this.needleUnitButton.Name = "needleUnitButton";
            this.needleUnitButton.Size = new System.Drawing.Size(148, 23);
            this.needleUnitButton.TabIndex = 2;
            this.needleUnitButton.Text = "No Needle Unit Test";
            this.needleUnitButton.UseVisualStyleBackColor = true;
            this.needleUnitButton.Click += new System.EventHandler(this.needleUnitButton_Click);
            // 
            // noInsulinButton
            // 
            this.noInsulinButton.Enabled = false;
            this.noInsulinButton.Location = new System.Drawing.Point(38, 89);
            this.noInsulinButton.Name = "noInsulinButton";
            this.noInsulinButton.Size = new System.Drawing.Size(148, 23);
            this.noInsulinButton.TabIndex = 3;
            this.noInsulinButton.Text = "No Insulin Remaining Test";
            this.noInsulinButton.UseVisualStyleBackColor = true;
            this.noInsulinButton.Click += new System.EventHandler(this.noInsulinButton_Click);
            // 
            // lowInsulinButton
            // 
            this.lowInsulinButton.Enabled = false;
            this.lowInsulinButton.Location = new System.Drawing.Point(38, 118);
            this.lowInsulinButton.Name = "lowInsulinButton";
            this.lowInsulinButton.Size = new System.Drawing.Size(148, 23);
            this.lowInsulinButton.TabIndex = 4;
            this.lowInsulinButton.Text = "Low Insulin Test";
            this.lowInsulinButton.UseVisualStyleBackColor = true;
            this.lowInsulinButton.Click += new System.EventHandler(this.lowInsulinButton_Click);
            // 
            // pumpFailureButton
            // 
            this.pumpFailureButton.Enabled = false;
            this.pumpFailureButton.Location = new System.Drawing.Point(38, 176);
            this.pumpFailureButton.Name = "pumpFailureButton";
            this.pumpFailureButton.Size = new System.Drawing.Size(148, 23);
            this.pumpFailureButton.TabIndex = 6;
            this.pumpFailureButton.Text = "Pump Failure Test";
            this.pumpFailureButton.UseVisualStyleBackColor = true;
            this.pumpFailureButton.Click += new System.EventHandler(this.pumpFailureButton_Click);
            // 
            // needleFailureButton
            // 
            this.needleFailureButton.Enabled = false;
            this.needleFailureButton.Location = new System.Drawing.Point(38, 205);
            this.needleFailureButton.Name = "needleFailureButton";
            this.needleFailureButton.Size = new System.Drawing.Size(148, 23);
            this.needleFailureButton.TabIndex = 7;
            this.needleFailureButton.Text = "Needle Failure Test";
            this.needleFailureButton.UseVisualStyleBackColor = true;
            this.needleFailureButton.Click += new System.EventHandler(this.needleFailureButton_Click);
            // 
            // sensorFailureButton
            // 
            this.sensorFailureButton.Enabled = false;
            this.sensorFailureButton.Location = new System.Drawing.Point(38, 234);
            this.sensorFailureButton.Name = "sensorFailureButton";
            this.sensorFailureButton.Size = new System.Drawing.Size(148, 23);
            this.sensorFailureButton.TabIndex = 8;
            this.sensorFailureButton.Text = "Sensor Failure Test";
            this.sensorFailureButton.UseVisualStyleBackColor = true;
            this.sensorFailureButton.Click += new System.EventHandler(this.sensorFailureButton_Click);
            // 
            // sugarLowButton
            // 
            this.sugarLowButton.Enabled = false;
            this.sugarLowButton.Location = new System.Drawing.Point(38, 263);
            this.sugarLowButton.Name = "sugarLowButton";
            this.sugarLowButton.Size = new System.Drawing.Size(148, 23);
            this.sugarLowButton.TabIndex = 9;
            this.sugarLowButton.Text = "Sugar Low Test";
            this.sugarLowButton.UseVisualStyleBackColor = true;
            this.sugarLowButton.Click += new System.EventHandler(this.sugarLowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Error Conditions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fix Errors";
            // 
            // replaceNeedleUnitButton
            // 
            this.replaceNeedleUnitButton.Enabled = false;
            this.replaceNeedleUnitButton.Location = new System.Drawing.Point(192, 60);
            this.replaceNeedleUnitButton.Name = "replaceNeedleUnitButton";
            this.replaceNeedleUnitButton.Size = new System.Drawing.Size(148, 23);
            this.replaceNeedleUnitButton.TabIndex = 13;
            this.replaceNeedleUnitButton.Text = "Replace Needle Unit";
            this.replaceNeedleUnitButton.UseVisualStyleBackColor = true;
            this.replaceNeedleUnitButton.Click += new System.EventHandler(this.replaceNeedleUnitButton_Click);
            // 
            // replaceBatteryButton
            // 
            this.replaceBatteryButton.Enabled = false;
            this.replaceBatteryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.replaceBatteryButton.Location = new System.Drawing.Point(192, 118);
            this.replaceBatteryButton.Name = "replaceBatteryButton";
            this.replaceBatteryButton.Size = new System.Drawing.Size(148, 23);
            this.replaceBatteryButton.TabIndex = 15;
            this.replaceBatteryButton.Text = "Replace Battery";
            this.replaceBatteryButton.UseVisualStyleBackColor = true;
            this.replaceBatteryButton.Click += new System.EventHandler(this.replaceBatteryButton_Click);
            // 
            // replacePumpButton
            // 
            this.replacePumpButton.Enabled = false;
            this.replacePumpButton.Location = new System.Drawing.Point(192, 147);
            this.replacePumpButton.Name = "replacePumpButton";
            this.replacePumpButton.Size = new System.Drawing.Size(148, 23);
            this.replacePumpButton.TabIndex = 16;
            this.replacePumpButton.Text = "Replace Pump";
            this.replacePumpButton.UseVisualStyleBackColor = true;
            this.replacePumpButton.Click += new System.EventHandler(this.replacePumpButton_Click);
            // 
            // replaceSensorButton
            // 
            this.replaceSensorButton.Enabled = false;
            this.replaceSensorButton.Location = new System.Drawing.Point(192, 176);
            this.replaceSensorButton.Name = "replaceSensorButton";
            this.replaceSensorButton.Size = new System.Drawing.Size(148, 23);
            this.replaceSensorButton.TabIndex = 17;
            this.replaceSensorButton.Text = "Replace Sensor";
            this.replaceSensorButton.UseVisualStyleBackColor = true;
            this.replaceSensorButton.Click += new System.EventHandler(this.replaceSensorButton_Click);
            // 
            // consumeSugar
            // 
            this.consumeSugar.Enabled = false;
            this.consumeSugar.Location = new System.Drawing.Point(192, 205);
            this.consumeSugar.Name = "consumeSugar";
            this.consumeSugar.Size = new System.Drawing.Size(148, 23);
            this.consumeSugar.TabIndex = 18;
            this.consumeSugar.Text = "Consume Sugar";
            this.consumeSugar.UseVisualStyleBackColor = true;
            this.consumeSugar.Click += new System.EventHandler(this.consumeSugar_Click);
            // 
            // bloodSugarBox
            // 
            this.bloodSugarBox.Location = new System.Drawing.Point(678, 109);
            this.bloodSugarBox.Name = "bloodSugarBox";
            this.bloodSugarBox.Size = new System.Drawing.Size(100, 20);
            this.bloodSugarBox.TabIndex = 19;
            // 
            // hardwareBox
            // 
            this.hardwareBox.Location = new System.Drawing.Point(678, 135);
            this.hardwareBox.Name = "hardwareBox";
            this.hardwareBox.Size = new System.Drawing.Size(100, 20);
            this.hardwareBox.TabIndex = 20;
            // 
            // alarmBox
            // 
            this.alarmBox.Location = new System.Drawing.Point(678, 161);
            this.alarmBox.Name = "alarmBox";
            this.alarmBox.Size = new System.Drawing.Size(100, 20);
            this.alarmBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Testing of blood sugar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Testing of hardware";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Testing of alarm status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Interval (in seconds)";
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(689, 187);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 26;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // batteryButton
            // 
            this.batteryButton.Enabled = false;
            this.batteryButton.Location = new System.Drawing.Point(38, 147);
            this.batteryButton.Name = "batteryButton";
            this.batteryButton.Size = new System.Drawing.Size(148, 23);
            this.batteryButton.TabIndex = 27;
            this.batteryButton.Text = "Low Battery Test";
            this.batteryButton.UseVisualStyleBackColor = true;
            this.batteryButton.Click += new System.EventHandler(this.batteryButton_Click);
            // 
            // bloodSugarLevelBox
            // 
            this.bloodSugarLevelBox.Enabled = false;
            this.bloodSugarLevelBox.Location = new System.Drawing.Point(678, 362);
            this.bloodSugarLevelBox.Name = "bloodSugarLevelBox";
            this.bloodSugarLevelBox.Size = new System.Drawing.Size(100, 20);
            this.bloodSugarLevelBox.TabIndex = 28;
            // 
            // bloodSugarLevelButton
            // 
            this.bloodSugarLevelButton.Enabled = false;
            this.bloodSugarLevelButton.Location = new System.Drawing.Point(689, 388);
            this.bloodSugarLevelButton.Name = "bloodSugarLevelButton";
            this.bloodSugarLevelButton.Size = new System.Drawing.Size(75, 23);
            this.bloodSugarLevelButton.TabIndex = 29;
            this.bloodSugarLevelButton.Text = "Input";
            this.bloodSugarLevelButton.UseVisualStyleBackColor = true;
            this.bloodSugarLevelButton.Click += new System.EventHandler(this.bloodSugarLevelButton_Click);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bloodSugarLevelButton);
            this.Controls.Add(this.bloodSugarLevelBox);
            this.Controls.Add(this.batteryButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alarmBox);
            this.Controls.Add(this.hardwareBox);
            this.Controls.Add(this.bloodSugarBox);
            this.Controls.Add(this.consumeSugar);
            this.Controls.Add(this.replaceSensorButton);
            this.Controls.Add(this.replacePumpButton);
            this.Controls.Add(this.replaceBatteryButton);
            this.Controls.Add(this.replaceNeedleUnitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sugarLowButton);
            this.Controls.Add(this.sensorFailureButton);
            this.Controls.Add(this.needleFailureButton);
            this.Controls.Add(this.pumpFailureButton);
            this.Controls.Add(this.lowInsulinButton);
            this.Controls.Add(this.noInsulinButton);
            this.Controls.Add(this.needleUnitButton);
            this.Controls.Add(this.insulinReservoirButton);
            this.Name = "Simulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insulinReservoirButton;
        private System.Windows.Forms.Button needleUnitButton;
        private System.Windows.Forms.Button noInsulinButton;
        private System.Windows.Forms.Button lowInsulinButton;
        private System.Windows.Forms.Button pumpFailureButton;
        private System.Windows.Forms.Button needleFailureButton;
        private System.Windows.Forms.Button sensorFailureButton;
        private System.Windows.Forms.Button sugarLowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button replaceNeedleUnitButton;
        private System.Windows.Forms.Button replaceBatteryButton;
        private System.Windows.Forms.Button replacePumpButton;
        private System.Windows.Forms.Button replaceSensorButton;
        private System.Windows.Forms.Button consumeSugar;
        private System.Windows.Forms.TextBox bloodSugarBox;
        private System.Windows.Forms.TextBox hardwareBox;
        private System.Windows.Forms.TextBox alarmBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button batteryButton;
        private System.Windows.Forms.TextBox bloodSugarLevelBox;
        private System.Windows.Forms.Button bloodSugarLevelButton;
    }
}