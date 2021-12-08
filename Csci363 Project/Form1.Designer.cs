
namespace Csci363_Project
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.insulinButton = new System.Windows.Forms.Button();
            this.operatorButton = new System.Windows.Forms.Button();
            this.operationModeLabel = new System.Windows.Forms.Label();
            this.insulinCounter = new System.Windows.Forms.Label();
            this.insulinTimer = new System.Windows.Forms.Timer(this.components);
            this.runtimeTimer = new System.Windows.Forms.Timer(this.components);
            this.runtimeLabel = new System.Windows.Forms.Label();
            this.insulinMessages = new System.Windows.Forms.ListBox();
            this.systemMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.offButton = new System.Windows.Forms.Button();
            this.bloodSugarTimer = new System.Windows.Forms.Timer(this.components);
            this.hardwareTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.insulinDoseLabel = new System.Windows.Forms.Label();
            this.batteryTimer = new System.Windows.Forms.Timer(this.components);
            this.batteryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick_1);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clock.Location = new System.Drawing.Point(44, 16);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(49, 13);
            this.clock.TabIndex = 0;
            this.clock.Text = "00:00:00";
            this.clock.Click += new System.EventHandler(this.clock_Click);
            // 
            // insulinButton
            // 
            this.insulinButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.insulinButton.Enabled = false;
            this.insulinButton.FlatAppearance.BorderSize = 0;
            this.insulinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insulinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insulinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.insulinButton.Location = new System.Drawing.Point(64, 223);
            this.insulinButton.Name = "insulinButton";
            this.insulinButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.insulinButton.Size = new System.Drawing.Size(291, 74);
            this.insulinButton.TabIndex = 0;
            this.insulinButton.Text = "Administer 1 dose of insulin";
            this.insulinButton.UseMnemonic = false;
            this.insulinButton.UseVisualStyleBackColor = false;
            this.insulinButton.Visible = false;
            this.insulinButton.Click += new System.EventHandler(this.insulinButton_Click);
            // 
            // operatorButton
            // 
            this.operatorButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.operatorButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.operatorButton.Enabled = false;
            this.operatorButton.FlatAppearance.BorderSize = 0;
            this.operatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.operatorButton.Location = new System.Drawing.Point(64, 349);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(291, 71);
            this.operatorButton.TabIndex = 2;
            this.operatorButton.Text = "Change Operation Mode";
            this.operatorButton.UseVisualStyleBackColor = false;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // operationModeLabel
            // 
            this.operationModeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.operationModeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operationModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.operationModeLabel.Location = new System.Drawing.Point(185, 432);
            this.operationModeLabel.Name = "operationModeLabel";
            this.operationModeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operationModeLabel.Size = new System.Drawing.Size(61, 16);
            this.operationModeLabel.TabIndex = 0;
            this.operationModeLabel.Text = "Auto";
            this.operationModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operationModeLabel.UseWaitCursor = true;
            // 
            // insulinCounter
            // 
            this.insulinCounter.Location = new System.Drawing.Point(64, 207);
            this.insulinCounter.Name = "insulinCounter";
            this.insulinCounter.Size = new System.Drawing.Size(291, 13);
            this.insulinCounter.TabIndex = 3;
            this.insulinCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insulinTimer
            // 
            this.insulinTimer.Interval = 5000;
            this.insulinTimer.Tick += new System.EventHandler(this.insulinTimer_Tick);
            // 
            // runtimeTimer
            // 
            this.runtimeTimer.Interval = 1000;
            this.runtimeTimer.Tick += new System.EventHandler(this.runtime_Tick);
            // 
            // runtimeLabel
            // 
            this.runtimeLabel.AutoSize = true;
            this.runtimeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.runtimeLabel.Location = new System.Drawing.Point(354, 16);
            this.runtimeLabel.Name = "runtimeLabel";
            this.runtimeLabel.Size = new System.Drawing.Size(49, 13);
            this.runtimeLabel.TabIndex = 5;
            this.runtimeLabel.Text = "00:00:00";
            // 
            // insulinMessages
            // 
            this.insulinMessages.BackColor = System.Drawing.Color.White;
            this.insulinMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insulinMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.insulinMessages.FormattingEnabled = true;
            this.insulinMessages.Location = new System.Drawing.Point(12, 50);
            this.insulinMessages.Name = "insulinMessages";
            this.insulinMessages.Size = new System.Drawing.Size(402, 93);
            this.insulinMessages.TabIndex = 8;
            this.insulinMessages.SelectedIndexChanged += new System.EventHandler(this.sysMsgBox_SelectedIndexChanged);
            // 
            // systemMessageTimer
            // 
            this.systemMessageTimer.Interval = 5000;
            this.systemMessageTimer.Tick += new System.EventHandler(this.systemMessageTimer_Tick);
            // 
            // offButton
            // 
            this.offButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.offButton.Enabled = false;
            this.offButton.FlatAppearance.BorderSize = 0;
            this.offButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.offButton.Location = new System.Drawing.Point(12, 520);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(182, 32);
            this.offButton.TabIndex = 10;
            this.offButton.TabStop = false;
            this.offButton.Text = "Turn Off";
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // bloodSugarTimer
            // 
            this.bloodSugarTimer.Interval = 1001;
            this.bloodSugarTimer.Tick += new System.EventHandler(this.bloodSugarTimer_Tick);
            // 
            // hardwareTimer
            // 
            this.hardwareTimer.Interval = 1001;
            this.hardwareTimer.Tick += new System.EventHandler(this.hardwareTimer_Tick);
            // 
            // alarmTimer
            // 
            this.alarmTimer.Interval = 1001;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.exitButton.Location = new System.Drawing.Point(232, 518);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 34);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Csci363_Project.Properties.Resources.clock1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(700, 451);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(178, 23);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "No insulin remaining";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(556, 50);
            this.chart1.Name = "chart1";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series13.Legend = "Legend1";
            series13.MarkerBorderColor = System.Drawing.Color.Aqua;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series13.Name = "Series1";
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series13.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.Legend = "Legend1";
            series14.MarkerBorderColor = System.Drawing.Color.Aqua;
            series14.Name = "Series2";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series15.Legend = "Legend1";
            series15.MarkerBorderColor = System.Drawing.Color.Red;
            series15.Name = "Series3";
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(435, 300);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // insulinDoseLabel
            // 
            this.insulinDoseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insulinDoseLabel.Location = new System.Drawing.Point(611, 21);
            this.insulinDoseLabel.Name = "insulinDoseLabel";
            this.insulinDoseLabel.Size = new System.Drawing.Size(359, 23);
            this.insulinDoseLabel.TabIndex = 15;
            this.insulinDoseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batteryTimer
            // 
            this.batteryTimer.Interval = 100000;
            this.batteryTimer.Tick += new System.EventHandler(this.batteryTimer_Tick);
            // 
            // batteryLabel
            // 
            this.batteryLabel.Location = new System.Drawing.Point(172, 16);
            this.batteryLabel.Name = "batteryLabel";
            this.batteryLabel.Size = new System.Drawing.Size(71, 23);
            this.batteryLabel.TabIndex = 16;
            this.batteryLabel.Text = "Battery 100%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1026, 566);
            this.Controls.Add(this.batteryLabel);
            this.Controls.Add(this.insulinDoseLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.insulinMessages);
            this.Controls.Add(this.runtimeLabel);
            this.Controls.Add(this.insulinCounter);
            this.Controls.Add(this.operationModeLabel);
            this.Controls.Add(this.operatorButton);
            this.Controls.Add(this.insulinButton);
            this.Controls.Add(this.clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Insulin Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button insulinButton;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.Label operationModeLabel;
        private System.Windows.Forms.Label insulinCounter;
        private System.Windows.Forms.Timer insulinTimer;
        private System.Windows.Forms.Label runtimeLabel;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Timer bloodSugarTimer;
        private System.Windows.Forms.Timer hardwareTimer;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Timer runtimeTimer;
        private System.Windows.Forms.Timer systemMessageTimer;
        private System.Windows.Forms.ListBox insulinMessages;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label insulinDoseLabel;
        private System.Windows.Forms.Timer batteryTimer;
        private System.Windows.Forms.Label batteryLabel;
    }
}

