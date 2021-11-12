
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
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.insulinPanel = new System.Windows.Forms.Panel();
            this.insulinButton = new System.Windows.Forms.Button();
            this.operatorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.systemPanel = new System.Windows.Forms.Panel();
            this.operationModeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick_1);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(170, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(49, 13);
            this.clock.TabIndex = 0;
            this.clock.Text = "00:00:00";
            // 
            // insulinPanel
            // 
            this.insulinPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insulinPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insulinPanel.Location = new System.Drawing.Point(12, 107);
            this.insulinPanel.Name = "insulinPanel";
            this.insulinPanel.Size = new System.Drawing.Size(138, 165);
            this.insulinPanel.TabIndex = 1;
            this.insulinPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.insulinPanel_Paint);
            // 
            // insulinButton
            // 
            this.insulinButton.Location = new System.Drawing.Point(12, 486);
            this.insulinButton.Name = "insulinButton";
            this.insulinButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.insulinButton.Size = new System.Drawing.Size(155, 23);
            this.insulinButton.TabIndex = 0;
            this.insulinButton.Text = "Administer 1 does of insulin";
            this.insulinButton.UseVisualStyleBackColor = true;
            this.insulinButton.Click += new System.EventHandler(this.insulinButton_Click);
            // 
            // operatorButton
            // 
            this.operatorButton.Location = new System.Drawing.Point(12, 529);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(155, 23);
            this.operatorButton.TabIndex = 2;
            this.operatorButton.Text = "Change Operation Mode";
            this.operatorButton.UseVisualStyleBackColor = true;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // systemPanel
            // 
            this.systemPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.systemPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.systemPanel.Location = new System.Drawing.Point(276, 107);
            this.systemPanel.Name = "systemPanel";
            this.systemPanel.Size = new System.Drawing.Size(138, 165);
            this.systemPanel.TabIndex = 2;
            this.systemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.systemPanel_Paint);
            // 
            // operationModeLabel
            // 
            this.operationModeLabel.AutoSize = true;
            this.operationModeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.operationModeLabel.Enabled = false;
            this.operationModeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.operationModeLabel.Location = new System.Drawing.Point(173, 534);
            this.operationModeLabel.Name = "operationModeLabel";
            this.operationModeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operationModeLabel.Size = new System.Drawing.Size(29, 13);
            this.operationModeLabel.TabIndex = 0;
            this.operationModeLabel.Text = "Auto";
            this.operationModeLabel.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 566);
            this.Controls.Add(this.operationModeLabel);
            this.Controls.Add(this.systemPanel);
            this.Controls.Add(this.operatorButton);
            this.Controls.Add(this.insulinButton);
            this.Controls.Add(this.insulinPanel);
            this.Controls.Add(this.clock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Panel insulinPanel;
        private System.Windows.Forms.Button insulinButton;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel systemPanel;
        private System.Windows.Forms.Label operationModeLabel;
    }
}

