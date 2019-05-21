namespace MontyHall
{
    partial class frmMain
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
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblRounds = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSwitch = new System.Windows.Forms.GroupBox();
            this.tbSwitchRnds = new System.Windows.Forms.TextBox();
            this.tbSwitchWin = new System.Windows.Forms.TextBox();
            this.tbSwitchLose = new System.Windows.Forms.TextBox();
            this.tbSwitchPct = new System.Windows.Forms.TextBox();
            this.grpStay = new System.Windows.Forms.GroupBox();
            this.tbStayRnds = new System.Windows.Forms.TextBox();
            this.tbStayWin = new System.Windows.Forms.TextBox();
            this.tbStayLose = new System.Windows.Forms.TextBox();
            this.tbStayPct = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbOne = new System.Windows.Forms.RichTextBox();
            this.rtbTwo = new System.Windows.Forms.RichTextBox();
            this.rtbThree = new System.Windows.Forms.RichTextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.grpResults.SuspendLayout();
            this.grpSwitch.SuspendLayout();
            this.grpStay.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblRounds);
            this.grpResults.Controls.Add(this.btnReset);
            this.grpResults.Controls.Add(this.grpSwitch);
            this.grpResults.Controls.Add(this.grpStay);
            this.grpResults.Controls.Add(this.lblPercent);
            this.grpResults.Controls.Add(this.lblLoss);
            this.grpResults.Controls.Add(this.lblWins);
            this.grpResults.Location = new System.Drawing.Point(16, 322);
            this.grpResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResults.Size = new System.Drawing.Size(497, 170);
            this.grpResults.TabIndex = 8;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(39, 105);
            this.lblRounds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(57, 17);
            this.lblRounds.TabIndex = 11;
            this.lblRounds.Text = "Rounds";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(423, 23);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 139);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpSwitch
            // 
            this.grpSwitch.Controls.Add(this.tbSwitchRnds);
            this.grpSwitch.Controls.Add(this.tbSwitchWin);
            this.grpSwitch.Controls.Add(this.tbSwitchLose);
            this.grpSwitch.Controls.Add(this.tbSwitchPct);
            this.grpSwitch.Location = new System.Drawing.Point(264, 14);
            this.grpSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSwitch.Name = "grpSwitch";
            this.grpSwitch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSwitch.Size = new System.Drawing.Size(151, 151);
            this.grpSwitch.TabIndex = 10;
            this.grpSwitch.TabStop = false;
            this.grpSwitch.Text = "Switch";
            // 
            // tbSwitchRnds
            // 
            this.tbSwitchRnds.Location = new System.Drawing.Point(8, 87);
            this.tbSwitchRnds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSwitchRnds.Name = "tbSwitchRnds";
            this.tbSwitchRnds.ReadOnly = true;
            this.tbSwitchRnds.Size = new System.Drawing.Size(132, 22);
            this.tbSwitchRnds.TabIndex = 17;
            this.tbSwitchRnds.TabStop = false;
            this.tbSwitchRnds.Text = global::MontyHall.Properties.Settings.Default.ZeroApp;
            // 
            // tbSwitchWin
            // 
            this.tbSwitchWin.Location = new System.Drawing.Point(8, 23);
            this.tbSwitchWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSwitchWin.Name = "tbSwitchWin";
            this.tbSwitchWin.ReadOnly = true;
            this.tbSwitchWin.Size = new System.Drawing.Size(132, 22);
            this.tbSwitchWin.TabIndex = 0;
            this.tbSwitchWin.TabStop = false;
            this.tbSwitchWin.Text = "0";
            // 
            // tbSwitchLose
            // 
            this.tbSwitchLose.Location = new System.Drawing.Point(8, 55);
            this.tbSwitchLose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSwitchLose.Name = "tbSwitchLose";
            this.tbSwitchLose.ReadOnly = true;
            this.tbSwitchLose.Size = new System.Drawing.Size(132, 22);
            this.tbSwitchLose.TabIndex = 1;
            this.tbSwitchLose.TabStop = false;
            this.tbSwitchLose.Text = "0";
            // 
            // tbSwitchPct
            // 
            this.tbSwitchPct.Location = new System.Drawing.Point(8, 119);
            this.tbSwitchPct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSwitchPct.Name = "tbSwitchPct";
            this.tbSwitchPct.ReadOnly = true;
            this.tbSwitchPct.Size = new System.Drawing.Size(132, 22);
            this.tbSwitchPct.TabIndex = 2;
            this.tbSwitchPct.TabStop = false;
            this.tbSwitchPct.Text = global::MontyHall.Properties.Settings.Default.Percent;
            // 
            // grpStay
            // 
            this.grpStay.Controls.Add(this.tbStayRnds);
            this.grpStay.Controls.Add(this.tbStayWin);
            this.grpStay.Controls.Add(this.tbStayLose);
            this.grpStay.Controls.Add(this.tbStayPct);
            this.grpStay.Location = new System.Drawing.Point(105, 14);
            this.grpStay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStay.Name = "grpStay";
            this.grpStay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStay.Size = new System.Drawing.Size(151, 151);
            this.grpStay.TabIndex = 9;
            this.grpStay.TabStop = false;
            this.grpStay.Text = "Stay";
            // 
            // tbStayRnds
            // 
            this.tbStayRnds.Location = new System.Drawing.Point(8, 87);
            this.tbStayRnds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStayRnds.Name = "tbStayRnds";
            this.tbStayRnds.ReadOnly = true;
            this.tbStayRnds.Size = new System.Drawing.Size(132, 22);
            this.tbStayRnds.TabIndex = 16;
            this.tbStayRnds.TabStop = false;
            this.tbStayRnds.Text = global::MontyHall.Properties.Settings.Default.ZeroApp;
            // 
            // tbStayWin
            // 
            this.tbStayWin.Location = new System.Drawing.Point(8, 23);
            this.tbStayWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStayWin.Name = "tbStayWin";
            this.tbStayWin.ReadOnly = true;
            this.tbStayWin.Size = new System.Drawing.Size(132, 22);
            this.tbStayWin.TabIndex = 0;
            this.tbStayWin.TabStop = false;
            this.tbStayWin.Text = "0";
            // 
            // tbStayLose
            // 
            this.tbStayLose.Location = new System.Drawing.Point(8, 55);
            this.tbStayLose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStayLose.Name = "tbStayLose";
            this.tbStayLose.ReadOnly = true;
            this.tbStayLose.Size = new System.Drawing.Size(132, 22);
            this.tbStayLose.TabIndex = 1;
            this.tbStayLose.TabStop = false;
            this.tbStayLose.Text = "0";
            // 
            // tbStayPct
            // 
            this.tbStayPct.Location = new System.Drawing.Point(8, 119);
            this.tbStayPct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStayPct.Name = "tbStayPct";
            this.tbStayPct.ReadOnly = true;
            this.tbStayPct.Size = new System.Drawing.Size(132, 22);
            this.tbStayPct.TabIndex = 2;
            this.tbStayPct.TabStop = false;
            this.tbStayPct.Text = global::MontyHall.Properties.Settings.Default.Percent;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(15, 137);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(81, 17);
            this.lblPercent.TabIndex = 8;
            this.lblPercent.Text = "Percentage";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Location = new System.Drawing.Point(44, 73);
            this.lblLoss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(53, 17);
            this.lblLoss.TabIndex = 7;
            this.lblLoss.Text = "Losses";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(56, 41);
            this.lblWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(39, 17);
            this.lblWins.TabIndex = 6;
            this.lblWins.Text = "Wins";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(539, 369);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(221, 101);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbOne
            // 
            this.rtbOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOne.Location = new System.Drawing.Point(16, 16);
            this.rtbOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbOne.Name = "rtbOne";
            this.rtbOne.ReadOnly = true;
            this.rtbOne.Size = new System.Drawing.Size(244, 244);
            this.rtbOne.TabIndex = 10;
            this.rtbOne.TabStop = false;
            this.rtbOne.Text = "";
            // 
            // rtbTwo
            // 
            this.rtbTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTwo.Location = new System.Drawing.Point(269, 16);
            this.rtbTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbTwo.Name = "rtbTwo";
            this.rtbTwo.ReadOnly = true;
            this.rtbTwo.Size = new System.Drawing.Size(244, 244);
            this.rtbTwo.TabIndex = 11;
            this.rtbTwo.TabStop = false;
            this.rtbTwo.Text = "";
            // 
            // rtbThree
            // 
            this.rtbThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbThree.Location = new System.Drawing.Point(523, 16);
            this.rtbThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbThree.Name = "rtbThree";
            this.rtbThree.ReadOnly = true;
            this.rtbThree.Size = new System.Drawing.Size(244, 244);
            this.rtbThree.TabIndex = 12;
            this.rtbThree.TabStop = false;
            this.rtbThree.Text = "";
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(88, 268);
            this.btnOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(100, 28);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "Choose";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(343, 268);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(100, 28);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "Choose";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(597, 268);
            this.btnThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(100, 28);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "Choose";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.rtbThree);
            this.Controls.Add(this.rtbTwo);
            this.Controls.Add(this.rtbOne);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpResults);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Monty Hall Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.grpSwitch.ResumeLayout(false);
            this.grpSwitch.PerformLayout();
            this.grpStay.ResumeLayout(false);
            this.grpStay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.GroupBox grpSwitch;
        private System.Windows.Forms.TextBox tbSwitchWin;
        private System.Windows.Forms.TextBox tbSwitchLose;
        private System.Windows.Forms.TextBox tbSwitchPct;
        private System.Windows.Forms.GroupBox grpStay;
        private System.Windows.Forms.TextBox tbStayWin;
        private System.Windows.Forms.TextBox tbStayLose;
        private System.Windows.Forms.TextBox tbStayPct;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbOne;
        private System.Windows.Forms.RichTextBox rtbTwo;
        private System.Windows.Forms.RichTextBox rtbThree;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.TextBox tbSwitchRnds;
        private System.Windows.Forms.TextBox tbStayRnds;
    }
}

