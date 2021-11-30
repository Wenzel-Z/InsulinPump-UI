
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
            this.insulinButton = new System.Windows.Forms.Button();
            this.operatorButton = new System.Windows.Forms.Button();
            this.operationModeLabel = new System.Windows.Forms.Label();
            this.insulinCounter = new System.Windows.Forms.Label();
            this.insulinTimer = new System.Windows.Forms.Timer(this.components);
            this.runtimeTimer = new System.Windows.Forms.Timer(this.components);
            this.runtimeLabel = new System.Windows.Forms.Label();
            this.insulinMessages = new System.Windows.Forms.ListBox();
            this.systemMessages = new System.Windows.Forms.ListBox();
            this.systemMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.offButton = new System.Windows.Forms.Button();
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
            // insulinButton
            // 
            this.insulinButton.Enabled = false;
            this.insulinButton.Location = new System.Drawing.Point(12, 486);
            this.insulinButton.Name = "insulinButton";
            this.insulinButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.insulinButton.Size = new System.Drawing.Size(155, 23);
            this.insulinButton.TabIndex = 0;
            this.insulinButton.Text = "Administer 1 does of insulin";
            this.insulinButton.UseMnemonic = false;
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
            // insulinCounter
            // 
            this.insulinCounter.AutoSize = true;
            this.insulinCounter.Location = new System.Drawing.Point(170, 491);
            this.insulinCounter.Name = "insulinCounter";
            this.insulinCounter.Size = new System.Drawing.Size(0, 13);
            this.insulinCounter.TabIndex = 3;
            // 
            // insulinTimer
            // 
            this.insulinTimer.Interval = 5000;
            this.insulinTimer.Tick += new System.EventHandler(this.insulinTimer_Tick);
            // 
            // runtimeTimer
            // 
            this.runtimeTimer.Enabled = true;
            this.runtimeTimer.Interval = 1000;
            this.runtimeTimer.Tick += new System.EventHandler(this.runtime_Tick);
            // 
            // runtimeLabel
            // 
            this.runtimeLabel.AutoSize = true;
            this.runtimeLabel.Location = new System.Drawing.Point(170, 34);
            this.runtimeLabel.Name = "runtimeLabel";
            this.runtimeLabel.Size = new System.Drawing.Size(49, 13);
            this.runtimeLabel.TabIndex = 5;
            this.runtimeLabel.Text = "00:00:00";
            // 
            // insulinMessages
            // 
            this.insulinMessages.FormattingEnabled = true;
            this.insulinMessages.Location = new System.Drawing.Point(12, 119);
            this.insulinMessages.Name = "insulinMessages";
            this.insulinMessages.Size = new System.Drawing.Size(402, 95);
            this.insulinMessages.TabIndex = 8;
            this.insulinMessages.SelectedIndexChanged += new System.EventHandler(this.sysMsgBox_SelectedIndexChanged);
            // 
            // systemMessages
            // 
            this.systemMessages.FormattingEnabled = true;
            this.systemMessages.Location = new System.Drawing.Point(12, 288);
            this.systemMessages.Name = "systemMessages";
            this.systemMessages.Size = new System.Drawing.Size(402, 43);
            this.systemMessages.TabIndex = 9;
            this.systemMessages.SelectedIndexChanged += new System.EventHandler(this.systemMessages_SelectedIndexChanged);
            // 
            // systemMessageTimer
            // 
            this.systemMessageTimer.Interval = 5000;
            this.systemMessageTimer.Tick += new System.EventHandler(this.systemMessageTimer_Tick);
            // 
            // offButton
            // 
            this.offButton.Location = new System.Drawing.Point(282, 524);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(132, 23);
            this.offButton.TabIndex = 10;
            this.offButton.Text = "Turn Off";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 566);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.systemMessages);
            this.Controls.Add(this.insulinMessages);
            this.Controls.Add(this.runtimeLabel);
            this.Controls.Add(this.insulinCounter);
            this.Controls.Add(this.operationModeLabel);
            this.Controls.Add(this.operatorButton);
            this.Controls.Add(this.insulinButton);
            this.Controls.Add(this.clock);
            this.Name = "Form1";
            this.Text = "Insulin Display";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Timer runtimeTimer;
        private System.Windows.Forms.Label runtimeLabel;
        private System.Windows.Forms.ListBox insulinMessages;
        private System.Windows.Forms.ListBox systemMessages;
        private System.Windows.Forms.Timer systemMessageTimer;
        private System.Windows.Forms.Button offButton;
    }
}

