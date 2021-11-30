
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
            this.button1 = new System.Windows.Forms.Button();
            this.pumpFailureButton = new System.Windows.Forms.Button();
            this.needleFailureButton = new System.Windows.Forms.Button();
            this.sensorFailureButton = new System.Windows.Forms.Button();
            this.sugarLowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.replaceNeedleUnitButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insulinReservoirButton
            // 
            this.insulinReservoirButton.Location = new System.Drawing.Point(346, 89);
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
            this.lowInsulinButton.Location = new System.Drawing.Point(38, 118);
            this.lowInsulinButton.Name = "lowInsulinButton";
            this.lowInsulinButton.Size = new System.Drawing.Size(148, 23);
            this.lowInsulinButton.TabIndex = 4;
            this.lowInsulinButton.Text = "Low Insulin Test";
            this.lowInsulinButton.UseVisualStyleBackColor = true;
            this.lowInsulinButton.Click += new System.EventHandler(this.lowInsulinButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Low Battery Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pumpFailureButton
            // 
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alarm Conditions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fix Errors";
            // 
            // replaceNeedleUnitButton
            // 
            this.replaceNeedleUnitButton.Location = new System.Drawing.Point(346, 60);
            this.replaceNeedleUnitButton.Name = "replaceNeedleUnitButton";
            this.replaceNeedleUnitButton.Size = new System.Drawing.Size(148, 23);
            this.replaceNeedleUnitButton.TabIndex = 13;
            this.replaceNeedleUnitButton.Text = "Replace Needle Unit";
            this.replaceNeedleUnitButton.UseVisualStyleBackColor = true;
            this.replaceNeedleUnitButton.Click += new System.EventHandler(this.replaceNeedleUnitButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.replaceNeedleUnitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sugarLowButton);
            this.Controls.Add(this.sensorFailureButton);
            this.Controls.Add(this.needleFailureButton);
            this.Controls.Add(this.pumpFailureButton);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pumpFailureButton;
        private System.Windows.Forms.Button needleFailureButton;
        private System.Windows.Forms.Button sensorFailureButton;
        private System.Windows.Forms.Button sugarLowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button replaceNeedleUnitButton;
        private System.Windows.Forms.Button button3;
    }
}